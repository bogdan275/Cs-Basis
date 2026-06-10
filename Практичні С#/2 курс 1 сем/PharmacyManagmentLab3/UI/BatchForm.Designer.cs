namespace UI
{
    partial class BatchForm
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
            listBoxBa = new ListBox();
            buttonAddAI = new Button();
            buttonDelateAI = new Button();
            buttonUpdateAi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDownStockQuantity = new NumericUpDown();
            comboBoxBatchRefrigerator = new ComboBox();
            comboBoxOrder = new ComboBox();
            textBoxBatchNum = new TextBox();
            dateTimePickerArrivalDate = new DateTimePicker();
            dateTimePickerExpiriDate = new DateTimePicker();
            Frige = new Label();
            comboBoxBatchMedicine = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).BeginInit();
            SuspendLayout();
            // 
            // listBoxBa
            // 
            listBoxBa.Dock = DockStyle.Left;
            listBoxBa.FormattingEnabled = true;
            listBoxBa.Location = new Point(0, 0);
            listBoxBa.Name = "listBoxBa";
            listBoxBa.Size = new Size(476, 450);
            listBoxBa.TabIndex = 1;
            // 
            // buttonAddAI
            // 
            buttonAddAI.Location = new Point(610, 373);
            buttonAddAI.Name = "buttonAddAI";
            buttonAddAI.Size = new Size(103, 29);
            buttonAddAI.TabIndex = 10;
            buttonAddAI.Text = "Add";
            buttonAddAI.UseVisualStyleBackColor = true;
            buttonAddAI.Click += buttonAddAI_Click;
            // 
            // buttonDelateAI
            // 
            buttonDelateAI.Location = new Point(493, 373);
            buttonDelateAI.Name = "buttonDelateAI";
            buttonDelateAI.Size = new Size(103, 29);
            buttonDelateAI.TabIndex = 9;
            buttonDelateAI.Text = "Delate";
            buttonDelateAI.UseVisualStyleBackColor = true;
            buttonDelateAI.Click += buttonDelateAI_Click;
            // 
            // buttonUpdateAi
            // 
            buttonUpdateAi.Location = new Point(493, 409);
            buttonUpdateAi.Name = "buttonUpdateAi";
            buttonUpdateAi.Size = new Size(103, 29);
            buttonUpdateAi.TabIndex = 8;
            buttonUpdateAi.Text = "Update";
            buttonUpdateAi.UseVisualStyleBackColor = true;
            buttonUpdateAi.Click += buttonUpdateAi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 11;
            label1.Text = "Num";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 266);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 12;
            label2.Text = "Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 215);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 13;
            label3.Text = "Medicine";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 164);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 14;
            label4.Text = "Stock quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 113);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 15;
            label5.Text = "Expiri date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 61);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 16;
            label6.Text = "Arrival date";
            // 
            // numericUpDownStockQuantity
            // 
            numericUpDownStockQuantity.Location = new Point(610, 164);
            numericUpDownStockQuantity.Name = "numericUpDownStockQuantity";
            numericUpDownStockQuantity.Size = new Size(150, 27);
            numericUpDownStockQuantity.TabIndex = 20;
            // 
            // comboBoxBatchRefrigerator
            // 
            comboBoxBatchRefrigerator.FormattingEnabled = true;
            comboBoxBatchRefrigerator.Location = new Point(609, 318);
            comboBoxBatchRefrigerator.Name = "comboBoxBatchRefrigerator";
            comboBoxBatchRefrigerator.Size = new Size(151, 28);
            comboBoxBatchRefrigerator.TabIndex = 22;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(609, 266);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(151, 28);
            comboBoxOrder.TabIndex = 23;
            // 
            // textBoxBatchNum
            // 
            textBoxBatchNum.Location = new Point(609, 12);
            textBoxBatchNum.Name = "textBoxBatchNum";
            textBoxBatchNum.Size = new Size(151, 27);
            textBoxBatchNum.TabIndex = 24;
            // 
            // dateTimePickerArrivalDate
            // 
            dateTimePickerArrivalDate.Location = new Point(609, 61);
            dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            dateTimePickerArrivalDate.Size = new Size(151, 27);
            dateTimePickerArrivalDate.TabIndex = 25;
            // 
            // dateTimePickerExpiriDate
            // 
            dateTimePickerExpiriDate.Location = new Point(610, 113);
            dateTimePickerExpiriDate.Name = "dateTimePickerExpiriDate";
            dateTimePickerExpiriDate.Size = new Size(151, 27);
            dateTimePickerExpiriDate.TabIndex = 26;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(493, 318);
            Frige.Name = "Frige";
            Frige.Size = new Size(51, 20);
            Frige.TabIndex = 27;
            Frige.Text = "Fridge";
            // 
            // comboBoxBatchMedicine
            // 
            comboBoxBatchMedicine.FormattingEnabled = true;
            comboBoxBatchMedicine.Location = new Point(610, 215);
            comboBoxBatchMedicine.Name = "comboBoxBatchMedicine";
            comboBoxBatchMedicine.Size = new Size(151, 28);
            comboBoxBatchMedicine.TabIndex = 28;
            // 
            // BatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxBatchMedicine);
            Controls.Add(Frige);
            Controls.Add(dateTimePickerExpiriDate);
            Controls.Add(dateTimePickerArrivalDate);
            Controls.Add(textBoxBatchNum);
            Controls.Add(comboBoxOrder);
            Controls.Add(comboBoxBatchRefrigerator);
            Controls.Add(numericUpDownStockQuantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddAI);
            Controls.Add(buttonDelateAI);
            Controls.Add(buttonUpdateAi);
            Controls.Add(listBoxBa);
            Name = "BatchForm";
            Text = "BatchForm";
            Load += BatchForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBa;
        private Button buttonAddAI;
        private Button buttonDelateAI;
        private Button buttonUpdateAi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDownStockQuantity;
        private ComboBox comboBox1;
        private ComboBox comboBoxBatchRefrigerator;
        private ComboBox comboBoxOrder;
        private TextBox textBoxBatchNum;
        private DateTimePicker dateTimePickerArrivalDate;
        private DateTimePicker dateTimePickerExpiriDate;
        private Label Frige;
        private ComboBox comboBoxBatchMedicine;
    }
}