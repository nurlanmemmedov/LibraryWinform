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
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(549, 361);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(111, 40);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtReturningBook
            // 
            this.TxtReturningBook.Location = new System.Drawing.Point(72, 381);
            this.TxtReturningBook.Name = "TxtReturningBook";
            this.TxtReturningBook.Size = new System.Drawing.Size(205, 20);
            this.TxtReturningBook.TabIndex = 2;
            // 
            // LblReturningBook
            // 
            this.LblReturningBook.AutoSize = true;
            this.LblReturningBook.Location = new System.Drawing.Point(72, 361);
            this.LblReturningBook.Name = "LblReturningBook";
            this.LblReturningBook.Size = new System.Drawing.Size(95, 13);
            this.LblReturningBook.TabIndex = 3;
            this.LblReturningBook.Text = "Book To Returned";
            // 
            // DgvOrders
            // 
            this.DgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvOrders.Location = new System.Drawing.Point(72, 44);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.Size = new System.Drawing.Size(588, 279);
            this.DgvOrders.TabIndex = 0;
            this.DgvOrders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrders_RowHeaderMouseDoubleClick);
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
            // Returning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 440);
            this.Controls.Add(this.LblReturningBook);
            this.Controls.Add(this.TxtReturningBook);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DgvOrders);
            this.Name = "Returning";
            this.Text = "Returning";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
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
    }
}