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
            this.DgvReports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbRange = new System.Windows.Forms.ComboBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.LblRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReports
            // 
            this.DgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvReports.Location = new System.Drawing.Point(46, 90);
            this.DgvReports.Name = "DgvReports";
            this.DgvReports.Size = new System.Drawing.Size(442, 281);
            this.DgvReports.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Client Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Book Title";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pay";
            this.Column4.Name = "Column4";
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
            this.CmbRange.Location = new System.Drawing.Point(46, 45);
            this.CmbRange.Name = "CmbRange";
            this.CmbRange.Size = new System.Drawing.Size(174, 21);
            this.CmbRange.TabIndex = 1;
            this.CmbRange.SelectedIndexChanged += new System.EventHandler(this.CmbRange_SelectedIndexChanged);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(350, 398);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(138, 36);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // LblRange
            // 
            this.LblRange.AutoSize = true;
            this.LblRange.Location = new System.Drawing.Point(43, 25);
            this.LblRange.Name = "LblRange";
            this.LblRange.Size = new System.Drawing.Size(87, 13);
            this.LblRange.TabIndex = 3;
            this.LblRange.Text = "Choose a Range";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 452);
            this.Controls.Add(this.CmbRange);
            this.Controls.Add(this.LblRange);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.DgvReports);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).EndInit();
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
    }
}