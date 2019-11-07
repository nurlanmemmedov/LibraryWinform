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
    public partial class Search : Form
    {
        private readonly ClientService _clientService;
        public Client selectedClient;
        public Search()
        {
            _clientService = new ClientService();
            selectedClient = new Client();
            InitializeComponent();
            FillClients();
        }
        private void Reset()
        {
            FillClients();
            Txtname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            BtnCancelSearch.Hide();
        }
        private void FillClients()
        {
            foreach (Client item in _clientService.Clients())
            {
                DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
            }
        }
        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            DgvClientsSearch.Rows.Clear();
            Reset();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Adding adding = new Adding(selectedClient);
            adding.ShowDialog();
            adding.FormClosed += (s, args) => this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Returning returning = new Returning(selectedClient);
            returning.ShowDialog();
            returning.FormClosed += (s, args) => this.Close();
        }

        private void DgvClientsSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Show();
            BtnReturn.Show();
            int index = Convert.ToInt32(DgvClientsSearch.Rows[e.RowIndex].Cells[0].Value);
            selectedClient = _clientService.Find(index);
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            if ((TxtPhone.Text == string.Empty && Txtname.Text == string.Empty))
            {
                DgvClientsSearch.Rows.Clear();
                Reset();
                return;
            }
            DgvClientsSearch.Rows.Clear();
            foreach (Client item in _clientService.Clients())
            {
                if ((item.Fullname.ToLower().Contains(Txtname.Text.ToLower())
                    || Txtname.Text == string.Empty) && (item.Phone.ToLower().Contains(TxtPhone.Text.ToLower())
                    || TxtPhone.Text == string.Empty))
                {
                    DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
            BtnCancelSearch.Show();
        }
    }
}
