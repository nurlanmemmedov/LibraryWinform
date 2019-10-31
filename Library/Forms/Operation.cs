using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library.Forms
{
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search SearchForm = new Search();
            SearchForm.Show();
            SearchForm.FormClosed += (s, args) => this.Close();
        }

        private void BtnManagerCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerCrud managerCrud = new ManagerCrud();
            managerCrud.Show();
            managerCrud.FormClosed += (s, args) => this.Close();
        }

        private void BtnBooksCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCrud bookCrud = new BookCrud();
            bookCrud.Show();
            bookCrud.FormClosed += (s, args) => this.Close();
        }

        private void BtnClientsCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientCrud clientCrud = new ClientCrud();
            clientCrud.Show();
            clientCrud.FormClosed += (s, args) => this.Close();
        }

        private void BtnFollow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Follow follow = new Follow();
            follow.Show();
            follow.FormClosed += (s, args) => this.Close();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports report = new Reports();
            report.Show();
            report.FormClosed += (s, args) => this.Close();
        }
    }
}
