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
    public partial class IncidentsForm : Form
    {
        private readonly ServiceManager _manager;

        public IncidentsForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void IncidentsForm_Load(object sender, EventArgs e)
        {
            LoadStaticData();
            RefreshList();
        }

        private void LoadStaticData()
        {
            cbPriority.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });
            cbPriority.SelectedIndex = 1; 

            cbStatus.Items.AddRange(new string[] { "New", "InProgress", "Resolved", "Closed" });
            cbStatus.SelectedIndex = 0; 

            cbAuthor.Items.AddRange(_manager.EmployeeService.GetAllEmployees().ToArray());
            if (cbAuthor.Items.Count > 0) cbAuthor.SelectedIndex = 0;
        }

        private void RefreshList()
        {
            listBoxIncidents.Items.Clear();
            listBoxIncidents.Items.AddRange(_manager.IncidentService.GetAllIncidents().ToArray());
        }

        private void listBoxIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIncidents.SelectedItem is Incident inc)
            {
                txtTitle.Text = inc.Title;
                rtbDesc.Text = inc.Description;
                cbPriority.Text = inc.Priority;
                cbStatus.Text = inc.Status;
                rtbRootCause.Text = inc.RootCause;
                rtbSolution.Text = inc.Solution;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxIncidents.SelectedItem is Incident inc)
            {
                try
                {
                    var author = (Employee)cbAuthor.SelectedItem;
                    inc.Title = txtTitle.Text;
                    inc.Description = rtbDesc.Text;
                    inc.Priority = cbPriority.Text;
                    inc.Status = cbStatus.Text;
                    inc.RootCause = rtbRootCause.Text;
                    inc.Solution = rtbSolution.Text;

                    _manager.IncidentService.UpdateIncident(inc, author);
                    RefreshList();
                    MessageBox.Show("Incident data updated!", "Success");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            if (listBoxIncidents.SelectedItem is Incident inc)
            {
                try
                {
                    var author = (Employee)cbAuthor.SelectedItem;
                    _manager.IncidentService.ResolveIncident(
                        inc,
                        rtbRootCause.Text,
                        rtbSolution.Text,
                        "Check system logs in 24h",
                        author
                    );
                    RefreshList();
                    MessageBox.Show("Incident was resolved and logged!", "Success");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Validation Error"); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxIncidents.SelectedItem is Incident inc)
            {
                if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _manager.IncidentService.DeleteIncident(inc.IncidentId, (Employee)cbAuthor.SelectedItem);
                    RefreshList();
                }
            }
        }
    }
}
