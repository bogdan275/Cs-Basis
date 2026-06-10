using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class ProductForm : Form
    {
        private readonly ServiceManager _manager;

        public ProductForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            numLength.DecimalPlaces = 3;
            numWidth.DecimalPlaces = 3;
            numHeight.DecimalPlaces = 3;
            numWeight.DecimalPlaces = 3;

            numWeight.Minimum = 1;
            numHeight.Minimum = 1;
            numLength.Minimum = 1;
            numWidth.Minimum = 1;

            LoadComboBoxes();
            UpdateProductList();
        }

        void UpdateProductList()
        {
            listBoxProducts.Items.Clear();
            listBoxProducts.Items.AddRange(_manager.ProductService.GetAll().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxClient.Items.Clear();
            comboBoxClient.Items.AddRange(_manager.ClientService.GetAll().ToArray());
            if (comboBoxClient.Items.Count > 0)
            {
                comboBoxClient.SelectedIndex = 0;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Client (Owner)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Name = txtName.Text;
                string SKU = txtSKU.Text;
                decimal Length = numLength.Value;
                decimal Width = numWidth.Value;
                decimal Height = numHeight.Value;
                decimal Weight = numWeight.Value;
                string Description = textBoxDescription.Text;
                int ClientId = ((Client)comboBoxClient.SelectedItem).Id;

                _manager.ProductService.Create(Name, SKU, Description,  Length, Width, Height, Weight, ClientId);

                UpdateProductList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;

                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nПодробиці (Inner): {ex.InnerException.Message}";
                }

                MessageBox.Show($"Не вдалося додати товар:\n{errorMessage}", "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex == -1 || listBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedProduct = (Product)listBoxProducts.SelectedItem;

                if (comboBoxClient.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Client!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Name = txtName.Text;
                string SKU = txtSKU.Text;
                decimal Length = numLength.Value;
                decimal Width = numWidth.Value;
                decimal Height = numHeight.Value;
                decimal Weight = numWeight.Value;
                string Description = textBoxDescription.Text;
                int ClientId = ((Client)comboBoxClient.SelectedItem).Id;

                _manager.ProductService.Update(selectedProduct, Name, SKU, Description, Length, Width, Height, Weight, ClientId);

                UpdateProductList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                var selectedProduct = (Product)listBoxProducts.SelectedItem;

                var result = MessageBox.Show($"Delete product '{selectedProduct.Name}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.ProductService.Delete(selectedProduct.Id);

                        UpdateProductList();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                var item = (Product)listBoxProducts.SelectedItem;

                txtName.Text = item.Name;
                txtSKU.Text = item.SKU;
                numLength.Value = item.Length;
                numWidth.Value = item.Width;
                numHeight.Value = item.Height;
                numWeight.Value = item.Weight;

                foreach (Client c in comboBoxClient.Items)
                {
                    if (c.Id == item.ClientId)
                    {
                        comboBoxClient.SelectedItem = c;
                        break;
                    }
                }
            }
        }

        void ClearInputs()
        {
            txtName.Clear();
            txtSKU.Clear();

            numLength.Value = 1;
            numWidth.Value = 1;
            numHeight.Value = 1;
            numWeight.Value = 1;

            listBoxProducts.SelectedIndex = -1;

            if (comboBoxClient.Items.Count > 0)
            {
                comboBoxClient.SelectedIndex = 0;
            }
        }
    }
}