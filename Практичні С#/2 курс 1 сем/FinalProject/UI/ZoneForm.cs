using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class ZoneForm : Form
    {
        private readonly ServiceManager _manager;
        public ZoneForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void ZoneForm_Load(object sender, EventArgs e)
        {
            numericUpDownCost.DecimalPlaces = 2;
            numericUpDownCost.Minimum = 1;
            numericUpDownCost.Value = 1;

            LoadCombos();
            UpdateList();
        }

        void UpdateList()
        {
            listBoxZones.Items.Clear();
            listBoxZones.Items.AddRange(_manager.StorageZoneService.GetAll().ToArray());
        }

        void LoadCombos()
        {
            comboBoxWarehouse.Items.Clear();
            comboBoxWarehouse.Items.AddRange(_manager.StorageZoneService.GetWarehouses().ToArray());
            comboBoxWarehouse.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxWarehouse.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Warehouse!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               _manager.StorageZoneService.Create(
                    txtName.Text,
                    numericUpDownCost.Value,
                    ((Warehouse)comboBoxWarehouse.SelectedItem).Id
                );

                UpdateList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxZones.SelectedIndex == -1 || listBoxZones.SelectedItem == null) return;

            try
            {
                if (comboBoxWarehouse.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Warehouse!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var z = (StorageZone)listBoxZones.SelectedItem;

                _manager.StorageZoneService.Update(
                    z,
                    txtName.Text,
                    numericUpDownCost.Value,
                    ((Warehouse)comboBoxWarehouse.SelectedItem).Id
                );

                UpdateList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxZones.SelectedIndex != -1)
            {
                var z = (StorageZone)listBoxZones.SelectedItem;
                if (MessageBox.Show($"Delete zone '{z.Name}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _manager.StorageZoneService.Delete(z.Id);
                        UpdateList();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxZones.SelectedIndex != -1)
            {
                var z = (StorageZone)listBoxZones.SelectedItem;
                txtName.Text = z.Name;
                numericUpDownCost.Value = z.CostMultiplier;

                foreach (Warehouse w in comboBoxWarehouse.Items)
                {
                    if (w.Id == z.WarehouseId)
                    {
                        comboBoxWarehouse.SelectedItem = w;
                        break;
                    }
                }
            }
        }

        void ClearInputs()
        {
            txtName.Clear();
            numericUpDownCost.Value = 1;
            listBoxZones.SelectedIndex = -1;
            comboBoxWarehouse.SelectedIndex = 0;
        }
    }
}
