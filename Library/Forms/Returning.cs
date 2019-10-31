using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms;
using Library.Services;
using Library.Models;

namespace Library.Forms
{
    public partial class Returning : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        //private readonly ReportService _reportService;
        private Client _SelectedCli;
        private Order _SelectedOrder;
        public Returning(Client SelectedCli)
        {
            InitializeComponent();
            _bookService = new BookService();
            _orderService = new OrderService();
            //_reportService = new ReportService();
            this._SelectedCli = SelectedCli;
            _SelectedOrder = new Order();
            FillClientBooks();
        }
        private void Reset()
        {
            TxtPayment.Text = string.Empty;
            TxtReturningBook.Text = string.Empty;
        }
        private void FillClientBooks()
        {
            foreach (Book item in _bookService.All())
            {
                foreach (Order orderItem in _orderService.Orders())
                {
                    if (orderItem.ClientId == _SelectedCli.Id && item.Id == orderItem.BookId)
                    {
                        DgvOrders.Rows.Add(orderItem.Id, orderItem.Book.Title, orderItem.OrderDate, orderItem.ReturnDate, orderItem.Cost, orderItem.Returned);
                    }
                }
            }
        }

        private void DgvOrders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrders.Rows[e.RowIndex].Cells[0].Value);
            _SelectedOrder = _orderService.Find(id);

            TxtReturningBook.Text = _SelectedOrder.Book.Title;
            if ((DateTime.Now - _SelectedOrder.ReturnDate).Days > 0)
            {
                decimal Payment = (_SelectedOrder.Cost + ((DateTime.Now - _SelectedOrder.ReturnDate).Days) * (_SelectedOrder.Cost * 5 / 1000));
                TxtPayment.Text = Payment.ToString();
            }
            else
            {
                TxtPayment.Text = _SelectedOrder.Cost.ToString();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            _SelectedOrder.Returned = true;
            _SelectedOrder.Cost = Convert.ToDecimal(TxtPayment.Text);
            _orderService.Update(_SelectedOrder);
            DgvOrders.Rows.Clear();
            FillClientBooks();
            Reset();
        }
    }
}
