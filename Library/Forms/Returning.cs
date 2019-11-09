using System;
using System.Windows.Forms;
using Library.Services;
using Library.Models;
using Library.Helpers;

namespace Library.Forms
{
    public partial class Returning : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private readonly ClientService _clientService;
        private int _selectedIndex;
        private Client _SelectedCli;
        private Order _SelectedOrder;
        public Returning(Client SelectedCli)
        {
            InitializeComponent();
            _bookService = new BookService();
            _clientService = new ClientService();
            _orderService = new OrderService();
            this._SelectedCli = SelectedCli;
            _SelectedOrder = new Order();
            FillClientBooks();
            FillClientsCombo();
        }
        private void Reset()
        {
            TxtPayment.Text = string.Empty;
            TxtReturningBook.Text = string.Empty;
        }

        private void FillClientBooks()
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

        private void FillClientsCombo()
        {
            foreach (Client item in _clientService.Clients())
            {
                CmbClient.Items.Add(new ComboItem(item.Id, item.Fullname));
            }
        }

        private void DgvOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrders.Rows[e.RowIndex].Cells[0].Value);
            _selectedIndex = e.RowIndex;
            _SelectedOrder = _orderService.Find(id);
            if (_SelectedOrder.Returned == false)
            {
                TxtReturningBook.Text = _SelectedOrder.Book.Title;
                if ((DateTime.Now - _SelectedOrder.OrderDate).Days < 1)
                {
                    BtnReturn.Hide();
                    BtnCancel.Show();
                }
                else if ((DateTime.Now - _SelectedOrder.MustReturnAt).Days > 0)
                {
                    decimal Payment = (_SelectedOrder.Cost + ((DateTime.Now - _SelectedOrder.MustReturnAt).Days) * (_SelectedOrder.Cost * 5 / 1000));
                    TxtPayment.Text = Payment.ToString();
                    BtnReturn.Show();
                    BtnCancel.Hide();
                }
                else
                {
                    TxtPayment.Text = _SelectedOrder.Cost.ToString();
                    BtnReturn.Show();
                    BtnCancel.Hide();
                }
                return;
            }
                MessageBox.Show("This Book Is already Returned");
                TxtPayment.Text = string.Empty;
                TxtReturningBook.Text = string.Empty;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            _SelectedOrder.Returned = true;
            _SelectedOrder.Book.Count++;
            _SelectedOrder.ReturningDate = DateTime.Now;
            _orderService.Update(_SelectedOrder);
            DgvOrders.Rows[_selectedIndex].Cells[5].Value = true;
            Reset();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _orderService.Delete(_SelectedOrder);
            DgvOrders.Rows.RemoveAt(_selectedIndex);
        }

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedCli = _clientService.Find((CmbClient.SelectedItem as ComboItem).Id);
            Reset();
            DgvOrders.Rows.Clear();
            FillClientBooks();
        }

    }
}

