using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QRDocVault
{
    public partial class Dashboard : Form
    {
        // System Timers
        private System.Windows.Forms.Timer pulseTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();

        private int pulseAlpha = 255;
        private bool pulseDir = true;
        private bool isFilteredView = false;

        public Dashboard()
        {
            InitializeComponent();
            SetupCyberAnimations();
            SetupAutoRefresh();

            // Forensic Red/Green coloring event
            dgvRecentActivity.CellFormatting += dgvRecentActivity_CellFormatting;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplyGridStyles();
            RefreshHubStats();
        }

        private void SetupCyberAnimations()
        {
            // Breathing Logo Effect
            pulseTimer.Interval = 50;
            pulseTimer.Tick += (s, e) => {
                if (pulseDir) pulseAlpha -= 5; else pulseAlpha += 5;
                if (pulseAlpha <= 110) pulseDir = false;
                if (pulseAlpha >= 255) pulseDir = true;
                lblLogo.ForeColor = Color.FromArgb(pulseAlpha, 78, 154, 241);
            };
            pulseTimer.Start();
        }

        private void SetupAutoRefresh()
        {
            refreshTimer.Interval = 10000; // 10s Heartbeat
            refreshTimer.Tick += (s, e) => {
                if (!isFilteredView) RefreshHubStats();
            };
            refreshTimer.Start();
        }

        private void ApplyGridStyles()
        {
            dgvRecentActivity.ReadOnly = true;
            dgvRecentActivity.RowHeadersVisible = false;
            dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentActivity.BackgroundColor = Color.FromArgb(35, 35, 45);
            dgvRecentActivity.BorderStyle = BorderStyle.None;
            dgvRecentActivity.GridColor = Color.FromArgb(50, 50, 70);
            dgvRecentActivity.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
            dgvRecentActivity.DefaultCellStyle.ForeColor = Color.White;
            dgvRecentActivity.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 80);
        }

        public void RefreshHubStats()
        {
            try
            {
                DataTable dtDocs = DbHelper.ExecuteQuery("SELECT COUNT(*) FROM Documents");
                DataTable dtScans = DbHelper.ExecuteQuery("SELECT COUNT(*) FROM AccessLog");
                DataTable dtAlerts = DbHelper.ExecuteQuery("SELECT COUNT(*) FROM AccessLog WHERE IsSuspicious = 1");

                lblTotalDocs.Text = (dtDocs.Rows.Count > 0) ? dtDocs.Rows[0][0].ToString() : "0";
                lblTotalScans.Text = (dtScans.Rows.Count > 0) ? dtScans.Rows[0][0].ToString() : "0";

                int alertCount = Convert.ToInt32(dtAlerts.Rows[0][0]);
                lblSecurityAlerts.Text = alertCount.ToString();

                pnlAlertPulse.BackColor = alertCount > 0 ? Color.Crimson : Color.MediumSeaGreen;
                lblStatusHeader.Text = alertCount > 0 ? "VAULT STATUS: ALERTS ACTIVE" : "VAULT STATUS: SECURE";
                lblStatusHeader.ForeColor = alertCount > 0 ? Color.Crimson : Color.MediumSeaGreen;

                // Smart Intelligence
                DataTable dtPopular = DbHelper.ExecuteQuery("SELECT TOP 1 D.Title FROM Documents D INNER JOIN AccessLog A ON D.DocID = A.DocID GROUP BY D.Title ORDER BY COUNT(A.LogID) DESC");
                lblMostScanned.Text = (dtPopular.Rows.Count > 0) ? "🔥 Popular: " + dtPopular.Rows[0][0].ToString() : "🔥 Popular: N/A";

                DataTable dtUser = DbHelper.ExecuteQuery("SELECT TOP 1 UserName FROM AccessLog ORDER BY AccessTime DESC");
                lblLastUser.Text = (dtUser.Rows.Count > 0) ? "👤 Last User: " + dtUser.Rows[0][0].ToString() : "👤 Last User: ---";

                // Activity Log with Titles
                string sql = "SELECT TOP 15 A.AccessTime, A.AccessMode, A.UserName, D.Title FROM AccessLog A LEFT JOIN Documents D ON A.DocID = D.DocID ORDER BY A.AccessTime DESC";
                dgvRecentActivity.DataSource = DbHelper.ExecuteQuery(sql);
                lblActivityTitle.Text = "RECENT VAULT ACTIVITY";
                isFilteredView = false;
            }
            catch { }
        }

        private void dgvRecentActivity_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRecentActivity.Columns[e.ColumnIndex].Name == "AccessMode" && e.Value != null)
            {
                string val = e.Value.ToString().ToUpper();
                if (val.Contains("WRONG") || val.Contains("FAIL") || val.Contains("UNAUTHORIZED") || val.Contains("SUSPICIOUS") || val.Contains("KICK-OUT") || val.Contains("PASS"))
                {
                    e.CellStyle.ForeColor = Color.Crimson;
                    e.CellStyle.Font = new Font(dgvRecentActivity.Font, FontStyle.Bold);
                }
                else if (val.Contains("SUCCESS") || val.Contains("GRANTED") || val.Contains("OPEN"))
                {
                    e.CellStyle.ForeColor = Color.MediumSeaGreen;
                }
            }
        }

        private void btnNavUpload_Click(object sender, EventArgs e) { this.Opacity = 0.8; new Form1().ShowDialog(); this.Opacity = 1.0; RefreshHubStats(); }
        private void btnNavSearch_Click(object sender, EventArgs e) { this.Opacity = 0.8; new SearchForm().ShowDialog(); this.Opacity = 1.0; RefreshHubStats(); }
        private void btnNavLogs_Click(object sender, EventArgs e)
        {
            string sql = "SELECT A.AccessTime, A.AccessMode, A.UserName, D.Title FROM AccessLog A LEFT JOIN Documents D ON A.DocID = D.DocID WHERE A.IsSuspicious = 1 ORDER BY A.AccessTime DESC";
            dgvRecentActivity.DataSource = DbHelper.ExecuteQuery(sql);
            lblActivityTitle.Text = "🚩 CRITICAL SECURITY AUDIT";
            lblActivityTitle.ForeColor = Color.Crimson;
            isFilteredView = true;
        }
        private void btnExitSystem_Click(object sender, EventArgs e) { if (MessageBox.Show("Close QR Doc Vault?", "Lockdown", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit(); }

        private void btn_MouseEnter(object sender, EventArgs e) { ((Button)sender).BackColor = Color.FromArgb(60, 60, 80); }
        private void btn_MouseLeave(object sender, EventArgs e) { ((Button)sender).BackColor = Color.FromArgb(35, 35, 45); }
    }
}