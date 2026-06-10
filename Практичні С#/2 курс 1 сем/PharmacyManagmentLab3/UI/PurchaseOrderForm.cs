using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class PurchaseOrderForm : Form
    {
        private readonly PurchaseOrderService _service;

        public PurchaseOrderForm(PurchaseOrderService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdatePurchaseOrderList();
        }

        void UpdatePurchaseOrderList()
        {
            listBoxPO.Items.Clear();
            listBoxPO.Items.AddRange(_service.GetAllOrders().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxPOSupplier.Items.Clear();
            comboBoxPOSupplier.Items.AddRange(_service.GetAllSuppliers().ToArray());
            comboBoxPOSupplier.SelectedIndex = 0;

            comboBoxPOStatus.Items.Clear();
            comboBoxPOStatus.Items.AddRange(new object[] { "Completed", "Pending", "In Transit" });
            comboBoxPOStatus.SelectedIndex = 0;
        }

        private void buttonAddAI_Click(object sender, EventArgs e)
        {
            try
            {
                var purchaseOrder = new Purchase_Order
                {
                    Supplier = (Supplier)comboBoxPOSupplier.SelectedItem,
                    Status = comboBoxPOStatus.SelectedItem.ToString(),
                    Order_Date = dateTimePickerPODate.Value
                };

                _service.AddOrder(purchaseOrder);
                UpdatePurchaseOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateAi_Click(object sender, EventArgs e)
        {
            if (listBoxPO.SelectedIndex != -1)
            {
                try
                {
                    var selectedOrder = (Purchase_Order)listBoxPO.SelectedItem;

                    selectedOrder.Supplier = (Supplier)comboBoxPOSupplier.SelectedItem;
                    selectedOrder.Status = comboBoxPOStatus.SelectedItem.ToString();
                    selectedOrder.Order_Date = dateTimePickerPODate.Value;

                    _service.UpdateOrder(selectedOrder);
                    UpdatePurchaseOrderList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelateAI_Click(object sender, EventArgs e)
        {
            if (listBoxPO.SelectedIndex != -1) 
            {
                var purchaseOrder = (Purchase_Order)listBoxPO.SelectedItem; 

                var dialogResult = MessageBox.Show($"Are you sure you want to delete order ID '{purchaseOrder.Purchase_Order_Id}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteOrder(purchaseOrder.Purchase_Order_Id);
                        UpdatePurchaseOrderList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}