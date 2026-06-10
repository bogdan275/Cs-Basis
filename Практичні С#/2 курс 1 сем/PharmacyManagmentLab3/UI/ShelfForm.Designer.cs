namespace UI
{
    partial class ShelfForm
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
            listBoxSh = new ListBox();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            Reason = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            textBoxShelfZone = new TextBox();
            numericUpShelfNumber = new NumericUpDown();
            numericUpDownRowNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpShelfNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRowNumber).BeginInit();
            SuspendLayout();
            // 
            // listBoxSh
            // 
            listBoxSh.Dock = DockStyle.Left;
            listBoxSh.FormattingEnabled = true;
            listBoxSh.Location = new Point(0, 0);
            listBoxSh.Name = "listBoxSh";
            listBoxSh.Size = new Size(476, 450);
            listBoxSh.TabIndex = 1;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(509, 195);
            Frige.Name = "Frige";
            Frige.Size = new Size(93, 20);
            Frige.TabIndex = 160;
            Frige.Text = "Row number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 159;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 145);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 158;
            label2.Text = "Shelf number";
            // 
            // Reason
            // 
            Reason.AutoSize = true;
            Reason.Location = new Point(509, 94);
            Reason.Name = "Reason";
            Reason.RightToLeft = RightToLeft.No;
            Reason.Size = new Size(43, 20);
            Reason.TabIndex = 157;
            Reason.Text = "Zone";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(624, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 156;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(509, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 155;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(509, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 154;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // textBoxShelfZone
            // 
            textBoxShelfZone.Location = new Point(624, 94);
            textBoxShelfZone.Name = "textBoxShelfZone";
            textBoxShelfZone.Size = new Size(151, 27);
            textBoxShelfZone.TabIndex = 162;
            // 
            // numericUpShelfNumber
            // 
            numericUpShelfNumber.Location = new Point(624, 145);
            numericUpShelfNumber.Name = "numericUpShelfNumber";
            numericUpShelfNumber.Size = new Size(150, 27);
            numericUpShelfNumber.TabIndex = 163;
            // 
            // numericUpDownRowNumber
            // 
            numericUpDownRowNumber.Location = new Point(624, 195);
            numericUpDownRowNumber.Name = "numericUpDownRowNumber";
            numericUpDownRowNumber.Size = new Size(150, 27);
            numericUpDownRowNumber.TabIndex = 164;
            // 
            // ShelfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownRowNumber);
            Controls.Add(numericUpShelfNumber);
            Controls.Add(textBoxShelfZone);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(Reason);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxSh);
            Name = "ShelfForm";
            Text = "ShelfForm";
            Load += ShelfForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpShelfNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRowNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSh;
        private ComboBox comboBoxBatch;
        private Label label3;
        private NumericUpDown numericUpDownSalePrice;
        private NumericUpDown numericUpDownSaleQuantity;
        private DateTimePicker dateTimePickerSaleDate;
        private Label label1;
        private ComboBox comboBoxMedicine;
        private Label label4;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label Reason;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private TextBox textBoxShelfZone;
        private NumericUpDown numericUpShelfNumber;
        private NumericUpDown numericUpDownRowNumber;
    }
}