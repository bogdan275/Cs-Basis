using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.TechSpecialist;

namespace UI.Main
{
    public partial class TechSpecialistMainForm : Form
    {
        private readonly ServiceManager _manager;
        private readonly User _currentUser;

        public TechSpecialistMainForm(ServiceManager manager, User currentUser)
        {
            InitializeComponent();
            _manager = manager;
            _currentUser = currentUser;
        }

        private void TechSpecialistMainForm_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            try
            {
                var allIncidents = _manager.IncidentService.GetAllIncidents().ToList();

                var activeIncidents = allIncidents
                    .Where(i => i.Status != "Closed" && i.Status != "Resolved")
                    .OrderByDescending(i => i.Priority == "Critical")
                    .ThenByDescending(i => i.DetectedAt)
                    .ToList();

                int newCount = allIncidents.Count(i => i.Status == "New");
                lblNewIncidents.Text = $"New Unassigned Incidents: {newCount}";

                dgvActiveTasks.DataSource = activeIncidents.Select(i => new {
                    i.IncidentId,
                    i.Title,
                    Service = i.Service?.ServiceName ?? "N/A",
                    i.Priority,
                    i.Status,
                    Detected = i.DetectedAt.ToString("g")
                }).ToList();

                if (dgvActiveTasks.Columns.Count > 0)
                    dgvActiveTasks.Columns[0].Width = 70; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenServices_Click(object sender, EventArgs e)
        {
            var form = new ServicesForm(_manager);
            form.ShowDialog();
            RefreshDashboard();
        }

        private void btnOpenIncidents_Click(object sender, EventArgs e)
        {
            var form = new IncidentsForm(_manager);
            form.ShowDialog();
            RefreshDashboard();
        }

        private void btnOpenLogs_Click(object sender, EventArgs e)
        {
            var form = new AuditLogForm(_manager);
            form.ShowDialog();
        }
    }
}
