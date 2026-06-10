using System.Windows.Forms;

namespace UI.TechSpecialist
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

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
            textBoxName.Size = new Size(150, 27);
            textBoxName.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 660);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.Location = new Point(380, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            label1.Text = "Name*";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Location = new Point(380, 85);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 28);
            comboBoxCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(380, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Category*";
            // 
            // label3
            // 
            label3.Location = new Point(380, 116);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Service type*";
            // 
            // comboBoxType
            // 
            comboBoxType.Location = new Point(380, 139);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(150, 28);
            comboBoxType.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(380, 170);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            label4.Text = "Criticality*";
            // 
            // comboBoxCriticality
            // 
            comboBoxCriticality.Location = new Point(380, 193);
            comboBoxCriticality.Name = "comboBoxCriticality";
            comboBoxCriticality.Size = new Size(150, 28);
            comboBoxCriticality.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(380, 224);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Interval*";
            // 
            // label6
            // 
            label6.Location = new Point(380, 277);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Timeout*";
            // 
            // label7
            // 
            label7.Location = new Point(380, 436);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 18;
            label7.Text = "Responsible Employee";
            // 
            // label8
            // 
            label8.Location = new Point(380, 490);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 20;
            label8.Text = "URL";
            // 
            // label9
            // 
            label9.Location = new Point(710, 10);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 41;
            label9.Text = "Description";
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.Location = new Point(540, 513);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(104, 24);
            checkBoxIsActive.TabIndex = 40;
            checkBoxIsActive.Text = "Is Active";
            // 
            // label10
            // 
            label10.Location = new Point(540, 62);
            label10.Name = "label10";
            label10.Size = new Size(150, 23);
            label10.TabIndex = 24;
            label10.Text = "Network address";
            // 
            // label11
            // 
            label11.Location = new Point(540, 116);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 26;
            label11.Text = "Port";
            // 
            // label12
            // 
            label12.Location = new Point(540, 170);
            label12.Name = "label12";
            label12.Size = new Size(150, 23);
            label12.TabIndex = 28;
            label12.Text = "Check method*";
            // 
            // label13
            // 
            label13.Location = new Point(380, 330);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 14;
            label13.Text = "Retry count*";
            // 
            // label14
            // 
            label14.Location = new Point(380, 383);
            label14.Name = "label14";
            label14.Size = new Size(150, 23);
            label14.TabIndex = 16;
            label14.Text = "Exp. Status Code";
            // 
            // label15
            // 
            label15.Location = new Point(540, 224);
            label15.Name = "label15";
            label15.Size = new Size(150, 23);
            label15.TabIndex = 30;
            label15.Text = "Response contains";
            // 
            // label16
            // 
            label16.Location = new Point(540, 277);
            label16.Name = "label16";
            label16.Size = new Size(150, 23);
            label16.TabIndex = 32;
            label16.Text = "Warning Resp. Time";
            // 
            // label17
            // 
            label17.Location = new Point(540, 330);
            label17.Name = "label17";
            label17.Size = new Size(150, 23);
            label17.TabIndex = 34;
            label17.Text = "Critical Resp. Time";
            // 
            // label18
            // 
            label18.Location = new Point(540, 383);
            label18.Name = "label18";
            label18.Size = new Size(150, 23);
            label18.TabIndex = 36;
            label18.Text = "Max Failures";
            // 
            // label19
            // 
            label19.Location = new Point(540, 436);
            label19.Name = "label19";
            label19.Size = new Size(150, 23);
            label19.TabIndex = 38;
            label19.Text = "Min Uptime %";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(380, 513);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(150, 27);
            textBoxURL.TabIndex = 21;
            // 
            // textBoxNetworkAdress
            // 
            textBoxNetworkAdress.Location = new Point(540, 85);
            textBoxNetworkAdress.Name = "textBoxNetworkAdress";
            textBoxNetworkAdress.Size = new Size(150, 27);
            textBoxNetworkAdress.TabIndex = 25;
            // 
            // numericUpDownPort
            // 
            numericUpDownPort.Location = new Point(540, 139);
            numericUpDownPort.Name = "numericUpDownPort";
            numericUpDownPort.Size = new Size(150, 27);
            numericUpDownPort.TabIndex = 27;
            // 
            // comboBoxResponsibleEmployee
            // 
            comboBoxResponsibleEmployee.Location = new Point(380, 459);
            comboBoxResponsibleEmployee.Name = "comboBoxResponsibleEmployee";
            comboBoxResponsibleEmployee.Size = new Size(150, 28);
            comboBoxResponsibleEmployee.TabIndex = 19;
            // 
            // comboBoxChekMethod
            // 
            comboBoxChekMethod.Location = new Point(540, 193);
            comboBoxChekMethod.Name = "comboBoxChekMethod";
            comboBoxChekMethod.Size = new Size(150, 28);
            comboBoxChekMethod.TabIndex = 29;
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Location = new Point(380, 247);
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new Size(150, 27);
            numericUpDownInterval.TabIndex = 11;
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Location = new Point(380, 300);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new Size(150, 27);
            numericUpDownTimeout.TabIndex = 13;
            // 
            // numericUpDownRetryCount
            // 
            numericUpDownRetryCount.Location = new Point(380, 353);
            numericUpDownRetryCount.Name = "numericUpDownRetryCount";
            numericUpDownRetryCount.Size = new Size(150, 27);
            numericUpDownRetryCount.TabIndex = 15;
            // 
            // numericUpDownExpectedStatusCode
            // 
            numericUpDownExpectedStatusCode.Location = new Point(380, 406);
            numericUpDownExpectedStatusCode.Name = "numericUpDownExpectedStatusCode";
            numericUpDownExpectedStatusCode.Size = new Size(150, 27);
            numericUpDownExpectedStatusCode.TabIndex = 17;
            // 
            // textBoxExpectedResponseContains
            // 
            textBoxExpectedResponseContains.Location = new Point(540, 247);
            textBoxExpectedResponseContains.Name = "textBoxExpectedResponseContains";
            textBoxExpectedResponseContains.Size = new Size(150, 27);
            textBoxExpectedResponseContains.TabIndex = 31;
            // 
            // numericUpDownWarningResponseTime
            // 
            numericUpDownWarningResponseTime.Location = new Point(540, 300);
            numericUpDownWarningResponseTime.Name = "numericUpDownWarningResponseTime";
            numericUpDownWarningResponseTime.Size = new Size(150, 27);
            numericUpDownWarningResponseTime.TabIndex = 33;
            // 
            // numericUpDownCriticalResponseTime
            // 
            numericUpDownCriticalResponseTime.Location = new Point(540, 353);
            numericUpDownCriticalResponseTime.Name = "numericUpDownCriticalResponseTime";
            numericUpDownCriticalResponseTime.Size = new Size(150, 27);
            numericUpDownCriticalResponseTime.TabIndex = 35;
            // 
            // numericUpDownMaxConsecutiveFailures
            // 
            numericUpDownMaxConsecutiveFailures.Location = new Point(540, 406);
            numericUpDownMaxConsecutiveFailures.Name = "numericUpDownMaxConsecutiveFailures";
            numericUpDownMaxConsecutiveFailures.Size = new Size(150, 27);
            numericUpDownMaxConsecutiveFailures.TabIndex = 37;
            // 
            // numericUpDownMinUptimePercent
            // 
            numericUpDownMinUptimePercent.Location = new Point(540, 460);
            numericUpDownMinUptimePercent.Name = "numericUpDownMinUptimePercent";
            numericUpDownMinUptimePercent.Size = new Size(150, 27);
            numericUpDownMinUptimePercent.TabIndex = 39;
            // 
            // label20
            // 
            label20.Location = new Point(540, 10);
            label20.Name = "label20";
            label20.Size = new Size(150, 23);
            label20.TabIndex = 22;
            label20.Text = "Depends on";
            // 
            // comboBoxDependsOn
            // 
            comboBoxDependsOn.Location = new Point(540, 31);
            comboBoxDependsOn.Name = "comboBoxDependsOn";
            comboBoxDependsOn.Size = new Size(150, 28);
            comboBoxDependsOn.TabIndex = 23;
            comboBoxDependsOn.SelectedIndexChanged += comboBoxDependsOn_SelectedIndexChanged_1;
            // 
            // label21
            // 
            label21.Location = new Point(710, 169);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 43;
            label21.Text = "Depends type";
            label21.Visible = false;
            // 
            // comboBoxDependsType
            // 
            comboBoxDependsType.Location = new Point(710, 193);
            comboBoxDependsType.Name = "comboBoxDependsType";
            comboBoxDependsType.Size = new Size(260, 28);
            comboBoxDependsType.TabIndex = 44;
            comboBoxDependsType.Visible = false;
            // 
            // label22
            // 
            label22.Location = new Point(710, 224);
            label22.Name = "label22";
            label22.Size = new Size(260, 23);
            label22.TabIndex = 45;
            label22.Text = "Depends description";
            label22.Visible = false;
            // 
            // richTextBoxDependsDescription
            // 
            richTextBoxDependsDescription.Location = new Point(710, 247);
            richTextBoxDependsDescription.Name = "richTextBoxDependsDescription";
            richTextBoxDependsDescription.Size = new Size(260, 188);
            richTextBoxDependsDescription.TabIndex = 46;
            richTextBoxDependsDescription.Text = "";
            richTextBoxDependsDescription.Visible = false;
            // 
            // richTextBoxServiceDesctiption
            // 
            richTextBoxServiceDesctiption.Location = new Point(710, 33);
            richTextBoxServiceDesctiption.Name = "richTextBoxServiceDesctiption";
            richTextBoxServiceDesctiption.Size = new Size(260, 134);
            richTextBoxServiceDesctiption.TabIndex = 42;
            richTextBoxServiceDesctiption.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(380, 600);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 35);
            buttonAdd.TabIndex = 49;
            buttonAdd.Text = "Add";
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(510, 600);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 35);
            buttonUpdate.TabIndex = 50;
            buttonUpdate.Text = "Update";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(850, 600);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(120, 35);
            buttonDelate.TabIndex = 51;
            buttonDelate.Text = "Delete";
            buttonDelate.Click += buttonDelate_Click;
            // 
            // comboBoxActionAuthor
            // 
            comboBoxActionAuthor.Location = new Point(710, 463);
            comboBoxActionAuthor.Name = "comboBoxActionAuthor";
            comboBoxActionAuthor.Size = new Size(260, 28);
            comboBoxActionAuthor.TabIndex = 48;
            // 
            // label23
            // 
            label23.Location = new Point(710, 440);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 47;
            label23.Text = "Action author*";
            // 
            // ServicesForm
            // 
            ClientSize = new Size(1000, 660);
            Controls.Add(listBox1);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(label2);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(comboBoxCriticality);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(numericUpDownInterval);
            Controls.Add(label6);
            Controls.Add(numericUpDownTimeout);
            Controls.Add(label13);
            Controls.Add(numericUpDownRetryCount);
            Controls.Add(label14);
            Controls.Add(numericUpDownExpectedStatusCode);
            Controls.Add(label7);
            Controls.Add(comboBoxResponsibleEmployee);
            Controls.Add(label8);
            Controls.Add(textBoxURL);
            Controls.Add(label20);
            Controls.Add(comboBoxDependsOn);
            Controls.Add(label10);
            Controls.Add(textBoxNetworkAdress);
            Controls.Add(label11);
            Controls.Add(numericUpDownPort);
            Controls.Add(label12);
            Controls.Add(comboBoxChekMethod);
            Controls.Add(label15);
            Controls.Add(textBoxExpectedResponseContains);
            Controls.Add(label16);
            Controls.Add(numericUpDownWarningResponseTime);
            Controls.Add(label17);
            Controls.Add(numericUpDownCriticalResponseTime);
            Controls.Add(label18);
            Controls.Add(numericUpDownMaxConsecutiveFailures);
            Controls.Add(label19);
            Controls.Add(numericUpDownMinUptimePercent);
            Controls.Add(checkBoxIsActive);
            Controls.Add(label9);
            Controls.Add(richTextBoxServiceDesctiption);
            Controls.Add(label21);
            Controls.Add(comboBoxDependsType);
            Controls.Add(label22);
            Controls.Add(richTextBoxDependsDescription);
            Controls.Add(label23);
            Controls.Add(comboBoxActionAuthor);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelate);
            Name = "ServicesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Service Management Terminal";
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
    }
}