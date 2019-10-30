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
    public partial class Adding : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private Client _SelectedCli;
        private Book _SelectedBook;
        public Adding(Client SelectedCli)
        {
            _bookService = new BookService();
            _orderService = new OrderService();
            this._SelectedCli = SelectedCli;
            _SelectedBook = new Book();
            InitializeComponent();
            FillAllBooksExceptClients();
            FillBasket();
        }
        private void Reset()
        {
            TxtOrderingBook.Text = string.Empty;
            DtpReturn.Value = DateTime.Now;
        }
        private void FillAllBooksExceptClients()
        {
            foreach (Book item in _bookService.All())
            { 
                //foreach (Order orderItem in _orderService.Orders())
                //{
                    //if (item.Id != orderItem.BookId && orderItem.ClientId == _SelectedCli.Id)
                    //{
                        DgvAllBooksExceptClients.Rows.Add(item.Id, item.Title, item.Price, item.Author);
                //    }
                //}

            }
        }
        private void FillBasket()
        {
            foreach (Book item in _bookService.All())
            {
                foreach (Order orderItem in _orderService.Orders())
                {
                    if (orderItem.ClientId == _SelectedCli.Id && item.Id == orderItem.BookId)
                    {
                        DgvOrders.Rows.Add(orderItem.Id, orderItem.Book.Title, orderItem.OrderDate,orderItem.ReturnDate,orderItem.Cost,orderItem.Returned);
                    }
                }
            }
        }

        private void DgvAllBooksExceptClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = Convert.ToInt32(DgvAllBooksExceptClients.Rows[e.RowIndex].Cells[0].Value);
            _SelectedBook = _bookService.Find(Id);
            TxtOrderingBook.Text = _SelectedBook.Title;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                ClientId = _SelectedCli.Id,
                BookId = _SelectedBook.Id,
                OrderDate = DateTime.Now,
                ReturnDate = DtpReturn.Value,
                Cost = _SelectedBook.Price,
                Returned = false
            };
            _orderService.Add(order);
            DgvOrders.Rows.Clear();
            FillBasket();
            Reset();
        }

    }
}
