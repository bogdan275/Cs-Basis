namespace UI
{
    partial class PurchaseOrderForm
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
            listBoxPO = new ListBox();
            comboBoxPOSupplier = new ComboBox();
            comboBoxPOStatus = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            buttonAddAI = new Button();
            buttonDelateAI = new Button();
            buttonUpdateAi = new Button();
            Frige = new Label();
            label2 = new Label();
            dateTimePickerPODate = new DateTimePicker();
            SuspendLayout();
            // 
            // listBoxPO
            // 
            listBoxPO.Dock = DockStyle.Left;
            listBoxPO.FormattingEnabled = true;
            listBoxPO.Location = new Point(0, 0);
            listBoxPO.Name = "listBoxPO";
            listBoxPO.Size = new Size(476, 457);
            listBoxPO.TabIndex = 1;
            // 
            // comboBoxPOSupplier
            // 
            comboBoxPOSupplier.FormattingEnabled = true;
            comboBoxPOSupplier.Location = new Point(614, 110);
            comboBoxPOSupplier.Name = "comboBoxPOSupplier";
            comboBoxPOSupplier.Size = new Size(151, 28);
            comboBoxPOSupplier.TabIndex = 71;
            // 
            // comboBoxPOStatus
            // 
            comboBoxPOStatus.FormattingEnabled = true;
            comboBoxPOStatus.Location = new Point(614, 58);
            comboBoxPOStatus.Name = "comboBoxPOStatus";
            comboBoxPOStatus.Size = new Size(151, 28);
            comboBoxPOStatus.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 58);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 56;
            label1.Text = "Date";
            // 
            // buttonAddAI
            // 
            buttonAddAI.Location = new Point(616, 367);
            buttonAddAI.Name = "buttonAddAI";
            buttonAddAI.Size = new Size(103, 29);
            buttonAddAI.TabIndex = 55;
            buttonAddAI.Text = "Add";
            buttonAddAI.UseVisualStyleBackColor = true;
            buttonAddAI.Click += buttonAddAI_Click;
            // 
            // buttonDelateAI
            // 
            buttonDelateAI.Location = new Point(499, 367);
            buttonDelateAI.Name = "buttonDelateAI";
            buttonDelateAI.Size = new Size(103, 29);
            buttonDelateAI.TabIndex = 54;
            buttonDelateAI.Text = "Delate";
            buttonDelateAI.UseVisualStyleBackColor = true;
            buttonDelateAI.Click += buttonDelateAI_Click;
            // 
            // buttonUpdateAi
            // 
            buttonUpdateAi.Location = new Point(499, 421);
            buttonUpdateAi.Name = "buttonUpdateAi";
            buttonUpdateAi.Size = new Size(103, 29);
            buttonUpdateAi.TabIndex = 53;
            buttonUpdateAi.Text = "Update";
            buttonUpdateAi.UseVisualStyleBackColor = true;
            buttonUpdateAi.Click += buttonUpdateAi_Click;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(499, 110);
            Frige.Name = "Frige";
            Frige.Size = new Size(64, 20);
            Frige.TabIndex = 65;
            Frige.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 57;
            label2.Text = "Status";
            // 
            // dateTimePickerPODate
            // 
            dateTimePickerPODate.Location = new Point(614, 9);
            dateTimePickerPODate.Name = "dateTimePickerPODate";
            dateTimePickerPODate.Size = new Size(151, 27);
            dateTimePickerPODate.TabIndex = 72;
            // 
            // PurchaseOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(dateTimePickerPODate);
            Controls.Add(comboBoxPOSupplier);
            Controls.Add(comboBoxPOStatus);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddAI);
            Controls.Add(buttonDelateAI);
            Controls.Add(buttonUpdateAi);
            Controls.Add(listBoxPO);
            Name = "PurchaseOrderForm";
            Text = "PurchaseOrderForm";
            Load += PurchaseOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPO;
        private ComboBox comboBoxPOSupplier;
        private ComboBox comboBoxReleaseForm;
        private ComboBox comboBoxPOStatus;
        private Label label6;
        private Label label1;
        private Button buttonAddAI;
        private Button buttonDelateAI;
        private Button buttonUpdateAi;
        private Label Frige;
        private Label label2;
        private DateTimePicker dateTimePickerPODate;
    }
}