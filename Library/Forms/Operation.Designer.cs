namespace Library.Forms
{
    partial class Operation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClientsCrud = new System.Windows.Forms.Button();
            this.BtnBooksCrud = new System.Windows.Forms.Button();
            this.BtnManagerCrud = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClientsCrud);
            this.panel1.Controls.Add(this.BtnBooksCrud);
            this.panel1.Controls.Add(this.BtnManagerCrud);
            this.panel1.Location = new System.Drawing.Point(307, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 247);
            this.panel1.TabIndex = 0;
            // 
            // BtnClientsCrud
            // 
            this.BtnClientsCrud.Location = new System.Drawing.Point(29, 174);
            this.BtnClientsCrud.Name = "BtnClientsCrud";
            this.BtnClientsCrud.Size = new System.Drawing.Size(177, 36);
            this.BtnClientsCrud.TabIndex = 2;
            this.BtnClientsCrud.Text = "Clients CRUD";
            this.BtnClientsCrud.UseVisualStyleBackColor = true;
            this.BtnClientsCrud.Click += new System.EventHandler(this.BtnClientsCrud_Click);
            // 
            // BtnBooksCrud
            // 
            this.BtnBooksCrud.Location = new System.Drawing.Point(29, 102);
            this.BtnBooksCrud.Name = "BtnBooksCrud";
            this.BtnBooksCrud.Size = new System.Drawing.Size(177, 36);
            this.BtnBooksCrud.TabIndex = 1;
            this.BtnBooksCrud.Text = "Books CRUD";
            this.BtnBooksCrud.UseVisualStyleBackColor = true;
            this.BtnBooksCrud.Click += new System.EventHandler(this.BtnBooksCrud_Click);
            // 
            // BtnManagerCrud
            // 
            this.BtnManagerCrud.Location = new System.Drawing.Point(29, 33);
            this.BtnManagerCrud.Name = "BtnManagerCrud";
            this.BtnManagerCrud.Size = new System.Drawing.Size(177, 36);
            this.BtnManagerCrud.TabIndex = 0;
            this.BtnManagerCrud.Text = "Managers CRUD";
            this.BtnManagerCrud.UseVisualStyleBackColor = true;
            this.BtnManagerCrud.Click += new System.EventHandler(this.BtnManagerCrud_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnPayment);
            this.panel2.Controls.Add(this.BtnSearch);
            this.panel2.Location = new System.Drawing.Point(45, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 174);
            this.panel2.TabIndex = 1;
            // 
            // BtnPayment
            // 
            this.BtnPayment.Location = new System.Drawing.Point(15, 95);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(190, 50);
            this.BtnPayment.TabIndex = 1;
            this.BtnPayment.Text = "Payment";
            this.BtnPayment.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(15, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(190, 50);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Operation";
            this.Text = "Operation";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClientsCrud;
        private System.Windows.Forms.Button BtnBooksCrud;
        private System.Windows.Forms.Button BtnManagerCrud;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnPayment;
    }
}