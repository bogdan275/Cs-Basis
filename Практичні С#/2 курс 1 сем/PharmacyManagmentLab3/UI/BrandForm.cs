using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class BrandForm : Form
    {
        private readonly BrandService _service;

        public BrandForm(BrandService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            UpdateBrandList();
        }

        void UpdateBrandList()
        {
            listBoxBr.Items.Clear();
            listBoxBr.Items.AddRange(_service.GetAllBrands().ToArray());
        }

        private void buttonDelateBrand_Click(object sender, EventArgs e)
        {
            if (listBoxBr.SelectedIndex != -1)
            {
                var brand = (Brand)listBoxBr.SelectedItem;
                var dialogResult = MessageBox.Show($"Are you sure you want to delete '{brand.Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteBrand(brand.Id);
                        UpdateBrandList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            var newBrandName = textBoxBrandName.Text.Trim();

            try
            {
                _service.AddBrand(newBrandName);
                textBoxBrandName.Clear();
                UpdateBrandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateBrand_Click(object sender, EventArgs e)
        {
            if (listBoxBr.SelectedIndex != -1)
            {
                var selectedBrand = (Brand)listBoxBr.SelectedItem;
                var updatedName = textBoxBrandName.Text.Trim();

                try
                {
                    _service.UpdateBrand(selectedBrand, updatedName);
                    textBoxBrandName.Clear();
                    UpdateBrandList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}