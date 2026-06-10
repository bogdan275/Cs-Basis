using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class ShelfItemForm : Form
    {
        private readonly ShelfItemService _service;

        public ShelfItemForm(ShelfItemService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ShelfItemForm_Load(object sender, EventArgs e)
        {
            UpdateShelfItems();
            LoadMedicines();
            LoadShelfs();

            if (comboBoxShelf.Items.Count > 0) comboBoxShelf.SelectedIndex = 0;
            if (comboBoxMedicine.Items.Count > 0) comboBoxMedicine.SelectedIndex = 0;
        }

        void UpdateShelfItems()
        {
            listBoxSI.Items.Clear();
            listBoxSI.Items.AddRange(_service.GetAllShelfItems().ToArray());
        }

        void LoadMedicines()
        {
            comboBoxMedicine.Items.Clear();
            comboBoxMedicine.Items.AddRange(_service.GetAllMedicines().ToArray());
        }

        void LoadShelfs()
        {
            comboBoxShelf.Items.Clear();
            comboBoxShelf.Items.AddRange(_service.GetAllShelves().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                var newShelfItem = new Shelf_Item
                {
                    Face_Current = (int)numericUpDownFaceCurrent.Value,
                    Face_Required = (int)numericUpDownFaceRequired.Value,
                    Last_Updated = dateTimePickerLastUpdated.Value,
                    Location_Hint = textBoxLocationHint.Text,
                    Medicine = (Medicine)comboBoxMedicine.SelectedItem,
                    Shelf = (Shelf)comboBoxShelf.SelectedItem
                };

                _service.AddShelfItem(newShelfItem);
                UpdateShelfItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSI.SelectedIndex != -1)
            {
                var shelfItem = (Shelf_Item)listBoxSI.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete shelf item '{shelfItem.Shelf_Item_Id}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteShelfItem(shelfItem.Shelf_Item_Id);
                        UpdateShelfItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting item: {ex.Message}");
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSI.SelectedIndex != -1)
            {
                try
                {
                    var selectedShelfItem = (Shelf_Item)listBoxSI.SelectedItem;

                    selectedShelfItem.Face_Current = (int)numericUpDownFaceCurrent.Value;
                    selectedShelfItem.Face_Required = (int)numericUpDownFaceRequired.Value;
                    selectedShelfItem.Last_Updated = dateTimePickerLastUpdated.Value;
                    selectedShelfItem.Location_Hint = textBoxLocationHint.Text;
                    selectedShelfItem.Medicine = (Medicine)comboBoxMedicine.SelectedItem;
                    selectedShelfItem.Shelf = (Shelf)comboBoxShelf.SelectedItem;

                    _service.UpdateShelfItem(selectedShelfItem);
                    UpdateShelfItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the shelf item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}