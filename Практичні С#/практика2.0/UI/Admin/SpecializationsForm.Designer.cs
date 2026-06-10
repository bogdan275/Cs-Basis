using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace UI.Main
{
    partial class SpecializationsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxSpecs = new ListBox();
            txtName = new TextBox();
            label1 = new Label();
            rtbDesc = new RichTextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBoxSpecs
            // 
            listBoxSpecs.Dock = DockStyle.Left;
            listBoxSpecs.Location = new Point(0, 0);
            listBoxSpecs.Name = "listBoxSpecs";
            listBoxSpecs.Size = new Size(200, 350);
            listBoxSpecs.TabIndex = 0;
            listBoxSpecs.SelectedIndexChanged += listBoxSpecs_SelectedIndexChanged;
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
            label1.Size = new Size(149, 20);
            label1.TabIndex = 2;
            label1.Text = "Specialization name*";
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
            label2.Size = new Size(120, 20);
            label2.TabIndex = 4;
            label2.Text = "Skills description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(220, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(365, 230);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // SpecializationsForm
            // 
            ClientSize = new Size(500, 350);
            Controls.Add(listBoxSpecs);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(rtbDesc);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "SpecializationsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Specialization Management";
            Load += SpecializationsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxSpecs;
        private TextBox txtName;
        private Label label1;
        private RichTextBox rtbDesc;
        private Label label2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}