namespace Library.Forms
{
    partial class ManagerCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerCrud));
            this.DgvManagers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDeactive = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblSelect = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblSurnameSearch = new System.Windows.Forms.Label();
            this.TxtSurnameSearch = new System.Windows.Forms.TextBox();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.TxtPhoneSearch = new System.Windows.Forms.TextBox();
            this.LblNameSearch = new System.Windows.Forms.Label();
            this.LblPhoneNum = new System.Windows.Forms.Label();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagers)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvManagers
            // 
            this.DgvManagers.AllowUserToAddRows = false;
            this.DgvManagers.AllowUserToDeleteRows = false;
            this.DgvManagers.AllowUserToResizeRows = false;
            this.DgvManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvManagers.BackgroundColor = System.Drawing.Color.White;
            this.DgvManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvManagers.GridColor = System.Drawing.Color.Black;
            this.DgvManagers.Location = new System.Drawing.Point(302, 180);
            this.DgvManagers.Name = "DgvManagers";
            this.DgvManagers.ReadOnly = true;
            this.DgvManagers.Size = new System.Drawing.Size(546, 425);
            this.DgvManagers.TabIndex = 0;
            this.DgvManagers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvManagers_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "İs Admin";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(40, 246);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(227, 20);
            this.TxtName.TabIndex = 1;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(40, 313);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(227, 20);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(40, 378);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(227, 20);
            this.TxtPhone.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Green;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(40, 566);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(227, 39);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(40, 220);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(40, 285);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(49, 13);
            this.LblSurname.TabIndex = 6;
            this.LblSurname.Text = "Surname";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(40, 356);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(38, 13);
            this.LblPhone.TabIndex = 7;
            this.LblPhone.Text = "Phone";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(40, 566);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 39);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDeactive
            // 
            this.BtnDeactive.BackColor = System.Drawing.Color.Brown;
            this.BtnDeactive.FlatAppearance.BorderSize = 0;
            this.BtnDeactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDeactive.ForeColor = System.Drawing.Color.White;
            this.BtnDeactive.Location = new System.Drawing.Point(117, 566);
            this.BtnDeactive.Name = "BtnDeactive";
            this.BtnDeactive.Size = new System.Drawing.Size(72, 39);
            this.BtnDeactive.TabIndex = 9;
            this.BtnDeactive.Text = "lay off";
            this.BtnDeactive.UseVisualStyleBackColor = false;
            this.BtnDeactive.Visible = false;
            this.BtnDeactive.Click += new System.EventHandler(this.BtnDeactive_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(195, 566);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 39);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblSelect);
            this.PnlHeader.Location = new System.Drawing.Point(302, 149);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(546, 31);
            this.PnlHeader.TabIndex = 11;
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Location = new System.Drawing.Point(3, 10);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(182, 13);
            this.LblSelect.TabIndex = 9;
            this.LblSelect.Text = "Click To Update Or Delete Managers";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(37, 154);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(44, 13);
            this.LblPosition.TabIndex = 13;
            this.LblPosition.Text = "Position";
            // 
            // CmbPosition
            // 
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Items.AddRange(new object[] {
            "Admin",
            "Ordinary Manager"});
            this.CmbPosition.Location = new System.Drawing.Point(40, 180);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(227, 21);
            this.CmbPosition.TabIndex = 14;
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.PnlSearch.Controls.Add(this.LblHeader);
            this.PnlSearch.Controls.Add(this.LblSurnameSearch);
            this.PnlSearch.Controls.Add(this.TxtSurnameSearch);
            this.PnlSearch.Controls.Add(this.BtnCancelSearch);
            this.PnlSearch.Controls.Add(this.TxtPhoneSearch);
            this.PnlSearch.Controls.Add(this.LblNameSearch);
            this.PnlSearch.Controls.Add(this.LblPhoneNum);
            this.PnlSearch.Controls.Add(this.TxtNameSearch);
            this.PnlSearch.Location = new System.Drawing.Point(12, 13);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(836, 106);
            this.PnlSearch.TabIndex = 15;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.BackColor = System.Drawing.Color.DarkOrange;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(0, 4);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(127, 20);
            this.LblHeader.TabIndex = 25;
            this.LblHeader.Text = "Search Manager";
            // 
            // LblSurnameSearch
            // 
            this.LblSurnameSearch.AutoSize = true;
            this.LblSurnameSearch.ForeColor = System.Drawing.Color.White;
            this.LblSurnameSearch.Location = new System.Drawing.Point(248, 45);
            this.LblSurnameSearch.Name = "LblSurnameSearch";
            this.LblSurnameSearch.Size = new System.Drawing.Size(140, 13);
            this.LblSurnameSearch.TabIndex = 21;
            this.LblSurnameSearch.Text = "Enter a surname of manager";
            // 
            // TxtSurnameSearch
            // 
            this.TxtSurnameSearch.Location = new System.Drawing.Point(251, 68);
            this.TxtSurnameSearch.Name = "TxtSurnameSearch";
            this.TxtSurnameSearch.Size = new System.Drawing.Size(202, 20);
            this.TxtSurnameSearch.TabIndex = 22;
            this.TxtSurnameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelSearch.FlatAppearance.BorderSize = 0;
            this.BtnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCancelSearch.Location = new System.Drawing.Point(718, 62);
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
            this.TxtPhoneSearch.Location = new System.Drawing.Point(484, 68);
            this.TxtPhoneSearch.Name = "TxtPhoneSearch";
            this.TxtPhoneSearch.Size = new System.Drawing.Size(195, 20);
            this.TxtPhoneSearch.TabIndex = 19;
            this.TxtPhoneSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // LblNameSearch
            // 
            this.LblNameSearch.AutoSize = true;
            this.LblNameSearch.ForeColor = System.Drawing.Color.White;
            this.LblNameSearch.Location = new System.Drawing.Point(25, 45);
            this.LblNameSearch.Name = "LblNameSearch";
            this.LblNameSearch.Size = new System.Drawing.Size(126, 13);
            this.LblNameSearch.TabIndex = 16;
            this.LblNameSearch.Text = "Enter a name of manager";
            // 
            // LblPhoneNum
            // 
            this.LblPhoneNum.AutoSize = true;
            this.LblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.LblPhoneNum.Location = new System.Drawing.Point(481, 45);
            this.LblPhoneNum.Name = "LblPhoneNum";
            this.LblPhoneNum.Size = new System.Drawing.Size(168, 13);
            this.LblPhoneNum.TabIndex = 18;
            this.LblPhoneNum.Text = "Enter a phone number of manager";
            // 
            // TxtNameSearch
            // 
            this.TxtNameSearch.Location = new System.Drawing.Point(28, 68);
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(185, 20);
            this.TxtNameSearch.TabIndex = 17;
            this.TxtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(39, 486);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 19;
            this.LblPassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(39, 415);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(53, 13);
            this.LblUsername.TabIndex = 18;
            this.LblUsername.Text = "username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(39, 508);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(227, 20);
            this.TxtPassword.TabIndex = 17;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(39, 443);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(227, 20);
            this.TxtUsername.TabIndex = 16;
            // 
            // ManagerCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(860, 643);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.PnlSearch);
            this.Controls.Add(this.CmbPosition);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeactive);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.DgvManagers);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerCrud";
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagers)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvManagers;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDeactive;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.TextBox TxtPhoneSearch;
        private System.Windows.Forms.Label LblNameSearch;
        private System.Windows.Forms.Label LblPhoneNum;
        private System.Windows.Forms.TextBox TxtNameSearch;
        private System.Windows.Forms.Label LblSurnameSearch;
        private System.Windows.Forms.TextBox TxtSurnameSearch;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
    }
}