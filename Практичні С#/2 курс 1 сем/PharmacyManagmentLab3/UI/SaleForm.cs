using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class SaleForm : Form
    {
        private readonly SaleService _service;

        public SaleForm(SaleService service)
        {
            InitializeComponent();
            _service = service;

            comboBoxBatch.SelectedIndexChanged += comboBoxBatch_SelectedIndexChanged;
            numericUpDownSaleQuantity.ValueChanged += numericUpDownSaleQuantity_ValueChanged;
            listBoxSa.SelectedIndexChanged += listBoxSa_SelectedIndexChanged;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            UpdateSaleList();
            UpdateMedicineList();
            if (comboBoxMedicine.Items.Count > 0)
            {
                comboBoxMedicine.SelectedIndex = 0;
            }

            numericUpDownSaleQuantity.Minimum = 1;
            numericUpDownSaleQuantity.Maximum = 1000000;

            UpdatePriceDisplay();
        }

        public void UpdateSaleList()
        {
            listBoxSa.Items.Clear();
            listBoxSa.Items.AddRange(_service.GetAllSales().ToArray());
        }

        public void UpdateMedicineList()
        {
            comboBoxMedicine.Items.Clear();
            comboBoxMedicine.Items.AddRange(_service.GetAllMedicines().ToArray());
        }

        public void UpdateBatchList()
        {
            if (comboBoxMedicine.SelectedIndex != -1)
            {
                var selectedMedicine = (Medicine)comboBoxMedicine.SelectedItem;
                var batches = _service.GetAvailableBatches(selectedMedicine.Id).ToList();

                comboBoxBatch.Items.Clear();
                comboBoxBatch.Items.AddRange(batches.ToArray());

                if (comboBoxBatch.Items.Count > 0)
                {
                    comboBoxBatch.SelectedIndex = 0;
                }
                else
                {
                    comboBoxBatch.Text = "";
                    numericUpDownSaleQuantity.Enabled = false;
                    buttonAddRec.Enabled = false;
                    labelPrice.Text = string.Empty;
                }

                UpdatePriceDisplay();
            }
            else
            {
                comboBoxBatch.Items.Clear();
                labelPrice.Text = string.Empty;
                numericUpDownSaleQuantity.Enabled = false;
                buttonAddRec.Enabled = false;
            }
        }

        private decimal CalculatePriceForSelectedBatch(int quantity)
        {
            if (comboBoxBatch.SelectedIndex == -1)
            {
                return 0m;
            }
            var batch = (Batch)comboBoxBatch.SelectedItem;
            if (batch == null) return 0m;

            decimal perItem = 0m;

            if (batch.Initial_Quantity > 0)
            {
                perItem = batch.Initial_Quantity > 0
                    ? batch.Unit_Price / batch.Initial_Quantity
                    : 0m;
            }
            else
            {
                perItem = batch.Unit_Price;
            }

            return Math.Round(perItem * quantity, 2);
        }

        private void UpdatePriceDisplay()
        {
            if (comboBoxBatch.SelectedIndex != -1)
            {
                var qty = (int)numericUpDownSaleQuantity.Value;
                try
                {
                    var price = CalculatePriceForSelectedBatch(qty);
                    labelPrice.Text = price.ToString("F2");
                }
                catch
                {
                    labelPrice.Text = string.Empty;
                }
            }
            else
            {
                labelPrice.Text = string.Empty;
            }
        }

        private void AdjustQuantityLimitsForSelectedBatch()
        {
            if (comboBoxBatch.SelectedIndex == -1)
            {
                numericUpDownSaleQuantity.Enabled = false;
                buttonAddRec.Enabled = false;
                return;
            }

            var batch = (Batch)comboBoxBatch.SelectedItem;
            if (batch == null)
            {
                numericUpDownSaleQuantity.Enabled = false;
                buttonAddRec.Enabled = false;
                return;
            }

            var stock = batch.Stock_Quantity;
            if (stock <= 0)
            {
                numericUpDownSaleQuantity.Enabled = false;
                buttonAddRec.Enabled = false;
                numericUpDownSaleQuantity.Minimum = 0;
                numericUpDownSaleQuantity.Maximum = 0;
                numericUpDownSaleQuantity.Value = 0;
                labelPrice.Text = "";
                return;
            }

            numericUpDownSaleQuantity.Enabled = true;
            buttonAddRec.Enabled = true;

            numericUpDownSaleQuantity.Minimum = 1;
            numericUpDownSaleQuantity.Maximum = stock;

            if (numericUpDownSaleQuantity.Value < numericUpDownSaleQuantity.Minimum)
                numericUpDownSaleQuantity.Value = numericUpDownSaleQuantity.Minimum;
            else if (numericUpDownSaleQuantity.Value > numericUpDownSaleQuantity.Maximum)
                numericUpDownSaleQuantity.Value = numericUpDownSaleQuantity.Maximum;
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            if (comboBoxBatch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a batch.");
                return;
            }

            try
            {
                var qty = (int)numericUpDownSaleQuantity.Value;
                var newSale = new Sale
                {
                    Date_Of_Sale = dateTimePickerSaleDate.Value,
                    Quantity = qty,
                    Customer_Name = textBoxCustomerName.Text.Trim(),
                    MedicineId = ((Medicine)comboBoxMedicine.SelectedItem).Id,
                    BatchId = ((Batch)comboBoxBatch.SelectedItem).Batch_Id,
                    Price = CalculatePriceForSelectedBatch(qty)
                };

                _service.AddSale(newSale);

                UpdateSaleList();
                UpdateBatchList();
                MessageBox.Show("Sale completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding sale record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxSa_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBoxSa.SelectedIndex == -1) return;

            var selectedSale = (Sale)listBoxSa.SelectedItem;
            if (selectedSale == null) return;

            dateTimePickerSaleDate.Value = selectedSale.Date_Of_Sale;

            for (int i = 0; i < comboBoxMedicine.Items.Count; i++)
            {
                if (((Medicine)comboBoxMedicine.Items[i]).Id == selectedSale.MedicineId)
                {
                    comboBoxMedicine.SelectedIndex = i;
                    break;
                }
            }

            UpdateBatchList();
            for (int i = 0; i < comboBoxBatch.Items.Count; i++)
            {
                if (((Batch)comboBoxBatch.Items[i]).Batch_Id == selectedSale.BatchId)
                {
                    comboBoxBatch.SelectedIndex = i;
                    break;
                }
            }

            AdjustQuantityLimitsForSelectedBatch();
            numericUpDownSaleQuantity.Value = Math.Max(numericUpDownSaleQuantity.Minimum, Math.Min(numericUpDownSaleQuantity.Maximum, selectedSale.Quantity));
            textBoxCustomerName.Text = selectedSale.Customer_Name ?? string.Empty;

            UpdatePriceDisplay();
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSa.SelectedIndex != -1)
            {
                var sale = (Sale)listBoxSa.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete the sale record for '{sale.Customer_Name}'? Stock will be returned.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteSale(sale.Sale_Id);
                        UpdateSaleList();
                        UpdateBatchList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting sale: {ex.Message}");
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSa.SelectedIndex != -1)
            {
                var selectedSale = (Sale)listBoxSa.SelectedItem;

                if (comboBoxBatch.SelectedIndex == -1) return;

                try
                {
                    selectedSale.Date_Of_Sale = dateTimePickerSaleDate.Value;
                    selectedSale.Quantity = (int)numericUpDownSaleQuantity.Value;
                    selectedSale.Customer_Name = textBoxCustomerName.Text.Trim();
                    selectedSale.MedicineId = ((Medicine)comboBoxMedicine.SelectedItem).Id;
                    selectedSale.BatchId = ((Batch)comboBoxBatch.SelectedItem).Batch_Id;

                    selectedSale.Price = CalculatePriceForSelectedBatch(selectedSale.Quantity);

                    _service.UpdateSale(selectedSale);
                    UpdateSaleList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void comboBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBatchList();
        }

        private void comboBoxBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustQuantityLimitsForSelectedBatch();
            UpdatePriceDisplay();
        }

        private void numericUpDownSaleQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceDisplay();
        }
    }
}