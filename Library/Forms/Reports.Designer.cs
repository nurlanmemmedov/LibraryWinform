namespace Library.Forms
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.DgvReports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbRange = new System.Windows.Forms.ComboBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.LblRange = new System.Windows.Forms.Label();
            this.Txtİncome = new System.Windows.Forms.TextBox();
            this.Lblİncome = new System.Windows.Forms.Label();
            this.FbdChooseArea = new System.Windows.Forms.FolderBrowserDialog();
            this.PbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReports
            // 
            this.DgvReports.AllowUserToAddRows = false;
            this.DgvReports.AllowUserToDeleteRows = false;
            this.DgvReports.AllowUserToResizeRows = false;
            this.DgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReports.BackgroundColor = System.Drawing.Color.White;
            this.DgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvReports.GridColor = System.Drawing.Color.Black;
            this.DgvReports.Location = new System.Drawing.Point(46, 125);
            this.DgvReports.Name = "DgvReports";
            this.DgvReports.ReadOnly = true;
            this.DgvReports.Size = new System.Drawing.Size(442, 281);
            this.DgvReports.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Client Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Book Title";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pay";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CmbRange
            // 
            this.CmbRange.FormattingEnabled = true;
            this.CmbRange.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "Novomber",
            "December",
            "All"});
            this.CmbRange.Location = new System.Drawing.Point(46, 80);
            this.CmbRange.Name = "CmbRange";
            this.CmbRange.Size = new System.Drawing.Size(174, 21);
            this.CmbRange.TabIndex = 1;
            this.CmbRange.SelectedIndexChanged += new System.EventHandler(this.CmbRange_SelectedIndexChanged);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnExport.FlatAppearance.BorderSize = 0;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.Location = new System.Drawing.Point(350, 433);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(138, 36);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // LblRange
            // 
            this.LblRange.AutoSize = true;
            this.LblRange.Location = new System.Drawing.Point(43, 60);
            this.LblRange.Name = "LblRange";
            this.LblRange.Size = new System.Drawing.Size(87, 13);
            this.LblRange.TabIndex = 3;
            this.LblRange.Text = "Choose a Range";
            // 
            // Txtİncome
            // 
            this.Txtİncome.Location = new System.Drawing.Point(46, 449);
            this.Txtİncome.Name = "Txtİncome";
            this.Txtİncome.ReadOnly = true;
            this.Txtİncome.Size = new System.Drawing.Size(139, 20);
            this.Txtİncome.TabIndex = 4;
            // 
            // Lblİncome
            // 
            this.Lblİncome.AutoSize = true;
            this.Lblİncome.Location = new System.Drawing.Point(46, 430);
            this.Lblİncome.Name = "Lblİncome";
            this.Lblİncome.Size = new System.Drawing.Size(0, 13);
            this.Lblİncome.TabIndex = 5;
            // 
            // PbBack
            // 
            this.PbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBack.BackgroundImage")));
            this.PbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbBack.Location = new System.Drawing.Point(5, 5);
            this.PbBack.Name = "PbBack";
            this.PbBack.Size = new System.Drawing.Size(50, 51);
            this.PbBack.TabIndex = 17;
            this.PbBack.TabStop = false;
            this.PbBack.Click += new System.EventHandler(this.PbBack_Click_1);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(535, 504);
            this.Controls.Add(this.PbBack);
            this.Controls.Add(this.Lblİncome);
            this.Controls.Add(this.Txtİncome);
            this.Controls.Add(this.CmbRange);
            this.Controls.Add(this.LblRange);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.DgvReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReports;
        private System.Windows.Forms.ComboBox CmbRange;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Label LblRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox Txtİncome;
        private System.Windows.Forms.Label Lblİncome;
        private System.Windows.Forms.FolderBrowserDialog FbdChooseArea;
        private System.Windows.Forms.PictureBox PbBack;
    }
}