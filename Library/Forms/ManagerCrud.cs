using System;
using System.Windows.Forms;
using Library.Services;
using Library.Models;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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
        private void Reset()//reset the all changes on textboxes
        {
            TxtName.Text = string.Empty;
            TxtSurname.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtUsername.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtNewPassword.Text = string.Empty;
            CmbPosition.SelectedItem = null;
            BtnAdd.Show();
            BtnDeactive.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();
            TxtNewPassword.Hide();
            LblPassword.Text = "password";
            TxtPassword.Show();
            LblComment.Hide();
        }

        private void ResetSearch()//reset the searching
        {
            TxtNameSearch.Text = string.Empty;
            TxtSurnameSearch.Text = string.Empty;
            TxtPhoneSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }

        private void FillManagers()//fill all managers which are active
        {
            foreach (Manager item in _managerService.Managers())
            {
                if (item.isActive == true)
                {
                    DgvManagers.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.IsAdmin);
                }
            }
        }

        public bool isDigit(string str)//checks if the string is digit
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

        private void BtnAdd_Click(object sender, EventArgs e)//add the new manager
        {
            //check if the manager information is null
            if (TxtName.Text == string.Empty || TxtSurname.Text == string.Empty || TxtPhone.Text == string.Empty || CmbPosition.Text == string.Empty || TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Managers information can't be null");
                return;
            }
            //check if the phone  contains digit
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("phone number can not contain letter");
                return;
            }

            //check if the Name  contains letter
            if (!Regex.IsMatch(TxtName.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the name can not contain digit");
                return;
            }
            //check if the Surname contains letter
            if (!Regex.IsMatch(TxtSurname.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the Surname can not contain digit");
                return;
            }
            //check if the given manager is already exist
            foreach (Manager item in _managerService.Managers())
            {
                if (item.isActive == true)
                {
                    if (item.Name == TxtName.Text &&
                        item.Phone == TxtPhone.Text &&
                        item.Surname == TxtSurname.Text
                        )
                    {
                        MessageBox.Show("such manager is already exists");
                        return;
                    }
                }
            }
            //convert comboitem to boolean type
            bool IsAdminOrNot = false;
            if (CmbPosition.SelectedIndex == 0)
            {
                IsAdminOrNot = true;
            }
            Manager manager = new Manager()//manager to adding 
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                IsAdmin = IsAdminOrNot,
                Username = TxtUsername.Text,
                Password = Encrypt(TxtPassword.Text),
                isActive = true
            };
            _managerService.Add(manager);
            DgvManagers.Rows.Add(manager.Id, manager.Name, manager.Surname, manager.Phone, manager.IsAdmin);
            ResetSearch();
            Reset();
        }

        private void DgvManagers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select the manager to updating or deactiving
        {
            BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDeactive.Show();
            BtnCancel.Show();
            TxtPassword.Hide();
            LblPassword.Text = "New Password";
            LblComment.Show();
            TxtNewPassword.Show();
            int Id = Convert.ToInt32(DgvManagers.Rows[e.RowIndex].Cells[0].Value);
            _selectedManager = _managerService.Find(Id);

            //index of selected manager on datagridview
            _selectedIndex = e.RowIndex;
            //fill the selected manager information to the textboxes
            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;
            TxtPhone.Text = _selectedManager.Phone;
            TxtUsername.Text = _selectedManager.Username;
            if (_selectedManager.IsAdmin == true)
            {
                CmbPosition.SelectedIndex = 0;
                return;
            }
            CmbPosition.SelectedIndex = 1;

        }

        private void BtnCancel_Click(object sender, EventArgs e)//call the reset function to canceling selected manager
        {
            Reset();
        }

        private void BtnDeactive_Click_1(object sender, EventArgs e)//deactive the selected manager
        {
            DialogResult result = MessageBox.Show("Are you sure you want to deactive", "Deactive manager", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _selectedManager.isActive = false;
                _managerService.Update(_selectedManager);
                DgvManagers.Rows.RemoveAt(_selectedIndex);
                ResetSearch();
                Reset();
            }
            MessageBox.Show("manager is deactived");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)//update the selected manager
        {
            //check if the manager information is null
            if (TxtName.Text == string.Empty || TxtSurname.Text == string.Empty || TxtPhone.Text == string.Empty || CmbPosition.Text == string.Empty || TxtUsername.Text == string.Empty)
            {
                MessageBox.Show("Managers information can't be null");
                return;
            }
            //check if the phone  contains digit
            if (!isDigit(TxtPhone.Text))
            {
                MessageBox.Show("phone number can not contain letter");
                return;
            }

            //check if the Name  contains letter
            if (!Regex.IsMatch(TxtName.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the name can not contain digit");
                return;
            }
            //check if the Surname contains letter
            if (!Regex.IsMatch(TxtSurname.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the Surname can not contain digit");
                return;
            }
            //convert comboitem to boolean type
            bool IsAdminOrNot = false;
            if (CmbPosition.SelectedIndex == 0)
            {
                IsAdminOrNot = true;
            }
            //check if the given  is already exist
            foreach (Manager item in _managerService.Managers())
            {
                if (item.isActive == true && TxtNewPassword.Text != string.Empty)
                {
                    if (item.IsAdmin == IsAdminOrNot &&
                        item.Name == TxtName.Text &&
                        item.Phone == TxtPhone.Text &&
                        item.Surname == TxtSurname.Text &&
                        item.Username == TxtUsername.Text &&
                        item.Password == Encrypt(TxtNewPassword.Text)
                        )
                    {
                        MessageBox.Show("such Manager is already exists");
                        return;
                    }
                }
                else if (item.isActive == true && TxtNewPassword.Text == string.Empty)
                {
                    if (item.IsAdmin == IsAdminOrNot &&
                        item.Name == TxtName.Text &&
                      item.Phone == TxtPhone.Text &&
                      item.Surname == TxtSurname.Text &&
                      item.Username == TxtUsername.Text
                      )
                    {
                        MessageBox.Show("such Manager is already exists");
                        return;
                    }
                }
            }
            //update the selected manager information
            _selectedManager.Name = TxtName.Text;
            _selectedManager.Surname = TxtSurname.Text;
            _selectedManager.Phone = TxtPhone.Text;
            _selectedManager.Username = TxtUsername.Text;
            if (TxtNewPassword.Text != string.Empty)
            {
                _selectedManager.Password = Encrypt(TxtNewPassword.Text);
            }
            if (CmbPosition.SelectedIndex == 0)
            {
                _selectedManager.IsAdmin = true;
            }
            else
            {
                _selectedManager.IsAdmin = false;
            }
            _managerService.Update(_selectedManager);
            //apply changes to selected manager on datagridview
            DgvManagers.Rows[_selectedIndex].Cells[0].Value = _selectedManager.Id;
            DgvManagers.Rows[_selectedIndex].Cells[1].Value = TxtName.Text;
            DgvManagers.Rows[_selectedIndex].Cells[2].Value = TxtSurname.Text;
            DgvManagers.Rows[_selectedIndex].Cells[3].Value = TxtPhone.Text;
            if (CmbPosition.SelectedIndex == 0)
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

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)//shows the result of the searching when the text changes
        {
            //check if the searching textboxes is empty
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
                    || TxtNameSearch.Text == string.Empty) && (item.Surname.ToLower().Contains(TxtSurnameSearch.Text.ToLower()) || TxtSurnameSearch.Text == string.Empty) && (item.Phone.ToLower().Contains(TxtPhoneSearch.Text.ToLower())
                    || TxtPhoneSearch.Text == string.Empty) && item.isActive == true)
                {
                    DgvManagers.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.IsAdmin);
                }
            }
            BtnCancelSearch.Show();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)//call the resetsearch and cancel the searching results
        {
            DgvManagers.Rows.Clear();
            FillManagers();
            ResetSearch();
        }

        private void PbBack_Click(object sender, EventArgs e)//hide the current form and return to previous
        {
            this.Hide();
        }

        public string Encrypt(string password)//hash the password of manager
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            string result = BitConverter.ToString(bytes).Replace("-", string.Empty);
            return result;
        }

    }
}
