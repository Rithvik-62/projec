namespace QRDocVault
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.btnNavLogs = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavUpload = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLastUser = new System.Windows.Forms.Label();
            this.lblMostScanned = new System.Windows.Forms.Label();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.dgvRecentActivity = new System.Windows.Forms.DataGridView();
            this.pnlAlertPulse = new System.Windows.Forms.Panel();
            this.lblStatusHeader = new System.Windows.Forms.Label();
            this.cardAlerts = new System.Windows.Forms.Panel();
            this.lblSecurityAlerts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardScans = new System.Windows.Forms.Panel();
            this.lblTotalScans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardDocs = new System.Windows.Forms.Panel();
            this.lblTotalDocs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
            this.cardAlerts.SuspendLayout();
            this.cardScans.SuspendLayout();
            this.cardDocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.pnlSidebar.Controls.Add(this.btnExitSystem);
            this.pnlSidebar.Controls.Add(this.btnNavLogs);
            this.pnlSidebar.Controls.Add(this.btnNavSearch);
            this.pnlSidebar.Controls.Add(this.btnNavUpload);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitSystem.FlatAppearance.BorderSize = 0;
            this.btnExitSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExitSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExitSystem.Location = new System.Drawing.Point(12, 650);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(235, 45);
            this.btnExitSystem.TabIndex = 4;
            this.btnExitSystem.Text = "🚪 EXIT DOC VAULT";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            this.btnExitSystem.Click += new System.EventHandler(this.btnExitSystem_Click);
            // 
            // btnNavLogs
            // 
            this.btnNavLogs.FlatAppearance.BorderSize = 0;
            this.btnNavLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavLogs.ForeColor = System.Drawing.Color.White;
            this.btnNavLogs.Location = new System.Drawing.Point(12, 260);
            this.btnNavLogs.Name = "btnNavLogs";
            this.btnNavLogs.Size = new System.Drawing.Size(235, 50);
            this.btnNavLogs.TabIndex = 3;
            this.btnNavLogs.Text = "🛡️ SECURITY AUDIT";
            this.btnNavLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogs.UseVisualStyleBackColor = true;
            this.btnNavLogs.Click += new System.EventHandler(this.btnNavLogs_Click);
            this.btnNavLogs.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnNavLogs.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.FlatAppearance.BorderSize = 0;
            this.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavSearch.ForeColor = System.Drawing.Color.White;
            this.btnNavSearch.Location = new System.Drawing.Point(12, 200);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(235, 50);
            this.btnNavSearch.TabIndex = 2;
            this.btnNavSearch.Text = "🔍 SEARCH DOCUMENT";
            this.btnNavSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSearch.UseVisualStyleBackColor = true;
            this.btnNavSearch.Click += new System.EventHandler(this.btnNavSearch_Click);
            this.btnNavSearch.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnNavSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnNavUpload
            // 
            this.btnNavUpload.FlatAppearance.BorderSize = 0;
            this.btnNavUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNavUpload.ForeColor = System.Drawing.Color.White;
            this.btnNavUpload.Location = new System.Drawing.Point(12, 140);
            this.btnNavUpload.Name = "btnNavUpload";
            this.btnNavUpload.Size = new System.Drawing.Size(235, 50);
            this.btnNavUpload.TabIndex = 1;
            this.btnNavUpload.Text = "📤 UPLOAD DOCUMENT";
            this.btnNavUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUpload.UseVisualStyleBackColor = true;
            this.btnNavUpload.Click += new System.EventHandler(this.btnNavUpload_Click);
            this.btnNavUpload.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnNavUpload.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(154)))), ((int)(((byte)(241)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🛡️ QR DOC VAULT";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlMain.Controls.Add(this.lblLastUser);
            this.pnlMain.Controls.Add(this.lblMostScanned);
            this.pnlMain.Controls.Add(this.lblActivityTitle);
            this.pnlMain.Controls.Add(this.dgvRecentActivity);
            this.pnlMain.Controls.Add(this.pnlAlertPulse);
            this.pnlMain.Controls.Add(this.lblStatusHeader);
            this.pnlMain.Controls.Add(this.cardAlerts);
            this.pnlMain.Controls.Add(this.cardScans);
            this.pnlMain.Controls.Add(this.cardDocs);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(260, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 720);
            this.pnlMain.TabIndex = 1;
            // 
            // lblLastUser
            // 
            this.lblLastUser.AutoSize = true;
            this.lblLastUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastUser.ForeColor = System.Drawing.Color.Silver;
            this.lblLastUser.Location = new System.Drawing.Point(400, 275);
            this.lblLastUser.Name = "lblLastUser";
            this.lblLastUser.Size = new System.Drawing.Size(100, 20);
            this.lblLastUser.TabIndex = 7;
            this.lblLastUser.Text = "👤 Last User: ---";
            // 
            // lblMostScanned
            // 
            this.lblMostScanned.AutoSize = true;
            this.lblMostScanned.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMostScanned.ForeColor = System.Drawing.Color.LightBlue;
            this.lblMostScanned.Location = new System.Drawing.Point(40, 275);
            this.lblMostScanned.Name = "lblMostScanned";
            this.lblMostScanned.Size = new System.Drawing.Size(95, 20);
            this.lblMostScanned.TabIndex = 6;
            this.lblMostScanned.Text = "🔥 Popular: ---";
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblActivityTitle.Location = new System.Drawing.Point(40, 315);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(220, 28);
            this.lblActivityTitle.TabIndex = 5;
            this.lblActivityTitle.Text = "RECENT VAULT ACTIVITY";
            // 
            // dgvRecentActivity
            // 
            this.dgvRecentActivity.AllowUserToAddRows = false;
            this.dgvRecentActivity.AllowUserToDeleteRows = false;
            this.dgvRecentActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.dgvRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentActivity.Location = new System.Drawing.Point(40, 355);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.ReadOnly = true;
            this.dgvRecentActivity.RowHeadersVisible = false;
            this.dgvRecentActivity.RowHeadersWidth = 51;
            this.dgvRecentActivity.RowTemplate.Height = 35;
            this.dgvRecentActivity.Size = new System.Drawing.Size(1020, 340);
            this.dgvRecentActivity.TabIndex = 4;
            // 
            // pnlAlertPulse
            // 
            this.pnlAlertPulse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlAlertPulse.Location = new System.Drawing.Point(40, 40);
            this.pnlAlertPulse.Name = "pnlAlertPulse";
            this.pnlAlertPulse.Size = new System.Drawing.Size(15, 15);
            this.pnlAlertPulse.TabIndex = 3;
            // 
            // lblStatusHeader
            // 
            this.lblStatusHeader.AutoSize = true;
            this.lblStatusHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblStatusHeader.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblStatusHeader.Location = new System.Drawing.Point(65, 35);
            this.lblStatusHeader.Name = "lblStatusHeader";
            this.lblStatusHeader.Size = new System.Drawing.Size(200, 25);
            this.lblStatusHeader.TabIndex = 2;
            this.lblStatusHeader.Text = "VAULT STATUS: SECURE";
            // 
            // cardAlerts
            // 
            this.cardAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cardAlerts.Controls.Add(this.lblSecurityAlerts);
            this.cardAlerts.Controls.Add(this.label3);
            this.cardAlerts.Location = new System.Drawing.Point(740, 90);
            this.cardAlerts.Name = "cardAlerts";
            this.cardAlerts.Size = new System.Drawing.Size(320, 160);
            this.cardAlerts.TabIndex = 1;
            // 
            // lblSecurityAlerts
            // 
            this.lblSecurityAlerts.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblSecurityAlerts.ForeColor = System.Drawing.Color.Crimson;
            this.lblSecurityAlerts.Location = new System.Drawing.Point(0, 40);
            this.lblSecurityAlerts.Name = "lblSecurityAlerts";
            this.lblSecurityAlerts.Size = new System.Drawing.Size(320, 100);
            this.lblSecurityAlerts.TabIndex = 1;
            this.lblSecurityAlerts.Text = "0";
            this.lblSecurityAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "SECURITY ALERTS";
            // 
            // cardScans
            // 
            this.cardScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cardScans.Controls.Add(this.lblTotalScans);
            this.cardScans.Controls.Add(this.label2);
            this.cardScans.Location = new System.Drawing.Point(390, 90);
            this.cardScans.Name = "cardScans";
            this.cardScans.Size = new System.Drawing.Size(320, 160);
            this.cardScans.TabIndex = 1;
            // 
            // lblTotalScans
            // 
            this.lblTotalScans.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblTotalScans.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalScans.Location = new System.Drawing.Point(0, 40);
            this.lblTotalScans.Name = "lblTotalScans";
            this.lblTotalScans.Size = new System.Drawing.Size(320, 100);
            this.lblTotalScans.TabIndex = 1;
            this.lblTotalScans.Text = "0";
            this.lblTotalScans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SCAN COUNT";
            // 
            // cardDocs
            // 
            this.cardDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cardDocs.Controls.Add(this.lblTotalDocs);
            this.cardDocs.Controls.Add(this.label1);
            this.cardDocs.Location = new System.Drawing.Point(40, 90);
            this.cardDocs.Name = "cardDocs";
            this.cardDocs.Size = new System.Drawing.Size(320, 160);
            this.cardDocs.TabIndex = 0;
            // 
            // lblTotalDocs
            // 
            this.lblTotalDocs.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblTotalDocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(154)))), ((int)(((byte)(241)))));
            this.lblTotalDocs.Location = new System.Drawing.Point(0, 40);
            this.lblTotalDocs.Name = "lblTotalDocs";
            this.lblTotalDocs.Size = new System.Drawing.Size(320, 100);
            this.lblTotalDocs.TabIndex = 1;
            this.lblTotalDocs.Text = "0";
            this.lblTotalDocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTS";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Doc Vault Intelligence Hub";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
            this.cardAlerts.ResumeLayout(false);
            this.cardAlerts.PerformLayout();
            this.cardScans.ResumeLayout(false);
            this.cardScans.PerformLayout();
            this.cardDocs.ResumeLayout(false);
            this.cardDocs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavUpload;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavLogs;
        private System.Windows.Forms.Button btnExitSystem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel cardDocs;
        private System.Windows.Forms.Label lblTotalDocs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cardScans;
        private System.Windows.Forms.Label lblTotalScans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel cardAlerts;
        private System.Windows.Forms.Label lblSecurityAlerts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAlertPulse;
        private System.Windows.Forms.Label lblStatusHeader;
        private System.Windows.Forms.DataGridView dgvRecentActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblMostScanned;
        private System.Windows.Forms.Label lblLastUser;
    }
}