namespace UI
{
    partial class SaleForm
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
            listBoxSa = new ListBox();
            label1 = new Label();
            comboBoxMedicine = new ComboBox();
            textBoxCustomerName = new TextBox();
            label4 = new Label();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            Reason = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            dateTimePickerSaleDate = new DateTimePicker();
            numericUpDownSaleQuantity = new NumericUpDown();
            label3 = new Label();
            comboBoxBatch = new ComboBox();
            labelPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleQuantity).BeginInit();
            SuspendLayout();
            // 
            // listBoxSa
            // 
            listBoxSa.Dock = DockStyle.Left;
            listBoxSa.FormattingEnabled = true;
            listBoxSa.Location = new Point(0, 0);
            listBoxSa.Name = "listBoxSa";
            listBoxSa.Size = new Size(476, 450);
            listBoxSa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 213);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 148;
            label1.Text = "Medicine";
            // 
            // comboBoxMedicine
            // 
            comboBoxMedicine.FormattingEnabled = true;
            comboBoxMedicine.Location = new Point(623, 213);
            comboBoxMedicine.Name = "comboBoxMedicine";
            comboBoxMedicine.Size = new Size(151, 28);
            comboBoxMedicine.TabIndex = 147;
            comboBoxMedicine.SelectedIndexChanged += comboBoxMedicine_SelectedIndexChanged;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(623, 113);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(151, 27);
            textBoxCustomerName.TabIndex = 144;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 165);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 141;
            label4.Text = "Price";
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(508, 113);
            Frige.Name = "Frige";
            Frige.Size = new Size(113, 20);
            Frige.TabIndex = 140;
            Frige.Text = "Customer name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 139;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 61);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 138;
            label2.Text = "Quantity";
            // 
            // Reason
            // 
            Reason.AutoSize = true;
            Reason.Location = new Point(508, 12);
            Reason.Name = "Reason";
            Reason.RightToLeft = RightToLeft.No;
            Reason.Size = new Size(45, 20);
            Reason.TabIndex = 137;
            Reason.Text = "Date ";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(623, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 136;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(508, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 135;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(508, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 134;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // dateTimePickerSaleDate
            // 
            dateTimePickerSaleDate.Location = new Point(623, 12);
            dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            dateTimePickerSaleDate.Size = new Size(151, 27);
            dateTimePickerSaleDate.TabIndex = 149;
            // 
            // numericUpDownSaleQuantity
            // 
            numericUpDownSaleQuantity.Location = new Point(623, 59);
            numericUpDownSaleQuantity.Name = "numericUpDownSaleQuantity";
            numericUpDownSaleQuantity.Size = new Size(151, 27);
            numericUpDownSaleQuantity.TabIndex = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 265);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 152;
            label3.Text = "Batch";
            // 
            // comboBoxBatch
            // 
            comboBoxBatch.FormattingEnabled = true;
            comboBoxBatch.Location = new Point(623, 265);
            comboBoxBatch.Name = "comboBoxBatch";
            comboBoxBatch.Size = new Size(151, 28);
            comboBoxBatch.TabIndex = 153;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(623, 165);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 20);
            labelPrice.TabIndex = 154;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrice);
            Controls.Add(comboBoxBatch);
            Controls.Add(label3);
            Controls.Add(numericUpDownSaleQuantity);
            Controls.Add(dateTimePickerSaleDate);
            Controls.Add(label1);
            Controls.Add(comboBoxMedicine);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label4);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(Reason);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxSa);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSa;
        private Label label1;
        private ComboBox comboBoxMedicine;
        private TextBox textBoxCustomerName;
        private Label label4;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label Reason;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private DateTimePicker dateTimePickerSaleDate;
        private NumericUpDown numericUpDownSaleQuantity;
        private Label label3;
        private ComboBox comboBoxBatch;
        private Label labelPrice;
    }
}