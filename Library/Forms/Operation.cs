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


        public Operation(Manager manager)//brings manager who logged in
        {
            InitializeComponent();
            this.Manager = manager;
            _orderService = new OrderService();
            _managerService = new ManagerService();
            _clientService = new ClientService();
            _bookService = new BookService();
            //block some features for managers who are not Admin
            if (!Manager.IsAdmin)
            {
                BtnBooksCrud.Visible = false;
                BtnPayment.Visible = false;
                BtnManagerCrud.Visible = false;
                PcbManager.Visible = false;
                PcbBooks.Visible = false;
                BtnManagers.Visible = false;
                LblManagerCount.Visible = false;
                LblManagers.Visible = false;
                BtnBooks.Visible = false;
                LblBooks.Visible = false;
                LblBookCount.Visible = false;
                BtnReport.Visible = false;
                LblReports.Visible = false;
                LblReportCount.Visible = false;
                BtnPayment.Visible = false;
                PcbReport.Visible = false;
                PnlBooks.Visible = false;
                PnlManager.Visible = false;
                PnlReports.Visible = false;
                BtnTime.Location = new Point(691, 115);
                PnlDate.Location = new Point(691, 115);
                LblCurrentDate.Location = new Point(847, 125);
                LblDate.Location = new Point(879, 184);
                BtnLogout.Location = new Point(-2, 307);
                PcbManager.Location = new Point(5, 311);
                BtnClose.Location = new Point(-2, 369);
                PcbClose.Location = new Point(6, 374);
                PcbLogout.Location = new Point(5, 311);
                return;
            }
            FillCounts();
        }
        private void FillCounts()//brings the statistic counts
        {
            int Count = 0;
            int ManagerCount = 0;
            int ClientCount = 0;
            int ReportCount = 0;
            int BookCount = 0;
            foreach (Order item in _orderService.Orders())
            {
                if (item.Returned == false)
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

        private void BtnSearch_Click(object sender, EventArgs e)//open the 'Search' form
        {
            Search SearchForm = new Search();
            SearchForm.ShowDialog();
        }

        private void BtnBooksCrud_Click(object sender, EventArgs e)//open the 'BooksCrud' form
        {
            BookCrud bookCrud = new BookCrud();
            bookCrud.ShowDialog();
        }

        private void BtnClientsCrud_Click(object sender, EventArgs e)//open the 'ClientsCrud' form
        {
            ClientCrud clientCrud = new ClientCrud();
            clientCrud.ShowDialog();
        }

        private void BtnFollow_Click(object sender, EventArgs e)//open the 'Follow' form
        {
            Follow follow = new Follow();
            follow.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)//open the 'Report' form
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)//open the 'Adding' form
        {
            Adding adding = new Adding(null);
            adding.ShowDialog();
        }

        private void BtnReturn_Click(object sender, EventArgs e)//open the 'Returning' form
        {
            Returning returning = new Returning(null);
            returning.ShowDialog();
        }

        private void BtnManagerCrud_Click_1(object sender, EventArgs e)//open the 'ManagerCrud' form
        {
            ManagerCrud managerCrud = new ManagerCrud();
            managerCrud.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)//return the login form
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)//exit from the application
        {
            Application.Exit();
        }
    }
}
