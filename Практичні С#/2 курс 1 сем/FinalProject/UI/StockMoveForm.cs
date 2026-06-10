using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class StockMoveForm : Form
    {
        private readonly ServiceManager _manager;

        public StockMoveForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void StockMoveForm_Load(object sender, EventArgs e)
        {
            numericUpDownReciveQ.Minimum = 1;
            numericUpDownReciveQ.Maximum = 10000;

            if (numericUpDownShipQ != null)
                numericUpDownShipQ.Minimum = 1;

            if (numericUpDownRelocateQ != null)
                numericUpDownRelocateQ.Minimum = 1;

            LoadAllCombos();
            UpdateHistory();
        }

        void LoadAllCombos()
        {
            var products = _manager.ProductService.GetAll().ToArray();
            var bins = _manager.StorageBinService.GetAll().ToArray();

            void SetupBox(ComboBox box, object[] data)
            {
                if (box == null) return;
                box.Items.Clear();
                box.Items.AddRange(data);
                if (box.Items.Count > 0) box.SelectedIndex = 0;
            }

            SetupBox(comboBoxReciveProduct, products);
            SetupBox(comboBoxReciveTo, bins);

            SetupBox(comboBoxShipProduct, products);
            SetupBox(comboBoxShipFrom, bins);

            SetupBox(comboBoxRelocateProduct, products);
            SetupBox(comboBoxRelocateFrom, bins);
            SetupBox(comboBoxRelocateTo, bins);
        }

        void UpdateHistory()
        {
            var moves = _manager.StockMovementService.GetAll();

            var gridData = moves.Select(m => new
            {
                ID = m.Id,
                Date = m.MovementDate.ToShortDateString(),
                Type = m.Type,
                Product = m.Product?.Name ?? "Unknown Product",
                Qty = m.Quantity,
                From = m.FromBin?.Code ?? "-",
                To = m.ToBin?.Code ?? "-"
            }).ToList();

            gridHistory.DataSource = gridData;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxReciveProduct.SelectedItem == null)
                {
                    throw new Exception("Please select a Product!");
                }
                if (comboBoxReciveTo.SelectedItem == null)
                {
                    throw new Exception("Please select a Destination Bin!");
                }

                var prod = (Product)comboBoxReciveProduct.SelectedItem;
                var bin = (StorageBin)comboBoxReciveTo.SelectedItem;
                int qty = (int)numericUpDownReciveQ.Value;

                _manager.InventoryItemService.ReceiveStock(prod.Id, bin.Id, qty);

                MessageBox.Show("Stock Received Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numericUpDownReciveQ.Value = 1;
                UpdateHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Receive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxShipProduct.SelectedItem == null)
                {
                    throw new Exception("Please select a Product!");
                }
                if (comboBoxShipFrom.SelectedItem == null)
                {
                    throw new Exception("Please select a Source Bin!");
                }

                var prod = (Product)comboBoxShipProduct.SelectedItem;
                var binFrom = (StorageBin)comboBoxShipFrom.SelectedItem;

                int qty = (int)(numericUpDownShipQ != null ? numericUpDownShipQ.Value : numericUpDownReciveQ.Value);

                _manager.InventoryItemService.ShipStock(prod.Id, binFrom.Id, qty);

                MessageBox.Show("Stock Shipped Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (numericUpDownShipQ != null)
                {
                    numericUpDownShipQ.Value = 1;
                }
                UpdateHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Shipment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRelocateProduct.SelectedItem == null)
                {
                    throw new Exception("Please select a Product!");
                }
                if (comboBoxRelocateFrom.SelectedItem == null)
                { 
                        throw new Exception("Please select a Source Bin!");
                }
                if (comboBoxRelocateTo.SelectedItem == null)
                {
                    throw new Exception("Please select a Destination Bin!");
                }

                var prod = (Product)comboBoxRelocateProduct.SelectedItem;
                var binFrom = (StorageBin)comboBoxRelocateFrom.SelectedItem;
                var binTo = (StorageBin)comboBoxRelocateTo.SelectedItem;

                int qty = (int)(numericUpDownRelocateQ != null ? numericUpDownRelocateQ.Value : numericUpDownReciveQ.Value);

                if (binFrom.Id == binTo.Id)
                {
                    throw new Exception("Source and Destination bins cannot be the same!");
                }

                _manager.InventoryItemService.RelocateStock(prod.Id, binFrom.Id, binTo.Id, qty);

                MessageBox.Show("Stock Relocated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (numericUpDownRelocateQ != null)
                {
                    numericUpDownRelocateQ.Value = 1;
                }
                UpdateHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Relocation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}