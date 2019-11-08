using System;
using System.Drawing;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library.Forms
{
    public partial class Operation : Form
    {
        private Manager Manager;
        private readonly ManagerService _managerService;
        private readonly OrderService _orderService;
        private readonly ClientService _clientService;
        private readonly BookService _bookService;


        public Operation(Manager manager)
        {
            InitializeComponent();
            this.Manager = manager;
            _orderService = new OrderService();
            _managerService = new ManagerService();
            _clientService = new ClientService();
            _bookService = new BookService();
            if (!Manager.IsAdmin)
            {
                BtnBooksCrud.Visible = false;
                BtnPayment.Visible = false;
                BtnManagerCrud.Visible = false;
                return;
            }
            FillCounts();
        }
        private void FillCounts()
        {
            int Count = 0;
            int ManagerCount = 0;
            int ClientCount = 0;
            int ReportCount = 0;
            int BookCount = 0;
            foreach (Order item in _orderService.Orders())
            {
                if(item.Returned == false)
                {
                    Count++;
                }
            }
            LblCount.Text = Count.ToString();
            foreach (Manager item in _managerService.Managers())
            {
                ManagerCount++;
            }
            LblManagerCount.Text = ManagerCount.ToString();
            foreach (Client item in _clientService.Clients())
            {
                ClientCount++;
            }
            LblMemberCount.Text = ClientCount.ToString();
            foreach (Order item in _orderService.Orders())
            {
                if (item.Returned == true)
                {
                    ReportCount++;
                }
            }
            LblReportCount.Text = ReportCount.ToString();
            foreach (Book item in _bookService.All())
            {
                    BookCount++;
            }
            LblBookCount.Text = BookCount.ToString();
            LblDate.Text = DateTime.Now.ToString("yyyy,MM.dd");
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search SearchForm = new Search();
            SearchForm.ShowDialog();
        }

        private void BtnBooksCrud_Click(object sender, EventArgs e)
        {
            BookCrud bookCrud = new BookCrud();
            bookCrud.ShowDialog();
        }

        private void BtnClientsCrud_Click(object sender, EventArgs e)
        {
            ClientCrud clientCrud = new ClientCrud();
            clientCrud.ShowDialog();
        }

        private void BtnFollow_Click(object sender, EventArgs e)
        {
            Follow follow = new Follow();
            follow.ShowDialog();
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            Adding adding = new Adding(null);
            adding.ShowDialog();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Returning returning = new Returning(null);
            returning.ShowDialog();
        }

        private void BtnManagerCrud_Click_1(object sender, EventArgs e)
        {
            ManagerCrud managerCrud = new ManagerCrud();
            managerCrud.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
