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
using ClosedXML.Excel;

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
        private void ExportToExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Reports");
                worksheet.Cell("A1").Value = "Client Name";
                worksheet.Cell("B1").Value = "Book Name";
                worksheet.Cell("C1").Value = "Pay";

                int rowstart = 2;
                foreach (var item in _reportService.Reports())
                {
                    worksheet.Cell(rowstart, 1).Value = item.Client.Fullname;
                    worksheet.Cell(rowstart, 2).Value = item.Book.Title;
                    worksheet.Cell(rowstart, 3).Value = item.Pay;
                    rowstart++;
                }
                workbook.SaveAs(@"C:\Users\Code\Desktop\Report.xlsx");
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
