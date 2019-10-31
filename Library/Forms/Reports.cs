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
        private readonly OrderService _orderService;
        public Reports()
        {
            InitializeComponent();
            _orderService = new OrderService();
            CmbRange.SelectedIndex = 12;
        }
        private void Reset()
        {
            DgvReports.Rows.Clear();
        }
        private void FillReports()
        {
            foreach (Order item in _orderService.Orders())
            {
                if (item.Returned == true)
                {
                    DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Cost);
                }
            }
        }
        private void CmbRange_SelectedIndexChanged(object sender, EventArgs e)
        {

            Reset();
            if (CmbRange.SelectedIndex == 12)
            {
                FillReports();
                return;
            }
            foreach (Order item in _orderService.Orders())
            {
                if (item.Returned == true && item.OrderDate.Month == CmbRange.SelectedIndex+1)
                {
                    DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Cost);
                }
            }
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
                foreach (DataGridViewRow row in DgvReports.Rows)
                {
                    worksheet.Cell(rowstart, 1).Value = row.Cells[1].Value;
                    worksheet.Cell(rowstart, 2).Value = row.Cells[2].Value;
                    worksheet.Cell(rowstart, 3).Value = row.Cells[3].Value;
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
