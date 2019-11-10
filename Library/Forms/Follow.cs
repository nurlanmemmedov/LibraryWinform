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
        private void Reset()//reset the changes
        {
            DgvFollowings.Rows.Clear();
            BtnToday.BackColor = Color.White;
            BtnTomorrow.BackColor = Color.White;
            BtnLate.BackColor = Color.White;
            BtnToday.ForeColor = Color.Black;
            BtnTomorrow.ForeColor = Color.Black;
            BtnLate.ForeColor = Color.Black;
        }

        private void Init()//default selected tap when form initialize
        {
            Reset();
            BtnToday.BackColor = Color.Maroon;
            BtnToday.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                //check if the returning day is today
                if ((item.MustReturnAt - DateTime.Now).Days == 0 && item.Returned == false)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }

        private void BtnToday_Click(object sender, EventArgs e)//brings the today's returnings
        {
            Init();
        }

        private void BtnTomorrow_Click(object sender, EventArgs e)//brings the tomorrow's returnings
        {
            Reset();
            BtnTomorrow.BackColor = Color.Maroon;
            BtnTomorrow.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                //check if the returning day is tomorrow
                if ((item.MustReturnAt - DateTime.Now).Days == 1 && item.Returned == false)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }

        private void BtnLate_Click(object sender, EventArgs e)//brings the returnings which were lated
        {
            Reset();
            BtnLate.BackColor = Color.Maroon;
            BtnLate.ForeColor = Color.White;
            foreach (Order item in _orderService.Orders())
            {
                //checks if the returning was lated
                if ((item.MustReturnAt - DateTime.Now).Days < 0 && item.Returned == false)
                {
                    DgvFollowings.Rows.Add(item.Client.Fullname, item.Client.Phone, item.Book.Title);
                }
            }
        }

        private void PbBack_Click_1(object sender, EventArgs e)//hide the current form and return the previous
        {
            this.Hide();
        }
    }
}
