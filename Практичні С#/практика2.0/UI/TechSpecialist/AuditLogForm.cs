using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI.TechSpecialist
{
    public partial class AuditLogForm : Form
    {
        private readonly ServiceManager _manager;
        private List<AuditLog> _allLogs; 

        public AuditLogForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void AuditLogForm_Load(object sender, EventArgs e)
        {
            // Налаштування дат: за замовчуванням показуємо за останній тиждень
            dtpFrom.Value = DateTime.Now.AddDays(-7);
            dtpTo.Value = DateTime.Now;

            LoadSpecialists();
            RefreshLogs();
        }

        private void LoadSpecialists()
        {
            cbUserFilter.Items.Clear();
            cbUserFilter.Items.Add("All Specialists");

            var employees = _manager.EmployeeService.GetAllEmployees().ToArray();
            cbUserFilter.Items.AddRange(employees);

            cbUserFilter.SelectedIndex = 0; // Встановлюємо "All Specialists" за замовчуванням
        }

        private void RefreshLogs()
        {
            try
            {
                var logs = _manager.AuditLogService.GetAllLogs();

                logs = logs.Where(l => l.Timestamp.Date >= dtpFrom.Value.Date &&
                                     l.Timestamp.Date <= dtpTo.Value.Date);

                if (cbUserFilter.SelectedIndex > 0 && cbUserFilter.SelectedItem is Employee selectedEmp)
                {
                    logs = logs.Where(l => l.EmployeeId == selectedEmp.EmployeeId);
                }

                dgvLogs.DataSource = logs.Select(l => new {
                    l.LogId,
                    Date = l.Timestamp.ToString("dd.MM.yyyy HH:mm"),
                    l.Action,
                    Specialist = l.Employee != null ? l.Employee.FullName : "System",
                    Details = l.Description
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLogs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentRow != null)
            {
                dynamic selectedItem = dgvLogs.CurrentRow.DataBoundItem;
                int logId = selectedItem.LogId;

                var result = MessageBox.Show($"Delete log entry #{logId}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _manager.AuditLogService.DeleteLog(logId);
                    RefreshLogs();
                    MessageBox.Show("Record deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}