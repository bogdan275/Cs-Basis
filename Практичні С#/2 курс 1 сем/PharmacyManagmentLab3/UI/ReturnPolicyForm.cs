using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class ReturnPolicyForm : Form
    {
        private readonly ReturnPolicyService _service;

        public ReturnPolicyForm(ReturnPolicyService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ReturnPolicyForm_Load(object sender, EventArgs e)
        {
            UpdateReturnPolicyList();
            FillSales();
            if (comboBoxSale.Items.Count > 0) comboBoxSale.SelectedIndex = 0;
        }

        void UpdateReturnPolicyList()
        {
            listBoxRP.Items.Clear();
            listBoxRP.Items.AddRange(_service.GetAllPolicies().ToArray());
        }

        void FillSales()
        {
            comboBoxSale.Items.Clear();
            comboBoxSale.Items.AddRange(_service.GetAllSales().ToArray());
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            try
            {
                var newReturn = new Return_Policy
                {
                    Sale = (Sale)comboBoxSale.SelectedItem,
                    Reason = textBoxReason.Text,
                    Signature1 = textBoxSign1.Text,
                    Signature2 = textBoxSign2.Text,
                    Pasport_Data = textBoxPassportData.Text,
                    Can_Return = checkBoxCanReturn.Checked
                };

                _service.AddReturnPolicy(newReturn);
                UpdateReturnPolicyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRP.SelectedIndex != -1)
            {
                var selectedReturn = (Return_Policy)listBoxRP.SelectedItem;

                var dialogResult = MessageBox.Show("Are you sure you want to delete the selected return policy?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteReturnPolicy(selectedReturn.Return_Policy_Id);
                        UpdateReturnPolicyList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting policy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonUpdateRec_Click(object sender, EventArgs e)
        {
            if (listBoxRP.SelectedIndex != -1)
            {
                try
                {
                    var selectedReturn = (Return_Policy)listBoxRP.SelectedItem;

                    selectedReturn.Sale = (Sale)comboBoxSale.SelectedItem;
                    selectedReturn.Reason = textBoxReason.Text;
                    selectedReturn.Signature1 = textBoxSign1.Text;
                    selectedReturn.Signature2 = textBoxSign2.Text;
                    selectedReturn.Pasport_Data = textBoxPassportData.Text;
                    selectedReturn.Can_Return = checkBoxCanReturn.Checked;

                    _service.UpdateReturnPolicy(selectedReturn);
                    UpdateReturnPolicyList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the return policy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}