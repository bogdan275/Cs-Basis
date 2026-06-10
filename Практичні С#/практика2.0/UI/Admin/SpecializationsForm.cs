using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI.Main
{
    public partial class SpecializationsForm : Form
    {
        private readonly ServiceManager _manager;

        public SpecializationsForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void SpecializationsForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxSpecs.Items.Clear();
            listBoxSpecs.Items.AddRange(_manager.SpecializationService.GetAllSpecializations().ToArray());
        }

        private void listBoxSpecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSpecs.SelectedItem is Specialization spec)
            {
                txtName.Text = spec.SpecializationName;
                rtbDesc.Text = spec.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.SpecializationService.AddSpecialization(txtName.Text, rtbDesc.Text);
                RefreshList();
                MessageBox.Show("Specialization added!", "Success");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxSpecs.SelectedItem is Specialization spec)
            {
                try
                {
                    _manager.SpecializationService.UpdateSpecialization(spec, txtName.Text, rtbDesc.Text);
                    RefreshList();
                    MessageBox.Show("Updated successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSpecs.SelectedItem is Specialization spec)
            {
                if (MessageBox.Show("Delete this specialization?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _manager.SpecializationService.DeleteSpecialization(spec.SpecializationId);
                        RefreshList();
                        txtName.Clear();
                        rtbDesc.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show("Cannot delete: check if employees use this specialization."); }
                }
            }
        }
    }
}