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

namespace Library.Forms
{
    public partial class ClientCrud : Form
    {
        private readonly ClientService _clientService;
        private Client _selectedClient;
        private int _selectedIndex;
        public ClientCrud()
        {
            _clientService = new ClientService();
            _selectedClient = new Client();
            InitializeComponent();
            FillClients();
        }

        private void Reset()
        {
            TxtFullname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();

        }
        private void ResetSearch()
        {
            TxtPhoneSearch.Text = string.Empty;
            TxtNameSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }
        private void FillClients()
        {
            foreach (Client item in _clientService.Clients())
            {
                if (item.isActive)
                {
                    DgvClients.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
        }
        public bool isDigit(string str)
        {
            foreach (Char item in str)
            {
                if (item < '0' || item > '9')
                {
                    return false;
                }
            }
            return true;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Clients information can't be null");
                return;
            }
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("the phone can only contain digits");
                return;
            }
            foreach (Client item in _clientService.Clients())
            {
                if(item.Fullname == TxtFullname.Text && item.Phone == TxtPhone.Text)
                {
                    MessageBox.Show("such client is already exists");
                    return;
                }
            }
            Client client = new Client()
            {
                Fullname = TxtFullname.Text,
                Phone = TxtPhone.Text,

            };
            _clientService.Add(client);
            DgvClients.Rows.Add(client.Id, client.Fullname, client.Phone);
            ResetSearch();
            Reset();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("clients information can't be null");
                return;
            }
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("the phone can only contain digits");
                return;
            }
            foreach (Client item in _clientService.Clients())
            {
                if (item.Fullname == TxtFullname.Text && item.Phone == TxtPhone.Text)
                {
                    MessageBox.Show("such client is already exists");
                    return;
                }
            }
            _selectedClient.Fullname = TxtFullname.Text;
            _selectedClient.Phone = TxtPhone.Text;
            _clientService.Update(_selectedClient);
            DgvClients.Rows[_selectedIndex].Cells[0].Value = _selectedClient.Id;
            DgvClients.Rows[_selectedIndex].Cells[1].Value = TxtFullname.Text;
            DgvClients.Rows[_selectedIndex].Cells[2].Value = TxtPhone.Text;
            ResetSearch();
            Reset();
            MessageBox.Show("client is updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to deactive", "Deactive client", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _selectedClient.isActive = false;
                _clientService.Update(_selectedClient);
                DgvClients.Rows.RemoveAt(_selectedIndex);
                ResetSearch();
                Reset();
            }
            MessageBox.Show("client is deactived");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DgvClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDelete.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvClients.Rows[e.RowIndex].Cells[0].Value);
            _selectedIndex = e.RowIndex;
            _selectedClient = _clientService.Find(Id);
            TxtFullname.Text = _selectedClient.Fullname;
            TxtPhone.Text = _selectedClient.Phone;
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            if ((TxtPhoneSearch.Text == string.Empty && TxtNameSearch.Text == string.Empty))
            {
                DgvClients.Rows.Clear();
                FillClients();
                ResetSearch();
                return;
            }
            DgvClients.Rows.Clear();
            foreach (Client item in _clientService.Clients())
            {
                if ((item.Fullname.ToLower().Contains(TxtNameSearch.Text.ToLower())
                    || TxtNameSearch.Text == string.Empty) && (item.Phone.ToLower().Contains(TxtPhoneSearch.Text.ToLower())
                    || TxtPhoneSearch.Text == string.Empty))
                {
                    DgvClients.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
            BtnCancelSearch.Show();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            DgvClients.Rows.Clear();
            FillClients();
            ResetSearch();
        }

       
    }
}
