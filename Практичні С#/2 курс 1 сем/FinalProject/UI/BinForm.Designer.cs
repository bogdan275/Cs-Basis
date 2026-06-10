namespace UI
{
    partial class BinForm
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
            numMaxWeight = new NumericUpDown();
            comboBoxZone = new ComboBox();
            label3 = new Label();
            labelPhone = new Label();
            label1 = new Label();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            txtName = new TextBox();
            listBoxBins = new ListBox();
            numMaxVol = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numMaxWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxVol).BeginInit();
            SuspendLayout();
            // 
            // numMaxWeight
            // 
            numMaxWeight.Location = new Point(603, 140);
            numMaxWeight.Name = "numMaxWeight";
            numMaxWeight.Size = new Size(196, 27);
            numMaxWeight.TabIndex = 73;
            // 
            // comboBoxZone
            // 
            comboBoxZone.FormattingEnabled = true;
            comboBoxZone.Location = new Point(603, 86);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(196, 28);
            comboBoxZone.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 117);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 71;
            label3.Text = "Max weight";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(603, 9);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(49, 20);
            labelPhone.TabIndex = 70;
            labelPhone.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(603, 63);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 69;
            label1.Text = "Zone";
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(705, 417);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 68;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(705, 365);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 67;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(603, 365);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 66;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(603, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 27);
            txtName.TabIndex = 65;
            // 
            // listBoxBins
            // 
            listBoxBins.Dock = DockStyle.Left;
            listBoxBins.FormattingEnabled = true;
            listBoxBins.Location = new Point(0, 0);
            listBoxBins.Name = "listBoxBins";
            listBoxBins.Size = new Size(478, 450);
            listBoxBins.TabIndex = 64;
            // 
            // numMaxVol
            // 
            numMaxVol.Location = new Point(603, 193);
            numMaxVol.Name = "numMaxVol";
            numMaxVol.Size = new Size(196, 27);
            numMaxVol.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 170);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 74;
            label2.Text = "Max vol";
            // 
            // BinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numMaxVol);
            Controls.Add(label2);
            Controls.Add(numMaxWeight);
            Controls.Add(comboBoxZone);
            Controls.Add(label3);
            Controls.Add(labelPhone);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(txtName);
            Controls.Add(listBoxBins);
            Name = "BinForm";
            Text = "BinForm";
            Load += BinForm_Load;
            ((System.ComponentModel.ISupportInitialize)numMaxWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxVol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMaxWeight;
        private ComboBox comboBoxZone;
        private Label label3;
        private Label labelPhone;
        private Label label1;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox txtName;
        private ListBox listBoxBins;
        private NumericUpDown numMaxVol;
        private Label label2;
    }
}