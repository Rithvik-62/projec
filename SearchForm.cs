using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Security.Cryptography;
using ZXing; // Uses ZXing.Net for QR decoding

namespace QRDocVault
{
    public partial class SearchForm : Form
    {
        // Security Tracking
        private int failedAttempts = 0;
        private string currentSearchMode = "NAME";

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            ApplyGridStyles();

            // INITIAL STATE: Hide everything for the "Clean Slate" intelligence look
            dgvResults.Visible = false;
            pnlSearchHeader.Visible = false;
            btnOpenDoc.Visible = false;

            // Wire up visual interactions
            SetupVisualEffects();
        }

        private void ApplyGridStyles()
        {
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.BackgroundColor = Color.FromArgb(35, 35, 45);
            dgvResults.BorderStyle = BorderStyle.None;
            dgvResults.GridColor = Color.FromArgb(50, 50, 70);
            dgvResults.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dgvResults.DefaultCellStyle.ForeColor = Color.White;
            dgvResults.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 80);
        }

        // =========================================================
        // 🎨 UI NAVIGATION (MODE SELECTION)
        // =========================================================

        private void btnNavName_Click(object sender, EventArgs e)
        {
            currentSearchMode = "NAME";
            lblSearchMode.Text = "SEARCHING BY: FILENAME";

            // UI Transition: Show only the search bar panel
            pnlSearchHeader.Visible = true;
            dgvResults.Visible = false; // Keep grid hidden initially
            btnOpenDoc.Visible = false;

            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnNavQR_Click(object sender, EventArgs e)
        {
            // Requirement: Upload a QR Image Key to locate the document
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Vault Keys|*.png;*.jpg;*.jpeg;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Bitmap bitmap = (Bitmap)Bitmap.FromFile(ofd.FileName))
                        {
                            BarcodeReader reader = new BarcodeReader();
                            var result = reader.Decode(bitmap);

                            if (result != null)
                            {
                                currentSearchMode = "QR";
                                lblSearchMode.Text = "SEARCHING BY: QR ACCESS KEY";
                                pnlSearchHeader.Visible = true;
                                txtSearch.Text = result.Text;

                                // Auto-trigger the search action
                                ExecuteVaultSearch();
                            }
                            else
                            {
                                MessageBox.Show("No valid QR Vault Key detected in the uploaded image.", "Forensic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Retrieval Error: " + ex.Message); }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================
        // 🔍 DYNAMIC SEARCH ENGINE
        // =========================================================

        // This handles the 'Find' button click to reveal the grid
        private void btnSearchAction_Click(object sender, EventArgs e)
        {
            ExecuteVaultSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Hide the grid if the user clears the text box
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvResults.Visible = false;
                btnOpenDoc.Visible = false;
            }
        }

        private void ExecuteVaultSearch()
        {
            string term = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(term)) return;

            string sql = "";
            SqlParameter[] p = {
                new SqlParameter("@K", "%" + term + "%"),
                new SqlParameter("@ExactK", term)
            };

            if (currentSearchMode == "NAME")
                sql = "SELECT DocID, Title, QRText, DocType, SecurityLevel FROM Documents WHERE Title LIKE @K";
            else
                sql = "SELECT DocID, Title, QRText, DocType, SecurityLevel FROM Documents WHERE QRText = @ExactK";

            DataTable results = DbHelper.ExecuteQuery(sql, p);

            if (results.Rows.Count > 0)
            {
                dgvResults.DataSource = results;
                dgvResults.Visible = true; // REVEAL grid only when results are found
                btnOpenDoc.Visible = true;
            }
            else
            {
                dgvResults.Visible = false;
                btnOpenDoc.Visible = false;
                MessageBox.Show("No matching records found in the vault.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // =========================================================
        // 🛡️ SECURITY PROTOCOLS (INTEGRITY & AUTH)
        // =========================================================

        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            if (dgvResults.CurrentRow == null) return;

            string id = dgvResults.CurrentRow.Cells["DocID"].Value.ToString();

            DataTable dt = DbHelper.ExecuteQuery("SELECT * FROM Documents WHERE DocID = " + id);
            if (dt.Rows.Count > 0)
            {
                DataRow doc = dt.Rows[0];
                string filePath = doc["FilePath"].ToString();
                string storedHash = doc["FileHash"].ToString();

                // 1. FORENSIC INTEGRITY CHECK
                if (File.Exists(filePath))
                {
                    if (GetFileHash(filePath) != storedHash)
                    {
                        lblStatusHeader.Text = "VAULT STATUS: TAMPER DETECTED";
                        lblStatusHeader.ForeColor = Color.Crimson;
                        pnlStatusDot.BackColor = Color.Crimson;

                        MessageBox.Show("🚩 SECURITY BREACH: Physical file tampered with. Access Blocked.", "Forensic Failure");
                        LogActivity(id, "TAMPER_DETECTED", 1);
                        return;
                    }
                }

                // 2. PASSWORD CHALLENGE
                if (doc["SecurityLevel"].ToString() != "Public")
                {
                    if (!ChallengePassword(doc["Password"].ToString(), id)) return;
                }

                // 3. AUTHORIZED ACCESS
                LogActivity(id, "SUCCESS_OPEN", 0);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
        }

        private bool ChallengePassword(string correctPass, string docId)
        {
            using (Form auth = new Form { Text = "Identity Verification", Size = new Size(300, 160), StartPosition = FormStartPosition.CenterScreen, FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false })
            {
                Label lbl = new Label { Text = "Enter Vault Password:", Left = 20, Top = 20, AutoSize = true };
                TextBox txt = new TextBox { Left = 20, Top = 45, Width = 240, PasswordChar = '*' };
                Button btn = new Button { Text = "Unlock", Left = 185, Top = 80, DialogResult = DialogResult.OK, FlatStyle = FlatStyle.Flat };
                auth.Controls.AddRange(new Control[] { lbl, txt, btn });
                auth.AcceptButton = btn;

                if (auth.ShowDialog() == DialogResult.OK)
                {
                    if (txt.Text == correctPass)
                    {
                        failedAttempts = 0;
                        return true;
                    }

                    failedAttempts++;
                    if (failedAttempts >= 3)
                    {
                        LogActivity(docId, "KICK_OUT_BRUTE_FORCE", 1);
                        MessageBox.Show("🚩 SECURITY LOCKDOWN: Excess failed attempts. Session terminated.", "Intrusion Alert");
                        this.Close();
                    }
                    else
                    {
                        LogActivity(docId, "WRONG_PASS", 1);
                        MessageBox.Show($"Incorrect Password. Attempt {failedAttempts} of 3.");
                    }
                }
                return false;
            }
        }

        // =========================================================
        // 🛠️ UTILITIES & EFFECTS
        // =========================================================

        private string GetFileHash(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        private void LogActivity(string docId, string mode, int isSuspicious)
        {
            string sql = "INSERT INTO AccessLog (DocID, AccessTime, AccessMode, UserName, IsSuspicious) " +
                         "VALUES (@ID, GETDATE(), @M, @U, @S)";
            SqlParameter[] p = {
                new SqlParameter("@ID", docId),
                new SqlParameter("@M", mode),
                new SqlParameter("@U", Environment.UserName),
                new SqlParameter("@S", isSuspicious)
            };
            DbHelper.ExecuteNonQuery(sql, p);
        }

        private void SetupVisualEffects()
        {
            btnNavName.MouseEnter += btn_MouseEnter;
            btnNavName.MouseLeave += btn_MouseLeave;
            btnNavQR.MouseEnter += btn_MouseEnter;
            btnNavQR.MouseLeave += btn_MouseLeave;
            btnBack.MouseEnter += btn_MouseEnter;
            btnBack.MouseLeave += btn_MouseLeave;
        }

        private void btn_MouseEnter(object sender, EventArgs e) { Button b = (Button)sender; b.BackColor = Color.FromArgb(60, 60, 80); b.ForeColor = Color.FromArgb(78, 154, 241); }
        private void btn_MouseLeave(object sender, EventArgs e) { Button b = (Button)sender; b.BackColor = Color.FromArgb(35, 35, 45); b.ForeColor = Color.White; }
    }
}