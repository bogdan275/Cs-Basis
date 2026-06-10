namespace UI
{
    partial class TariffForm
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
            listBoxTariffs = new ListBox();
            textBoxTName = new TextBox();
            numericUpDownTPrice = new NumericUpDown();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDownHandling = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHandling).BeginInit();
            SuspendLayout();
            // 
            // listBoxTariffs
            // 
            listBoxTariffs.Dock = DockStyle.Left;
            listBoxTariffs.FormattingEnabled = true;
            listBoxTariffs.Location = new Point(0, 0);
            listBoxTariffs.Name = "listBoxTariffs";
            listBoxTariffs.Size = new Size(478, 450);
            listBoxTariffs.TabIndex = 0;
            listBoxTariffs.SelectedIndexChanged += listBoxTariffs_SelectedIndexChanged_1;
            // 
            // textBoxTName
            // 
            textBoxTName.Location = new Point(579, 57);
            textBoxTName.Name = "textBoxTName";
            textBoxTName.Size = new Size(196, 27);
            textBoxTName.TabIndex = 1;
            // 
            // numericUpDownTPrice
            // 
            numericUpDownTPrice.Location = new Point(579, 122);
            numericUpDownTPrice.Name = "numericUpDownTPrice";
            numericUpDownTPrice.Size = new Size(196, 27);
            numericUpDownTPrice.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(579, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(681, 345);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(681, 397);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 5;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 99);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 152);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 8;
            label3.Text = "Handling fee per unit";
            // 
            // numericUpDownHandling
            // 
            numericUpDownHandling.Location = new Point(579, 175);
            numericUpDownHandling.Name = "numericUpDownHandling";
            numericUpDownHandling.Size = new Size(196, 27);
            numericUpDownHandling.TabIndex = 9;
            // 
            // TariffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownHandling);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownTPrice);
            Controls.Add(textBoxTName);
            Controls.Add(listBoxTariffs);
            Name = "TariffForm";
            Text = "TariffForm";
            Load += TariffForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHandling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTariffs;
        private TextBox textBoxTName;
        private NumericUpDown numericUpDownTPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelate;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownHandling;
    }
}