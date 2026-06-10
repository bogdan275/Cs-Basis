namespace UI
{
    partial class ShelfItemForm
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
            listBoxSI = new ListBox();
            buttonUpdateRec = new Button();
            buttonDelateRec = new Button();
            buttonAddRec = new Button();
            Reason = new Label();
            label2 = new Label();
            textBoxLocationHint = new TextBox();
            Frige = new Label();
            numericUpDownFaceCurrent = new NumericUpDown();
            numericUpDownFaceRequired = new NumericUpDown();
            label6 = new Label();
            dateTimePickerLastUpdated = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBoxShelf = new ComboBox();
            comboBoxMedicine = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFaceCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFaceRequired).BeginInit();
            SuspendLayout();
            // 
            // listBoxSI
            // 
            listBoxSI.Dock = DockStyle.Left;
            listBoxSI.FormattingEnabled = true;
            listBoxSI.Location = new Point(0, 0);
            listBoxSI.Name = "listBoxSI";
            listBoxSI.Size = new Size(476, 450);
            listBoxSI.TabIndex = 1;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(512, 396);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 165;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(512, 346);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 166;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(627, 346);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 167;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // Reason
            // 
            Reason.AutoSize = true;
            Reason.Location = new Point(512, 93);
            Reason.Name = "Reason";
            Reason.RightToLeft = RightToLeft.No;
            Reason.Size = new Size(88, 20);
            Reason.TabIndex = 168;
            Reason.Text = "Face current";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 45);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 169;
            label2.Text = "Face required";
            // 
            // textBoxLocationHint
            // 
            textBoxLocationHint.Location = new Point(627, 135);
            textBoxLocationHint.Name = "textBoxLocationHint";
            textBoxLocationHint.Size = new Size(151, 27);
            textBoxLocationHint.TabIndex = 172;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(512, 135);
            Frige.Name = "Frige";
            Frige.Size = new Size(95, 20);
            Frige.TabIndex = 171;
            Frige.Text = "Location hint";
            // 
            // numericUpDownFaceCurrent
            // 
            numericUpDownFaceCurrent.Location = new Point(628, 93);
            numericUpDownFaceCurrent.Name = "numericUpDownFaceCurrent";
            numericUpDownFaceCurrent.Size = new Size(150, 27);
            numericUpDownFaceCurrent.TabIndex = 174;
            // 
            // numericUpDownFaceRequired
            // 
            numericUpDownFaceRequired.Location = new Point(627, 45);
            numericUpDownFaceRequired.Name = "numericUpDownFaceRequired";
            numericUpDownFaceRequired.Size = new Size(150, 27);
            numericUpDownFaceRequired.TabIndex = 173;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 54);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 170;
            // 
            // dateTimePickerLastUpdated
            // 
            dateTimePickerLastUpdated.Location = new Point(628, 183);
            dateTimePickerLastUpdated.Name = "dateTimePickerLastUpdated";
            dateTimePickerLastUpdated.Size = new Size(150, 27);
            dateTimePickerLastUpdated.TabIndex = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 183);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 176;
            label1.Text = "Last updated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 235);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 177;
            label3.Text = "Shelf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 281);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 178;
            label4.Text = "Medicine";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBoxShelf
            // 
            comboBoxShelf.FormattingEnabled = true;
            comboBoxShelf.Location = new Point(626, 235);
            comboBoxShelf.Name = "comboBoxShelf";
            comboBoxShelf.Size = new Size(151, 28);
            comboBoxShelf.TabIndex = 179;
            // 
            // comboBoxMedicine
            // 
            comboBoxMedicine.FormattingEnabled = true;
            comboBoxMedicine.Location = new Point(626, 281);
            comboBoxMedicine.Name = "comboBoxMedicine";
            comboBoxMedicine.Size = new Size(151, 28);
            comboBoxMedicine.TabIndex = 180;
            // 
            // ShelfItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxMedicine);
            Controls.Add(comboBoxShelf);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePickerLastUpdated);
            Controls.Add(numericUpDownFaceCurrent);
            Controls.Add(numericUpDownFaceRequired);
            Controls.Add(textBoxLocationHint);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(Reason);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxSI);
            Name = "ShelfItemForm";
            Text = "ShelfItemForm";
            Load += ShelfItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownFaceCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFaceRequired).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSI;
        private Button buttonUpdateRec;
        private Button buttonDelateRec;
        private Button buttonAddRec;
        private Label Reason;
        private Label label2;
        private TextBox textBoxLocationHint;
        private Label Frige;
        private NumericUpDown numericUpDownFaceCurrent;
        private NumericUpDown numericUpDownFaceRequired;
        private Label label6;
        private DateTimePicker dateTimePickerLastUpdated;
        private Label label1;
        private Label label3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxShelf;
        private ComboBox comboBoxMedicine;
    }
}