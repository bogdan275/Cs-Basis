using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class MedicineForm : Form
    {
        private readonly MedicineService _service;

        public MedicineForm(MedicineService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdateMedicineList();
        }

        void UpdateMedicineList()
        {
            listBoxMe.Items.Clear();
            listBoxMe.Items.AddRange(_service.GetAllMedicines().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxBrand.Items.Clear();
            comboBoxBrand.Items.AddRange(_service.GetAllBrands().ToArray());
            comboBoxBrand.SelectedIndex = 0;

            comboBoxIngredient.Items.Clear();
            comboBoxIngredient.Items.AddRange(_service.GetAllIngredients().ToArray());
            comboBoxIngredient.SelectedIndex = 0;

            comboBoxSeason.Items.Clear();
            comboBoxSeason.Items.AddRange(new object[] { "Year-round", "Winter", "Spring/Fall", "Summer" });
            comboBoxSeason.SelectedIndex = 0;

            comboBoxReleaseForm.Items.Clear();
            comboBoxReleaseForm.Items.AddRange(new object[] { "Tablet", "Capsule", "Syrup", "Injection", "Ointment", "Drops" });
            comboBoxReleaseForm.SelectedIndex = 0;
        }

        private void buttonAddAI_Click(object sender, EventArgs e)
        {
            try
            {
                var medicine = new Medicine
                {
                    Name = textBoxMedicineName.Text.Trim(),
                    Storage_Conditions = textBoxMedicineStorage.Text.Trim(),
                    Is_Child_form = checkBoxIsChild.Checked,
                    Seasonal_Status = comboBoxSeason.SelectedItem.ToString(),
                    Dosage = (int)numericUpDownDosage.Value,
                    Release_Form = comboBoxReleaseForm.SelectedItem.ToString(),
                    Brand = (Brand)comboBoxBrand.SelectedItem,
                    Active_Ingredient = (Active_Ingredient)comboBoxIngredient.SelectedItem,
                    Prescription_Required = checkBoxNeedPrescription.Checked
                };

                _service.AddMedicine(medicine);
                UpdateMedicineList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateAI_Click(object sender, EventArgs e)
        {
            if (listBoxMe.SelectedIndex != -1)
            {
                var medicine = (Medicine)listBoxMe.SelectedItem;

                var dialogResult = MessageBox.Show($"Are you sure you want to delete '{medicine.Name}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteMedicine(medicine.Id);
                        UpdateMedicineList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateAi_Click(object sender, EventArgs e)
        {
            if (listBoxMe.SelectedIndex != -1)
            {
                try
                {
                    var selectedMedicine = (Medicine)listBoxMe.SelectedItem;

                    selectedMedicine.Name = textBoxMedicineName.Text.Trim();
                    selectedMedicine.Storage_Conditions = textBoxMedicineStorage.Text.Trim();
                    selectedMedicine.Is_Child_form = checkBoxIsChild.Checked;
                    selectedMedicine.Seasonal_Status = comboBoxSeason.SelectedItem.ToString();
                    selectedMedicine.Dosage = (int)numericUpDownDosage.Value;
                    selectedMedicine.Release_Form = comboBoxReleaseForm.SelectedItem.ToString();
                    selectedMedicine.Brand = (Brand)comboBoxBrand.SelectedItem;
                    selectedMedicine.Active_Ingredient = (Active_Ingredient)comboBoxIngredient.SelectedItem;
                    selectedMedicine.Prescription_Required = checkBoxNeedPrescription.Checked;

                    _service.UpdateMedicine(selectedMedicine);
                    UpdateMedicineList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}