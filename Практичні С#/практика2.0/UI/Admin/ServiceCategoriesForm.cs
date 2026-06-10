using System;
using System.Linq;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI.Main
{
    public partial class ServiceCategoriesForm : Form
    {
        private readonly ServiceManager _manager;

        public ServiceCategoriesForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void ServiceCategoriesForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxCategories.Items.Clear();
            listBoxCategories.Items.AddRange(_manager.ServiceCategoryService.GetAllCategories().ToArray());
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is ServiceCategory category)
            {
                txtName.Text = category.CategoryName;
                rtbDesc.Text = category.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.ServiceCategoryService.AddCategory(txtName.Text, rtbDesc.Text);
                RefreshList();
                MessageBox.Show("Category added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is ServiceCategory category)
            {
                try
                {
                    _manager.ServiceCategoryService.UpdateCategory(category, txtName.Text, rtbDesc.Text);
                    RefreshList();
                    MessageBox.Show("Category updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem is ServiceCategory category)
            {
                var result = MessageBox.Show($"Delete category '{category.CategoryName}'? Note: This may fail if services are linked to it.",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.ServiceCategoryService.DeleteCategory(category.CategoryId);
                        RefreshList();
                        txtName.Clear();
                        rtbDesc.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show($"Deletion failed: {ex.Message}", "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}