using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Data.Models;
using Services;

namespace UI
{
    public partial class TariffForm : Form
    {
        private readonly ServiceManager _manager;
        public TariffForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void TariffForm_Load(object sender, EventArgs e)
        {
            UpdateTariffList();
            numericUpDownHandling.DecimalPlaces = 1;
            numericUpDownTPrice.DecimalPlaces = 1;

            numericUpDownTPrice.Minimum = 1;
            numericUpDownHandling.Minimum = 1;
        }

        void UpdateTariffList()
        {
            listBoxTariffs.Items.Clear();
            listBoxTariffs.Items.AddRange(_manager.TariffPlanService.GetAll().ToArray());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBoxTName.Text;
                decimal DailyStorageCostPerCubicMeter = numericUpDownTPrice.Value;
                decimal HandlingFeePerUnit = numericUpDownHandling.Value;

                _manager.TariffPlanService.Create(Name, DailyStorageCostPerCubicMeter, HandlingFeePerUnit);

                UpdateTariffList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding tariff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxTariffs.SelectedIndex != -1)
            {
                try
                {
                    var selectedTariff = (TariffPlan)listBoxTariffs.SelectedItem;

                    string Name = textBoxTName.Text;
                    decimal DailyStorageCostPerCubicMeter = numericUpDownTPrice.Value;
                    decimal HandlingFeePerUnit = numericUpDownHandling.Value;

                    _manager.TariffPlanService.Update(selectedTariff, Name, DailyStorageCostPerCubicMeter, HandlingFeePerUnit);

                    UpdateTariffList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating tariff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxTariffs.SelectedIndex != -1)
            {
                var selectedTariff = (TariffPlan)listBoxTariffs.SelectedItem;

                var result = MessageBox.Show($"Delete tariff '{selectedTariff.Name}'?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.TariffPlanService.Delete(selectedTariff.Id);

                        UpdateTariffList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting tariff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTariffs.SelectedIndex != -1)
            {
                var item = (TariffPlan)listBoxTariffs.SelectedItem;
                textBoxTName.Text = item.Name;
                numericUpDownTPrice.Value = item.DailyStorageCostPerCubicMeter;
            }
        }

        private void listBoxTariffs_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
