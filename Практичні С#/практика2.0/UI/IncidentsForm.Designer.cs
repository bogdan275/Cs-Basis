namespace UI
{
    partial class IncidentsForm
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
            listBox1 = new ListBox();
            textBoxTitle = new TextBox();
            label8 = new Label();
            label5 = new Label();
            comboBoxPriority = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            richTextBoxDescription = new RichTextBox();
            comboBoxService = new ComboBox();
            label7 = new Label();
            comboBoxSeverity = new ComboBox();
            label9 = new Label();
            comboBoxEmployee = new ComboBox();
            label23 = new Label();
            comboBoxActionAuthor = new ComboBox();
            richTextBoxRootCause = new RichTextBox();
            richTextBoxSolution = new RichTextBox();
            label10 = new Label();
            richTextBoxRecomendations = new RichTextBox();
            dateTimePickerDetectedAt = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            textBoxResolovedDate = new TextBox();
            buttonResolove = new Button();
            buttonAsign = new Button();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(364, 473);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(387, 43);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(151, 27);
            textBoxTitle.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 20);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 40;
            label8.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 180);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 37;
            label5.Text = "Priority";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(387, 203);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(151, 28);
            comboBoxPriority.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 73);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 35;
            label4.Text = "Service";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 234);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 51;
            label1.Text = "Status";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(387, 257);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 295);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 52;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 181);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 53;
            label3.Text = "Solution";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 73);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 54;
            label6.Text = "Root cause";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(387, 318);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(151, 82);
            richTextBoxDescription.TabIndex = 55;
            richTextBoxDescription.Text = "";
            // 
            // comboBoxService
            // 
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Location = new Point(387, 95);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(151, 28);
            comboBoxService.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 126);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 58;
            label7.Text = "Severity";
            // 
            // comboBoxSeverity
            // 
            comboBoxSeverity.FormattingEnabled = true;
            comboBoxSeverity.Location = new Point(387, 149);
            comboBoxSeverity.Name = "comboBoxSeverity";
            comboBoxSeverity.Size = new Size(151, 28);
            comboBoxSeverity.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 20);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 60;
            label9.Text = "Assigned employee";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(544, 42);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(151, 28);
            comboBoxEmployee.TabIndex = 59;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(713, 126);
            label23.Name = "label23";
            label23.Size = new Size(99, 20);
            label23.TabIndex = 62;
            label23.Text = "Action author";
            // 
            // comboBoxActionAuthor
            // 
            comboBoxActionAuthor.FormattingEnabled = true;
            comboBoxActionAuthor.Location = new Point(713, 150);
            comboBoxActionAuthor.Name = "comboBoxActionAuthor";
            comboBoxActionAuthor.Size = new Size(250, 28);
            comboBoxActionAuthor.TabIndex = 61;
            // 
            // richTextBoxRootCause
            // 
            richTextBoxRootCause.Location = new Point(544, 96);
            richTextBoxRootCause.Name = "richTextBoxRootCause";
            richTextBoxRootCause.Size = new Size(151, 82);
            richTextBoxRootCause.TabIndex = 63;
            richTextBoxRootCause.Text = "";
            // 
            // richTextBoxSolution
            // 
            richTextBoxSolution.Location = new Point(544, 204);
            richTextBoxSolution.Name = "richTextBoxSolution";
            richTextBoxSolution.Size = new Size(151, 82);
            richTextBoxSolution.TabIndex = 64;
            richTextBoxSolution.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(544, 295);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 65;
            label10.Text = "Recomendations";
            // 
            // richTextBoxRecomendations
            // 
            richTextBoxRecomendations.Location = new Point(544, 318);
            richTextBoxRecomendations.Name = "richTextBoxRecomendations";
            richTextBoxRecomendations.Size = new Size(151, 82);
            richTextBoxRecomendations.TabIndex = 66;
            richTextBoxRecomendations.Text = "";
            // 
            // dateTimePickerDetectedAt
            // 
            dateTimePickerDetectedAt.Location = new Point(713, 43);
            dateTimePickerDetectedAt.Name = "dateTimePickerDetectedAt";
            dateTimePickerDetectedAt.Size = new Size(250, 27);
            dateTimePickerDetectedAt.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(713, 20);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 68;
            label11.Text = "Detected at";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(713, 73);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 69;
            label12.Text = "Resoloved at";
            // 
            // textBoxResolovedDate
            // 
            textBoxResolovedDate.Enabled = false;
            textBoxResolovedDate.Location = new Point(713, 96);
            textBoxResolovedDate.Name = "textBoxResolovedDate";
            textBoxResolovedDate.Size = new Size(250, 27);
            textBoxResolovedDate.TabIndex = 70;
            // 
            // buttonResolove
            // 
            buttonResolove.Location = new Point(841, 202);
            buttonResolove.Name = "buttonResolove";
            buttonResolove.Size = new Size(122, 29);
            buttonResolove.TabIndex = 72;
            buttonResolove.Text = "Resolove";
            buttonResolove.UseVisualStyleBackColor = true;
            buttonResolove.Click += buttonResolove_Click;
            // 
            // buttonAsign
            // 
            buttonAsign.Location = new Point(713, 204);
            buttonAsign.Name = "buttonAsign";
            buttonAsign.Size = new Size(122, 29);
            buttonAsign.TabIndex = 71;
            buttonAsign.Text = "Asign";
            buttonAsign.UseVisualStyleBackColor = true;
            buttonAsign.Click += buttonAsign_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(841, 429);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(122, 29);
            buttonDelate.TabIndex = 73;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(544, 429);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(151, 29);
            buttonUpdate.TabIndex = 75;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(387, 429);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(151, 29);
            buttonAdd.TabIndex = 74;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // IncidentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 473);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelate);
            Controls.Add(buttonResolove);
            Controls.Add(buttonAsign);
            Controls.Add(textBoxResolovedDate);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dateTimePickerDetectedAt);
            Controls.Add(richTextBoxRecomendations);
            Controls.Add(label10);
            Controls.Add(richTextBoxSolution);
            Controls.Add(richTextBoxRootCause);
            Controls.Add(label23);
            Controls.Add(comboBoxActionAuthor);
            Controls.Add(label9);
            Controls.Add(comboBoxEmployee);
            Controls.Add(label7);
            Controls.Add(comboBoxSeverity);
            Controls.Add(comboBoxService);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxTitle);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(comboBoxPriority);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Name = "IncidentsForm";
            Text = "IncidentsForm";
            Load += IncidentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBoxTitle;
        private Label label8;
        private Label label5;
        private ComboBox comboBoxPriority;
        private Label label4;
        private Label label1;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label label3;
        private Label label6;
        private RichTextBox richTextBoxDescription;
        private ComboBox comboBoxService;
        private Label label7;
        private ComboBox comboBoxSeverity;
        private Label label9;
        private ComboBox comboBoxEmployee;
        private Label label23;
        private ComboBox comboBoxActionAuthor;
        private RichTextBox richTextBoxRootCause;
        private RichTextBox richTextBoxSolution;
        private Label label10;
        private RichTextBox richTextBoxRecomendations;
        private DateTimePicker dateTimePickerDetectedAt;
        private Label label11;
        private Label label12;
        private TextBox textBoxResolovedDate;
        private Button buttonResolove;
        private Button buttonAsign;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
    }
}