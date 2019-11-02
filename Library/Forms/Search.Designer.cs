namespace Library.Forms
{
    partial class Search
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
            this.DgvClientsSearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblName = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblSelect = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientsSearch)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientsSearch
            // 
            this.DgvClientsSearch.AllowUserToAddRows = false;
            this.DgvClientsSearch.AllowUserToDeleteRows = false;
            this.DgvClientsSearch.AllowUserToResizeRows = false;
            this.DgvClientsSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientsSearch.BackgroundColor = System.Drawing.Color.White;
            this.DgvClientsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientsSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvClientsSearch.GridColor = System.Drawing.Color.Black;
            this.DgvClientsSearch.Location = new System.Drawing.Point(47, 128);
            this.DgvClientsSearch.Name = "DgvClientsSearch";
            this.DgvClientsSearch.ReadOnly = true;
            this.DgvClientsSearch.Size = new System.Drawing.Size(602, 303);
            this.DgvClientsSearch.TabIndex = 0;
            this.DgvClientsSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClientsSearch_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(44, 26);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(126, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Enter a Fullname of client";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(47, 57);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(164, 20);
            this.Txtname.TabIndex = 2;
            this.Txtname.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(268, 57);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(164, 20);
            this.TxtPhone.TabIndex = 4;
            this.TxtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a phone number of client";
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelSearch.FlatAppearance.BorderSize = 0;
            this.BtnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCancelSearch.Location = new System.Drawing.Point(550, 48);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(99, 29);
            this.BtnCancelSearch.TabIndex = 6;
            this.BtnCancelSearch.Text = "Cancel";
            this.BtnCancelSearch.UseVisualStyleBackColor = false;
            this.BtnCancelSearch.Visible = false;
            this.BtnCancelSearch.Click += new System.EventHandler(this.BtnCancelSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Green;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(424, 445);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(106, 28);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add Order";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Visible = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(550, 444);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(99, 29);
            this.BtnReturn.TabIndex = 8;
            this.BtnReturn.Text = "Return Book";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Visible = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Location = new System.Drawing.Point(3, 9);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(175, 13);
            this.LblSelect.TabIndex = 9;
            this.LblSelect.Text = " Click To Add Order or Return Book";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblSelect);
            this.PnlHeader.Location = new System.Drawing.Point(47, 97);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(602, 31);
            this.PnlHeader.TabIndex = 10;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(692, 487);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCancelSearch);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.DgvClientsSearch);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientsSearch)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientsSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.Panel PnlHeader;
    }
}