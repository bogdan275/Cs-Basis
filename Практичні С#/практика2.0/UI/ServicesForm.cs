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
    public partial class ServicesForm : Form
    {
        private readonly ServiceManager _manager;
        public ServicesForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            UpdateServicesList();
            LoadStaticData();
            SetDefaultValues();
        }

        private void SetMaximumValues()
        {
            numericUpDownExpectedStatusCode.Maximum = 599;
            numericUpDownInterval.Maximum = 1440;
            numericUpDownTimeout.Maximum = 300;
            numericUpDownPort.Maximum = 65535;
            numericUpDownRetryCount.Maximum = 10;
            numericUpDownWarningResponseTime.Maximum = 60000;
            numericUpDownCriticalResponseTime.Maximum = 60000;
            numericUpDownMaxConsecutiveFailures.Maximum = 10;
            numericUpDownMinUptimePercent.Maximum = 100;
        }
        private void SetDefaultValues()
        {
            SetMaximumValues();
            numericUpDownExpectedStatusCode.Value = 200;

            numericUpDownInterval.Value = 5;
            numericUpDownTimeout.Value = 10;
            numericUpDownRetryCount.Value = 3;
            numericUpDownWarningResponseTime.Value = 3000;
            numericUpDownCriticalResponseTime.Value = 10000;
            numericUpDownMaxConsecutiveFailures.Value = 3;
            numericUpDownMinUptimePercent.Value = 99.50m;
            checkBoxIsActive.Checked = true;

            comboBoxChekMethod.SelectedIndex = 0;
            comboBoxActionAuthor.SelectedIndex = 0;
            comboBoxCategory.SelectedIndex = 0;
            comboBoxResponsibleEmployee.SelectedIndex = 0;
            comboBoxChekMethod.SelectedIndex = 0;
            comboBoxCriticality.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
            comboBoxDependsType.SelectedIndex = 0;
            comboBoxDependsOn.SelectedIndex = -1;
        }

        private void LoadStaticData()
        {
            comboBoxCategory.Items.AddRange(_manager.ServiceCategoryService.GetAllCategories().ToArray());
            comboBoxResponsibleEmployee.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());
            comboBoxActionAuthor.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());

            comboBoxActionAuthor.Items.Clear();
            comboBoxActionAuthor.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());
            if (comboBoxActionAuthor.Items.Count > 0)
            {
                comboBoxActionAuthor.SelectedIndex = 0;
            }

            comboBoxType.Items.AddRange(new string[] { "HTTP", "TCP", "Database", "FileSystem" });
            comboBoxCriticality.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });
            comboBoxChekMethod.Items.AddRange(new string[] { "HTTP_GET", "HTTP_POST", "TCP_Connect", "ICMP_Ping" });
            comboBoxDependsType.Items.AddRange(new string[] { "Required", "Optional" });
        }

        private void UpdateServicesList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_manager.ServiceService.GetAllServices().ToArray());
            UpdateDependsOnCombo();
        }
        private void UpdateDependsOnCombo()
        {
            var selectedService = (Service)listBox1.SelectedItem;
            var allServices = _manager.ServiceService.GetAllServices();

            comboBoxDependsOn.Items.Clear();
            foreach (var s in allServices)
            {
                if (selectedService == null || s.ServiceId != selectedService.ServiceId)
                {
                    comboBoxDependsOn.Items.Add(s);
                }
            }
        }


        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            var author = (Employee)comboBoxActionAuthor.SelectedItem;
            if (author == null)
            {
                MessageBox.Show("Please select an action author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var s = new Service
                {
                    ServiceName = textBoxName.Text,
                    Url = textBoxURL.Text,
                    NetworkAddress = textBoxNetworkAdress.Text,
                    Description = richTextBoxServiceDesctiption.Text,
                    Port = (int)numericUpDownPort.Value,
                    CategoryId = ((ServiceCategory)comboBoxCategory.SelectedItem).CategoryId,
                    ServiceType = comboBoxType.Text,
                    Criticality = comboBoxCriticality.Text,
                    CheckMethod = comboBoxChekMethod.Text,
                    CheckInterval = (int)numericUpDownInterval.Value,
                    Timeout = (int)numericUpDownTimeout.Value,
                    RetryCount = (int)numericUpDownRetryCount.Value,
                    ExpectedStatusCode = (int)numericUpDownExpectedStatusCode.Value,
                    ExpectedResponseContains = textBoxExpectedResponseContains.Text,
                    WarningResponseTime = (int)numericUpDownWarningResponseTime.Value,
                    CriticalResponseTime = (int)numericUpDownCriticalResponseTime.Value,
                    MaxConsecutiveFailures = (int)numericUpDownMaxConsecutiveFailures.Value,
                    MinUptimePercent = numericUpDownMinUptimePercent.Value,
                    IsActive = checkBoxIsActive.Checked,
                    ResponsibleEmployeeId = ((Employee)comboBoxResponsibleEmployee.SelectedItem)?.EmployeeId
                };
                _manager.ServiceService.AddService(s, author);

                if (comboBoxDependsOn.SelectedItem is Service depService)
                {
                    var dep = new ServiceDependency
                    {
                        ServiceId = s.ServiceId,
                        DependsOnServiceId = depService.ServiceId,
                        DependencyType = comboBoxDependsType.Text,
                        Description = richTextBoxDependsDescription.Text
                    };
                    _manager.ServiceDependencyService.AddDependency(dep);
                }

                UpdateServicesList();
                MessageBox.Show("Service added successfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Service selectedService)
            {
                try
                {
                    var author = (Employee)comboBoxActionAuthor.SelectedItem;

                    selectedService.ServiceName = textBoxName.Text;
                    selectedService.Url = textBoxURL.Text;
                    selectedService.NetworkAddress = textBoxNetworkAdress.Text;
                    selectedService.Description = richTextBoxServiceDesctiption.Text;
                    selectedService.Port = (int)numericUpDownPort.Value;
                    selectedService.CategoryId = ((ServiceCategory)comboBoxCategory.SelectedItem).CategoryId;
                    selectedService.ServiceType = comboBoxType.Text;
                    selectedService.Criticality = comboBoxCriticality.Text;
                    selectedService.CheckMethod = comboBoxChekMethod.Text;
                    selectedService.CheckInterval = (int)numericUpDownInterval.Value;
                    selectedService.Timeout = (int)numericUpDownTimeout.Value;
                    selectedService.RetryCount = (int)numericUpDownRetryCount.Value;
                    selectedService.ExpectedStatusCode = (int)numericUpDownExpectedStatusCode.Value;
                    selectedService.ExpectedResponseContains = textBoxExpectedResponseContains.Text;
                    selectedService.WarningResponseTime = (int)numericUpDownWarningResponseTime.Value;
                    selectedService.CriticalResponseTime = (int)numericUpDownCriticalResponseTime.Value;
                    selectedService.MaxConsecutiveFailures = (int)numericUpDownMaxConsecutiveFailures.Value;
                    selectedService.MinUptimePercent = numericUpDownMinUptimePercent.Value;
                    selectedService.IsActive = checkBoxIsActive.Checked;
                    selectedService.ResponsibleEmployeeId = ((Employee)comboBoxResponsibleEmployee.SelectedItem)?.EmployeeId;

                    _manager.ServiceService.UpdateService(selectedService, author);

                    UpdateServicesList();
                    MessageBox.Show("Service updated!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while updating service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Service selectedService)
            {
                var result = MessageBox.Show($"Are you sure you want to delate this service '{selectedService.ServiceName}'? This will also remove all of its checks!",
                    "Confirmation of deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var author = (Employee)comboBoxActionAuthor.SelectedItem;
                    try
                    {
                        _manager.ServiceService.DeleteService(selectedService.ServiceId, author);

                        UpdateServicesList();
                        ClearInputs();
                        MessageBox.Show("Service was delated");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while delating service: {ex.Message}");
                    }
                }
            }
        }

        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxURL.Clear();
            textBoxNetworkAdress.Clear();
            richTextBoxServiceDesctiption.Clear();
            numericUpDownPort.Value = 0;
            comboBoxDependsOn.SelectedIndex = -1;

            SetDefaultValues();
        }

        private void comboBoxDependsOn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bool hasSelection = comboBoxDependsOn.SelectedIndex != -1;
            label21.Visible = comboBoxDependsType.Visible = hasSelection;
            label22.Visible = richTextBoxDependsDescription.Visible = hasSelection;
            comboBoxDependsType.Visible = hasSelection;
            comboBoxDependsType.SelectedIndex = 0;
            richTextBoxDependsDescription.Visible = hasSelection;

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Service s)
            {
                SetMaximumValues();
                textBoxName.Text = s.ServiceName;
                textBoxURL.Text = s.Url;
                textBoxNetworkAdress.Text = s.NetworkAddress;
                richTextBoxServiceDesctiption.Text = s.Description;
                numericUpDownPort.Value = s.Port ?? 0;
                comboBoxType.Text = s.ServiceType;
                comboBoxCriticality.Text = s.Criticality;
                comboBoxChekMethod.Text = s.CheckMethod;
                numericUpDownInterval.Value = s.CheckInterval;
                numericUpDownTimeout.Value = s.Timeout;
                numericUpDownRetryCount.Value = s.RetryCount;
                numericUpDownExpectedStatusCode.Value = s.ExpectedStatusCode ?? 200;
                textBoxExpectedResponseContains.Text = s.ExpectedResponseContains;
                numericUpDownWarningResponseTime.Value = s.WarningResponseTime;
                numericUpDownCriticalResponseTime.Value = s.CriticalResponseTime;
                numericUpDownMaxConsecutiveFailures.Value = s.MaxConsecutiveFailures;
                numericUpDownMinUptimePercent.Value = s.MinUptimePercent;
                checkBoxIsActive.Checked = s.IsActive;

                comboBoxCategory.SelectedItem = comboBoxCategory.Items.Cast<ServiceCategory>()
                    .FirstOrDefault(c => c.CategoryId == s.CategoryId);
                comboBoxResponsibleEmployee.SelectedItem = comboBoxResponsibleEmployee.Items.Cast<Employee>()
                    .FirstOrDefault(emp => emp.EmployeeId == s.ResponsibleEmployeeId);

                UpdateDependsOnCombo();
            }
        }
    }
}
