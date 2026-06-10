using Data.Models;
using Services;
using Services.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Main
{
    public partial class AdminMainForm : Form
    {
        private readonly ServiceManager _manager;
        private readonly User _currentUser;

        public AdminMainForm(ServiceManager manager, User currentUser)
        {
            InitializeComponent();
            _manager = manager;
            _currentUser = currentUser;
        }

        private void AdminMainForm_Load_1(object sender, EventArgs e)
        {
            this.Text = $"Monitoring System [ADMIN] - logged as {_currentUser.Login}";

            UpdateAllData();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateAllData()
        {
            LoadDashboard();
            LoadServicesGrid();
        }
        private void LoadDashboard()
        {
            try
            {
                var services = _manager.ServiceService.GetAllServices().ToList();
                var incidents = _manager.IncidentService.GetAllIncidents().ToList();
                var employees = _manager.EmployeeService.GetAllEmployees().ToList();
                var maintenance = _manager.MaintenanceWindowService.GetAllMaintenanceWindows().ToList();

                labelTotalServices.Text = $"Total Services: {services.Count}";
                labelActiveServices.Text = $"Active Monitoring: {services.Count(s => s.IsActive)}";
                labelCriticalServices.Text = $"Critical Services: {services.Count(s => s.Criticality == "Critical")}";

                int activeCount = incidents.Count(i => i.Status == "New" || i.Status == "InProgress");
                labelTotalIncidents.Text = $"Total Incidents: {incidents.Count}";
                labelActiveIncidents.Text = $"Active Incidents: {activeCount}";
                int critUnresolved = incidents.Count(i => i.Priority == "Critical" && (i.Status != "Resolved" && i.Status != "Closed"));
                labelCriticalUnresolved.Text = $"Critical Unresolved: {critUnresolved}";
                DateTime last24h = DateTime.Now.AddDays(-1);
                int resolvedToday = incidents.Count(i => i.ResolvedAt >= last24h);
                labelResolvedToday.Text = $"Resolved (24h): {resolvedToday}";
                labelTotalEmployees.Text = $"Staff Members: {employees.Count}";
                int todayMaint = maintenance.Count(m => m.StartDateTime.Date == DateTime.Today);
                labelMaintenanceToday.Text = $"Maintenances Today: {todayMaint}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadServicesGrid()
        {
            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = _manager.ServiceService.GetAllServices()
                .Select(s => new
                {
                    s.ServiceName,
                    s.ServiceType,
                    s.Criticality,
                    Status = s.IsActive ? "Active" : "Inactive",
                    Responsible = s.ResponsibleEmployee?.FullName ?? "None"
                }).ToList();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            richTextBoxReport.Text = _manager.ReportService.GetSystemSummaryText();
            buttonExportToXLSX.Enabled = true;
            buttonExportToDocx.Enabled = true;
        }

        private void buttonExportToXLSX_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = "SystemReport.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _manager.ReportService.ExportSystemReportToExcel(sfd.FileName);
                MessageBox.Show("Excel report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExportToDocx_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Word Documents|*.docx", FileName = "SystemSummary.docx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _manager.ReportService.ExportSystemReportToDocx(sfd.FileName);
                MessageBox.Show("Word report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DepartmentsForm(_manager);
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UsersForm(_manager);
            form.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void manageServiceCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ServiceCategoriesForm(_manager);
            form.ShowDialog();
        }

        private void manageSpecializationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SpecializationsForm(_manager);
            form.ShowDialog();
        }
    }
}
