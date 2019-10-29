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

        private void FillClients()
        {
            foreach (Client item in _clientService.Clients())
            {
                DgvClients.Rows.Add(item.Id, item.Fullname, item.Phone);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Clients information can't be null");
                return;
            }
            Client client = new Client()
            {
                Fullname = TxtFullname.Text,
                Phone = TxtPhone.Text,

            };
            _clientService.Add(client);
            DgvClients.Rows.Clear();
            FillClients();
            Reset();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("clients information can't be null");
                return;
            }
            _selectedClient.Fullname = TxtFullname.Text;
            _selectedClient.Phone = TxtPhone.Text;
            _clientService.Update(_selectedClient);
            DgvClients.Rows.Clear();
            FillClients();
            Reset();
            MessageBox.Show("client is updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Delete client", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _clientService.Delete(_selectedClient);
                DgvClients.Rows.Clear();
                FillClients();
                Reset();
            }
            MessageBox.Show("client is deleted");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DgvClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDelete.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvClients.Rows[e.RowIndex].Cells[0].Value);
            _selectedClient = _clientService.Find(Id);
            TxtFullname.Text = _selectedClient.Fullname;
            TxtPhone.Text = _selectedClient.Phone;
        }
    }
}
