using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace UI.Main
{
    partial class ServiceCategoriesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxCategories = new ListBox();
            txtName = new TextBox();
            label1 = new Label();
            rtbDesc = new RichTextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBoxCategories
            // 
            listBoxCategories.Dock = DockStyle.Left;
            listBoxCategories.Location = new Point(0, 0);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(200, 350);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 2;
            label1.Text = "Service category name*";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(220, 107);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(250, 100);
            rtbDesc.TabIndex = 3;
            rtbDesc.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 85);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 4;
            label2.Text = "Category description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(216, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(346, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(216, 265);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // ServiceCategoriesForm
            // 
            ClientSize = new Size(520, 350);
            Controls.Add(listBoxCategories);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(rtbDesc);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "ServiceCategoriesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Service Category Management";
            Load += ServiceCategoriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxCategories;
        private TextBox txtName;
        private Label label1;
        private RichTextBox rtbDesc;
        private Label label2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}