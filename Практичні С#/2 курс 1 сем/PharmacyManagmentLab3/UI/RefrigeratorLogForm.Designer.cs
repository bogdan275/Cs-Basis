namespace UI
{
    partial class RefrigeratorLogForm
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
            listBoxRL = new ListBox();
            comboBoxLogRefrigerator = new ComboBox();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            label3 = new Label();
            numericUpDownMin = new NumericUpDown();
            numericUpDownMax = new NumericUpDown();
            numericUpDownCurrent = new NumericUpDown();
            label4 = new Label();
            dateTimePickerLogDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrent).BeginInit();
            SuspendLayout();
            // 
            // listBoxRL
            // 
            listBoxRL.Dock = DockStyle.Left;
            listBoxRL.FormattingEnabled = true;
            listBoxRL.Location = new Point(0, 0);
            listBoxRL.Name = "listBoxRL";
            listBoxRL.Size = new Size(476, 450);
            listBoxRL.TabIndex = 1;
            // 
            // comboBoxLogRefrigerator
            // 
            comboBoxLogRefrigerator.FormattingEnabled = true;
            comboBoxLogRefrigerator.Location = new Point(626, 210);
            comboBoxLogRefrigerator.Name = "comboBoxLogRefrigerator";
            comboBoxLogRefrigerator.Size = new Size(151, 28);
            comboBoxLogRefrigerator.TabIndex = 103;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(482, 113);
            Frige.Name = "Frige";
            Frige.Size = new Size(143, 20);
            Frige.TabIndex = 102;
            Frige.Text = "Current temperature";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 61);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 100;
            label2.Text = "Max. temperature";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 99;
            label1.Text = "Min. temperature";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(626, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 98;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(511, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 97;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(511, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 96;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 210);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 108;
            label3.Text = "Refrigerator";
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Location = new Point(626, 12);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(151, 27);
            numericUpDownMin.TabIndex = 109;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Location = new Point(626, 61);
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(151, 27);
            numericUpDownMax.TabIndex = 110;
            // 
            // numericUpDownCurrent
            // 
            numericUpDownCurrent.Location = new Point(626, 113);
            numericUpDownCurrent.Name = "numericUpDownCurrent";
            numericUpDownCurrent.Size = new Size(151, 27);
            numericUpDownCurrent.TabIndex = 111;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 165);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 112;
            label4.Text = "Log date";
            // 
            // dateTimePickerLogDate
            // 
            dateTimePickerLogDate.Location = new Point(626, 165);
            dateTimePickerLogDate.Name = "dateTimePickerLogDate";
            dateTimePickerLogDate.Size = new Size(151, 27);
            dateTimePickerLogDate.TabIndex = 113;
            // 
            // RefrigeratorLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerLogDate);
            Controls.Add(label4);
            Controls.Add(numericUpDownCurrent);
            Controls.Add(numericUpDownMax);
            Controls.Add(numericUpDownMin);
            Controls.Add(label3);
            Controls.Add(comboBoxLogRefrigerator);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxRL);
            Name = "RefrigeratorLogForm";
            Text = "RefrigeratorLogForm";
            Load += RefrigeratorLogForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRL;
        private TextBox textBoxDoctorPhone;
        private TextBox textBoxDoctorName;
        private ComboBox comboBoxLogRefrigerator;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private Label label3;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownMax;
        private NumericUpDown numericUpDownCurrent;
        private Label label4;
        private DateTimePicker dateTimePickerLogDate;
    }
}