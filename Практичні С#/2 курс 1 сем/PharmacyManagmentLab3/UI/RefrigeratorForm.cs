using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class RefrigeratorForm : Form
    {
        private readonly RefrigeratorService _service;

        public RefrigeratorForm(RefrigeratorService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void RefrigeratorForm_Load(object sender, EventArgs e)
        {
            UpdateRefrigeratorList();
        }

        void UpdateRefrigeratorList()
        {
            listBoxRe.Items.Clear();
            listBoxRe.Items.AddRange(_service.GetAllRefrigerators().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                _service.AddRefrigerator(textBoxRefrigeratorName.Text);
                UpdateRefrigeratorList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the refrigerator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRe.SelectedIndex != -1)
            {
                var refrigerator = (Refrigerator)listBoxRe.SelectedItem;
                var dialogResult = MessageBox.Show($"Are you sure you want to delete '{refrigerator.Refrigerator_Name}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteRefrigerator(refrigerator.Refrigerator_Id);
                        UpdateRefrigeratorList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting refrigerator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRe.SelectedIndex != -1)
            {
                try
                {
                    var selectedRefrigerator = (Refrigerator)listBoxRe.SelectedItem;
                    _service.UpdateRefrigerator(selectedRefrigerator, textBoxRefrigeratorName.Text);
                    UpdateRefrigeratorList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the refrigerator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}