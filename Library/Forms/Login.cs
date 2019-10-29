using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;
using Library.Models;
using Library.Forms;


namespace Library.Forms
{
    public partial class Login : Form
    {
        private readonly AdminService _adminService;
        public Login()
        {
            InitializeComponent();
            _adminService = new AdminService();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text ==string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Username and password should not be empty");
                return;
            }
           if( _adminService.Login(TxtUsername.Text, TxtPassword.Text)==-1)
            {
                MessageBox.Show("this Admin was not found");
                return;
            }

            this.Hide();
            Operation operation = new Operation();
            operation.Show();
            operation.FormClosed += (s, args) => this.Close();
            operation.FormClosed += (s, args) => this.Close();

        }
    }
}
