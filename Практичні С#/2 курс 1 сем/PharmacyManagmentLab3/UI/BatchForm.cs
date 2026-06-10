using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services; 

namespace UI
{
    public partial class BatchForm : Form
    {
        private readonly BatchService _service;

        public BatchForm(BatchService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void BatchForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdateBatchList();
        }

        private void LoadComboBoxes()
        {
            comboBoxBatchMedicine.Items.Clear();
            comboBoxBatchMedicine.Items.AddRange(_service.GetMedicines().ToArray());
            comboBoxBatchMedicine.SelectedIndex = 0;

            comboBoxOrder.Items.Clear();
            comboBoxOrder.Items.AddRange(_service.GetOrders().ToArray());
            comboBoxOrder.SelectedIndex = 0;

            comboBoxBatchRefrigerator.Items.Clear();
            comboBoxBatchRefrigerator.Items.AddRange(_service.GetRefrigerators().ToArray());
            comboBoxBatchRefrigerator.SelectedIndex = 0;
        }

        void UpdateBatchList()
        {
            listBoxBa.Items.Clear();
            listBoxBa.Items.AddRange(_service.GetAllBatches().ToArray());
        }

        private void buttonDelateAI_Click(object sender, EventArgs e)
        {
            if (listBoxBa.SelectedIndex != -1)
            {
                var batch = (Batch)listBoxBa.SelectedItem;
                var dialogResult = MessageBox.Show($"Delete '{batch.Batch_Num}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteBatch(batch.Batch_Id);
                        UpdateBatchList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonAddAI_Click(object sender, EventArgs e)
        {
            try
            {
                var newBatch = new Batch
                {
                    Batch_Num = textBoxBatchNum.Text.Trim(),
                    Arrival_Date = dateTimePickerArrivalDate.Value,
                    Expiri_Date = dateTimePickerExpiriDate.Value,
                    Stock_Quantity = (int)numericUpDownStockQuantity.Value,
                    MedicineId = ((Medicine)comboBoxBatchMedicine.SelectedItem).Id,
                    Purchase_OrderId = ((Purchase_Order)comboBoxOrder.SelectedItem).Purchase_Order_Id,
                    RefrigeratorId = ((Refrigerator)comboBoxBatchRefrigerator.SelectedItem).Refrigerator_Id
                };

                _service.AddBatch(newBatch);

                UpdateBatchList();
                MessageBox.Show("Batch added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateAi_Click(object sender, EventArgs e)
        {
            if (listBoxBa.SelectedIndex != -1)
            {
                try
                {
                    var selectedBatch = (Batch)listBoxBa.SelectedItem;

                    selectedBatch.Batch_Num = textBoxBatchNum.Text.Trim();
                    selectedBatch.Arrival_Date = dateTimePickerArrivalDate.Value;
                    selectedBatch.Expiri_Date = dateTimePickerExpiriDate.Value;
                    selectedBatch.Stock_Quantity = (int)numericUpDownStockQuantity.Value;
                    selectedBatch.MedicineId = ((Medicine)comboBoxBatchMedicine.SelectedItem).Id;
                    selectedBatch.Purchase_OrderId = ((Purchase_Order)comboBoxOrder.SelectedItem).Purchase_Order_Id;
                    selectedBatch.RefrigeratorId = ((Refrigerator)comboBoxBatchRefrigerator.SelectedItem).Refrigerator_Id;

                    _service.UpdateBatch(selectedBatch);

                    UpdateBatchList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}