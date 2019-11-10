using System;
using System.Windows.Forms;
using Library.Services;
using Library.Models;
using System.Text.RegularExpressions;

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

        private void Reset()//reset the all changes on textboxes
        {
            TxtFullname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            BtnAdd.Show();
            BtnDeactive.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();

        }

        private void ResetSearch()//reset the searching
        {
            TxtPhoneSearch.Text = string.Empty;
            TxtNameSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }

        private void FillClients()//fill all clients which are active
        {
            foreach (Client item in _clientService.Clients())
            {
                //checks if the client is active
                if (item.isActive)
                {
                    DgvClients.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
        }

        public bool isDigit(string str)//checks if the string contains digits
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

        private void BtnAdd_Click(object sender, EventArgs e)//add new client
        {
            //check if the book information is null
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Clients information can't be null");
                return;
            }
            //check if the phone number contain digit
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("the phone can not contain letter");
                return;
            }
            //check if the fullname contain letter
            if (!Regex.IsMatch(TxtFullname.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the fullname can not contain digit");
                return;
            }
            //check if given client is already exists
            foreach (Client item in _clientService.Clients())
            {
                if (item.isActive == true)
                {
                    if (item.Fullname == TxtFullname.Text && item.Phone == TxtPhone.Text)
                    {
                        MessageBox.Show("such client is already exists");
                        return;
                    }
                }
            }
            Client client = new Client()//client to adding
            {
                Fullname = TxtFullname.Text,
                Phone = TxtPhone.Text,
                isActive = true
            };
            _clientService.Add(client);
            DgvClients.Rows.Add(client.Id, client.Fullname, client.Phone);
            ResetSearch();
            Reset();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)//update the selected client
        {
            //check if the book information is null
            if (TxtFullname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Clients information can't be null");
                return;
            }
            //check if the phone number contain digit
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("the phone can not contain letter");
                return;
            }
            //check if the fullname contain letter
            if (!Regex.IsMatch(TxtFullname.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the fullname can not contain digit");
                return;
            }
            //check if given client is already exists
            foreach (Client item in _clientService.Clients())
            {
                if (item.Fullname == TxtFullname.Text && item.Phone == TxtPhone.Text)
                {
                    MessageBox.Show("such Client is already exists");
                    return;
                }
            }
            //update the selected client information
            _selectedClient.Fullname = TxtFullname.Text;
            _selectedClient.Phone = TxtPhone.Text;
            _clientService.Update(_selectedClient);
            //apply changes to selected client on datagridview
            DgvClients.Rows[_selectedIndex].Cells[0].Value = _selectedClient.Id;
            DgvClients.Rows[_selectedIndex].Cells[1].Value = TxtFullname.Text;
            DgvClients.Rows[_selectedIndex].Cells[2].Value = TxtPhone.Text;
            ResetSearch();
            Reset();
            MessageBox.Show("client is updated");
        }

        private void BtnDeactive_Click_1(object sender, EventArgs e)//deactive the selected client
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

        private void BtnCancel_Click(object sender, EventArgs e)//call the reset function to canceling selected client
        {
            Reset();
        }

        private void DgvClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select the client to updating or deactiving
        {
            BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDeactive.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvClients.Rows[e.RowIndex].Cells[0].Value);
            //index of selected client on datagridview
            _selectedIndex = e.RowIndex;
            _selectedClient = _clientService.Find(Id);
            //fill the selected client information to the textboxes
            TxtFullname.Text = _selectedClient.Fullname;
            TxtPhone.Text = _selectedClient.Phone;
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)//shows the result of the searching when the text change
        {
            //check if the searching textboxes is empty
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
                    || TxtPhoneSearch.Text == string.Empty) && item.isActive == true)
                {
                    DgvClients.Rows.Add(item.Id, item.Fullname, item.Phone);
                }
            }
            BtnCancelSearch.Show();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)//call the resetsearch and cancel the searching results
        {
            DgvClients.Rows.Clear();
            FillClients();
            ResetSearch();
        }

        private void PbBack_Click(object sender, EventArgs e)//hide the current form and return to previou
        {
            this.Hide();
        }
    }
}
