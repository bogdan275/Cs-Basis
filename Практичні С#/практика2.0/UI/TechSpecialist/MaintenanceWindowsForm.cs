using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.TechSpecialist
{
    public partial class MaintenanceWindowsForm : Form
    {
        private readonly ServiceManager _manager;

        public MaintenanceWindowsForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void MaintenanceWindowsForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxWindows.Items.Clear();
            var windows = _manager.MaintenanceWindowService.GetAllMaintenanceWindows();
            listBoxWindows.Items.AddRange(windows.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newWindow = new MaintenanceWindow
                {
                    Title = txtTitle.Text,
                    StartDateTime = dtpStart.Value,
                    EndDateTime = dtpEnd.Value,
                    Reason = rtbReason.Text,
                    Status = "Scheduled"
                };

                _manager.MaintenanceWindowService.AddMaintenanceWindow(newWindow);
                RefreshList();
                ClearFields();
                MessageBox.Show("Maintenance window scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                try
                {
                    mw.Title = txtTitle.Text;
                    mw.StartDateTime = dtpStart.Value;
                    mw.EndDateTime = dtpEnd.Value;
                    mw.Reason = rtbReason.Text;

                    _manager.MaintenanceWindowService.UpdateMaintenanceWindow(mw);
                    RefreshList();
                    MessageBox.Show("Maintenance window updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStartMaint_Click(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                try
                {
                    _manager.MaintenanceWindowService.StartMaintenance(mw.MaintenanceId);
                    RefreshList();
                    MessageBox.Show($"Maintenance '{mw.Title}' started.", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCompleteMaint_Click(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                try
                {
                    _manager.MaintenanceWindowService.CompleteMaintenance(mw.MaintenanceId);
                    RefreshList();
                    MessageBox.Show($"Maintenance '{mw.Title}' completed.", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                var result = MessageBox.Show("Are you sure you want to cancel this maintenance window?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.MaintenanceWindowService.CancelMaintenance(mw.MaintenanceId);
                        RefreshList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                var result = MessageBox.Show("Delete this record permanently?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.MaintenanceWindowService.DeleteMaintenanceWindow(mw.MaintenanceId);
                        RefreshList();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWindows.SelectedItem is MaintenanceWindow mw)
            {
                txtTitle.Text = mw.Title;
                dtpStart.Value = mw.StartDateTime;
                dtpEnd.Value = mw.EndDateTime;
                rtbReason.Text = mw.Reason;
                this.Text = $"Maintenance: {mw.Title} [{mw.Status}]";
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            rtbReason.Clear();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddHours(1);
            this.Text = "Maintenance Management";
        }
    }
}