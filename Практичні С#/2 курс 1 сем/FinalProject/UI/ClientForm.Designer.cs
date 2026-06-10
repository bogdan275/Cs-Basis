
namespace UI
{
    partial class ClientForm
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
            this.labelPhone = new Label();
            label1 = new Label();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            listBoxClients = new ListBox();
            this.textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            comboBoxTariff = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(592, 99);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(50, 20);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(694, 397);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 13;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(694, 345);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(592, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(592, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(196, 27);
            textBoxName.TabIndex = 9;
            // 
            // listBoxClients
            // 
            listBoxClients.Dock = DockStyle.Left;
            listBoxClients.FormattingEnabled = true;
            listBoxClients.Location = new Point(0, 0);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(478, 450);
            listBoxClients.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new Point(592, 122);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(196, 27);
            this.textBoxPhone.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(592, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(196, 27);
            textBoxEmail.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 168);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 18;
            label3.Text = "Email";
            // 
            // comboBoxTariff
            // 
            comboBoxTariff.FormattingEnabled = true;
            comboBoxTariff.Location = new Point(592, 257);
            comboBoxTariff.Name = "comboBoxTariff";
            comboBoxTariff.Size = new Size(196, 28);
            comboBoxTariff.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 234);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 20;
            label2.Text = "Tariff";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(comboBoxTariff);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(this.textBoxPhone);
            Controls.Add(this.labelPhone);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(listBoxClients);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        private Label labelPhone;

        #endregion
        private Label label1;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBoxName;
        private ListBox listBoxClients;
        private TextBox textBoxPhone;
        private TextBox textBox1;
        private TextBox textBoxEmail;
        private Label label3;
        private ComboBox comboBoxTariff;
        private Label label2;
    }
}