using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data.Models;
using Services;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace UI
{
    public partial class BinForm : Form
    {
        private readonly ServiceManager _manager;
        public BinForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void BinForm_Load(object sender, EventArgs e)
        {
            numMaxWeight.DecimalPlaces = 2;
            numMaxVol.DecimalPlaces = 2;
            numMaxWeight.Maximum = 10000; 
            numMaxVol.Maximum = 10000;

            LoadCombos();
            UpdateList();
        }

        void UpdateList()
        {
            listBoxBins.Items.Clear();
            listBoxBins.Items.AddRange(_manager.StorageBinService.GetAll().ToArray());
        }

        void LoadCombos()
        {
            comboBoxZone.Items.Clear();
            comboBoxZone.Items.AddRange(_manager.StorageBinService.GetZones().ToArray());

            if (comboBoxZone.Items.Count > 0)
                comboBoxZone.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxZone.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Storage Zone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _manager.StorageBinService.Create(
                    txtName.Text,
                    numMaxWeight.Value,
                    numMaxVol.Value,
                    ((StorageZone)comboBoxZone.SelectedItem).Id
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
            if (listBoxBins.SelectedIndex != -1)
            {
                try
                {
                    if (comboBoxZone.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a Zone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var b = (StorageBin)listBoxBins.SelectedItem;

                    _manager.StorageBinService.Update(
                        b,
                        txtName.Text,
                        numMaxWeight.Value,
                        numMaxVol.Value,
                        ((StorageZone)comboBoxZone.SelectedItem).Id
                    );

                    UpdateList();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxBins.SelectedIndex != -1)
            {
                var b = (StorageBin)listBoxBins.SelectedItem;
                if (MessageBox.Show($"Delete bin '{b.Code}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _manager.StorageBinService.Delete(b.Id);
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

        private void listBoxBins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBins.SelectedIndex != -1)
            {
                var b = (StorageBin)listBoxBins.SelectedItem;
                txtName.Text = b.Code;
                numMaxWeight.Value = b.MaxWeight;
                numMaxVol.Value = b.MaxVolume;

                foreach (StorageZone z in comboBoxZone.Items)
                {
                    if (z.Id == b.StorageZoneId)
                    {
                        comboBoxZone.SelectedItem = z;
                        break;
                    }
                }
            }
        }

        void ClearInputs()
        {
            txtName.Clear();
            numMaxWeight.Value = 100;
            numMaxVol.Value = 10;
            listBoxBins.SelectedIndex = -1;
            if (comboBoxZone.Items.Count > 0)
            {
                comboBoxZone.SelectedIndex = 0;
            }
        }
    }
}
