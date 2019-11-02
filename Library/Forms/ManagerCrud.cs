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
    public partial class ManagerCrud : Form
    {
        private readonly ManagerService _managerService;
        private Manager _selectedManager;
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
            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();
        }
        private void FillManagers()
        {
            foreach (Manager item in _managerService.Managers())
            {
                DgvManagers.Rows.Add(item.Id, item.Name, item.Surname, item.Phone);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == string.Empty || TxtSurname.Text == string.Empty || TxtPhone.Text == string.Empty)
            {
                MessageBox.Show("Managers information can't be null");
                return;
            }
            Manager manager = new Manager()
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone  =TxtPhone.Text
                
            };
            _managerService.Add(manager);
            DgvManagers.Rows.Clear();
            FillManagers();
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
            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;
            TxtPhone.Text = _selectedManager.Phone;
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
                DgvManagers.Rows.Clear();
                FillManagers();
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
            _managerService.Update(_selectedManager);
            DgvManagers.Rows.Clear();
            FillManagers();
            Reset();
            MessageBox.Show("manager is updated");
        }

 
    }
}
