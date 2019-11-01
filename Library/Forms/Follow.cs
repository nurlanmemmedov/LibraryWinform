using System;
using System.Drawing;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library.Forms
{
    public partial class Follow : Form
    {
        private readonly OrderService _orderService;
        public Follow()
        {
            _orderService = new OrderService();
            InitializeComponent();
            Init();

        }
        private void Reset()
        {
            DgvFollowings.Rows.Clear();
            BtnToday.BackColor = Color.White;
            BtnTomorrow.BackColor = Color.White;
            BtnLate.BackColor = Color.White;
            BtnToday.ForeColor = Color.Black;
            BtnTomorrow.ForeColor = Color.Black;
            BtnLate.ForeColor = Color.Black;
        }
        private void Init()
        {
            Reset();
            BtnToday.BackColor = Color.Maroon;
            BtnToday.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                if ((item.ReturnDate - DateTime.Now).Days == 0)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }

        private void BtnToday_MouseClick(object sender, MouseEventArgs e)
        {
            Init();
        }

        private void BtnTomorrow_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
            BtnTomorrow.BackColor = Color.Maroon;
            BtnTomorrow.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                if ((item.ReturnDate - DateTime.Now).Days == 1)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }

        private void BtnLate_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
            BtnLate.BackColor = Color.Maroon;
            BtnLate.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                if ((item.ReturnDate - DateTime.Now).Days < 0)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }
    }
}
