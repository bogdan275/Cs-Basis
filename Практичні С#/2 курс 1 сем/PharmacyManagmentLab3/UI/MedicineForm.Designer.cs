namespace UI
{
    partial class MedicineForm
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
            listBoxMe = new ListBox();
            comboBoxSeason = new ComboBox();
            Frige = new Label();
            textBoxMedicineName = new TextBox();
            comboBoxBrand = new ComboBox();
            numericUpDownDosage = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddAI = new Button();
            buttonDelateAI = new Button();
            buttonUpdateAi = new Button();
            textBoxMedicineStorage = new TextBox();
            comboBoxIngredient = new ComboBox();
            checkBoxIsChild = new CheckBox();
            checkBoxNeedPrescription = new CheckBox();
            comboBoxReleaseForm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDosage).BeginInit();
            SuspendLayout();
            // 
            // listBoxMe
            // 
            listBoxMe.Dock = DockStyle.Left;
            listBoxMe.FormattingEnabled = true;
            listBoxMe.Location = new Point(0, 0);
            listBoxMe.Name = "listBoxMe";
            listBoxMe.Size = new Size(476, 594);
            listBoxMe.TabIndex = 1;
            // 
            // comboBoxSeason
            // 
            comboBoxSeason.FormattingEnabled = true;
            comboBoxSeason.Location = new Point(618, 164);
            comboBoxSeason.Name = "comboBoxSeason";
            comboBoxSeason.Size = new Size(151, 28);
            comboBoxSeason.TabIndex = 45;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(501, 318);
            Frige.Name = "Frige";
            Frige.Size = new Size(77, 20);
            Frige.TabIndex = 44;
            Frige.Text = "Ingredient";
            // 
            // textBoxMedicineName
            // 
            textBoxMedicineName.Location = new Point(617, 12);
            textBoxMedicineName.Name = "textBoxMedicineName";
            textBoxMedicineName.Size = new Size(151, 27);
            textBoxMedicineName.TabIndex = 41;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(616, 266);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(151, 28);
            comboBoxBrand.TabIndex = 39;
            // 
            // numericUpDownDosage
            // 
            numericUpDownDosage.Location = new Point(617, 113);
            numericUpDownDosage.Name = "numericUpDownDosage";
            numericUpDownDosage.Size = new Size(150, 27);
            numericUpDownDosage.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 61);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 37;
            label6.Text = "Storage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 164);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 36;
            label5.Text = "Season";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 113);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 35;
            label4.Text = "Dosage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 215);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 34;
            label3.Text = "Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 266);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 33;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 32;
            label1.Text = "Name";
            // 
            // buttonAddAI
            // 
            buttonAddAI.Location = new Point(618, 471);
            buttonAddAI.Name = "buttonAddAI";
            buttonAddAI.Size = new Size(103, 29);
            buttonAddAI.TabIndex = 31;
            buttonAddAI.Text = "Add";
            buttonAddAI.UseVisualStyleBackColor = true;
            buttonAddAI.Click += buttonAddAI_Click;
            // 
            // buttonDelateAI
            // 
            buttonDelateAI.Location = new Point(501, 471);
            buttonDelateAI.Name = "buttonDelateAI";
            buttonDelateAI.Size = new Size(103, 29);
            buttonDelateAI.TabIndex = 30;
            buttonDelateAI.Text = "Delate";
            buttonDelateAI.UseVisualStyleBackColor = true;
            buttonDelateAI.Click += buttonDelateAI_Click;
            // 
            // buttonUpdateAi
            // 
            buttonUpdateAi.Location = new Point(501, 507);
            buttonUpdateAi.Name = "buttonUpdateAi";
            buttonUpdateAi.Size = new Size(103, 29);
            buttonUpdateAi.TabIndex = 29;
            buttonUpdateAi.Text = "Update";
            buttonUpdateAi.UseVisualStyleBackColor = true;
            buttonUpdateAi.Click += buttonUpdateAi_Click;
            // 
            // textBoxMedicineStorage
            // 
            textBoxMedicineStorage.Location = new Point(617, 61);
            textBoxMedicineStorage.Name = "textBoxMedicineStorage";
            textBoxMedicineStorage.Size = new Size(151, 27);
            textBoxMedicineStorage.TabIndex = 46;
            // 
            // comboBoxIngredient
            // 
            comboBoxIngredient.FormattingEnabled = true;
            comboBoxIngredient.Location = new Point(616, 318);
            comboBoxIngredient.Name = "comboBoxIngredient";
            comboBoxIngredient.Size = new Size(151, 28);
            comboBoxIngredient.TabIndex = 47;
            // 
            // checkBoxIsChild
            // 
            checkBoxIsChild.AutoSize = true;
            checkBoxIsChild.Location = new Point(620, 370);
            checkBoxIsChild.Name = "checkBoxIsChild";
            checkBoxIsChild.Size = new Size(108, 24);
            checkBoxIsChild.TabIndex = 50;
            checkBoxIsChild.Text = "Child form?";
            checkBoxIsChild.UseVisualStyleBackColor = true;
            // 
            // checkBoxNeedPrescription
            // 
            checkBoxNeedPrescription.AutoSize = true;
            checkBoxNeedPrescription.Location = new Point(620, 416);
            checkBoxNeedPrescription.Name = "checkBoxNeedPrescription";
            checkBoxNeedPrescription.Size = new Size(157, 24);
            checkBoxNeedPrescription.TabIndex = 51;
            checkBoxNeedPrescription.Text = "Need prescription?";
            checkBoxNeedPrescription.UseVisualStyleBackColor = true;
            // 
            // comboBoxReleaseForm
            // 
            comboBoxReleaseForm.FormattingEnabled = true;
            comboBoxReleaseForm.Location = new Point(617, 215);
            comboBoxReleaseForm.Name = "comboBoxReleaseForm";
            comboBoxReleaseForm.Size = new Size(151, 28);
            comboBoxReleaseForm.TabIndex = 52;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(comboBoxReleaseForm);
            Controls.Add(checkBoxNeedPrescription);
            Controls.Add(checkBoxIsChild);
            Controls.Add(comboBoxIngredient);
            Controls.Add(textBoxMedicineStorage);
            Controls.Add(comboBoxSeason);
            Controls.Add(Frige);
            Controls.Add(textBoxMedicineName);
            Controls.Add(comboBoxBrand);
            Controls.Add(numericUpDownDosage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddAI);
            Controls.Add(buttonDelateAI);
            Controls.Add(buttonUpdateAi);
            Controls.Add(listBoxMe);
            Name = "MedicineForm";
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDosage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMe;
        private ComboBox comboBoxSeason;
        private Label Frige;
        private TextBox textBoxMedicineName;
        private TextBox textBoxBatchNum;
        private ComboBox comboBoxBrand;
        private NumericUpDown numericUpDownDosage;
        private NumericUpDown numericUpDownStockQuantity;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAddAI;
        private Button buttonDelateAI;
        private Button buttonUpdateAi;
        private TextBox textBoxMedicineStorage;
        private ComboBox comboBoxIngredient;
        private Label label7;
        private Label label8;
        private CheckBox checkBoxIsChild;
        private CheckBox checkBoxNeedPrescription;
        private ComboBox comboBoxReleaseForm;
    }
}