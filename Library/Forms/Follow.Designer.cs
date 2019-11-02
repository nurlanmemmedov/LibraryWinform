namespace Library.Forms
{
    partial class Follow
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
            this.BtnLate = new System.Windows.Forms.Button();
            this.BtnTomorrow = new System.Windows.Forms.Button();
            this.BtnToday = new System.Windows.Forms.Button();
            this.DgvFollowings = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFollowings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.BtnLate);
            this.panel1.Controls.Add(this.BtnTomorrow);
            this.panel1.Controls.Add(this.BtnToday);
            this.panel1.Location = new System.Drawing.Point(41, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 54);
            this.panel1.TabIndex = 0;
            // 
            // BtnLate
            // 
            this.BtnLate.BackColor = System.Drawing.Color.White;
            this.BtnLate.FlatAppearance.BorderSize = 0;
            this.BtnLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLate.Location = new System.Drawing.Point(472, -1);
            this.BtnLate.Name = "BtnLate";
            this.BtnLate.Size = new System.Drawing.Size(227, 46);
            this.BtnLate.TabIndex = 2;
            this.BtnLate.Text = "Were Lated";
            this.BtnLate.UseVisualStyleBackColor = false;
            this.BtnLate.Click += new System.EventHandler(this.BtnLate_Click);
            // 
            // BtnTomorrow
            // 
            this.BtnTomorrow.BackColor = System.Drawing.Color.White;
            this.BtnTomorrow.FlatAppearance.BorderSize = 0;
            this.BtnTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTomorrow.Location = new System.Drawing.Point(234, -1);
            this.BtnTomorrow.Name = "BtnTomorrow";
            this.BtnTomorrow.Size = new System.Drawing.Size(240, 46);
            this.BtnTomorrow.TabIndex = 1;
            this.BtnTomorrow.Text = "Will Be Return Tomorrow";
            this.BtnTomorrow.UseVisualStyleBackColor = false;
            this.BtnTomorrow.Click += new System.EventHandler(this.BtnTomorrow_Click);
            // 
            // BtnToday
            // 
            this.BtnToday.BackColor = System.Drawing.Color.White;
            this.BtnToday.FlatAppearance.BorderSize = 0;
            this.BtnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToday.Location = new System.Drawing.Point(-1, -1);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(239, 46);
            this.BtnToday.TabIndex = 0;
            this.BtnToday.Text = "Will Be Return Today";
            this.BtnToday.UseVisualStyleBackColor = false;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // DgvFollowings
            // 
            this.DgvFollowings.AllowUserToAddRows = false;
            this.DgvFollowings.AllowUserToDeleteRows = false;
            this.DgvFollowings.AllowUserToResizeRows = false;
            this.DgvFollowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFollowings.BackgroundColor = System.Drawing.Color.White;
            this.DgvFollowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFollowings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvFollowings.GridColor = System.Drawing.Color.Black;
            this.DgvFollowings.Location = new System.Drawing.Point(41, 119);
            this.DgvFollowings.Name = "DgvFollowings";
            this.DgvFollowings.ReadOnly = true;
            this.DgvFollowings.Size = new System.Drawing.Size(698, 301);
            this.DgvFollowings.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Client Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Client Phone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Books Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Follow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvFollowings);
            this.Controls.Add(this.panel1);
            this.Name = "Follow";
            this.Text = "Follow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFollowings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLate;
        private System.Windows.Forms.Button BtnTomorrow;
        private System.Windows.Forms.Button BtnToday;
        private System.Windows.Forms.DataGridView DgvFollowings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}