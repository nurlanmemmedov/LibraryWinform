using System;
using System.Windows.Forms;
using Library.Models;
using Library.Services;
using ClosedXML.Excel;
using System.IO;

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

        decimal? Income = 0;

        private void Reset()//reset the changes
        {
            DgvReports.Rows.Clear();
            Lblİncome.Text = string.Empty;
            Income = 0;
        }

        private void FillReports()//brings the all returned orders
        {
            foreach (Order item in _orderService.Orders())
            {
                if (item.ReturningDate != null)
                {
                    //if the returning date was lated, customer should be fined
                    if (item.ReturningDate > item.MustReturnAt) {
                        Decimal? penal = (item.ReturningDate - item.MustReturnAt)?.Days * (item.Cost * 5 / 1000);

                        DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Cost + penal);
                        Income += (item.Cost + penal);
                    }
                    else
                    {
                        DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Cost);
                        Income += item.Cost;

                    }
                }
            }
        }

        private void CmbRange_SelectedIndexChanged(object sender, EventArgs e)//brings the  Reports based on selected month
        {

            Reset();
            //if "All" is selected, brings the reports based on the year
            if (CmbRange.SelectedIndex == 12)
            {
                FillReports();
                Lblİncome.Text = "Total Income of Year";
                Txtİncome.Text = Income.ToString();
                return;
            }
            foreach (Order item in _orderService.Orders())
            {
                if (item.Returned == true && item.OrderDate.Month == CmbRange.SelectedIndex + 1 && item.ReturningDate > item.MustReturnAt)
                {
                        Decimal? penal = (item.ReturningDate - item.MustReturnAt)?.Days * (item.Cost * 5 / 1000);
                        DgvReports.Rows.Add(item.Id, item.Client.Fullname, item.Book.Title, item.Cost + penal);
                        Income += item.Cost + penal;
                }
            }
            //shows the total income
            Lblİncome.Text = "Total Income of" + " " + CmbRange.Text;
            Txtİncome.Text = Income.ToString();
        }

        private void BtnExport_Click(object sender, EventArgs e)//export the reports to excel file at selected location
        {
            string str = string.Empty;
            DialogResult result = FbdChooseArea.ShowDialog();
            if (DialogResult.OK == result)
            {
                str = FbdChooseArea.SelectedPath;
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Reports");
                    worksheet.Cell("A1").Value = "Client Name";
                    worksheet.Cell("B1").Value = "Book Name";
                    worksheet.Cell("C1").Value = "Pay";

                    worksheet.Column("A").Width = 30;
                    worksheet.Column("B").Width = 30;
                    worksheet.Column("C").Width = 15;

                    int rowstart = 2;
                    foreach (DataGridViewRow row in DgvReports.Rows)
                    {
                        worksheet.Cell(rowstart, 1).Value = row.Cells[1].Value;
                        worksheet.Cell(rowstart, 2).Value = row.Cells[2].Value;
                        worksheet.Cell(rowstart, 3).Value = row.Cells[3].Value;
                        rowstart++;
                    }
                    try
                    {
                        workbook.SaveAs(Path.Combine(str, $"{CmbRange.Text}-Report.xlsx"));
                    }
                    catch
                    {
                        MessageBox.Show("Close the other excel files");
                        return;
                    }
                    MessageBox.Show("the excel file created");
                }
            }
        }

        private void PbBack_Click_1(object sender, EventArgs e)//hide the current form and return to previous
        {
            this.Hide();
        }
    }
}
