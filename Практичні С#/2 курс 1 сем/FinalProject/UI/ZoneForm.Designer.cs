namespace UI
{
    partial class ZoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWarehouse = new ComboBox();
            label3 = new Label();
            labelPhone = new Label();
            label1 = new Label();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            txtName = new TextBox();
            listBoxZones = new ListBox();
            numericUpDownCost = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWarehouse
            // 
            comboBoxWarehouse.FormattingEnabled = true;
            comboBoxWarehouse.Location = new Point(601, 86);
            comboBoxWarehouse.Name = "comboBoxWarehouse";
            comboBoxWarehouse.Size = new Size(196, 28);
            comboBoxWarehouse.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 117);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 51;
            label3.Text = "Cost";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(601, 9);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(49, 20);
            labelPhone.TabIndex = 49;
            labelPhone.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 48;
            label1.Text = "Warehouse";
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(703, 417);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 47;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(703, 365);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 46;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(601, 365);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 45;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(601, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 27);
            txtName.TabIndex = 44;
            // 
            // listBoxZones
            // 
            listBoxZones.Dock = DockStyle.Left;
            listBoxZones.FormattingEnabled = true;
            listBoxZones.Location = new Point(0, 0);
            listBoxZones.Name = "listBoxZones";
            listBoxZones.Size = new Size(478, 450);
            listBoxZones.TabIndex = 43;
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.Location = new Point(601, 140);
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(196, 27);
            numericUpDownCost.TabIndex = 63;
            // 
            // ZoneForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownCost);
            Controls.Add(comboBoxWarehouse);
            Controls.Add(label3);
            Controls.Add(labelPhone);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(txtName);
            Controls.Add(listBoxZones);
            Name = "ZoneForm";
            Text = "ZoneForm";
            Load += ZoneForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxWarehouse;
        private Label label3;
        private Label labelPhone;
        private Label label1;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox txtName;
        private ListBox listBoxZones;
        private NumericUpDown numericUpDownCost;
    }
}