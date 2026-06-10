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
    public partial class WarehouseForm : Form
    {
        private readonly ServiceManager _manager;
        public WarehouseForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            UpdateWarehouses();
        }

        void UpdateWarehouses()
        {
            listBoxWarehouses.Items.Clear();
            listBoxWarehouses.Items.AddRange(_manager.WarehouseService.GetAll().ToArray());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.WarehouseService.Create(textBoxName.Text, textBoxAdress.Text);

                UpdateWarehouses();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxWarehouses.SelectedIndex != -1)
            {
                try
                {
                    var w = (Warehouse)listBoxWarehouses.SelectedItem;

                    _manager.WarehouseService.Update(w, textBoxName.Text, textBoxAdress.Text);

                    UpdateWarehouses();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxWarehouses.SelectedIndex != -1)
            {
                try
                {
                    var w = (Warehouse)listBoxWarehouses.SelectedItem;
                    _manager.WarehouseService.Delete(w.Id);
                    UpdateWarehouses();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("can'd delate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void listBoxWarehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWarehouses.SelectedIndex != -1)
            {
                var w = (Warehouse)listBoxWarehouses.SelectedItem;
                textBoxName.Text = w.Name;
            }
        }

        void ClearInputs()
        {
            textBoxName.Clear();
            textBoxAdress.Clear();
            listBoxWarehouses.SelectedIndex = -1;
        }
    }
}
