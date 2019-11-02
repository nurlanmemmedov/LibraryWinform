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
            this.PnlOperation = new System.Windows.Forms.Panel();
            this.BtnFollow = new System.Windows.Forms.Button();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
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
            this.BtnClientsCrud.BackColor = System.Drawing.Color.Maroon;
            this.BtnClientsCrud.FlatAppearance.BorderSize = 0;
            this.BtnClientsCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientsCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnClientsCrud.ForeColor = System.Drawing.Color.White;
            this.BtnClientsCrud.Location = new System.Drawing.Point(29, 167);
            this.BtnClientsCrud.Name = "BtnClientsCrud";
            this.BtnClientsCrud.Size = new System.Drawing.Size(177, 50);
            this.BtnClientsCrud.TabIndex = 2;
            this.BtnClientsCrud.Text = "Clients CRUD";
            this.BtnClientsCrud.UseVisualStyleBackColor = false;
            this.BtnClientsCrud.Click += new System.EventHandler(this.BtnClientsCrud_Click);
            // 
            // BtnBooksCrud
            // 
            this.BtnBooksCrud.BackColor = System.Drawing.Color.Maroon;
            this.BtnBooksCrud.FlatAppearance.BorderSize = 0;
            this.BtnBooksCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooksCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnBooksCrud.ForeColor = System.Drawing.Color.White;
            this.BtnBooksCrud.Location = new System.Drawing.Point(29, 95);
            this.BtnBooksCrud.Name = "BtnBooksCrud";
            this.BtnBooksCrud.Size = new System.Drawing.Size(177, 50);
            this.BtnBooksCrud.TabIndex = 1;
            this.BtnBooksCrud.Text = "Books CRUD";
            this.BtnBooksCrud.UseVisualStyleBackColor = false;
            this.BtnBooksCrud.Click += new System.EventHandler(this.BtnBooksCrud_Click);
            // 
            // BtnManagerCrud
            // 
            this.BtnManagerCrud.BackColor = System.Drawing.Color.Maroon;
            this.BtnManagerCrud.FlatAppearance.BorderSize = 0;
            this.BtnManagerCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagerCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnManagerCrud.ForeColor = System.Drawing.Color.White;
            this.BtnManagerCrud.Location = new System.Drawing.Point(29, 19);
            this.BtnManagerCrud.Name = "BtnManagerCrud";
            this.BtnManagerCrud.Size = new System.Drawing.Size(177, 50);
            this.BtnManagerCrud.TabIndex = 0;
            this.BtnManagerCrud.Text = "Managers CRUD";
            this.BtnManagerCrud.UseVisualStyleBackColor = false;
            this.BtnManagerCrud.Click += new System.EventHandler(this.BtnManagerCrud_Click);
            // 
            // PnlOperation
            // 
            this.PnlOperation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlOperation.Controls.Add(this.BtnFollow);
            this.PnlOperation.Controls.Add(this.BtnPayment);
            this.PnlOperation.Controls.Add(this.BtnSearch);
            this.PnlOperation.Location = new System.Drawing.Point(45, 37);
            this.PnlOperation.Name = "PnlOperation";
            this.PnlOperation.Size = new System.Drawing.Size(225, 247);
            this.PnlOperation.TabIndex = 1;
            // 
            // BtnFollow
            // 
            this.BtnFollow.BackColor = System.Drawing.Color.Chocolate;
            this.BtnFollow.FlatAppearance.BorderSize = 0;
            this.BtnFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnFollow.ForeColor = System.Drawing.Color.White;
            this.BtnFollow.Location = new System.Drawing.Point(15, 95);
            this.BtnFollow.Name = "BtnFollow";
            this.BtnFollow.Size = new System.Drawing.Size(190, 50);
            this.BtnFollow.TabIndex = 2;
            this.BtnFollow.Text = "Follow The Orders";
            this.BtnFollow.UseVisualStyleBackColor = false;
            this.BtnFollow.Click += new System.EventHandler(this.BtnFollow_Click);
            // 
            // BtnPayment
            // 
            this.BtnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPayment.FlatAppearance.BorderSize = 0;
            this.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPayment.ForeColor = System.Drawing.Color.White;
            this.BtnPayment.Location = new System.Drawing.Point(15, 167);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(190, 50);
            this.BtnPayment.TabIndex = 1;
            this.BtnPayment.Text = "Report";
            this.BtnPayment.UseVisualStyleBackColor = false;
            this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(15, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(190, 50);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.PnlOperation);
            this.Controls.Add(this.panel1);
            this.Name = "Operation";
            this.Text = "Operation";
            this.panel1.ResumeLayout(false);
            this.PnlOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClientsCrud;
        private System.Windows.Forms.Button BtnBooksCrud;
        private System.Windows.Forms.Button BtnManagerCrud;
        private System.Windows.Forms.Panel PnlOperation;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Button BtnFollow;
    }
}