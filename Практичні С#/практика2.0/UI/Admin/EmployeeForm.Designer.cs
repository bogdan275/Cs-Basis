namespace UI
{
    partial class EmployeeForm
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
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDelate = new Button();
            comboBoxSpecialization = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            Department = new Label();
            comboBoxDepartment = new ComboBox();
            textBoxFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            listBoxEmployees = new ListBox();
            label8 = new Label();
            textBoxPosition = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(653, 429);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(122, 29);
            buttonUpdate.TabIndex = 104;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(397, 429);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(122, 29);
            buttonAdd.TabIndex = 103;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(525, 429);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(122, 29);
            buttonDelate.TabIndex = 102;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(397, 318);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(151, 28);
            comboBoxSpecialization.TabIndex = 90;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 126);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 89;
            label7.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 295);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 83;
            label2.Text = "Specialization";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(397, 234);
            Department.Name = "Department";
            Department.Size = new Size(89, 20);
            Department.TabIndex = 82;
            Department.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(397, 257);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(151, 28);
            comboBoxDepartment.TabIndex = 81;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(397, 43);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(151, 27);
            textBoxFullName.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 180);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 79;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 73);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 77;
            label4.Text = "Position";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Dock = DockStyle.Left;
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.Location = new Point(0, 0);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(364, 473);
            listBoxEmployees.TabIndex = 76;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 20);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 105;
            label8.Text = "Name";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(397, 96);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(151, 27);
            textBoxPosition.TabIndex = 106;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(397, 151);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 27);
            textBoxEmail.TabIndex = 107;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(397, 202);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(151, 27);
            textBoxPhone.TabIndex = 108;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 473);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPosition);
            Controls.Add(label8);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelate);
            Controls.Add(comboBoxSpecialization);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(Department);
            Controls.Add(comboBoxDepartment);
            Controls.Add(textBoxFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBoxEmployees);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDelate;
        private ComboBox comboBoxSpecialization;
        private Label label7;
        private Label label2;
        private Label Department;
        private ComboBox comboBoxDepartment;
        private TextBox textBoxFullName;
        private Label label5;
        private Label label4;
        private ListBox listBoxEmployees;
        private Label label8;
        private TextBox textBoxPosition;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
    }
}