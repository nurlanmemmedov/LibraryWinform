using System;
using System.Windows.Forms;
using Library.Models;
using Library.Services;


namespace Library.Forms
{
    public partial class Login : Form
    {
        private readonly ManagerService _managerService;
        public Login()
        {
            InitializeComponent();
            _managerService = new ManagerService();
        }
        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Username and password should not be empty");
                return;
            }
            int Id = _managerService.Login(TxtUsername.Text, TxtPassword.Text);
            if (Id == -1)
            {
                MessageBox.Show("Username or Password are False");
                return;
            }
            this.Hide();
            Manager manager = _managerService.Find(Id);
            Operation operation = new Operation(manager);
            operation.Show();
            operation.FormClosed += (s, args) => this.Close();
        }

    }
}
