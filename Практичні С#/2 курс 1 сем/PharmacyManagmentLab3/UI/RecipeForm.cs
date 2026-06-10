using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class RecipeForm : Form
    {
        private readonly RecipeService _service;

        public RecipeForm(RecipeService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            UpdateRecipeList();
            FillMedicineComboBox();
            if (comboBoxRecMedicine.Items.Count > 0) comboBoxRecMedicine.SelectedIndex = 0;
        }

        void UpdateRecipeList()
        {
            listBoxRec.Items.Clear();
            listBoxRec.Items.AddRange(_service.GetAllRecipes().ToArray());
        }

        void FillMedicineComboBox()
        {
            comboBoxRecMedicine.Items.Clear();
            comboBoxRecMedicine.Items.AddRange(_service.GetAllMedicines().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                var recipe = new Recipe
                {
                    Doctor_Name = textBoxDoctorName.Text.Trim(),
                    Doctor_Phone = textBoxDoctorPhone.Text.Trim(),
                    Medicine = (Medicine)comboBoxRecMedicine.SelectedItem
                };

                _service.AddRecipe(recipe);
                UpdateRecipeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRec.SelectedIndex != -1)
            {
                var recipe = (Recipe)listBoxRec.SelectedItem;
                var dialogResult = MessageBox.Show($"Are you sure you want to delete the recipe by Dr. '{recipe.Doctor_Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteRecipe(recipe.Recipe_Id);
                        UpdateRecipeList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRec.SelectedIndex != -1)
            {
                try
                {
                    var selectedRecipe = (Recipe)listBoxRec.SelectedItem;

                    selectedRecipe.Doctor_Name = textBoxDoctorName.Text.Trim();
                    selectedRecipe.Doctor_Phone = textBoxDoctorPhone.Text.Trim();
                    selectedRecipe.Medicine = (Medicine)comboBoxRecMedicine.SelectedItem;

                    _service.UpdateRecipe(selectedRecipe);
                    UpdateRecipeList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}