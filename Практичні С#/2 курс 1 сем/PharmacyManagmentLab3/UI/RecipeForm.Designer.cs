
namespace UI
{
    partial class RecipeForm
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
            listBoxRec = new ListBox();
            comboBoxRecMedicine = new ComboBox();
            Frige = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAddRec = new Button();
            buttonDelateRec = new Button();
            buttonUpdateRec = new Button();
            checkBox1 = new CheckBox();
            textBoxDoctorName = new TextBox();
            textBoxDoctorPhone = new TextBox();
            SuspendLayout();
            // 
            // listBoxRec
            // 
            listBoxRec.Dock = DockStyle.Left;
            listBoxRec.FormattingEnabled = true;
            listBoxRec.Location = new Point(0, 0);
            listBoxRec.Name = "listBoxRec";
            listBoxRec.Size = new Size(476, 450);
            listBoxRec.TabIndex = 1;
            // 
            // comboBoxRecMedicine
            // 
            comboBoxRecMedicine.FormattingEnabled = true;
            comboBoxRecMedicine.Location = new Point(621, 113);
            comboBoxRecMedicine.Name = "comboBoxRecMedicine";
            comboBoxRecMedicine.Size = new Size(151, 28);
            comboBoxRecMedicine.TabIndex = 91;
            // 
            // Frige
            // 
            Frige.AutoSize = true;
            Frige.Location = new Point(506, 113);
            Frige.Name = "Frige";
            Frige.Size = new Size(70, 20);
            Frige.TabIndex = 89;
            Frige.Text = "Medicine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 61);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 87;
            label2.Text = "Doctor phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 86;
            label1.Text = "Doctor name";
            // 
            // buttonAddRec
            // 
            buttonAddRec.Location = new Point(621, 353);
            buttonAddRec.Name = "buttonAddRec";
            buttonAddRec.Size = new Size(103, 29);
            buttonAddRec.TabIndex = 85;
            buttonAddRec.Text = "Add";
            buttonAddRec.UseVisualStyleBackColor = true;
            buttonAddRec.Click += buttonAddRec_Click;
            // 
            // buttonDelateRec
            // 
            buttonDelateRec.Location = new Point(506, 353);
            buttonDelateRec.Name = "buttonDelateRec";
            buttonDelateRec.Size = new Size(103, 29);
            buttonDelateRec.TabIndex = 84;
            buttonDelateRec.Text = "Delate";
            buttonDelateRec.UseVisualStyleBackColor = true;
            buttonDelateRec.Click += buttonDelateRec_Click;
            // 
            // buttonUpdateRec
            // 
            buttonUpdateRec.Location = new Point(506, 403);
            buttonUpdateRec.Name = "buttonUpdateRec";
            buttonUpdateRec.Size = new Size(103, 29);
            buttonUpdateRec.TabIndex = 83;
            buttonUpdateRec.Text = "Update";
            buttonUpdateRec.UseVisualStyleBackColor = true;
            buttonUpdateRec.Click += buttonUpdateRec_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(609, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 24);
            checkBox1.TabIndex = 93;
            checkBox1.Text = "Can use alternative?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.Location = new Point(621, 12);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(151, 27);
            textBoxDoctorName.TabIndex = 94;
            // 
            // textBoxDoctorPhone
            // 
            textBoxDoctorPhone.Location = new Point(621, 61);
            textBoxDoctorPhone.Name = "textBoxDoctorPhone";
            textBoxDoctorPhone.Size = new Size(151, 27);
            textBoxDoctorPhone.TabIndex = 95;
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDoctorPhone);
            Controls.Add(textBoxDoctorName);
            Controls.Add(checkBox1);
            Controls.Add(comboBoxRecMedicine);
            Controls.Add(Frige);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddRec);
            Controls.Add(buttonDelateRec);
            Controls.Add(buttonUpdateRec);
            Controls.Add(listBoxRec);
            Name = "RecipeForm";
            Text = "RecipeForm";
            Load += RecipeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListBox listBoxRec;
        private ComboBox comboBoxRecMedicine;
        private Label Frige;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button buttonAddRec;
        private Button buttonDelateRec;
        private Button buttonUpdateRec;
        private CheckBox checkBox1;
        private TextBox textBoxDoctorName;
        private TextBox textBoxDoctorPhone;
    }
}