using System;
using System.Windows.Forms;
using Library.Services;
using Library.Models;

namespace Library.Forms
{
    public partial class ManagerCrud : Form
    {
        private readonly ManagerService _managerService;
        private Manager _selectedManager;
        private int _selectedIndex;
        public ManagerCrud()
        {
            InitializeComponent();
            _managerService = new ManagerService();
            _selectedManager = new Manager();
            FillManagers();
        }
        private void Reset()
        {
            TxtName.Text = string.Empty;
            TxtSurname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            CmbPosition.SelectedItem = null;
            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();

        }
        private void ResetSearch()
        {
            TxtNameSearch.Text = string.Empty;
            TxtSurnameSearch.Text = string.Empty;
            TxtPhoneSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }
        private void FillManagers()
        {
            foreach (Manager item in _managerService.Managers())
            {
                DgvManagers.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.IsAdmin);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == string.Empty || TxtSurname.Text == string.Empty || TxtPhone.Text == string.Empty || CmbPosition.Text == string.Empty || TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Managers information can't be null");
                return;
            }
            bool IsAdminOrNot = false;
            if(CmbPosition.SelectedIndex == 0)
            {
                IsAdminOrNot = true;
            }
            Manager manager = new Manager()
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                IsAdmin = IsAdminOrNot,
                Username = TxtUsername.Text,
                Password = TxtPassword.Text
            };
            _managerService.Add(manager);
            DgvManagers.Rows.Add(manager.Id, manager.Name, manager.Surname, manager.Phone , manager.IsAdmin);
            ResetSearch();
            Reset();
        }
        private void DgvManagers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDelete.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvManagers.Rows[e.RowIndex].Cells[0].Value);
            _selectedManager = _managerService.Find(Id);
            _selectedIndex = e.RowIndex;
            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;
            TxtPhone.Text = _selectedManager.Phone;
            TxtUsername.Text = _selectedManager.Username;
            TxtPassword.Text = _selectedManager.Password;
            if(_selectedManager.IsAdmin == true)
            {
                CmbPosition.SelectedIndex = 0;
                return;
            }
            CmbPosition.SelectedIndex = 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Delete manager", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _managerService.Delete(_selectedManager);
                DgvManagers.Rows.RemoveAt(_selectedIndex);
                ResetSearch();
                Reset();
            }
            MessageBox.Show("manager is deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == string.Empty || TxtSurname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Managers information can't be null");
                return;
            }
            _selectedManager.Name = TxtName.Text;
            _selectedManager.Surname = TxtSurname.Text;
            _selectedManager.Phone = TxtPhone.Text;
            _selectedManager.Username = TxtUsername.Text;
            _selectedManager.Password = TxtPassword.Text;
            if(CmbPosition.SelectedIndex == 0)
            {
                _selectedManager.IsAdmin = true;
            }
            else
            {
                _selectedManager.IsAdmin = false;
            }
            _managerService.Update(_selectedManager);
            DgvManagers.Rows[_selectedIndex].Cells[0].Value = _selectedManager.Id;
            DgvManagers.Rows[_selectedIndex].Cells[1].Value = TxtName.Text;
            DgvManagers.Rows[_selectedIndex].Cells[2].Value = TxtSurname.Text;
            DgvManagers.Rows[_selectedIndex].Cells[3].Value = TxtPhone.Text;
            if(CmbPosition.SelectedIndex == 0)
            {
                DgvManagers.Rows[_selectedIndex].Cells[4].Value = true;
            }
            else
            {
                DgvManagers.Rows[_selectedIndex].Cells[4].Value = false;
            }
            ResetSearch();
            Reset();
            MessageBox.Show("manager is updated");
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            if ((TxtPhoneSearch.Text == string.Empty && TxtNameSearch.Text == string.Empty && TxtSurnameSearch.Text == string.Empty))
            {
                DgvManagers.Rows.Clear();
                FillManagers();
                ResetSearch();
                return;
            }
            DgvManagers.Rows.Clear();
            foreach (Manager item in _managerService.Managers())
            {
                if ((item.Name.ToLower().Contains(TxtNameSearch.Text.ToLower())
                    || TxtNameSearch.Text == string.Empty) &&(item.Surname.ToLower().Contains(TxtSurnameSearch.Text.ToLower()) || TxtSurnameSearch.Text == string.Empty)&& (item.Phone.ToLower().Contains(TxtPhoneSearch.Text.ToLower())
                    || TxtPhoneSearch.Text == string.Empty))
                {
                    DgvManagers.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.IsAdmin);
                }
            }
            BtnCancelSearch.Show();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            DgvManagers.Rows.Clear();
            FillManagers();
            ResetSearch();
        }

    }
}
