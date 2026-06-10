using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Main
{
    public partial class UsersForm : Form
    {
        private readonly ServiceManager _manager;

        public UsersForm(ServiceManager manager)
        {
            //InitializeComponent();
            _manager = manager;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            //LoadUsers();
            //LoadEmployees();
            //LoadRoles();
        }

        //    private void LoadUsers()
        //    {
        //        listBoxUsers.Items.Clear();
        //        listBoxUsers.Items.AddRange(_manager.UserService.GetAllUsers().ToArray());
        //    }

        //    private void LoadEmployees()
        //    {
        //        comboBoxEmployee.Items.Clear();
        //        comboBoxEmployee.Items.Add("(None)");
        //        comboBoxEmployee.Items.AddRange(_manager.UserService.GetAllEmployees().ToArray());
        //        comboBoxEmployee.SelectedIndex = 0;
        //    }

        //    private void LoadRoles()
        //    {
        //        comboBoxRole.Items.Clear();
        //        comboBoxRole.Items.AddRange(new string[] { "Administrator", "TechnicalSpecialist" });
        //        comboBoxRole.SelectedIndex = 0;
        //    }

        //    private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        if (listBoxUsers.SelectedItem is User user)
        //        {
        //            textBoxLogin.Text = user.Login;
        //            textBoxPassword.Text = user.Password;
        //            comboBoxRole.Text = user.Role;
        //            checkBoxIsActive.Checked = user.IsActive;

        //            if (user.EmployeeId.HasValue)
        //            {
        //                comboBoxEmployee.SelectedItem = comboBoxEmployee.Items.Cast<object>()
        //                    .FirstOrDefault(item => item is Employee emp && emp.EmployeeId == user.EmployeeId.Value);
        //            }
        //            else
        //            {
        //                comboBoxEmployee.SelectedIndex = 0;
        //            }
        //        }
        //    }

        //    private void buttonAdd_Click(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            int? employeeId = null;
        //            if (comboBoxEmployee.SelectedItem is Employee emp)
        //            {
        //                employeeId = emp.EmployeeId;
        //            }

        //            _manager.UserService.Register(
        //                textBoxLogin.Text,
        //                textBoxPassword.Text,
        //                comboBoxRole.Text,
        //                employeeId
        //            );

        //            LoadUsers();
        //            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ClearFields();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    private void buttonUpdate_Click(object sender, EventArgs e)
        //    {
        //        if (listBoxUsers.SelectedItem is User user)
        //        {
        //            try
        //            {
        //                user.Login = textBoxLogin.Text;
        //                user.Password = textBoxPassword.Text;
        //                user.Role = comboBoxRole.Text;
        //                user.IsActive = checkBoxIsActive.Checked;

        //                if (comboBoxEmployee.SelectedItem is Employee emp)
        //                {
        //                    user.EmployeeId = emp.EmployeeId;
        //                }
        //                else
        //                {
        //                    user.EmployeeId = null;
        //                }

        //                _manager.UserService.UpdateUser(user);
        //                LoadUsers();
        //                MessageBox.Show("User updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }

        //    private void buttonDelete_Click(object sender, EventArgs e)
        //    {
        //        if (listBoxUsers.SelectedItem is User user)
        //        {
        //            var result = MessageBox.Show($"Delete user '{user.Login}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //            if (result == DialogResult.Yes)
        //            {
        //                try
        //                {
        //                    _manager.UserService.DeleteUser(user.UserId);
        //                    LoadUsers();
        //                    ClearFields();
        //                    MessageBox.Show("User deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //    }

        //    private void ClearFields()
        //    {
        //        textBoxLogin.Clear();
        //        textBoxPassword.Clear();
        //        comboBoxRole.SelectedIndex = 0;
        //        comboBoxEmployee.SelectedIndex = 0;
        //        checkBoxIsActive.Checked = true;
        //    }
        //}
    }
}