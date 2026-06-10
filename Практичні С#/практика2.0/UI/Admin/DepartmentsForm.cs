using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI.Main
{
    public partial class DepartmentsForm : Form
    {
        private readonly ServiceManager _manager;

        public DepartmentsForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxDepts.Items.Clear();
            listBoxDepts.Items.AddRange(_manager.DepartmentService.GetAllDepartments().ToArray());
        }

        private void listBoxDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDepts.SelectedItem is Department dept)
            {
                txtName.Text = dept.DepartmentName;
                rtbDesc.Text = dept.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.DepartmentService.AddDepartment(txtName.Text, rtbDesc.Text);
                RefreshList();
                MessageBox.Show("Department added!", "Success");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxDepts.SelectedItem is Department dept)
            {
                try
                {
                    _manager.DepartmentService.UpdateDepartment(dept, txtName.Text, rtbDesc.Text);
                    RefreshList();
                    MessageBox.Show("Updated successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDepts.SelectedItem is Department dept)
            {
                if (MessageBox.Show("Delete this department?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _manager.DepartmentService.DeleteDepartment(dept.DepartmentId);
                    RefreshList();
                }
            }
        }
    }
}