using Data.Models;
using DocumentFormat.OpenXml.ExtendedProperties;
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
    public partial class LoginForm : Form
    {
        private readonly ServiceManager _manager;

        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _manager = new ServiceManager();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.AddRange(new string[] { "Administrator", "TechnicalSpecialist" });
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLoginLogin.Text.Trim();
                string password = textBoxLoginPassword.Text;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter login and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CurrentUser = _manager.UserService.Authenticate(login, password);

                if (CurrentUser != null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLoginLogin.Text.Trim();
                string password = textBoxLoginPassword.Text;
                string role = comboBoxRole.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter login and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _manager.UserService.Register(login, password, role);

                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxLoginLogin.Text = login;
                textBoxLoginPassword.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}
