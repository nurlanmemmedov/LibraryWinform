namespace Library.Forms
{
    partial class ClientCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCrud));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDeactive = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblFullname = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtFullname = new System.Windows.Forms.TextBox();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.TxtPhoneSearch = new System.Windows.Forms.TextBox();
            this.LblNameSearch = new System.Windows.Forms.Label();
            this.LblPhoneNum = new System.Windows.Forms.Label();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.PbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(219, 455);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 39);
            this.BtnCancel.TabIndex = 32;
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
            this.BtnDeactive.Location = new System.Drawing.Point(141, 455);
            this.BtnDeactive.Name = "BtnDeactive";
            this.BtnDeactive.Size = new System.Drawing.Size(72, 39);
            this.BtnDeactive.TabIndex = 31;
            this.BtnDeactive.Text = "Deactive";
            this.BtnDeactive.UseVisualStyleBackColor = false;
            this.BtnDeactive.Visible = false;
            this.BtnDeactive.Click += new System.EventHandler(this.BtnDeactive_Click_1);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(64, 455);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 39);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DgvClients
            // 
            this.DgvClients.AllowUserToAddRows = false;
            this.DgvClients.AllowUserToDeleteRows = false;
            this.DgvClients.AllowUserToResizeRows = false;
            this.DgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClients.BackgroundColor = System.Drawing.Color.White;
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvClients.GridColor = System.Drawing.Color.Black;
            this.DgvClients.Location = new System.Drawing.Point(328, 192);
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.ReadOnly = true;
            this.DgvClients.Size = new System.Drawing.Size(523, 302);
            this.DgvClients.TabIndex = 24;
            this.DgvClients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClients_RowHeaderMouseClick);
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
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(61, 294);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(38, 13);
            this.LblPhone.TabIndex = 29;
            this.LblPhone.Text = "Phone";
            // 
            // LblFullname
            // 
            this.LblFullname.AutoSize = true;
            this.LblFullname.Location = new System.Drawing.Point(61, 160);
            this.LblFullname.Name = "LblFullname";
            this.LblFullname.Size = new System.Drawing.Size(49, 13);
            this.LblFullname.TabIndex = 28;
            this.LblFullname.Text = "Fullname";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(64, 455);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(227, 39);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(61, 316);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(227, 20);
            this.TxtPhone.TabIndex = 26;
            // 
            // TxtFullname
            // 
            this.TxtFullname.Location = new System.Drawing.Point(61, 186);
            this.TxtFullname.Name = "TxtFullname";
            this.TxtFullname.Size = new System.Drawing.Size(227, 20);
            this.TxtFullname.TabIndex = 25;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Location = new System.Drawing.Point(328, 162);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(523, 31);
            this.PnlHeader.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click To Update Or Delete Clients";
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.PnlSearch.Controls.Add(this.LblHeader);
            this.PnlSearch.Controls.Add(this.BtnCancelSearch);
            this.PnlSearch.Controls.Add(this.TxtPhoneSearch);
            this.PnlSearch.Controls.Add(this.LblNameSearch);
            this.PnlSearch.Controls.Add(this.LblPhoneNum);
            this.PnlSearch.Controls.Add(this.TxtNameSearch);
            this.PnlSearch.Location = new System.Drawing.Point(62, 12);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(786, 106);
            this.PnlSearch.TabIndex = 35;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.BackColor = System.Drawing.Color.DarkOrange;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(347, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(104, 20);
            this.LblHeader.TabIndex = 25;
            this.LblHeader.Text = "Search Client";
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelSearch.FlatAppearance.BorderSize = 0;
            this.BtnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCancelSearch.Location = new System.Drawing.Point(662, 62);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(99, 29);
            this.BtnCancelSearch.TabIndex = 20;
            this.BtnCancelSearch.Text = "Cancel";
            this.BtnCancelSearch.UseVisualStyleBackColor = false;
            this.BtnCancelSearch.Visible = false;
            this.BtnCancelSearch.Click += new System.EventHandler(this.BtnCancelSearch_Click);
            // 
            // TxtPhoneSearch
            // 
            this.TxtPhoneSearch.Location = new System.Drawing.Point(317, 68);
            this.TxtPhoneSearch.Name = "TxtPhoneSearch";
            this.TxtPhoneSearch.Size = new System.Drawing.Size(258, 20);
            this.TxtPhoneSearch.TabIndex = 19;
            this.TxtPhoneSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // LblNameSearch
            // 
            this.LblNameSearch.AutoSize = true;
            this.LblNameSearch.ForeColor = System.Drawing.Color.White;
            this.LblNameSearch.Location = new System.Drawing.Point(24, 45);
            this.LblNameSearch.Name = "LblNameSearch";
            this.LblNameSearch.Size = new System.Drawing.Size(126, 13);
            this.LblNameSearch.TabIndex = 16;
            this.LblNameSearch.Text = "Enter a full name of client";
            // 
            // LblPhoneNum
            // 
            this.LblPhoneNum.AutoSize = true;
            this.LblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.LblPhoneNum.Location = new System.Drawing.Point(314, 45);
            this.LblPhoneNum.Name = "LblPhoneNum";
            this.LblPhoneNum.Size = new System.Drawing.Size(152, 13);
            this.LblPhoneNum.TabIndex = 18;
            this.LblPhoneNum.Text = "Enter a phone number of client";
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
            this.PbBack.Location = new System.Drawing.Point(6, 16);
            this.PbBack.Name = "PbBack";
            this.PbBack.Size = new System.Drawing.Size(50, 51);
            this.PbBack.TabIndex = 26;
            this.PbBack.TabStop = false;
            this.PbBack.Click += new System.EventHandler(this.PbBack_Click);
            // 
            // ClientCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(882, 527);
            this.Controls.Add(this.PbBack);
            this.Controls.Add(this.PnlSearch);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeactive);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.DgvClients);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblFullname);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtFullname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCrud";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDeactive;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView DgvClients;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblFullname;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.TextBox TxtPhoneSearch;
        private System.Windows.Forms.Label LblNameSearch;
        private System.Windows.Forms.Label LblPhoneNum;
        private System.Windows.Forms.TextBox TxtNameSearch;
        private System.Windows.Forms.PictureBox PbBack;
    }
}