using Data.Models;
using Services;
using Services.Reports;
using UI.TechSpecialist;

namespace UI
{
    public partial class AMainForm : Form
    {
        private readonly ServiceManager _manager;

        public AMainForm()
        {
            InitializeComponent();
            _manager = new ServiceManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAllData();
        }

        private void UpdateAllData()
        {
            UpdateDashboard();
            UpdateServicesGrid();
            UpdateIncidentsGrid();
        }

        private void UpdateDashboard()
        {
            var services = _manager.ServiceService.GetAllServices().ToList();
            var incidents = _manager.IncidentService.GetAllIncidents().ToList();
            var employees = _manager.EmployeeService.GetAllEmployees().ToList();

            int totalServices = services.Count;
            int activeIncidents = incidents.Count(x => x.Status == "New" || x.Status == "InProgress");
            int criticalServices = services.Count(x => x.Criticality == "Critical");
        }

        private void UpdateServicesGrid()
        {
            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = _manager.ServiceService.GetAllServices().ToList();
        }

        private void UpdateIncidentsGrid()
        {
            dataGridViewIncidents.DataSource = null;
            dataGridViewIncidents.DataSource = _manager.IncidentService.GetActiveIncidents().ToList();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxReport.Text = _manager.ReportService.GetSystemSummaryText();

                buttonExportToDocx.Enabled = true;
                buttonExportToXLSX.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while preparing report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportToXLSX_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = "System_Report.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _manager.ReportService.ExportSystemReportToExcel(sfd.FileName);
                    MessageBox.Show("Report was saved!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while saving report: {ex.Message}");
                }
            }
        }

        private void buttonExportToDocx_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Word Documents|*.docx", FileName = "System_Summary.docx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _manager.ReportService.ExportSystemReportToDocx(sfd.FileName);
                    MessageBox.Show("Report was saved!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while saving report: {ex.Message}");
                }
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServicesForm(_manager);
            serviceForm.ShowDialog();
            UpdateAllData();
        }

        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var incidentForm = new IncidentsForm(_manager);
            incidentForm.ShowDialog();
            UpdateAllData();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm(_manager);
            employeeForm.ShowDialog();
            UpdateAllData();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logForm = new AuditLogForm(_manager);
            logForm.ShowDialog();
            UpdateAllData();
        }
    }
}
