using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class RefrigeratorLogForm : Form
    {
        private readonly RefrigeratorLogService _service;

        public RefrigeratorLogForm(RefrigeratorLogService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void RefrigeratorLogForm_Load(object sender, EventArgs e)
        {
            UpdateRefrigeratorLogList();
            LoadComboBoxes();
            if (comboBoxLogRefrigerator.Items.Count > 0) comboBoxLogRefrigerator.SelectedIndex = 0;
        }

        void UpdateRefrigeratorLogList()
        {
            listBoxRL.Items.Clear();
            listBoxRL.Items.AddRange(_service.GetAllLogs().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxLogRefrigerator.Items.Clear();
            comboBoxLogRefrigerator.Items.AddRange(_service.GetAllRefrigerators().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                var newLog = new Refrigerator_Log
                {
                    Refrigerator = (Refrigerator)comboBoxLogRefrigerator.SelectedItem,
                    Min_Temp = (int)numericUpDownMin.Value,
                    Max_Temp = (int)numericUpDownMax.Value,
                    Current_Temp = (int)numericUpDownCurrent.Value,
                    Log_Date = dateTimePickerLogDate.Value
                };

                _service.AddLog(newLog);
                UpdateRefrigeratorLogList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRL.SelectedIndex != -1)
            {
                var refrigeratorLog = (Refrigerator_Log)listBoxRL.SelectedItem;
                var dialogResult = MessageBox.Show($"Are you sure you want to delete the log from '{refrigeratorLog.Log_Date}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteLog(refrigeratorLog.Log_Id);
                        UpdateRefrigeratorLogList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRL.SelectedIndex != -1)
            {
                try
                {
                    var selectedLog = (Refrigerator_Log)listBoxRL.SelectedItem;

                    selectedLog.Refrigerator = (Refrigerator)comboBoxLogRefrigerator.SelectedItem;
                    selectedLog.Min_Temp = (int)numericUpDownMin.Value;
                    selectedLog.Max_Temp = (int)numericUpDownMax.Value;
                    selectedLog.Current_Temp = (int)numericUpDownCurrent.Value;
                    selectedLog.Log_Date = dateTimePickerLogDate.Value;

                    _service.UpdateLog(selectedLog);
                    UpdateRefrigeratorLogList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}