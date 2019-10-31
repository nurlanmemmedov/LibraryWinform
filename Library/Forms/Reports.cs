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
    public partial class Reports : Form
    {
        private readonly ReportService _reportService;
        public Reports()
        {
            InitializeComponent();
            _reportService = new ReportService();
            FillReports();
            CmbRange.SelectedIndex = 12;
        }
        private void FillReports()
        {
            foreach (Report item in _reportService.Reports())
            {
                DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Pay);
            }
        }

        private void CmbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
