using Data.Models;
using DocumentFormat.OpenXml.Presentation;
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
    public partial class IncidentsForm : Form
    {
        private readonly ServiceManager _manager;
        public IncidentsForm(ServiceManager serviceManager)
        {
            InitializeComponent();
            _manager = serviceManager;
        }

        private void IncidentsForm_Load(object sender, EventArgs e)
        {
            UpdateIncidentsList();
            LoadStaticData();
            SeedDefaultWalues();
        }

        private void LoadStaticData()
        {
            comboBoxService.Items.AddRange(_manager.IncidentService.GetAllServices().ToArray());
            comboBoxSeverity.Items.AddRange(_manager.IncidentService.GetAllSeverities().ToArray());
            comboBoxEmployee.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());
            comboBoxActionAuthor.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());

            comboBoxStatus.Items.AddRange(new string[] { "New", "InProgress", "Resolved", "Closed" });
            comboBoxPriority.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });

            if (comboBoxActionAuthor.Items.Count > 0)
            {
                comboBoxActionAuthor.SelectedIndex = 0;
            }

        }

        private void SeedDefaultWalues()
        {
            comboBoxActionAuthor.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 0;
            comboBoxEmployee.SelectedIndex = 0;
            comboBoxSeverity.SelectedIndex = 0;
            comboBoxService.SelectedIndex = 0;
            dateTimePickerDetectedAt.Value = DateTime.Now;
        }

        private void UpdateIncidentsList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_manager.IncidentService.GetAllIncidents().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Incident inc)
            {
                textBoxTitle.Text = inc.Title;
                richTextBoxDescription.Text = inc.Description;
                comboBoxStatus.Text = inc.Status;
                comboBoxPriority.Text = inc.Priority;

                dateTimePickerDetectedAt.Value = inc.DetectedAt;
                textBoxResolovedDate.Text = inc.ResolvedAt?.ToString("dd.MM.yyyy HH:mm") ?? "Not resoloved yet";

                comboBoxService.SelectedItem = comboBoxService.Items.Cast<Service>()
                    .FirstOrDefault(s => s.ServiceId == inc.ServiceId);

                comboBoxSeverity.SelectedItem = comboBoxSeverity.Items.Cast<IncidentSeverity>()
                    .FirstOrDefault(s => s.SeverityId == inc.SeverityId);

                comboBoxEmployee.SelectedItem = comboBoxEmployee.Items.Cast<Employee>()
                    .FirstOrDefault(emp => emp.EmployeeId == inc.AssignedToEmployeeId);

                richTextBoxRootCause.Text = inc.RootCause;
                richTextBoxSolution.Text = inc.Solution;
                richTextBoxRecomendations.Text = inc.Recommendations;
            }
        }

        private void buttonAsign_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Incident inc && comboBoxEmployee.SelectedItem is Employee assignee)
            {
                var author = (Employee)comboBoxActionAuthor.SelectedItem;
                try
                {
                    _manager.IncidentService.AssignIncident(inc, assignee, author);
                    UpdateIncidentsList();
                    MessageBox.Show("The asigned person hes been determined");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonResolove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Incident inc)
            {
                var author = (Employee)comboBoxActionAuthor.SelectedItem;
                try
                {
                    _manager.IncidentService.ResolveIncident(
                        inc,
                        richTextBoxRootCause.Text,
                        richTextBoxSolution.Text,
                        richTextBoxRecomendations.Text,
                        author
                    );

                    UpdateIncidentsList();
                    MessageBox.Show("Incident was resoloved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var author = (Employee)comboBoxActionAuthor.SelectedItem;
                var newInc = new Incident
                {
                    Title = textBoxTitle.Text,
                    Description = richTextBoxDescription.Text,
                    ServiceId = ((Service)comboBoxService.SelectedItem).ServiceId,
                    SeverityId = ((IncidentSeverity)comboBoxSeverity.SelectedItem).SeverityId,
                    Priority = comboBoxPriority.Text,
                    Status = "New",
                    DetectedAt = dateTimePickerDetectedAt.Value
                };

                _manager.IncidentService.AddIncident(newInc, author);
                UpdateIncidentsList();
                MessageBox.Show("New incident was created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Incident selectedIncident)
            {
                if (selectedIncident.Status == "Closed" || selectedIncident.Status == "Resolved")
                {
                    var confirm = MessageBox.Show("This incident has already been resolved or closed. Are you sure you want to change its details?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No)
                    {
                        return;
                    }
                }

                try
                {
                    var author = (Employee)comboBoxActionAuthor.SelectedItem;

                    selectedIncident.Title = textBoxTitle.Text.Trim();
                    selectedIncident.Description = richTextBoxDescription.Text.Trim();
                    selectedIncident.Status = comboBoxStatus.Text;
                    selectedIncident.Priority = comboBoxPriority.Text;
                    selectedIncident.DetectedAt = dateTimePickerDetectedAt.Value;

                    if (comboBoxService.SelectedItem is Service s)
                    {
                        selectedIncident.ServiceId = s.ServiceId;
                    }
                    if (comboBoxSeverity.SelectedItem is IncidentSeverity sev)
                    {
                        selectedIncident.SeverityId = sev.SeverityId;
                    }
                    if (comboBoxEmployee.SelectedItem is Employee emp)
                    {
                        selectedIncident.AssignedToEmployeeId = emp.EmployeeId;
                    }

                    selectedIncident.RootCause = richTextBoxRootCause.Text;
                    selectedIncident.Solution = richTextBoxSolution.Text;
                    selectedIncident.Recommendations = richTextBoxRecomendations.Text;

                    _manager.IncidentService.UpdateIncident(selectedIncident, author);

                    UpdateIncidentsList();
                    MessageBox.Show("Incident was updated succesefuly", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while updatibg incident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Incident selectedIncident)
            {
                var result = MessageBox.Show($"Are you sure you want delate the incident '{selectedIncident.Title}'?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var author = (Employee)comboBoxActionAuthor.SelectedItem;

                        _manager.IncidentService.DeleteIncident(selectedIncident.IncidentId, author);

                        UpdateIncidentsList();
                        ClearInputs(); 
                        MessageBox.Show("Incident was delated");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while delating uncident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearInputs()
        {
            textBoxTitle.Clear();
            richTextBoxDescription.Clear();
            richTextBoxRootCause.Clear();
            richTextBoxSolution.Clear();
            richTextBoxRecomendations.Clear();
            textBoxResolovedDate.Clear();

            SeedDefaultWalues();
        }
    }
}
