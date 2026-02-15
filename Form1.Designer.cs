namespace QRDocVault
{
    partial class Form1
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
            pnlSidebar = new Panel();
            btnExit = new Button();
            btnBack = new Button();
            lblLogo = new Label();
            pnlMain = new Panel();
            pnlAnalytics = new Panel();
            lblLastUser = new Label();
            lblMostScanned = new Label();
            lblSuspicious = new Label();
            lblTotalDocs = new Label();
            btnDownloadQR = new Button();
            pbQR = new PictureBox();
            btnSave = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            cmbSecurity = new ComboBox();
            label2 = new Label();
            lblDocType = new Label();
            lblFilePath = new Label();
            btnBrowse = new Button();
            txtTitle = new TextBox();
            label1 = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(35, 35, 45);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(btnBack);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 650);
            pnlSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(255, 80, 80);
            btnExit.Location = new Point(12, 580);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 45);
            btnExit.TabIndex = 2;
            btnExit.Text = "🚪";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnBack_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 140);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(235, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "🔙 BACK TO HUB";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(78, 154, 241);
            lblLogo.Location = new Point(0, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(260, 60);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🛡️ QR DOC VAULT";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(28, 28, 35);
            pnlMain.Controls.Add(pnlAnalytics);
            pnlMain.Controls.Add(btnDownloadQR);
            pnlMain.Controls.Add(pbQR);
            pnlMain.Controls.Add(btnSave);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(cmbSecurity);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(lblDocType);
            pnlMain.Controls.Add(lblFilePath);
            pnlMain.Controls.Add(btnBrowse);
            pnlMain.Controls.Add(txtTitle);
            pnlMain.Controls.Add(label1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(260, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(840, 650);
            pnlMain.TabIndex = 1;
            // 
            // pnlAnalytics
            // 
            pnlAnalytics.BackColor = Color.FromArgb(45, 45, 60);
            pnlAnalytics.Controls.Add(lblLastUser);
            pnlAnalytics.Controls.Add(lblMostScanned);
            pnlAnalytics.Controls.Add(lblSuspicious);
            pnlAnalytics.Controls.Add(lblTotalDocs);
            pnlAnalytics.Location = new Point(30, 480);
            pnlAnalytics.Name = "pnlAnalytics";
            pnlAnalytics.Size = new Size(780, 140);
            pnlAnalytics.TabIndex = 12;
            // 
            // lblLastUser
            // 
            lblLastUser.AutoSize = true;
            lblLastUser.ForeColor = Color.Silver;
            lblLastUser.Location = new Point(400, 80);
            lblLastUser.Name = "lblLastUser";
            lblLastUser.Size = new Size(118, 20);
            lblLastUser.TabIndex = 3;
            lblLastUser.Text = "👤 Last User: ---";
            // 
            // lblMostScanned
            // 
            lblMostScanned.AutoSize = true;
            lblMostScanned.ForeColor = Color.LightBlue;
            lblMostScanned.Location = new Point(400, 30);
            lblMostScanned.Name = "lblMostScanned";
            lblMostScanned.Size = new Size(109, 20);
            lblMostScanned.TabIndex = 2;
            lblMostScanned.Text = "🔥 Popular: ---";
            // 
            // lblSuspicious
            // 
            lblSuspicious.AutoSize = true;
            lblSuspicious.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSuspicious.ForeColor = Color.Crimson;
            lblSuspicious.Location = new Point(25, 75);
            lblSuspicious.Name = "lblSuspicious";
            lblSuspicious.Size = new Size(104, 28);
            lblSuspicious.TabIndex = 1;
            lblSuspicious.Text = "Alerts: 00";
            // 
            // lblTotalDocs
            // 
            lblTotalDocs.AutoSize = true;
            lblTotalDocs.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalDocs.ForeColor = Color.FromArgb(78, 154, 241);
            lblTotalDocs.Location = new Point(25, 25);
            lblTotalDocs.Name = "lblTotalDocs";
            lblTotalDocs.Size = new Size(154, 28);
            lblTotalDocs.TabIndex = 0;
            lblTotalDocs.Text = "Documents: 00";
            // 
            // btnDownloadQR
            // 
            btnDownloadQR.FlatAppearance.BorderColor = Color.FromArgb(78, 154, 241);
            btnDownloadQR.FlatStyle = FlatStyle.Flat;
            btnDownloadQR.ForeColor = Color.Silver;
            btnDownloadQR.Location = new Point(440, 320);
            btnDownloadQR.Name = "btnDownloadQR";
            btnDownloadQR.Size = new Size(250, 35);
            btnDownloadQR.TabIndex = 11;
            btnDownloadQR.Text = "💾 EXPORT ACCESS KEY";
            btnDownloadQR.UseVisualStyleBackColor = true;
            btnDownloadQR.Click += btnDownloadQR_Click;
            // 
            // pbQR
            // 
            pbQR.BackColor = Color.White;
            pbQR.BorderStyle = BorderStyle.FixedSingle;
            pbQR.Location = new Point(440, 60);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(250, 250);
            pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR.TabIndex = 10;
            pbQR.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 139, 87);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(380, 55);
            btnSave.TabIndex = 9;
            btnSave.Text = "🛡️ SECURE ASSET IN VAULT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(45, 45, 60);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(230, 320);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 295);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 7;
            label3.Text = "VAULT PASSWORD";
            // 
            // cmbSecurity
            // 
            cmbSecurity.BackColor = Color.FromArgb(45, 45, 60);
            cmbSecurity.FlatStyle = FlatStyle.Flat;
            cmbSecurity.ForeColor = Color.White;
            cmbSecurity.FormattingEnabled = true;
            cmbSecurity.Location = new Point(30, 320);
            cmbSecurity.Name = "cmbSecurity";
            cmbSecurity.Size = new Size(180, 28);
            cmbSecurity.TabIndex = 6;
            cmbSecurity.SelectedIndexChanged += cmbSecurity_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(30, 295);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 5;
            label2.Text = "SECURITY LEVEL";
            // 
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDocType.ForeColor = Color.FromArgb(78, 154, 241);
            lblDocType.Location = new Point(30, 160);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(95, 20);
            lblDocType.TabIndex = 4;
            lblDocType.Text = "TYPE: NONE";
            // 
            // lblFilePath
            // 
            lblFilePath.AutoEllipsis = true;
            lblFilePath.ForeColor = Color.Gray;
            lblFilePath.Location = new Point(170, 115);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(240, 23);
            lblFilePath.TabIndex = 3;
            lblFilePath.Text = "No file selected...";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(78, 154, 241);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(30, 110);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(130, 35);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "📁 BROWSE ASSET";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(45, 45, 60);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(30, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(380, 27);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "DOCUMENT TITLE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 650);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Ingestion Unit";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlAnalytics.ResumeLayout(false);
            pnlAnalytics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Button btnDownloadQR;
        private System.Windows.Forms.Panel pnlAnalytics;
        private System.Windows.Forms.Label lblLastUser;
        private System.Windows.Forms.Label lblMostScanned;
        private System.Windows.Forms.Label lblSuspicious;
        private System.Windows.Forms.Label lblTotalDocs;
    }
}