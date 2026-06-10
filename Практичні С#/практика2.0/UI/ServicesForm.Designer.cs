namespace UI
{
    partial class ServicesForm
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
            textBoxName = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            comboBoxCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxType = new ComboBox();
            label4 = new Label();
            comboBoxCriticality = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBoxIsActive = new CheckBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBoxURL = new TextBox();
            textBoxNetworkAdress = new TextBox();
            numericUpDownPort = new NumericUpDown();
            comboBoxResponsibleEmployee = new ComboBox();
            comboBoxChekMethod = new ComboBox();
            numericUpDownInterval = new NumericUpDown();
            numericUpDownTimeout = new NumericUpDown();
            numericUpDownRetryCount = new NumericUpDown();
            numericUpDownExpectedStatusCode = new NumericUpDown();
            textBoxExpectedResponseContains = new TextBox();
            numericUpDownWarningResponseTime = new NumericUpDown();
            numericUpDownCriticalResponseTime = new NumericUpDown();
            numericUpDownMaxConsecutiveFailures = new NumericUpDown();
            numericUpDownMinUptimePercent = new NumericUpDown();
            label20 = new Label();
            comboBoxDependsOn = new ComboBox();
            label21 = new Label();
            comboBoxDependsType = new ComboBox();
            label22 = new Label();
            richTextBoxDependsDescription = new RichTextBox();
            richTextBoxServiceDesctiption = new RichTextBox();
            label24 = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelate = new Button();
            comboBoxActionAuthor = new ComboBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRetryCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExpectedStatusCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWarningResponseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCriticalResponseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxConsecutiveFailures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinUptimePercent).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(380, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(364, 658);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Name*";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(380, 85);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Category*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 116);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Service type*";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(380, 139);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 170);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Criticality*";
            // 
            // comboBoxCriticality
            // 
            comboBoxCriticality.FormattingEnabled = true;
            comboBoxCriticality.Location = new Point(380, 193);
            comboBoxCriticality.Name = "comboBoxCriticality";
            comboBoxCriticality.Size = new Size(151, 28);
            comboBoxCriticality.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 224);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Interval*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 277);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "Timeout*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 436);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 11;
            label7.Text = "Responsible employee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 490);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 12;
            label8.Text = "URL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(710, 10);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 13;
            label9.Text = "Description";
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Location = new Point(545, 513);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(82, 24);
            checkBoxIsActive.TabIndex = 14;
            checkBoxIsActive.Text = "IsActive";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(543, 62);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 15;
            label10.Text = "Network address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(543, 116);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 16;
            label11.Text = "Port";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(542, 170);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 17;
            label12.Text = "Check method*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(380, 330);
            label13.Name = "label13";
            label13.Size = new Size(90, 20);
            label13.TabIndex = 18;
            label13.Text = "Retry count*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(380, 383);
            label14.Name = "label14";
            label14.Size = new Size(149, 20);
            label14.TabIndex = 19;
            label14.Text = "Expected status code";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(543, 224);
            label15.Name = "label15";
            label15.Size = new Size(131, 20);
            label15.TabIndex = 20;
            label15.Text = "Response contains";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(543, 277);
            label16.Name = "label16";
            label16.Size = new Size(161, 20);
            label16.TabIndex = 21;
            label16.Text = "Warning response time";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(542, 330);
            label17.Name = "label17";
            label17.Size = new Size(152, 20);
            label17.TabIndex = 22;
            label17.Text = "Critical response time";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(543, 383);
            label18.Name = "label18";
            label18.Size = new Size(170, 20);
            label18.TabIndex = 23;
            label18.Text = "Max consecutive failures";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(545, 436);
            label19.Name = "label19";
            label19.Size = new Size(139, 20);
            label19.TabIndex = 24;
            label19.Text = "Min uptime percent";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(380, 513);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(151, 27);
            textBoxURL.TabIndex = 26;
            // 
            // textBoxNetworkAdress
            // 
            textBoxNetworkAdress.Location = new Point(543, 85);
            textBoxNetworkAdress.Name = "textBoxNetworkAdress";
            textBoxNetworkAdress.Size = new Size(151, 27);
            textBoxNetworkAdress.TabIndex = 27;
            // 
            // numericUpDownPort
            // 
            numericUpDownPort.Location = new Point(544, 139);
            numericUpDownPort.Name = "numericUpDownPort";
            numericUpDownPort.Size = new Size(150, 27);
            numericUpDownPort.TabIndex = 28;
            // 
            // comboBoxResponsibleEmployee
            // 
            comboBoxResponsibleEmployee.FormattingEnabled = true;
            comboBoxResponsibleEmployee.Location = new Point(380, 459);
            comboBoxResponsibleEmployee.Name = "comboBoxResponsibleEmployee";
            comboBoxResponsibleEmployee.Size = new Size(151, 28);
            comboBoxResponsibleEmployee.TabIndex = 29;
            // 
            // comboBoxChekMethod
            // 
            comboBoxChekMethod.FormattingEnabled = true;
            comboBoxChekMethod.Location = new Point(544, 193);
            comboBoxChekMethod.Name = "comboBoxChekMethod";
            comboBoxChekMethod.Size = new Size(151, 28);
            comboBoxChekMethod.TabIndex = 30;
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Location = new Point(381, 247);
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new Size(150, 27);
            numericUpDownInterval.TabIndex = 31;
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Location = new Point(381, 300);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new Size(150, 27);
            numericUpDownTimeout.TabIndex = 32;
            // 
            // numericUpDownRetryCount
            // 
            numericUpDownRetryCount.Location = new Point(381, 353);
            numericUpDownRetryCount.Name = "numericUpDownRetryCount";
            numericUpDownRetryCount.Size = new Size(150, 27);
            numericUpDownRetryCount.TabIndex = 33;
            // 
            // numericUpDownExpectedStatusCode
            // 
            numericUpDownExpectedStatusCode.Location = new Point(381, 406);
            numericUpDownExpectedStatusCode.Name = "numericUpDownExpectedStatusCode";
            numericUpDownExpectedStatusCode.Size = new Size(150, 27);
            numericUpDownExpectedStatusCode.TabIndex = 34;
            // 
            // textBoxExpectedResponseContains
            // 
            textBoxExpectedResponseContains.Location = new Point(544, 247);
            textBoxExpectedResponseContains.Name = "textBoxExpectedResponseContains";
            textBoxExpectedResponseContains.Size = new Size(151, 27);
            textBoxExpectedResponseContains.TabIndex = 35;
            // 
            // numericUpDownWarningResponseTime
            // 
            numericUpDownWarningResponseTime.Location = new Point(544, 300);
            numericUpDownWarningResponseTime.Name = "numericUpDownWarningResponseTime";
            numericUpDownWarningResponseTime.Size = new Size(150, 27);
            numericUpDownWarningResponseTime.TabIndex = 36;
            // 
            // numericUpDownCriticalResponseTime
            // 
            numericUpDownCriticalResponseTime.Location = new Point(543, 353);
            numericUpDownCriticalResponseTime.Name = "numericUpDownCriticalResponseTime";
            numericUpDownCriticalResponseTime.Size = new Size(150, 27);
            numericUpDownCriticalResponseTime.TabIndex = 37;
            // 
            // numericUpDownMaxConsecutiveFailures
            // 
            numericUpDownMaxConsecutiveFailures.Location = new Point(545, 406);
            numericUpDownMaxConsecutiveFailures.Name = "numericUpDownMaxConsecutiveFailures";
            numericUpDownMaxConsecutiveFailures.Size = new Size(150, 27);
            numericUpDownMaxConsecutiveFailures.TabIndex = 38;
            // 
            // numericUpDownMinUptimePercent
            // 
            numericUpDownMinUptimePercent.Location = new Point(545, 460);
            numericUpDownMinUptimePercent.Name = "numericUpDownMinUptimePercent";
            numericUpDownMinUptimePercent.Size = new Size(150, 27);
            numericUpDownMinUptimePercent.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(541, 9);
            label20.Name = "label20";
            label20.Size = new Size(89, 20);
            label20.TabIndex = 40;
            label20.Text = "Depends on";
            // 
            // comboBoxDependsOn
            // 
            comboBoxDependsOn.FormattingEnabled = true;
            comboBoxDependsOn.Location = new Point(542, 31);
            comboBoxDependsOn.Name = "comboBoxDependsOn";
            comboBoxDependsOn.Size = new Size(151, 28);
            comboBoxDependsOn.TabIndex = 41;
            comboBoxDependsOn.SelectedIndexChanged += comboBoxDependsOn_SelectedIndexChanged_1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(710, 169);
            label21.Name = "label21";
            label21.Size = new Size(101, 20);
            label21.TabIndex = 42;
            label21.Text = "Depends type";
            label21.Visible = false;
            // 
            // comboBoxDependsType
            // 
            comboBoxDependsType.FormattingEnabled = true;
            comboBoxDependsType.Location = new Point(710, 193);
            comboBoxDependsType.Name = "comboBoxDependsType";
            comboBoxDependsType.Size = new Size(151, 28);
            comboBoxDependsType.TabIndex = 43;
            comboBoxDependsType.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(710, 224);
            label22.Name = "label22";
            label22.Size = new Size(146, 20);
            label22.TabIndex = 45;
            label22.Text = "Depends description";
            label22.Visible = false;
            // 
            // richTextBoxDependsDescription
            // 
            richTextBoxDependsDescription.Location = new Point(710, 247);
            richTextBoxDependsDescription.Name = "richTextBoxDependsDescription";
            richTextBoxDependsDescription.Size = new Size(264, 188);
            richTextBoxDependsDescription.TabIndex = 46;
            richTextBoxDependsDescription.Text = "";
            richTextBoxDependsDescription.Visible = false;
            // 
            // richTextBoxServiceDesctiption
            // 
            richTextBoxServiceDesctiption.Location = new Point(710, 33);
            richTextBoxServiceDesctiption.Name = "richTextBoxServiceDesctiption";
            richTextBoxServiceDesctiption.Size = new Size(264, 134);
            richTextBoxServiceDesctiption.TabIndex = 47;
            richTextBoxServiceDesctiption.Text = "";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(544, 490);
            label24.Name = "label24";
            label24.Size = new Size(0, 20);
            label24.TabIndex = 49;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(381, 617);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 29);
            buttonAdd.TabIndex = 50;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(522, 617);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 29);
            buttonUpdate.TabIndex = 51;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(844, 617);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(130, 29);
            buttonDelate.TabIndex = 52;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // comboBoxActionAuthor
            // 
            comboBoxActionAuthor.FormattingEnabled = true;
            comboBoxActionAuthor.Location = new Point(712, 513);
            comboBoxActionAuthor.Name = "comboBoxActionAuthor";
            comboBoxActionAuthor.Size = new Size(262, 28);
            comboBoxActionAuthor.TabIndex = 53;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(712, 490);
            label23.Name = "label23";
            label23.Size = new Size(99, 20);
            label23.TabIndex = 54;
            label23.Text = "Action author";
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 658);
            Controls.Add(label23);
            Controls.Add(comboBoxActionAuthor);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(label24);
            Controls.Add(richTextBoxServiceDesctiption);
            Controls.Add(richTextBoxDependsDescription);
            Controls.Add(label22);
            Controls.Add(comboBoxDependsType);
            Controls.Add(label21);
            Controls.Add(comboBoxDependsOn);
            Controls.Add(label20);
            Controls.Add(numericUpDownMinUptimePercent);
            Controls.Add(numericUpDownMaxConsecutiveFailures);
            Controls.Add(numericUpDownCriticalResponseTime);
            Controls.Add(numericUpDownWarningResponseTime);
            Controls.Add(textBoxExpectedResponseContains);
            Controls.Add(numericUpDownExpectedStatusCode);
            Controls.Add(numericUpDownRetryCount);
            Controls.Add(numericUpDownTimeout);
            Controls.Add(numericUpDownInterval);
            Controls.Add(comboBoxChekMethod);
            Controls.Add(comboBoxResponsibleEmployee);
            Controls.Add(numericUpDownPort);
            Controls.Add(textBoxNetworkAdress);
            Controls.Add(textBoxURL);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(checkBoxIsActive);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxCriticality);
            Controls.Add(label4);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxCategory);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBoxName);
            Name = "ServicesForm";
            Text = "ServicesForm";
            Load += ServicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRetryCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExpectedStatusCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWarningResponseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCriticalResponseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxConsecutiveFailures).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinUptimePercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private ListBox listBox1;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxType;
        private Label label4;
        private ComboBox comboBoxCriticality;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBoxIsActive;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBoxURL;
        private TextBox textBoxNetworkAdress;
        private NumericUpDown numericUpDownPort;
        private ComboBox comboBoxResponsibleEmployee;
        private ComboBox comboBoxChekMethod;
        private NumericUpDown numericUpDownInterval;
        private NumericUpDown numericUpDownTimeout;
        private NumericUpDown numericUpDownRetryCount;
        private NumericUpDown numericUpDownExpectedStatusCode;
        private TextBox textBoxExpectedResponseContains;
        private NumericUpDown numericUpDownWarningResponseTime;
        private NumericUpDown numericUpDownCriticalResponseTime;
        private NumericUpDown numericUpDownMaxConsecutiveFailures;
        private NumericUpDown numericUpDownMinUptimePercent;
        private Label label20;
        private ComboBox comboBoxDependsOn;
        private Label label21;
        private ComboBox comboBoxDependsType;
        private Label label22;
        private RichTextBox richTextBoxDependsDescription;
        private RichTextBox richTextBoxServiceDesctiption;
        private Label label24;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelate;
        private ComboBox comboBoxActionAuthor;
        private Label label23;
    }
}