namespace Library.Forms
{
    partial class Returning
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
            this.BtnReturn = new System.Windows.Forms.Button();
            this.TxtReturningBook = new System.Windows.Forms.TextBox();
            this.LblReturningBook = new System.Windows.Forms.Label();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(534, 364);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(111, 40);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtReturningBook
            // 
            this.TxtReturningBook.Location = new System.Drawing.Point(57, 384);
            this.TxtReturningBook.Name = "TxtReturningBook";
            this.TxtReturningBook.ReadOnly = true;
            this.TxtReturningBook.Size = new System.Drawing.Size(205, 20);
            this.TxtReturningBook.TabIndex = 2;
            // 
            // LblReturningBook
            // 
            this.LblReturningBook.AutoSize = true;
            this.LblReturningBook.Location = new System.Drawing.Point(57, 364);
            this.LblReturningBook.Name = "LblReturningBook";
            this.LblReturningBook.Size = new System.Drawing.Size(95, 13);
            this.LblReturningBook.TabIndex = 3;
            this.LblReturningBook.Text = "Book To Returned";
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
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvOrders.Location = new System.Drawing.Point(57, 61);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            this.DgvOrders.Size = new System.Drawing.Size(588, 274);
            this.DgvOrders.TabIndex = 0;
            this.DgvOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrders_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Order Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Return Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cost";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Returned";
            this.Column7.Name = "Column7";
            // 
            // TxtPayment
            // 
            this.TxtPayment.Location = new System.Drawing.Point(310, 383);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.ReadOnly = true;
            this.TxtPayment.Size = new System.Drawing.Size(173, 20);
            this.TxtPayment.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblAdd);
            this.PnlHeader.Location = new System.Drawing.Point(57, 30);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(588, 31);
            this.PnlHeader.TabIndex = 12;
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
            // Returning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(704, 440);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.LblReturningBook);
            this.Controls.Add(this.TxtReturningBook);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DgvOrders);
            this.Name = "Returning";
            this.Text = "Returning";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.TextBox TxtReturningBook;
        private System.Windows.Forms.Label LblReturningBook;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblAdd;
    }
}