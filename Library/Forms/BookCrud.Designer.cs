namespace Library.Forms
{
    partial class BookCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCrud));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDeactive = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblSelect = new System.Windows.Forms.Label();
            this.NmrcCount = new System.Windows.Forms.NumericUpDown();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.TxtAuthorSearch = new System.Windows.Forms.TextBox();
            this.LblNameSearch = new System.Windows.Forms.Label();
            this.LblPhoneNum = new System.Windows.Forms.Label();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.PbBack = new System.Windows.Forms.PictureBox();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcCount)).BeginInit();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(221, 453);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 39);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDeactive
            // 
            this.BtnDeactive.BackColor = System.Drawing.Color.Brown;
            this.BtnDeactive.FlatAppearance.BorderSize = 0;
            this.BtnDeactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDeactive.ForeColor = System.Drawing.Color.White;
            this.BtnDeactive.Location = new System.Drawing.Point(143, 453);
            this.BtnDeactive.Name = "BtnDeactive";
            this.BtnDeactive.Size = new System.Drawing.Size(72, 39);
            this.BtnDeactive.TabIndex = 20;
            this.BtnDeactive.Text = "Deactive";
            this.BtnDeactive.UseVisualStyleBackColor = false;
            this.BtnDeactive.Visible = false;
            this.BtnDeactive.Click += new System.EventHandler(this.BtnDeactive_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(66, 453);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 39);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.AllowUserToResizeRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvBooks.GridColor = System.Drawing.Color.Black;
            this.DgvBooks.Location = new System.Drawing.Point(325, 190);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.Size = new System.Drawing.Size(548, 302);
            this.DgvBooks.TabIndex = 11;
            this.DgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Count";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(66, 234);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(31, 13);
            this.LblPrice.TabIndex = 18;
            this.LblPrice.Text = "Price";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(66, 166);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 16;
            this.LblTitle.Text = "Title";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(66, 453);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(227, 39);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(66, 182);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(227, 20);
            this.TxtTitle.TabIndex = 12;
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(66, 302);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 23;
            this.LblAuthor.Text = "Author";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(66, 318);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(227, 20);
            this.TxtAuthor.TabIndex = 22;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(66, 367);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(35, 13);
            this.LblCount.TabIndex = 25;
            this.LblCount.Text = "Count";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblSelect);
            this.PnlHeader.Location = new System.Drawing.Point(325, 159);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(548, 31);
            this.PnlHeader.TabIndex = 26;
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Location = new System.Drawing.Point(3, 10);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(165, 13);
            this.LblSelect.TabIndex = 9;
            this.LblSelect.Text = "Click To Update Or Delete Books";
            // 
            // NmrcCount
            // 
            this.NmrcCount.Location = new System.Drawing.Point(69, 383);
            this.NmrcCount.Name = "NmrcCount";
            this.NmrcCount.Size = new System.Drawing.Size(224, 20);
            this.NmrcCount.TabIndex = 28;
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.PnlSearch.Controls.Add(this.LblHeader);
            this.PnlSearch.Controls.Add(this.BtnCancelSearch);
            this.PnlSearch.Controls.Add(this.TxtAuthorSearch);
            this.PnlSearch.Controls.Add(this.LblNameSearch);
            this.PnlSearch.Controls.Add(this.LblPhoneNum);
            this.PnlSearch.Controls.Add(this.TxtNameSearch);
            this.PnlSearch.Location = new System.Drawing.Point(62, 22);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(811, 106);
            this.PnlSearch.TabIndex = 36;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.BackColor = System.Drawing.Color.DarkOrange;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(364, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(101, 20);
            this.LblHeader.TabIndex = 25;
            this.LblHeader.Text = "Search Book";
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelSearch.FlatAppearance.BorderSize = 0;
            this.BtnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCancelSearch.Location = new System.Drawing.Point(693, 62);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(99, 29);
            this.BtnCancelSearch.TabIndex = 20;
            this.BtnCancelSearch.Text = "Cancel";
            this.BtnCancelSearch.UseVisualStyleBackColor = false;
            this.BtnCancelSearch.Visible = false;
            this.BtnCancelSearch.Click += new System.EventHandler(this.BtnCancelSearch_Click);
            // 
            // TxtAuthorSearch
            // 
            this.TxtAuthorSearch.Location = new System.Drawing.Point(317, 68);
            this.TxtAuthorSearch.Name = "TxtAuthorSearch";
            this.TxtAuthorSearch.Size = new System.Drawing.Size(258, 20);
            this.TxtAuthorSearch.TabIndex = 19;
            this.TxtAuthorSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // LblNameSearch
            // 
            this.LblNameSearch.AutoSize = true;
            this.LblNameSearch.ForeColor = System.Drawing.Color.White;
            this.LblNameSearch.Location = new System.Drawing.Point(24, 45);
            this.LblNameSearch.Name = "LblNameSearch";
            this.LblNameSearch.Size = new System.Drawing.Size(99, 13);
            this.LblNameSearch.TabIndex = 16;
            this.LblNameSearch.Text = "Enter a title of book";
            // 
            // LblPhoneNum
            // 
            this.LblPhoneNum.AutoSize = true;
            this.LblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.LblPhoneNum.Location = new System.Drawing.Point(314, 45);
            this.LblPhoneNum.Name = "LblPhoneNum";
            this.LblPhoneNum.Size = new System.Drawing.Size(93, 13);
            this.LblPhoneNum.TabIndex = 18;
            this.LblPhoneNum.Text = "enter author name";
            // 
            // TxtNameSearch
            // 
            this.TxtNameSearch.Location = new System.Drawing.Point(27, 68);
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(232, 20);
            this.TxtNameSearch.TabIndex = 17;
            this.TxtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // PbBack
            // 
            this.PbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbBack.BackgroundImage")));
            this.PbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbBack.Location = new System.Drawing.Point(6, 22);
            this.PbBack.Name = "PbBack";
            this.PbBack.Size = new System.Drawing.Size(50, 51);
            this.PbBack.TabIndex = 37;
            this.PbBack.TabStop = false;
            this.PbBack.Click += new System.EventHandler(this.PbBack_Click);
            // 
            // NumPrice
            // 
            this.NumPrice.DecimalPlaces = 2;
            this.NumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NumPrice.Location = new System.Drawing.Point(66, 259);
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(227, 20);
            this.NumPrice.TabIndex = 38;
            // 
            // BookCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(910, 528);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.PbBack);
            this.Controls.Add(this.PnlSearch);
            this.Controls.Add(this.NmrcCount);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeactive);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCrud";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcCount)).EndInit();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDeactive;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.NumericUpDown NmrcCount;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.TextBox TxtAuthorSearch;
        private System.Windows.Forms.Label LblNameSearch;
        private System.Windows.Forms.Label LblPhoneNum;
        private System.Windows.Forms.TextBox TxtNameSearch;
        private System.Windows.Forms.PictureBox PbBack;
        private System.Windows.Forms.NumericUpDown NumPrice;
    }
}