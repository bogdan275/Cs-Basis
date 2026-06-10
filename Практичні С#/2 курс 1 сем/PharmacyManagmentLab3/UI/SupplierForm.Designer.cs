namespace UI
{
    partial class SupplierForm
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
            listBoxSu = new ListBox();
            label1 = new Label();
            textBoxSupplierName = new TextBox();
            Frige = new Label();
            label6 = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            textBoxSupplierPhone = new TextBox();
            SuspendLayout();
            // 
            // listBoxSu
            // 
            listBoxSu.Dock = DockStyle.Left;
            listBoxSu.FormattingEnabled = true;
            listBoxSu.Location = new Point(0, 0);
            listBoxSu.Name = "listBoxSu";
            listBoxSu.Size = new Size(476, 450);
            listBoxSu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 150);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 192;
            label1.Text = "Phone";
            // 
            // textBoxSupplierName
            // 
            textBoxSupplierName.Location = new Point(624, 102);
            textBoxSupplierName.Name = "textBoxSupplierName";
            textBoxSupplierName.Size = new Size(151, 27);
            textBoxSupplierName.TabIndex = 188;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(509, 102);
            Frige.Name = "Frige";
            Frige.Size = new Size(49, 20);
            Frige.TabIndex = 187;
            Frige.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 21);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 186;
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(625, 355);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 183;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(510, 355);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 182;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(510, 405);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 181;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // textBoxSupplierPhone
            // 
            textBoxSupplierPhone.Location = new Point(625, 150);
            textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            textBoxSupplierPhone.Size = new Size(151, 27);
            textBoxSupplierPhone.TabIndex = 193;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSupplierPhone);
            Controls.Add(label1);
            Controls.Add(textBoxSupplierName);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxSu);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSu;
        private Label label1;
        private TextBox textBoxSupplierName;
        private Label Frige;
        private Label label6;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private TextBox textBoxSupplierPhone;
    }
}