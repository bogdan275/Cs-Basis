using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class EmployeeForm : Form
    {
        private readonly ServiceManager _manager;
        public EmployeeForm(ServiceManager serviceManager)
        {
            InitializeComponent();
            _manager = serviceManager;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            UpdateEmployeeList();
            LoadStaticData();
        }
        private void LoadStaticData()
        {
            comboBoxDepartment.Items.AddRange(_manager.EmployeeService.GetAllDepartments().ToArray());
            comboBoxSpecialization.Items.AddRange(_manager.EmployeeService.GetAllSpecializations().ToArray());
        }

        private void UpdateEmployeeList()
        {
            listBoxEmployees.Items.Clear();
            listBoxEmployees.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem is Employee emp)
            {
                textBoxFullName.Text = emp.FullName;
                textBoxPosition.Text = emp.Position;
                textBoxEmail.Text = emp.Email;
                textBoxPhone.Text = emp.Phone;

                comboBoxDepartment.SelectedItem = comboBoxDepartment.Items.Cast<Department>()
                    .FirstOrDefault(d => d.DepartmentId == emp.DepartmentId);

                comboBoxSpecialization.SelectedItem = comboBoxSpecialization.Items.Cast<Specialization>()
                    .FirstOrDefault(s => s.SpecializationId == emp.SpecializationId);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newEmp = new Employee
                {
                    FullName = textBoxFullName.Text.Trim(),
                    Position = textBoxPosition.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    Phone = textBoxPhone.Text.Trim(),
                    DepartmentId = ((Department)comboBoxDepartment.SelectedItem)?.DepartmentId,
                    SpecializationId = ((Specialization)comboBoxSpecialization.SelectedItem)?.SpecializationId
                };

                _manager.EmployeeService.AddEmployee(newEmp);

                UpdateEmployeeList();
                MessageBox.Show("New employee successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem is Employee selectedEmp)
            {
                try
                {
                    selectedEmp.FullName = textBoxFullName.Text.Trim();
                    selectedEmp.Position = textBoxPosition.Text.Trim();
                    selectedEmp.Email = textBoxEmail.Text.Trim();
                    selectedEmp.Phone = textBoxPhone.Text.Trim();
                    selectedEmp.DepartmentId = ((Department)comboBoxDepartment.SelectedItem)?.DepartmentId;
                    selectedEmp.SpecializationId = ((Specialization)comboBoxSpecialization.SelectedItem)?.SpecializationId;

                    _manager.EmployeeService.UpdateEmployee(selectedEmp);
                    UpdateEmployeeList();
                    MessageBox.Show("Employee data updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem is Employee selectedEmp)
            {
                var result = MessageBox.Show($"Are you sure you want to delete '{selectedEmp.FullName}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.EmployeeService.DeleteEmployee(selectedEmp.EmployeeId);
                        UpdateEmployeeList();
                        ClearInputs();
                        MessageBox.Show("Employee removed from the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cannot delete employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearInputs()
        {
            textBoxFullName.Clear();
            textBoxPosition.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            comboBoxDepartment.SelectedIndex = 0;
            comboBoxSpecialization.SelectedIndex = 0;
        }
    }
}
