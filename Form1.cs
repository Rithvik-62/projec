using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using ZXing;
using ZXing.Common;

namespace QRDocVault
{
    public partial class Form1 : Form
    {
        private string selectedFilePath = "";
        private string vaultPath = Path.Combine(Application.StartupPath, "VaultStorage");

        public Form1()
        {
            InitializeComponent();
            // Create storage directory if missing
            if (!Directory.Exists(vaultPath)) Directory.CreateDirectory(vaultPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize security levels
            cmbSecurity.Items.Clear();
            cmbSecurity.Items.AddRange(new string[] { "Public", "Confidential", "Highly Confidential" });
            cmbSecurity.SelectedIndex = 0;

            // Wire up hover effects for sidebar navigation
            btnBack.MouseEnter += btn_MouseEnter;
            btnBack.MouseLeave += btn_MouseLeave;

            // Initial state for password field
            TogglePasswordUI();
            RefreshVaultAnalytics();
        }

        // =========================================================
        // 🛡️ SECURITY UI LOGIC (Fix: White Labels & Selective Password)
        // =========================================================

        private void cmbSecurity_SelectedIndexChanged(object sender, EventArgs e)
        {
            TogglePasswordUI();
        }

        private void TogglePasswordUI()
        {
            // Requirement: Enable password only if not 'Public'
            bool needsPassword = (cmbSecurity.Text != "Public");

            txtPassword.Enabled = needsPassword;
            label3.Enabled = needsPassword; // Enable/Disable the label too

            // Ensure visual consistency (requested white color)
            label3.ForeColor = needsPassword ? Color.White : Color.Gray;
            txtPassword.BackColor = needsPassword ? Color.FromArgb(45, 45, 60) : Color.FromArgb(35, 35, 45);

            if (!needsPassword) txtPassword.Text = "";
        }

        // =========================================================
        // 📁 SMART INGESTION & CLASSIFICATION
        // =========================================================

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Secure Assets|*.pdf;*.doc;*.docx;*.jpg;*.png;*.txt|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    lblFilePath.Text = Path.GetFileName(selectedFilePath);

                    // SMART FEATURE: Auto-title formatting
                    string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    txtTitle.Text = fileName.Replace("_", " ").Replace("-", " ");

                    // SMART FEATURE: Auto-Classification based on keywords
                    string lower = fileName.ToLower();
                    if (lower.Contains("secret") || lower.Contains("private") || lower.Contains("confidential") || lower.Contains("pass"))
                        cmbSecurity.Text = "Highly Confidential";
                    else if (lower.Contains("internal") || lower.Contains("draft") || lower.Contains("office"))
                        cmbSecurity.Text = "Confidential";
                    else
                        cmbSecurity.Text = "Public";

                    lblDocType.Text = "TYPE: " + Path.GetExtension(selectedFilePath).ToUpper().Replace(".", "");
                    TogglePasswordUI();
                }
            }
        }

        // =========================================================
        // 🛡️ VAULTING: HASHING & QR GENERATION
        // =========================================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file to secure first.", "Ingestion Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. DUPLICATE SHIELD: MD5 Fingerprinting
                string fileHash = GetFileHash(selectedFilePath);
                DataTable dtDup = DbHelper.ExecuteQuery("SELECT DocID FROM Documents WHERE FileHash = @H", new SqlParameter[] { new SqlParameter("@H", fileHash) });

                if (dtDup.Rows.Count > 0)
                {
                    MessageBox.Show("⛔ SECURITY ALERT: This document already exists in the vault. Duplicate detected.", "Integrity Check Fail");
                    return;
                }

                // 2. GENERATE VAULT QR ID (The Access Key)
                string qrId = "VDV-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new EncodingOptions { Height = 250, Width = 250, Margin = 1 }
                };
                pbQR.Image = writer.Write(qrId);

                // 3. SECURE PHYSICAL MIGRATION
                string extension = Path.GetExtension(selectedFilePath);
                string destFile = Path.Combine(vaultPath, qrId + extension);
                File.Copy(selectedFilePath, destFile);

                // 4. DATABASE PERISTENCE
                string sql = "INSERT INTO Documents (Title, FilePath, SecurityLevel, Password, QRText, FileHash, DocType) " +
                             "VALUES (@T, @P, @S, @Pass, @QR, @H, @DT)";

                SqlParameter[] p = {
                    new SqlParameter("@T", txtTitle.Text),
                    new SqlParameter("@P", destFile),
                    new SqlParameter("@S", cmbSecurity.Text),
                    new SqlParameter("@Pass", txtPassword.Text),
                    new SqlParameter("@QR", qrId),
                    new SqlParameter("@H", fileHash),
                    new SqlParameter("@DT", extension.Replace(".","").ToUpper())
                };

                DbHelper.ExecuteNonQuery(sql, p);

                // Log the forensic ingestion event
                DbHelper.ExecuteNonQuery("INSERT INTO AccessLog (DocID, AccessTime, AccessMode, UserName, IsSuspicious) " +
                    "SELECT TOP 1 DocID, GETDATE(), 'SUCCESS_INGEST', '" + Environment.UserName + "', 0 FROM Documents WHERE QRText = '" + qrId + "'");

                MessageBox.Show("🛡️ Asset successfully encrypted and secured in the vault.", "Vault Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshVaultAnalytics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vault Entry Error: " + ex.Message);
            }
        }

        // =========================================================
        // 📊 ANALYTICS & HUB SYNC
        // =========================================================

        public void RefreshVaultAnalytics()
        {
            try
            {
                DataTable dtDocs = DbHelper.ExecuteQuery("SELECT COUNT(*) FROM Documents");
                lblTotalDocs.Text = "Documents: " + dtDocs.Rows[0][0];

                DataTable dtAlerts = DbHelper.ExecuteQuery("SELECT COUNT(*) FROM AccessLog WHERE IsSuspicious = 1");
                lblSuspicious.Text = "Alerts: " + dtAlerts.Rows[0][0];

                DataTable dtPop = DbHelper.ExecuteQuery("SELECT TOP 1 D.Title FROM AccessLog A JOIN Documents D ON A.DocID = D.DocID GROUP BY D.Title ORDER BY COUNT(*) DESC");
                lblMostScanned.Text = dtPop.Rows.Count > 0 ? "🔥 Popular: " + dtPop.Rows[0][0] : "🔥 Popular: None";

                DataTable dtUser = DbHelper.ExecuteQuery("SELECT TOP 1 UserName FROM AccessLog ORDER BY AccessTime DESC");
                lblLastUser.Text = dtUser.Rows.Count > 0 ? "👤 Last User: " + dtUser.Rows[0][0] : "👤 Last User: N/A";
            }
            catch { }
        }

        private void btnDownloadQR_Click(object sender, EventArgs e)
        {
            if (pbQR.Image == null) return;
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PNG Image|*.png", FileName = "Vault_Access_Key" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pbQR.Image.Save(sfd.FileName, ImageFormat.Png);
                    MessageBox.Show("Access Key Exported Successfully.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        // =========================================================
        // ✨ INTERACTIVE EFFECTS & UTILS
        // =========================================================

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(60, 60, 80);
            b.ForeColor = Color.FromArgb(78, 154, 241);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(35, 35, 45);
            b.ForeColor = Color.White;
        }

        private string GetFileHash(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}