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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClientsSearch
            // 
            this.DgvClientsSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClientsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientsSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvClientsSearch.Location = new System.Drawing.Point(248, 27);
            this.DgvClientsSearch.Name = "DgvClientsSearch";
            this.DgvClientsSearch.Size = new System.Drawing.Size(334, 303);
            this.DgvClientsSearch.TabIndex = 0;
            this.DgvClientsSearch.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClientsSearch_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(32, 27);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(126, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Enter a Fullname of client";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(35, 58);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(164, 20);
            this.Txtname.TabIndex = 2;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(35, 148);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(164, 20);
            this.TxtPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a phone number of client";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(100, 211);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 39);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.Location = new System.Drawing.Point(35, 211);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(59, 39);
            this.BtnCancelSearch.TabIndex = 6;
            this.BtnCancelSearch.Text = "Cancel";
            this.BtnCancelSearch.UseVisualStyleBackColor = true;
            this.BtnCancelSearch.Visible = false;
            this.BtnCancelSearch.Click += new System.EventHandler(this.BtnCancelSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(35, 290);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(76, 40);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add Order";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Visible = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(123, 290);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(76, 40);
            this.BtnReturn.TabIndex = 8;
            this.BtnReturn.Text = "Return Book";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Visible = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 385);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCancelSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.DgvClientsSearch);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientsSearch)).EndInit();
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
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReturn;
    }
}