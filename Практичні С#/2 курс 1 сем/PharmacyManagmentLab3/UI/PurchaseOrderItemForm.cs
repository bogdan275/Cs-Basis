using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class PurchaseOrderItemForm : Form
    {
        private readonly PurchaseOrderItemService _service;

        public PurchaseOrderItemForm(PurchaseOrderItemService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void PurchaseOrderItemForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdatePurchaseOrderItemList();
        }

        void UpdatePurchaseOrderItemList()
        {
            listBoxPOI.Items.Clear();
            listBoxPOI.Items.AddRange(_service.GetAllItems().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxPOIPurchase.Items.Clear();
            comboBoxPOIPurchase.Items.AddRange(_service.GetAllOrders().ToArray());
            if (comboBoxPOIPurchase.Items.Count > 0) comboBoxPOIPurchase.SelectedIndex = 0;

            comboBoxPOIMedicine.Items.Clear();
            comboBoxPOIMedicine.Items.AddRange(_service.GetAllMedicines().ToArray());
            if (comboBoxPOIMedicine.Items.Count > 0) comboBoxPOIMedicine.SelectedIndex = 0;
        }

        private void buttonAddAI_Click(object sender, EventArgs e)
        {
            try
            {
                var purchaseOrderItem = new Purchase_Order_Item
                {
                    Quantity = (int)numericUpDownPOIQuantity.Value,
                    Medicine = (Medicine)comboBoxPOIMedicine.SelectedItem,
                    Purchase_Order = (Purchase_Order)comboBoxPOIPurchase.SelectedItem
                };

                _service.AddOrderItem(purchaseOrderItem);
                UpdatePurchaseOrderItemList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the order item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateAI_Click(object sender, EventArgs e)
        {
            if (listBoxPOI.SelectedIndex != -1)
            {
                var purchaseOrderItem = (Purchase_Order_Item)listBoxPOI.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete order item ID '{purchaseOrderItem.Purchase_Order_Item_Id}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteOrderItem(purchaseOrderItem.Purchase_Order_Item_Id);
                        UpdatePurchaseOrderItemList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateAi_Click(object sender, EventArgs e)
        {
            if (listBoxPOI.SelectedIndex != -1)
            {
                try
                {
                    var selectedPurchaseOrderItem = (Purchase_Order_Item)listBoxPOI.SelectedItem;

                    selectedPurchaseOrderItem.Quantity = (int)numericUpDownPOIQuantity.Value;
                    selectedPurchaseOrderItem.Purchase_Order = (Purchase_Order)comboBoxPOIPurchase.SelectedItem;
                    selectedPurchaseOrderItem.Medicine = (Medicine)comboBoxPOIMedicine.SelectedItem;

                    _service.UpdateOrderItem(selectedPurchaseOrderItem);
                    UpdatePurchaseOrderItemList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the order item: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}