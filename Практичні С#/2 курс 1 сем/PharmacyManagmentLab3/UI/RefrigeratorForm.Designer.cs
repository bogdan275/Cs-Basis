namespace UI
{
    partial class RefrigeratorForm
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
            listBoxRe = new ListBox();
            textBoxRefrigeratorName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            SuspendLayout();
            // 
            // listBoxRe
            // 
            listBoxRe.Dock = DockStyle.Left;
            listBoxRe.FormattingEnabled = true;
            listBoxRe.Location = new Point(0, 0);
            listBoxRe.Name = "listBoxRe";
            listBoxRe.Size = new Size(476, 450);
            listBoxRe.TabIndex = 1;
            // 
            // textBoxRefrigeratorName
            // 
            textBoxRefrigeratorName.Location = new Point(621, 135);
            textBoxRefrigeratorName.Name = "textBoxRefrigeratorName";
            textBoxRefrigeratorName.Size = new Size(151, 27);
            textBoxRefrigeratorName.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 61);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 135);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 99;
            label1.Text = "Name";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(621, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 98;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(506, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 97;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(506, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 96;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // RefrigeratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRefrigeratorName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxRe);
            Name = "RefrigeratorForm";
            Text = "RefrigeratorForm";
            Load += RefrigeratorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRe;
        private TextBox textBoxDoctorPhone;
        private TextBox textBoxRefrigeratorName;
        private CheckBox checkBox1;
        private ComboBox comboBoxRecMedicine;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
    }
}