using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService _service;

        public SupplierForm(SupplierService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            UpdateSuppliers();
        }

        void UpdateSuppliers()
        {
            listBoxSu.Items.Clear();
            listBoxSu.Items.AddRange(_service.GetAllSuppliers().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                _service.AddSupplier(textBoxSupplierName.Text, textBoxSupplierPhone.Text);
                UpdateSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSu.SelectedIndex != -1)
            {
                var supplier = (Supplier)listBoxSu.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete '{supplier.SupplierName}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteSupplier(supplier.SupplierId);
                        UpdateSuppliers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSu.SelectedIndex != -1)
            {
                try
                {
                    var selectedSupplier = (Supplier)listBoxSu.SelectedItem;
                    _service.UpdateSupplier(selectedSupplier, textBoxSupplierName.Text, textBoxSupplierPhone.Text);
                    UpdateSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}