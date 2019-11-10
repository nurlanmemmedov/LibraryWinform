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
        public Adding(Client SelectedCli)//brings the selected client from the search form
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

        private void Reset()//reset the all changes on textboxes and datatimepicker

        {
            TxtOrderingBook.Text = string.Empty;
            DtpReturn.Value = DateTime.Now;
        }

        private void FillAllBooks()//fills the books to datagridview which are active and their counts are greater than 0
        {
            foreach (Book item in _bookService.All())
            {
                if (item.Count > 0 && item.isActive == true)
                {
                    DgvAllBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author);
                }
            }
        }

        private void FillClientsCombo()//fills the clients to Combobox which are active
        {
            foreach (Client item in _clientService.Clients())
            {
                if (item.isActive == true)
                {
                    CmbClient.Items.Add(new ComboItem(item.Id, item.Fullname));
                }
            }
        }

        private void FillBasket() //fill the orders of Selected client to datagridview
        {
            if (_SelectedCli != null)//the client must be selected
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

        private void DgvAllBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select the book to ordering
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

        public void AddOrder()//add new order to selected client
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
            DgvOrders.Rows.Add(_SelectedCli.Fullname, _SelectedBook.Title, DateTime.Now, DtpReturn.Value, _SelectedBook.Price, false);
            Reset();
        }

        private void BtnAdd_Click(object sender, EventArgs e)//call the addorder function
        {
            //actions done if datetimepicker value selected correct
            if (DtpReturn.Value < DateTime.Now)
            {
                MessageBox.Show("Return date cannot be less than order date, please select correctly");
                return;
            }
            foreach (Order item in _orderService.Orders())
            {
                //check if the selected client already have such an order
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

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)//selects client to add order
        {
            _SelectedCli = _clientService.Find((CmbClient.SelectedItem as ComboItem).Id);
            Reset();
            DgvOrders.Rows.Clear();
            FillBasket();
        }

        private void BtnNewClient_Click(object sender, EventArgs e)//open the managerCRUD form if clinet is not member of library
        {
            ClientCrud clientCrud = new ClientCrud();
            clientCrud.ShowDialog();
        }

        private void PbBack_Click(object sender, EventArgs e)//return the previous form
        {
            this.Hide();
        }
    }
}
