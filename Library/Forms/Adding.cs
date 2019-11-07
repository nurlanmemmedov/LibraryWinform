using System;
using System.Windows.Forms;
using Library.Services;
using Library.Models;
using Library.Helpers;

namespace Library.Forms
{
    public partial class Adding : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private readonly ClientService _clientService;
        private Client _SelectedCli;
        private Book _SelectedBook;
        public Adding(Client SelectedCli)
        {
            _bookService = new BookService();
            _orderService = new OrderService();
            _clientService = new ClientService();
            this._SelectedCli = SelectedCli;
            _SelectedBook = new Book();
            InitializeComponent();
            FillAllBooks();
            FillBasket();
            FillClientsCombo();
        }

        private void Reset()

        {
            TxtOrderingBook.Text = string.Empty;
            DtpReturn.Value = DateTime.Now;
        }

        private void FillAllBooks()
        {
            foreach (Book item in _bookService.All())
            {
                if (item.Count > 0)
                {
                    DgvAllBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author);
                }
            }
        }

        private void FillClientsCombo()
        {
            foreach (Client item in _clientService.Clients())
            {
                CmbClient.Items.Add(new ComboItem(item.Id, item.Fullname));
            }
        }

        private void FillBasket()
        {
            if (_SelectedCli != null)
            {
                CmbClient.SelectedItem = new ComboItem(_SelectedCli.Id, _SelectedCli.Fullname);
                CmbClient.Text = _SelectedCli.Fullname;
                foreach (Book item in _bookService.All())
                {
                    foreach (Order orderItem in _orderService.Orders())
                    {
                        if (orderItem.ClientId == _SelectedCli.Id && item.Id == orderItem.BookId)
                        {
                            DgvOrders.Rows.Add(orderItem.Id, orderItem.Book.Title, orderItem.OrderDate, orderItem.MustReturnAt, orderItem.Cost, orderItem.Returned);
                        }
                    }
                }
            }
        }

        private void DgvAllBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_SelectedCli == null)
            {
                MessageBox.Show("please select client");
                return;
            }
            int Id = Convert.ToInt32(DgvAllBooks.Rows[e.RowIndex].Cells[0].Value);
            _SelectedBook = _bookService.Find(Id);
            TxtOrderingBook.Text = _SelectedBook.Title;
        }

        public void AddOrder()
        {
            Order order = new Order()
            {
                ClientId = _SelectedCli.Id,
                BookId = _SelectedBook.Id,
                OrderDate = DateTime.Now,
                MustReturnAt = DtpReturn.Value,
                Cost = _SelectedBook.Price,
                Returned = false
            };
            _orderService.Add(order);
            _SelectedBook.Count--;
            _bookService.Update(_SelectedBook);
            DgvOrders.Rows.Clear();
            FillBasket();
            Reset();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DtpReturn.Value < DateTime.Now)
            {
                MessageBox.Show("Return date cannot be less than order date, please select correctly");
                return;
            }
            foreach (Order item in _orderService.Orders())
            {
                if (item.ClientId == _SelectedCli.Id && item.BookId == _SelectedBook.Id && item.Returned == false)
                {
                    DialogResult result = MessageBox.Show("this customer has such an order, do you want to give one more ?", "Exits Order", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        AddOrder();
                    }
                    Reset();
                    return;
                }
            }
            AddOrder();
        }

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedCli = _clientService.Find((CmbClient.SelectedItem as ComboItem).Id);
            Reset();
            DgvOrders.Rows.Clear();
            FillBasket();
        }

        private void BtnNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientCrud clientCrud = new ClientCrud();
            clientCrud.Show();
            clientCrud.FormClosed += (s, args) => this.Close();
        }
    }
}
