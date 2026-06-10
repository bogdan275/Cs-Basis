namespace UI
{
    partial class ReturnPolicyForm
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
            listBoxRP = new ListBox();
            label4 = new Label();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            Reason = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            textBoxReason = new TextBox();
            textBoxSign1 = new TextBox();
            textBoxSign2 = new TextBox();
            textBoxPassportData = new TextBox();
            checkBoxCanReturn = new CheckBox();
            comboBoxSale = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxRP
            // 
            listBoxRP.Dock = DockStyle.Left;
            listBoxRP.FormattingEnabled = true;
            listBoxRP.Location = new Point(0, 0);
            listBoxRP.Name = "listBoxRP";
            listBoxRP.Size = new Size(476, 450);
            listBoxRP.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 165);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 126;
            label4.Text = "Pasport data";
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(522, 113);
            Frige.Name = "Frige";
            Frige.Size = new Size(50, 20);
            Frige.TabIndex = 120;
            Frige.Text = "Sign 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(522, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 61);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 118;
            label2.Text = "Sign 1";
            // 
            // Reason
            // 
            Reason.AutoSize = true;
            Reason.Location = new Point(522, 12);
            Reason.Name = "Reason";
            Reason.RightToLeft = RightToLeft.No;
            Reason.Size = new Size(57, 20);
            Reason.TabIndex = 117;
            Reason.Text = "Reason";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(637, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 116;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(522, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 115;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(522, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 114;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(637, 12);
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(151, 27);
            textBoxReason.TabIndex = 127;
            // 
            // textBoxSign1
            // 
            textBoxSign1.Location = new Point(637, 61);
            textBoxSign1.Name = "textBoxSign1";
            textBoxSign1.Size = new Size(151, 27);
            textBoxSign1.TabIndex = 128;
            // 
            // textBoxSign2
            // 
            textBoxSign2.Location = new Point(637, 113);
            textBoxSign2.Name = "textBoxSign2";
            textBoxSign2.Size = new Size(151, 27);
            textBoxSign2.TabIndex = 129;
            // 
            // textBoxPassportData
            // 
            textBoxPassportData.Location = new Point(637, 165);
            textBoxPassportData.Name = "textBoxPassportData";
            textBoxPassportData.Size = new Size(151, 27);
            textBoxPassportData.TabIndex = 130;
            // 
            // checkBoxCanReturn
            // 
            checkBoxCanReturn.AutoSize = true;
            checkBoxCanReturn.Location = new Point(637, 261);
            checkBoxCanReturn.Name = "checkBoxCanReturn";
            checkBoxCanReturn.Size = new Size(106, 24);
            checkBoxCanReturn.TabIndex = 131;
            checkBoxCanReturn.Text = "Can return?";
            checkBoxCanReturn.UseVisualStyleBackColor = true;
            // 
            // comboBoxSale
            // 
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Location = new Point(637, 213);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(151, 28);
            comboBoxSale.TabIndex = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 213);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 133;
            label1.Text = "Sale";
            // 
            // ReturnPolicyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBoxSale);
            Controls.Add(checkBoxCanReturn);
            Controls.Add(textBoxPassportData);
            Controls.Add(textBoxSign2);
            Controls.Add(textBoxSign1);
            Controls.Add(textBoxReason);
            Controls.Add(label4);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(Reason);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxRP);
            Name = "ReturnPolicyForm";
            Text = "ReturnPolicyForm";
            Load += ReturnPolicyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRP;
        private Label label4;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label Reason;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private TextBox textBoxReason;
        private TextBox textBoxSign1;
        private TextBox textBoxSign2;
        private TextBox textBox2;
        private TextBox textBoxPassportData;
        private CheckBox checkBoxCanReturn;
        private ComboBox comboBoxSale;
        private Label label1;
    }
}