using Core.Entities;
using Data;
using Data.Managers;
using Domain;
using Domain.Exceptions;
using Domain.Reports;

namespace Ui
{
    public partial class Form1 : Form
    {
        private ICustomerManager _manager;
        private List<Customer> _customers = new List<Customer>();
        private string _currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logger.SetLogFilePath("application.log");
            Logger.LogInfo("Application started");
            UpdateCustomerGrid();
        }

        private void InitializeComboBoxes()
        {
            comboBoxGender.Items.AddRange(new[] { "Male", "Female" });
            var serviceStatuses = new[] { "Yes", "No", "No internet service", "No phone service" };
            comboBoxMultipleLines.Items.AddRange(serviceStatuses);
            comboBoxOnlineSecurity.Items.AddRange(serviceStatuses);
            comboBoxOnlineBackup.Items.AddRange(serviceStatuses);
            comboBoxDeviceProtection.Items.AddRange(serviceStatuses);
            comboBoxTechSupport.Items.AddRange(serviceStatuses);
            comboBoxStreamingTV.Items.AddRange(serviceStatuses);
            comboBoxStreamingMovies.Items.AddRange(serviceStatuses);

            comboBoxInternetService.Items.AddRange(new[] { "DSL", "Fiber optic", "No" });
            comboBoxContractType.Items.AddRange(new[] { "Month-to-month", "One year", "Two year" });
            comboBoxPaymentMethod.Items.AddRange(new[] {
                "Electronic check", "Mailed check",
                "Bank transfer (automatic)", "Credit card (automatic)"
            });
            comboBoxContractType.SelectedIndex = 0;
            comboBoxPaymentMethod.SelectedIndex = 0;
            comboBoxDeviceProtection.SelectedIndex = 0;
            comboBoxTechSupport.SelectedIndex = 0;
            comboBoxMultipleLines.SelectedIndex = 0;
            comboBoxOnlineSecurity.SelectedIndex = 0;
            comboBoxOnlineBackup.SelectedIndex = 0;
            comboBoxStreamingTV.SelectedIndex = 0;
            comboBoxStreamingMovies.SelectedIndex = 0;
            comboBoxInternetService.SelectedIndex = 0;

        }

        private void UpdateCustomerGrid()
        {
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = _customers;
            dataGridViewCustomers.AutoResizeColumns();
        }

        private void LoadCustomerToForm(Customer customer)
        {
            if (customer == null) return;

            textBoxCusromerID.Text = customer.CustomerID;
            comboBoxGender.SelectedItem = customer.Gender;
            checkBoxSeniorCitizen.Checked = customer.IsSeniorCitizen;
            checkBoxPartner.Checked = customer.HasPartner;
            checkBoxHasDepandents.Checked = customer.HasDependents;
            numericUpDownTenure.Value = customer.TenureMonths;

            checkBoxHasPhoneService.Checked = customer.Services.HasPhoneService;
            comboBoxMultipleLines.SelectedItem = customer.Services.MultipleLines;
            comboBoxInternetService.SelectedItem = customer.Services.InternetService;
            comboBoxOnlineSecurity.SelectedItem = customer.Services.OnlineSecurity;
            comboBoxOnlineBackup.SelectedItem = customer.Services.OnlineBackup;
            comboBoxDeviceProtection.SelectedItem = customer.Services.DeviceProtection;
            comboBoxTechSupport.SelectedItem = customer.Services.TechSupport;
            comboBoxStreamingTV.SelectedItem = customer.Services.StreamingTV;
            comboBoxStreamingMovies.SelectedItem = customer.Services.StreamingMovies;

            comboBoxContractType.SelectedItem = customer.Contract.ContractType;
            checkBoxPaperlessBilling.Checked = customer.Contract.PaperlessBilling;
            comboBoxPaymentMethod.SelectedItem = customer.Contract.PaymentMethod;

            textBoxContractType.Text = customer.MonthlyCharges.ToString();
            textBoxPaymentMethod.Text = customer.TotalCharges.ToString();
            checkBoxChurned.Checked = customer.HasChurned;
        }
        private Customer GetCustomerFromForm()
        {
            var customer = new Customer
            {
                CustomerID = textBoxCusromerID.Text,
                Gender = comboBoxGender.SelectedItem?.ToString() ?? "",
                IsSeniorCitizen = checkBoxSeniorCitizen.Checked,
                HasPartner = checkBoxPartner.Checked,
                HasDependents = checkBoxHasDepandents.Checked,
                TenureMonths = (int)numericUpDownTenure.Value,
                MonthlyCharges = decimal.TryParse(textBoxContractType.Text, out var monthly) ? monthly : 0,
                TotalCharges = decimal.TryParse(textBoxPaymentMethod.Text, out var total) ? total : 0,
                HasChurned = checkBoxChurned.Checked
            };

            customer.Services.HasPhoneService = checkBoxHasPhoneService.Checked;
            customer.Services.MultipleLines = comboBoxMultipleLines.SelectedItem?.ToString() ?? "";
            customer.Services.InternetService = comboBoxInternetService.SelectedItem?.ToString() ?? "";
            customer.Services.OnlineSecurity = comboBoxOnlineSecurity.SelectedItem?.ToString() ?? "";
            customer.Services.OnlineBackup = comboBoxOnlineBackup.SelectedItem?.ToString() ?? "";
            customer.Services.DeviceProtection = comboBoxDeviceProtection.SelectedItem?.ToString() ?? "";
            customer.Services.TechSupport = comboBoxTechSupport.SelectedItem?.ToString() ?? "";
            customer.Services.StreamingTV = comboBoxStreamingTV.SelectedItem?.ToString() ?? "";
            customer.Services.StreamingMovies = comboBoxStreamingMovies.SelectedItem?.ToString() ?? "";

            customer.Contract.ContractType = comboBoxContractType.SelectedItem?.ToString() ?? "";
            customer.Contract.PaperlessBilling = checkBoxPaperlessBilling.Checked;
            customer.Contract.PaymentMethod = comboBoxPaymentMethod.SelectedItem?.ToString() ?? "";

            return customer;
        }

        private void ClearForm()
        {
            textBoxCusromerID.Clear();
            comboBoxGender.SelectedIndex = -1;
            checkBoxSeniorCitizen.Checked = false;
            checkBoxPartner.Checked = false;
            checkBoxHasDepandents.Checked = false;
            numericUpDownTenure.Value = 0;
            checkBoxHasPhoneService.Checked = false;

            comboBoxMultipleLines.SelectedIndex = -1;
            comboBoxInternetService.SelectedIndex = -1;
            comboBoxOnlineSecurity.SelectedIndex = -1;
            comboBoxOnlineBackup.SelectedIndex = -1;
            comboBoxDeviceProtection.SelectedIndex = -1;
            comboBoxTechSupport.SelectedIndex = -1;
            comboBoxStreamingTV.SelectedIndex = -1;
            comboBoxStreamingMovies.SelectedIndex = -1;

            comboBoxContractType.SelectedIndex = -1;
            comboBoxPaymentMethod.SelectedIndex = -1;
            checkBoxPaperlessBilling.Checked = false;

            textBoxContractType.Clear();
            textBoxPaymentMethod.Clear();
            checkBoxChurned.Checked = false;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = GetCustomerFromForm();

                CustomerValidator.ValidateCustomer(customer);
                CustomerValidator.ValidateUniqueCustomerID(customer.CustomerID, _customers);

                _customers.Add(customer);
                UpdateCustomerGrid();
                ClearForm();

                Logger.LogInfo($"Added new customer: {customer.CustomerID}");
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CustomerDataException ex)
            {
                Logger.LogError("Validation error while adding customer", ex);
                MessageBox.Show($"Validation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Logger.LogError("Error adding customer", ex);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a customer to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                var updatedCustomer = GetCustomerFromForm();

                CustomerValidator.ValidateCustomer(updatedCustomer);

                if (selectedCustomer.CustomerID != updatedCustomer.CustomerID)
                {
                    CustomerValidator.ValidateUniqueCustomerID(updatedCustomer.CustomerID, _customers);
                }

                int index = _customers.IndexOf(selectedCustomer);
                _customers[index] = updatedCustomer;

                UpdateCustomerGrid();

                Logger.LogInfo($"Updated customer: {updatedCustomer.CustomerID}");
                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CustomerDataException ex)
            {
                Logger.LogError("Validation error while updating customer", ex);
                MessageBox.Show($"Validation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating customer", ex);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a customer to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this customer?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                    _customers.Remove(selectedCustomer);
                    UpdateCustomerGrid();
                    ClearForm();

                    Logger.LogInfo($"Deleted customer: {selectedCustomer.CustomerID}");
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deleting customer", ex);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetManager(string extension)
        {
            switch (extension.ToLower())
            {
                case "csv":
                    _manager = new CustomerCsvManager();
                    break;
                case "json":
                    _manager = new CustomerJsonManager();
                    break;
                case "xml":
                    _manager = new CustomerXmlManager();
                    break;
                case "xlsx":
                    _manager = new CustomerXlsxManager();
                    break;
                default:
                    throw new NotSupportedException($"Format {extension} not supported");
            }
        }

        private void OpenFile(string extension)
        {
            var dialog = new OpenFileDialog
            {
                Filter = $"{extension.ToUpper()} files (*.{extension})|*.{extension}",
                Title = $"Open {extension.ToUpper()} File"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _currentFilePath = dialog.FileName;
                    SetManager(extension);
                    _customers = _manager.Read(_currentFilePath);
                    UpdateCustomerGrid();

                    Logger.LogInfo($"Loaded {_customers.Count} customers from {_currentFilePath}");
                    MessageBox.Show($"Loaded {_customers.Count} customers successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Logger.LogError($"Error loading file: {_currentFilePath}", ex);
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFile(string extension)
        {
            if (_customers.Count == 0)
            {
                MessageBox.Show("No data to save", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = new SaveFileDialog
            {
                Filter = $"{extension.ToUpper()} files (*.{extension})|*.{extension}",
                Title = $"Save as {extension.ToUpper()}"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _currentFilePath = dialog.FileName;
                    SetManager(extension);
                    _manager.Write(_currentFilePath, _customers);

                    Logger.LogInfo($"Saved {_customers.Count} customers to {_currentFilePath}");
                    MessageBox.Show("File saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Logger.LogError($"Error saving file: {_currentFilePath}", ex);
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void chartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_customers.Count == 0)
            {
                MessageBox.Show("No data to generate charts", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var chartsForm = new ChartsForm(_customers);
            chartsForm.ShowDialog();
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                LoadCustomerToForm(selectedCustomer);
            }
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("csv");
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("json");
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("xml");
        }

        private void xLSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("xlsx");
        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile("csv");
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile("json");
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile("xml");
        }

        private void xLSXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile("xlsx");
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportservice = new DocxReportService();
            var saveDialog = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                Title = "Save Report As"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var reportPath = saveDialog.FileName;
                    reportservice.GenerateReport(_customers, reportPath);
                    Logger.LogInfo($"Generated report at {reportPath}");
                    MessageBox.Show("Report generated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error generating report", ex);
                    MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void generateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var reportservice = new DocxReportService();
            var saveDialog = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                Title = "Save Report As"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var reportPath = saveDialog.FileName;
                    reportservice.GenerateReport(_customers, reportPath);
                    Logger.LogInfo($"Generated report at {reportPath}");
                    MessageBox.Show("Report generated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error generating report", ex);
                    MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
