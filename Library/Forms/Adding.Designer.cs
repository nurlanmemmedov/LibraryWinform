﻿namespace Library.Forms
{
    partial class Adding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding));
            this.DgvAllBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DtpReturn = new System.Windows.Forms.DateTimePicker();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblBasket = new System.Windows.Forms.Label();
            this.TxtOrderingBook = new System.Windows.Forms.TextBox();
            this.LblOrderingBook = new System.Windows.Forms.Label();
            this.LblReturnedTime = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlBasketHeader = new System.Windows.Forms.Panel();
            this.CmbClient = new System.Windows.Forms.ComboBox();
            this.LblClient = new System.Windows.Forms.Label();
            this.BtnNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.PnlBasketHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAllBooks
            // 
            this.DgvAllBooks.AllowUserToAddRows = false;
            this.DgvAllBooks.AllowUserToDeleteRows = false;
            this.DgvAllBooks.AllowUserToResizeRows = false;
            this.DgvAllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvAllBooks.GridColor = System.Drawing.Color.Black;
            this.DgvAllBooks.Location = new System.Drawing.Point(32, 71);
            this.DgvAllBooks.Name = "DgvAllBooks";
            this.DgvAllBooks.ReadOnly = true;
            this.DgvAllBooks.Size = new System.Drawing.Size(284, 263);
            this.DgvAllBooks.TabIndex = 0;
            this.DgvAllBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAllBooks_RowHeaderMouseClick);
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
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(725, 381);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 34);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DtpReturn
            // 
            this.DtpReturn.Location = new System.Drawing.Point(529, 395);
            this.DtpReturn.Name = "DtpReturn";
            this.DtpReturn.Size = new System.Drawing.Size(155, 20);
            this.DtpReturn.TabIndex = 3;
            // 
            // DgvOrders
            // 
            this.DgvOrders.AllowUserToAddRows = false;
            this.DgvOrders.AllowUserToDeleteRows = false;
            this.DgvOrders.AllowUserToResizeRows = false;
            this.DgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvOrders.GridColor = System.Drawing.Color.Black;
            this.DgvOrders.Location = new System.Drawing.Point(341, 71);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            this.DgvOrders.Size = new System.Drawing.Size(494, 263);
            this.DgvOrders.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Return Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cost";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Returned";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(3, 9);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(100, 13);
            this.LblAdd.TabIndex = 5;
            this.LblAdd.Text = "Click to Add Basket";
            // 
            // LblBasket
            // 
            this.LblBasket.AutoSize = true;
            this.LblBasket.Location = new System.Drawing.Point(1, 9);
            this.LblBasket.Name = "LblBasket";
            this.LblBasket.Size = new System.Drawing.Size(40, 13);
            this.LblBasket.TabIndex = 6;
            this.LblBasket.Text = "Basket";
            // 
            // TxtOrderingBook
            // 
            this.TxtOrderingBook.Location = new System.Drawing.Point(330, 395);
            this.TxtOrderingBook.Name = "TxtOrderingBook";
            this.TxtOrderingBook.ReadOnly = true;
            this.TxtOrderingBook.Size = new System.Drawing.Size(163, 20);
            this.TxtOrderingBook.TabIndex = 7;
            // 
            // LblOrderingBook
            // 
            this.LblOrderingBook.AutoSize = true;
            this.LblOrderingBook.Location = new System.Drawing.Point(327, 369);
            this.LblOrderingBook.Name = "LblOrderingBook";
            this.LblOrderingBook.Size = new System.Drawing.Size(91, 13);
            this.LblOrderingBook.TabIndex = 8;
            this.LblOrderingBook.Text = "Book To Ordering";
            // 
            // LblReturnedTime
            // 
            this.LblReturnedTime.AutoSize = true;
            this.LblReturnedTime.Location = new System.Drawing.Point(528, 372);
            this.LblReturnedTime.Name = "LblReturnedTime";
            this.LblReturnedTime.Size = new System.Drawing.Size(79, 13);
            this.LblReturnedTime.TabIndex = 9;
            this.LblReturnedTime.Text = "Returning Time";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblAdd);
            this.PnlHeader.Location = new System.Drawing.Point(32, 40);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(284, 31);
            this.PnlHeader.TabIndex = 11;
            // 
            // PnlBasketHeader
            // 
            this.PnlBasketHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlBasketHeader.Controls.Add(this.LblBasket);
            this.PnlBasketHeader.Location = new System.Drawing.Point(341, 40);
            this.PnlBasketHeader.Name = "PnlBasketHeader";
            this.PnlBasketHeader.Size = new System.Drawing.Size(602, 31);
            this.PnlBasketHeader.TabIndex = 12;
            // 
            // CmbClient
            // 
            this.CmbClient.FormattingEnabled = true;
            this.CmbClient.Location = new System.Drawing.Point(133, 394);
            this.CmbClient.Name = "CmbClient";
            this.CmbClient.Size = new System.Drawing.Size(154, 21);
            this.CmbClient.TabIndex = 13;
            this.CmbClient.SelectedIndexChanged += new System.EventHandler(this.CmbClient_SelectedIndexChanged);
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Location = new System.Drawing.Point(131, 369);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(72, 13);
            this.LblClient.TabIndex = 14;
            this.LblClient.Text = "Choose Client";
            // 
            // BtnNewClient
            // 
            this.BtnNewClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnNewClient.FlatAppearance.BorderSize = 0;
            this.BtnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewClient.ForeColor = System.Drawing.Color.White;
            this.BtnNewClient.Location = new System.Drawing.Point(32, 381);
            this.BtnNewClient.Name = "BtnNewClient";
            this.BtnNewClient.Size = new System.Drawing.Size(69, 33);
            this.BtnNewClient.TabIndex = 15;
            this.BtnNewClient.Text = "New Client";
            this.BtnNewClient.UseVisualStyleBackColor = false;
            this.BtnNewClient.Click += new System.EventHandler(this.BtnNewClient_Click);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(869, 444);
            this.Controls.Add(this.BtnNewClient);
            this.Controls.Add(this.LblClient);
            this.Controls.Add(this.CmbClient);
            this.Controls.Add(this.PnlBasketHeader);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.LblReturnedTime);
            this.Controls.Add(this.LblOrderingBook);
            this.Controls.Add(this.TxtOrderingBook);
            this.Controls.Add(this.DgvOrders);
            this.Controls.Add(this.DtpReturn);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvAllBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlBasketHeader.ResumeLayout(false);
            this.PnlBasketHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAllBooks;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DateTimePicker DtpReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Label LblBasket;
        private System.Windows.Forms.TextBox TxtOrderingBook;
        private System.Windows.Forms.Label LblOrderingBook;
        private System.Windows.Forms.Label LblReturnedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlBasketHeader;
        private System.Windows.Forms.ComboBox CmbClient;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.Button BtnNewClient;
    }
}