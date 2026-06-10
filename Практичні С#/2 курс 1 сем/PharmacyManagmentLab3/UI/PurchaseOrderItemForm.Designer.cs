namespace UI
{
    partial class PurchaseOrderItemForm
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
            listBoxPOI = new ListBox();
            comboBoxPOIMedicine = new ComboBox();
            comboBoxPOIPurchase = new ComboBox();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddAI = new Button();
            buttonDelateAI = new Button();
            buttonUpdateAi = new Button();
            numericUpDownPOIQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPOIQuantity).BeginInit();
            SuspendLayout();
            // 
            // listBoxPOI
            // 
            listBoxPOI.Dock = DockStyle.Left;
            listBoxPOI.FormattingEnabled = true;
            listBoxPOI.Location = new Point(0, 0);
            listBoxPOI.Name = "listBoxPOI";
            listBoxPOI.Size = new Size(476, 450);
            listBoxPOI.TabIndex = 1;
            // 
            // comboBoxPOIMedicine
            // 
            comboBoxPOIMedicine.FormattingEnabled = true;
            comboBoxPOIMedicine.Location = new Point(622, 119);
            comboBoxPOIMedicine.Name = "comboBoxPOIMedicine";
            comboBoxPOIMedicine.Size = new Size(151, 28);
            comboBoxPOIMedicine.TabIndex = 81;
            // 
            // comboBoxPOIPurchase
            // 
            comboBoxPOIPurchase.FormattingEnabled = true;
            comboBoxPOIPurchase.Location = new Point(622, 67);
            comboBoxPOIPurchase.Name = "comboBoxPOIPurchase";
            comboBoxPOIPurchase.Size = new Size(151, 28);
            comboBoxPOIPurchase.TabIndex = 80;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(507, 119);
            Frige.Name = "Frige";
            Frige.Size = new Size(70, 20);
            Frige.TabIndex = 79;
            Frige.Text = "Medicine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 67);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 77;
            label2.Text = "Purchase";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 76;
            label1.Text = "Quantity";
            // 
            // buttonAddAI
            // 
            buttonAddAI.Location = new Point(622, 359);
            buttonAddAI.Name = "buttonAddAI";
            buttonAddAI.Size = new Size(103, 29);
            buttonAddAI.TabIndex = 75;
            buttonAddAI.Text = "Add";
            buttonAddAI.UseVisualStyleBackColor = true;
            buttonAddAI.Click += buttonAddAI_Click;
            // 
            // buttonDelateAI
            // 
            buttonDelateAI.Location = new Point(507, 359);
            buttonDelateAI.Name = "buttonDelateAI";
            buttonDelateAI.Size = new Size(103, 29);
            buttonDelateAI.TabIndex = 74;
            buttonDelateAI.Text = "Delate";
            buttonDelateAI.UseVisualStyleBackColor = true;
            buttonDelateAI.Click += buttonDelateAI_Click;
            // 
            // buttonUpdateAi
            // 
            buttonUpdateAi.Location = new Point(507, 409);
            buttonUpdateAi.Name = "buttonUpdateAi";
            buttonUpdateAi.Size = new Size(103, 29);
            buttonUpdateAi.TabIndex = 73;
            buttonUpdateAi.Text = "Update";
            buttonUpdateAi.UseVisualStyleBackColor = true;
            buttonUpdateAi.Click += buttonUpdateAi_Click;
            // 
            // numericUpDownPOIQuantity
            // 
            numericUpDownPOIQuantity.Location = new Point(622, 18);
            numericUpDownPOIQuantity.Name = "numericUpDownPOIQuantity";
            numericUpDownPOIQuantity.Size = new Size(150, 27);
            numericUpDownPOIQuantity.TabIndex = 82;
            // 
            // PurchaseOrderItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownPOIQuantity);
            Controls.Add(comboBoxPOIMedicine);
            Controls.Add(comboBoxPOIPurchase);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddAI);
            Controls.Add(buttonDelateAI);
            Controls.Add(buttonUpdateAi);
            Controls.Add(listBoxPOI);
            Name = "PurchaseOrderItemForm";
            Text = "PurchaseOrderItemForm";
            Load += PurchaseOrderItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPOIQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPOI;
        private ComboBox comboBoxPOIMedicine;
        private ComboBox comboBoxPOIPurchase;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button buttonAddAI;
        private Button buttonDelateAI;
        private Button buttonUpdateAi;
        private NumericUpDown numericUpDownPOIQuantity;
    }
}