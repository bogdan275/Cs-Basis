using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class ShelfForm : Form
    {
        private readonly ShelfService _service;

        public ShelfForm(ShelfService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ShelfForm_Load(object sender, EventArgs e)
        {
            UpdateShelfList();
            numericUpShelfNumber.Minimum = 1;
            numericUpDownRowNumber.Minimum = 1;
        }

        void UpdateShelfList()
        {
            listBoxSh.Items.Clear();
            listBoxSh.Items.AddRange(_service.GetAllShelves().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                var newShelf = new Shelf
                {
                    Zone = textBoxShelfZone.Text.Trim(),
                    RowNumber = (int)numericUpDownRowNumber.Value,
                    ShelfNumber = (int)numericUpShelfNumber.Value
                };

                _service.AddShelf(newShelf);
                UpdateShelfList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSh.SelectedIndex != -1)
            {
                var shelf = (Shelf)listBoxSh.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete shelf '{shelf.ShelfId}'?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteShelf(shelf.ShelfId);
                        UpdateShelfList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting shelf: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxSh.SelectedIndex != -1)
            {
                try
                {
                    var selectedShelf = (Shelf)listBoxSh.SelectedItem;

                    selectedShelf.Zone = textBoxShelfZone.Text.Trim();
                    selectedShelf.RowNumber = (int)numericUpDownRowNumber.Value;
                    selectedShelf.ShelfNumber = (int)numericUpShelfNumber.Value;

                    _service.UpdateShelf(selectedShelf);
                    UpdateShelfList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating shelf: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}