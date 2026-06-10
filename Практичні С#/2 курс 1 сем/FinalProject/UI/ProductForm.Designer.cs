namespace UI
{
    partial class ProductForm
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
            label2 = new Label();
            label3 = new Label();
            txtSKU = new TextBox();
            labelPhone = new Label();
            label1 = new Label();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            txtName = new TextBox();
            listBoxProducts = new ListBox();
            comboBoxClient = new ComboBox();
            numLength = new NumericUpDown();
            numHeight = new NumericUpDown();
            numWidth = new NumericUpDown();
            numWeight = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxDescription = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 169);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 32;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 115);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 30;
            label3.Text = "Client";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(598, 85);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(196, 27);
            txtSKU.TabIndex = 28;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(598, 62);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(36, 20);
            labelPhone.TabIndex = 27;
            labelPhone.Text = "SKU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 26;
            label1.Text = "Name";
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(700, 417);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 25;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(700, 365);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(598, 365);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 23;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(598, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 27);
            txtName.TabIndex = 22;
            // 
            // listBoxProducts
            // 
            listBoxProducts.Dock = DockStyle.Left;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(0, 0);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(478, 450);
            listBoxProducts.TabIndex = 21;
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(598, 138);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(196, 28);
            comboBoxClient.TabIndex = 33;
            // 
            // numLength
            // 
            numLength.Location = new Point(598, 192);
            numLength.Name = "numLength";
            numLength.Size = new Size(94, 27);
            numLength.TabIndex = 34;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(598, 245);
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(94, 27);
            numHeight.TabIndex = 35;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(700, 192);
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(94, 27);
            numWidth.TabIndex = 36;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(700, 245);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(94, 27);
            numWeight.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 169);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 38;
            label4.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 222);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 39;
            label5.Text = "Height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(700, 222);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 40;
            label6.Text = "Weight";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(598, 298);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(196, 27);
            textBoxDescription.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 275);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 42;
            label7.Text = "Description";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBoxDescription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numWeight);
            Controls.Add(numWidth);
            Controls.Add(numHeight);
            Controls.Add(numLength);
            Controls.Add(comboBoxClient);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtSKU);
            Controls.Add(labelPhone);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(txtName);
            Controls.Add(listBoxProducts);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBoxTariff;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox txtSKU;
        private Label labelPhone;
        private Label label1;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox txtName;
        private ListBox listBoxProducts;
        private ComboBox comboBoxClient;
        private NumericUpDown numLength;
        private NumericUpDown numHeight;
        private NumericUpDown numWidth;
        private NumericUpDown numWeight;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxDescription;
        private Label label7;
    }
}