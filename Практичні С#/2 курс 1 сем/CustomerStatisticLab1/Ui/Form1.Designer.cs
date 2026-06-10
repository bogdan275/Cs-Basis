namespace Ui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            xLSXToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem1 = new ToolStripMenuItem();
            jSONToolStripMenuItem1 = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            xLSXToolStripMenuItem1 = new ToolStripMenuItem();
            analyticsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            generateToolStripMenuItem = new ToolStripMenuItem();
            generateToolStripMenuItem1 = new ToolStripMenuItem();
            chartsToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewCustomers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxCusromerID = new TextBox();
            comboBoxGender = new ComboBox();
            checkBoxSeniorCitizen = new CheckBox();
            checkBoxPartner = new CheckBox();
            checkBoxHasDepandents = new CheckBox();
            label3 = new Label();
            numericUpDownTenure = new NumericUpDown();
            checkBoxHasPhoneService = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBoxMultipleLines = new ComboBox();
            comboBoxInternetService = new ComboBox();
            comboBoxOnlineSecurity = new ComboBox();
            comboBoxStreamingMovies = new ComboBox();
            comboBoxOnlineBackup = new ComboBox();
            comboBoxDeviceProtection = new ComboBox();
            comboBoxTechSupport = new ComboBox();
            comboBoxStreamingTV = new ComboBox();
            comboBoxContractType = new ComboBox();
            comboBoxPaymentMethod = new ComboBox();
            checkBoxPaperlessBilling = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBoxContractType = new TextBox();
            textBoxPaymentMethod = new TextBox();
            label15 = new Label();
            checkBoxChurned = new CheckBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelate = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenure).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, analyticsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem, jSONToolStripMenuItem, xMLToolStripMenuItem, xLSXToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(150, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(127, 26);
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += cSVToolStripMenuItem_Click;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(127, 26);
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += jSONToolStripMenuItem_Click;
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(127, 26);
            xMLToolStripMenuItem.Text = "XML";
            xMLToolStripMenuItem.Click += xMLToolStripMenuItem_Click;
            // 
            // xLSXToolStripMenuItem
            // 
            xLSXToolStripMenuItem.Name = "xLSXToolStripMenuItem";
            xLSXToolStripMenuItem.Size = new Size(127, 26);
            xLSXToolStripMenuItem.Text = "XLSX";
            xLSXToolStripMenuItem.Click += xLSXToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem1, jSONToolStripMenuItem1, xMLToolStripMenuItem1, xLSXToolStripMenuItem1 });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(150, 26);
            saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // cSVToolStripMenuItem1
            // 
            cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            cSVToolStripMenuItem1.Size = new Size(127, 26);
            cSVToolStripMenuItem1.Text = "CSV";
            cSVToolStripMenuItem1.Click += cSVToolStripMenuItem1_Click;
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new Size(127, 26);
            jSONToolStripMenuItem1.Text = "JSON";
            jSONToolStripMenuItem1.Click += jSONToolStripMenuItem1_Click;
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(127, 26);
            xMLToolStripMenuItem1.Text = "XML";
            xMLToolStripMenuItem1.Click += xMLToolStripMenuItem1_Click;
            // 
            // xLSXToolStripMenuItem1
            // 
            xLSXToolStripMenuItem1.Name = "xLSXToolStripMenuItem1";
            xLSXToolStripMenuItem1.Size = new Size(127, 26);
            xLSXToolStripMenuItem1.Text = "XLSX";
            xLSXToolStripMenuItem1.Click += xLSXToolStripMenuItem1_Click;
            // 
            // analyticsToolStripMenuItem
            // 
            analyticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportsToolStripMenuItem, chartsToolStripMenuItem });
            analyticsToolStripMenuItem.Name = "analyticsToolStripMenuItem";
            analyticsToolStripMenuItem.Size = new Size(82, 24);
            analyticsToolStripMenuItem.Text = "Analytics";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateToolStripMenuItem, generateToolStripMenuItem1 });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(224, 26);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateToolStripMenuItem
            // 
            generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            generateToolStripMenuItem.Size = new Size(224, 26);
            generateToolStripMenuItem.Text = "Generate XLSX";
            generateToolStripMenuItem.Click += generateToolStripMenuItem_Click;
            // 
            // generateToolStripMenuItem1
            // 
            generateToolStripMenuItem1.Name = "generateToolStripMenuItem1";
            generateToolStripMenuItem1.Size = new Size(224, 26);
            generateToolStripMenuItem1.Text = "Generate DOCX";
            generateToolStripMenuItem1.Click += generateToolStripMenuItem1_Click;
            // 
            // chartsToolStripMenuItem
            // 
            chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            chartsToolStripMenuItem.Size = new Size(224, 26);
            chartsToolStripMenuItem.Text = "Charts";
            chartsToolStripMenuItem.Click += chartsToolStripMenuItem_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Dock = DockStyle.Left;
            dataGridViewCustomers.Enabled = false;
            dataGridViewCustomers.Location = new Point(0, 28);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(438, 526);
            dataGridViewCustomers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 45);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 98);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Gender";
            // 
            // textBoxCusromerID
            // 
            textBoxCusromerID.Location = new Point(484, 71);
            textBoxCusromerID.Name = "textBoxCusromerID";
            textBoxCusromerID.Size = new Size(125, 27);
            textBoxCusromerID.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(484, 124);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(125, 28);
            comboBoxGender.TabIndex = 5;
            // 
            // checkBoxSeniorCitizen
            // 
            checkBoxSeniorCitizen.AutoSize = true;
            checkBoxSeniorCitizen.Location = new Point(484, 158);
            checkBoxSeniorCitizen.Name = "checkBoxSeniorCitizen";
            checkBoxSeniorCitizen.Size = new Size(139, 24);
            checkBoxSeniorCitizen.TabIndex = 6;
            checkBoxSeniorCitizen.Text = "Is senior citizen?";
            checkBoxSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // checkBoxPartner
            // 
            checkBoxPartner.AutoSize = true;
            checkBoxPartner.Location = new Point(484, 188);
            checkBoxPartner.Name = "checkBoxPartner";
            checkBoxPartner.Size = new Size(115, 24);
            checkBoxPartner.TabIndex = 7;
            checkBoxPartner.Text = "Has partner?";
            checkBoxPartner.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasDepandents
            // 
            checkBoxHasDepandents.AutoSize = true;
            checkBoxHasDepandents.Location = new Point(484, 218);
            checkBoxHasDepandents.Name = "checkBoxHasDepandents";
            checkBoxHasDepandents.Size = new Size(147, 24);
            checkBoxHasDepandents.TabIndex = 8;
            checkBoxHasDepandents.Text = "Has Dependents?";
            checkBoxHasDepandents.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 245);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 9;
            label3.Text = "Tenure";
            // 
            // numericUpDownTenure
            // 
            numericUpDownTenure.Location = new Point(484, 268);
            numericUpDownTenure.Name = "numericUpDownTenure";
            numericUpDownTenure.Size = new Size(125, 27);
            numericUpDownTenure.TabIndex = 10;
            // 
            // checkBoxHasPhoneService
            // 
            checkBoxHasPhoneService.AutoSize = true;
            checkBoxHasPhoneService.Location = new Point(484, 301);
            checkBoxHasPhoneService.Name = "checkBoxHasPhoneService";
            checkBoxHasPhoneService.Size = new Size(158, 24);
            checkBoxHasPhoneService.TabIndex = 11;
            checkBoxHasPhoneService.Text = "Has phone service?";
            checkBoxHasPhoneService.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(687, 48);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 12;
            label4.Text = "Multiple lines";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(691, 97);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 13;
            label5.Text = "Internet service";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(691, 151);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 14;
            label6.Text = "Online security";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(691, 205);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 15;
            label7.Text = "Online backup";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(691, 259);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 16;
            label8.Text = "Device protection";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 313);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 17;
            label9.Text = "Tech support";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(691, 364);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 18;
            label10.Text = "Streaming TV";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(691, 418);
            label11.Name = "label11";
            label11.Size = new Size(128, 20);
            label11.TabIndex = 19;
            label11.Text = "Streaming movies";
            // 
            // comboBoxMultipleLines
            // 
            comboBoxMultipleLines.FormattingEnabled = true;
            comboBoxMultipleLines.Location = new Point(687, 71);
            comboBoxMultipleLines.Name = "comboBoxMultipleLines";
            comboBoxMultipleLines.Size = new Size(125, 28);
            comboBoxMultipleLines.TabIndex = 20;
            // 
            // comboBoxInternetService
            // 
            comboBoxInternetService.FormattingEnabled = true;
            comboBoxInternetService.Location = new Point(687, 120);
            comboBoxInternetService.Name = "comboBoxInternetService";
            comboBoxInternetService.Size = new Size(125, 28);
            comboBoxInternetService.TabIndex = 21;
            // 
            // comboBoxOnlineSecurity
            // 
            comboBoxOnlineSecurity.FormattingEnabled = true;
            comboBoxOnlineSecurity.Location = new Point(687, 174);
            comboBoxOnlineSecurity.Name = "comboBoxOnlineSecurity";
            comboBoxOnlineSecurity.Size = new Size(125, 28);
            comboBoxOnlineSecurity.TabIndex = 22;
            // 
            // comboBoxStreamingMovies
            // 
            comboBoxStreamingMovies.FormattingEnabled = true;
            comboBoxStreamingMovies.Location = new Point(687, 441);
            comboBoxStreamingMovies.Name = "comboBoxStreamingMovies";
            comboBoxStreamingMovies.Size = new Size(125, 28);
            comboBoxStreamingMovies.TabIndex = 23;
            // 
            // comboBoxOnlineBackup
            // 
            comboBoxOnlineBackup.FormattingEnabled = true;
            comboBoxOnlineBackup.Location = new Point(687, 228);
            comboBoxOnlineBackup.Name = "comboBoxOnlineBackup";
            comboBoxOnlineBackup.Size = new Size(125, 28);
            comboBoxOnlineBackup.TabIndex = 24;
            // 
            // comboBoxDeviceProtection
            // 
            comboBoxDeviceProtection.FormattingEnabled = true;
            comboBoxDeviceProtection.Location = new Point(687, 282);
            comboBoxDeviceProtection.Name = "comboBoxDeviceProtection";
            comboBoxDeviceProtection.Size = new Size(125, 28);
            comboBoxDeviceProtection.TabIndex = 25;
            // 
            // comboBoxTechSupport
            // 
            comboBoxTechSupport.FormattingEnabled = true;
            comboBoxTechSupport.Location = new Point(687, 333);
            comboBoxTechSupport.Name = "comboBoxTechSupport";
            comboBoxTechSupport.Size = new Size(125, 28);
            comboBoxTechSupport.TabIndex = 26;
            // 
            // comboBoxStreamingTV
            // 
            comboBoxStreamingTV.FormattingEnabled = true;
            comboBoxStreamingTV.Location = new Point(687, 387);
            comboBoxStreamingTV.Name = "comboBoxStreamingTV";
            comboBoxStreamingTV.Size = new Size(125, 28);
            comboBoxStreamingTV.TabIndex = 27;
            // 
            // comboBoxContractType
            // 
            comboBoxContractType.FormattingEnabled = true;
            comboBoxContractType.Location = new Point(876, 70);
            comboBoxContractType.Name = "comboBoxContractType";
            comboBoxContractType.Size = new Size(125, 28);
            comboBoxContractType.TabIndex = 28;
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(876, 120);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(125, 28);
            comboBoxPaymentMethod.TabIndex = 29;
            // 
            // checkBoxPaperlessBilling
            // 
            checkBoxPaperlessBilling.AutoSize = true;
            checkBoxPaperlessBilling.Location = new Point(876, 151);
            checkBoxPaperlessBilling.Name = "checkBoxPaperlessBilling";
            checkBoxPaperlessBilling.Size = new Size(145, 24);
            checkBoxPaperlessBilling.TabIndex = 30;
            checkBoxPaperlessBilling.Text = "Paperless billing?";
            checkBoxPaperlessBilling.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(876, 48);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 31;
            label12.Text = "Contract type";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(876, 98);
            label13.Name = "label13";
            label13.Size = new Size(121, 20);
            label13.TabIndex = 32;
            label13.Text = "Payment method";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(876, 260);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 33;
            label14.Text = "Contract type";
            // 
            // textBoxContractType
            // 
            textBoxContractType.Location = new Point(876, 283);
            textBoxContractType.Name = "textBoxContractType";
            textBoxContractType.Size = new Size(125, 27);
            textBoxContractType.TabIndex = 34;
            // 
            // textBoxPaymentMethod
            // 
            textBoxPaymentMethod.Location = new Point(876, 333);
            textBoxPaymentMethod.Name = "textBoxPaymentMethod";
            textBoxPaymentMethod.Size = new Size(125, 27);
            textBoxPaymentMethod.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(876, 313);
            label15.Name = "label15";
            label15.Size = new Size(121, 20);
            label15.TabIndex = 36;
            label15.Text = "Payment method";
            // 
            // checkBoxChurned
            // 
            checkBoxChurned.AutoSize = true;
            checkBoxChurned.Location = new Point(876, 366);
            checkBoxChurned.Name = "checkBoxChurned";
            checkBoxChurned.Size = new Size(93, 24);
            checkBoxChurned.TabIndex = 37;
            checkBoxChurned.Text = "Churned?";
            checkBoxChurned.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(481, 513);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 38;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(581, 513);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 39;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(681, 513);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 40;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 554);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(checkBoxChurned);
            Controls.Add(label15);
            Controls.Add(textBoxPaymentMethod);
            Controls.Add(textBoxContractType);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(checkBoxPaperlessBilling);
            Controls.Add(comboBoxPaymentMethod);
            Controls.Add(comboBoxContractType);
            Controls.Add(comboBoxStreamingTV);
            Controls.Add(comboBoxTechSupport);
            Controls.Add(comboBoxDeviceProtection);
            Controls.Add(comboBoxOnlineBackup);
            Controls.Add(comboBoxStreamingMovies);
            Controls.Add(comboBoxOnlineSecurity);
            Controls.Add(comboBoxInternetService);
            Controls.Add(comboBoxMultipleLines);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBoxHasPhoneService);
            Controls.Add(numericUpDownTenure);
            Controls.Add(label3);
            Controls.Add(checkBoxHasDepandents);
            Controls.Add(checkBoxPartner);
            Controls.Add(checkBoxSeniorCitizen);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxCusromerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem xLSXToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem1;
        private ToolStripMenuItem jSONToolStripMenuItem1;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStripMenuItem xLSXToolStripMenuItem1;
        private DataGridView dataGridViewCustomers;
        private Label label1;
        private Label label2;
        private TextBox textBoxCusromerID;
        private ComboBox comboBoxGender;
        private CheckBox checkBoxSeniorCitizen;
        private CheckBox checkBoxPartner;
        private CheckBox checkBoxHasDepandents;
        private Label label3;
        private NumericUpDown numericUpDownTenure;
        private CheckBox checkBoxHasPhoneService;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxMultipleLines;
        private ComboBox comboBoxInternetService;
        private ComboBox comboBoxOnlineSecurity;
        private ComboBox comboBoxStreamingMovies;
        private ComboBox comboBoxOnlineBackup;
        private ComboBox comboBoxDeviceProtection;
        private ComboBox comboBoxTechSupport;
        private ComboBox comboBoxStreamingTV;
        private ComboBox comboBoxContractType;
        private ComboBox comboBoxPaymentMethod;
        private CheckBox checkBoxPaperlessBilling;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBoxContractType;
        private TextBox textBoxPaymentMethod;
        private Label label15;
        private CheckBox checkBoxChurned;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelate;
        private ToolStripMenuItem analyticsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem chartsToolStripMenuItem;
        private ToolStripMenuItem generateToolStripMenuItem;
        private ToolStripMenuItem generateToolStripMenuItem1;
    }
}
