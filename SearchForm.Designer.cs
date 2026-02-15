namespace QRDocVault
{
    partial class SearchForm
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
            btnNavQR = new Button();
            btnNavName = new Button();
            lblLogo = new Label();
            pnlMain = new Panel();
            lblStatusHeader = new Label();
            pnlStatusDot = new Panel();
            btnOpenDoc = new Button();
            dgvResults = new DataGridView();
            pnlSearchHeader = new Panel();
            txtSearch = new TextBox();
            lblSearchMode = new Label();
            lblMainTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            pnlSearchHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(35, 35, 45);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(btnBack);
            pnlSidebar.Controls.Add(btnNavQR);
            pnlSidebar.Controls.Add(btnNavName);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 680);
            pnlSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(255, 80, 80);
            btnExit.Location = new Point(12, 610);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 45);
            btnExit.TabIndex = 4;
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
            btnBack.Location = new Point(12, 120);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(235, 50);
            btnBack.TabIndex = 3;
            btnBack.Text = "🔙 BACK TO HUB";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNavQR
            // 
            btnNavQR.FlatAppearance.BorderSize = 0;
            btnNavQR.FlatStyle = FlatStyle.Flat;
            btnNavQR.Font = new Font("Segoe UI Semibold", 10F);
            btnNavQR.ForeColor = Color.White;
            btnNavQR.Location = new Point(12, 240);
            btnNavQR.Name = "btnNavQR";
            btnNavQR.Size = new Size(235, 50);
            btnNavQR.TabIndex = 2;
            btnNavQR.Text = "📷 QR SCANNER";
            btnNavQR.TextAlign = ContentAlignment.MiddleLeft;
            btnNavQR.UseVisualStyleBackColor = true;
            btnNavQR.Click += btnNavQR_Click;
            // 
            // btnNavName
            // 
            btnNavName.FlatAppearance.BorderSize = 0;
            btnNavName.FlatStyle = FlatStyle.Flat;
            btnNavName.Font = new Font("Segoe UI Semibold", 10F);
            btnNavName.ForeColor = Color.White;
            btnNavName.Location = new Point(12, 180);
            btnNavName.Name = "btnNavName";
            btnNavName.Size = new Size(235, 50);
            btnNavName.TabIndex = 1;
            btnNavName.Text = "🔍 NAME SEARCH";
            btnNavName.TextAlign = ContentAlignment.MiddleLeft;
            btnNavName.UseVisualStyleBackColor = true;
            btnNavName.Click += btnNavName_Click;
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
            pnlMain.Controls.Add(lblStatusHeader);
            pnlMain.Controls.Add(pnlStatusDot);
            pnlMain.Controls.Add(btnOpenDoc);
            pnlMain.Controls.Add(dgvResults);
            pnlMain.Controls.Add(pnlSearchHeader);
            pnlMain.Controls.Add(lblMainTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(260, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(840, 680);
            pnlMain.TabIndex = 1;
            // 
            // lblStatusHeader
            // 
            lblStatusHeader.AutoSize = true;
            lblStatusHeader.Font = new Font("Segoe UI Semibold", 10F);
            lblStatusHeader.ForeColor = Color.MediumSeaGreen;
            lblStatusHeader.Location = new Point(65, 30);
            lblStatusHeader.Name = "lblStatusHeader";
            lblStatusHeader.Size = new Size(191, 23);
            lblStatusHeader.TabIndex = 5;
            lblStatusHeader.Text = "VAULT STATUS: SECURE";
            // 
            // pnlStatusDot
            // 
            pnlStatusDot.BackColor = Color.MediumSeaGreen;
            pnlStatusDot.Location = new Point(40, 35);
            pnlStatusDot.Name = "pnlStatusDot";
            pnlStatusDot.Size = new Size(12, 12);
            pnlStatusDot.TabIndex = 4;
            // 
            // btnOpenDoc
            // 
            btnOpenDoc.BackColor = Color.FromArgb(46, 139, 87);
            btnOpenDoc.FlatAppearance.BorderSize = 0;
            btnOpenDoc.FlatStyle = FlatStyle.Flat;
            btnOpenDoc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOpenDoc.ForeColor = Color.White;
            btnOpenDoc.Location = new Point(40, 580);
            btnOpenDoc.Name = "btnOpenDoc";
            btnOpenDoc.Size = new Size(300, 55);
            btnOpenDoc.TabIndex = 3;
            btnOpenDoc.Text = "📄 OPEN DOCUMENT";
            btnOpenDoc.UseVisualStyleBackColor = false;
            btnOpenDoc.Visible = false;
            btnOpenDoc.Click += btnOpenDoc_Click;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.BackgroundColor = Color.FromArgb(35, 35, 45);
            dgvResults.BorderStyle = BorderStyle.None;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(40, 200);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 35;
            dgvResults.Size = new Size(760, 360);
            dgvResults.TabIndex = 2;
            dgvResults.Visible = false;
            // 
            // pnlSearchHeader
            // 
            pnlSearchHeader.BackColor = Color.FromArgb(45, 45, 60);
            pnlSearchHeader.Controls.Add(txtSearch);
            pnlSearchHeader.Controls.Add(lblSearchMode);
            pnlSearchHeader.Location = new Point(40, 115);
            pnlSearchHeader.Name = "pnlSearchHeader";
            pnlSearchHeader.Size = new Size(760, 70);
            pnlSearchHeader.TabIndex = 1;
            pnlSearchHeader.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(28, 28, 35);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 16F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(20, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(720, 36);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearchMode
            // 
            lblSearchMode.AutoSize = true;
            lblSearchMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSearchMode.ForeColor = Color.FromArgb(78, 154, 241);
            lblSearchMode.Location = new Point(20, 2);
            lblSearchMode.Name = "lblSearchMode";
            lblSearchMode.Size = new Size(191, 20);
            lblSearchMode.TabIndex = 0;
            lblSearchMode.Text = "SEARCHING BY: FILENAME";
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.White;
            lblMainTitle.Location = new Point(35, 65);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(382, 37);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "Document Intelligence Center";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 680);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Retrieval Center";
            Load += SearchForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            pnlSearchHeader.ResumeLayout(false);
            pnlSearchHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavName;
        private System.Windows.Forms.Button btnNavQR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel pnlSearchHeader;
        private System.Windows.Forms.Label lblSearchMode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.Label lblStatusHeader;
        private System.Windows.Forms.Panel pnlStatusDot;
    }
}