using System;
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
        private void Reset()//reset the changes on textboxes
        {
            Txtname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            BtnCancelSearch.Hide();
        }

        private void FillClients()//brings the clients which are active
        {
            foreach (Client item in _clientService.Clients())
            {
                //check if the client is active
                if (item.isActive == true)
                {
                    DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)//cancel searching
        {
            DgvClientsSearch.Rows.Clear();
            FillClients();
            Reset();
        }

        private void BtnAdd_Click(object sender, EventArgs e)//open the 'adding' form to adding order to selected client
        {
            Adding adding = new Adding(selectedClient);
            adding.ShowDialog();
            adding.FormClosed += (s, args) => this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)//open the'returning' form to return order of selected client
        {
            Returning returning = new Returning(selectedClient);
            returning.ShowDialog();
            returning.FormClosed += (s, args) => this.Close();
        }

        private void DgvClientsSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select client to add or return order
        {
            BtnAdd.Show();
            BtnReturn.Show();
            int index = Convert.ToInt32(DgvClientsSearch.Rows[e.RowIndex].Cells[0].Value);
            selectedClient = _clientService.Find(index);
            if(selectedClient.isActive == false)
            {
                BtnAdd.Hide();
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)//shows the result of the searching when the text changes
        {
            //searching for passive clients
            if (ChckPassive.Checked)
            {
                //check if the searching textboxes are empty
                if ((TxtPhone.Text == string.Empty && Txtname.Text == string.Empty))
                {
                    DgvClientsSearch.Rows.Clear();
                    foreach (Client item in _clientService.Clients())
                    {

                        if (item.isActive == false)
                        {
                            DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                        }
                    }
                    Reset();
                    return;
                }
                DgvClientsSearch.Rows.Clear();
                foreach (Client item in _clientService.Clients())
                {
                    if ((item.Fullname.ToLower().Contains(Txtname.Text.ToLower())
                        || Txtname.Text == string.Empty) && (item.Phone.ToLower().Contains(TxtPhone.Text.ToLower())
                        || TxtPhone.Text == string.Empty) && item.isActive == false)
                    {
                        DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                    }
                }
                BtnCancelSearch.Show();
            }
            //searching for active clients
            else
            {
                if ((TxtPhone.Text == string.Empty && Txtname.Text == string.Empty))
                {
                    DgvClientsSearch.Rows.Clear();
                    FillClients();
                    Reset();
                    return;
                }
                DgvClientsSearch.Rows.Clear();
                foreach (Client item in _clientService.Clients())
                {
                    if ((item.Fullname.ToLower().Contains(Txtname.Text.ToLower())
                        || Txtname.Text == string.Empty) && (item.Phone.ToLower().Contains(TxtPhone.Text.ToLower())
                        || TxtPhone.Text == string.Empty) && item.isActive == true)
                    {
                        DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                    }
                }
                BtnCancelSearch.Show();
            }
        }

        private void ChckPassive_CheckedChanged(object sender, EventArgs e)//toggle the active passive clients
        {
            if (ChckPassive.Checked)
            {
                ChckActive.Checked = false;
                DgvClientsSearch.Rows.Clear();
                foreach (Client item in _clientService.Clients())
                {

                    if (item.isActive == false)
                    {
                        DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                    }
                }
            }
            else
            {
                ChckActive.Checked = true;
                DgvClientsSearch.Rows.Clear();
                FillClients();
            }
        }

        private void ChckActive_CheckedChanged(object sender, EventArgs e)//toggle the active passive clients
        {
            if (ChckActive.Checked)
            {
                ChckPassive.Checked = false;
                DgvClientsSearch.Rows.Clear();
                foreach (Client item in _clientService.Clients())
                {

                    if (item.isActive == true)
                    {
                        DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                    }
                }
            }
            else
            {
                ChckPassive.Checked = true;
                DgvClientsSearch.Rows.Clear();
                foreach (Client item in _clientService.Clients())
                {

                    if (item.isActive == false)
                    {
                        DgvClientsSearch.Rows.Add(item.Id, item.Fullname, item.Phone);
                    }
                }
            }
        }

        private void PbBack_Click(object sender, EventArgs e)//hide the current form and return the previous
        {
            this.Hide();
        }
    }
}
