using System;
using System.Security.Cryptography;
using System.Text;
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

        public string Hash(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            string result = BitConverter.ToString(bytes).Replace("-", string.Empty);
            return result;
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)//Login the program
        {
            //checks if the username or password are null
            if (TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Username and password should not be empty");
                return;
            }
            int Id = _managerService.Login(TxtUsername.Text, Hash(TxtPassword.Text));
            //checks if the password is false
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
