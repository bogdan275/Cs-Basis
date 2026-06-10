namespace UI
{
    partial class BillingForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridViewHistory = new DataGridView();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label2 = new Label();
            comboBoxClient = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            buttonCreate = new Button();
            listBoxStats = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewHistory);
            tabPage1.Controls.Add(dateTimePickerEnd);
            tabPage1.Controls.Add(dateTimePickerStart);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBoxClient);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonCreate);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Invoices";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxStats);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Analytics";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Left;
            dataGridViewHistory.Location = new Point(3, 3);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.Size = new Size(570, 411);
            dataGridViewHistory.TabIndex = 97;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(588, 136);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(196, 27);
            dateTimePickerEnd.TabIndex = 96;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(588, 83);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(196, 27);
            dateTimePickerStart.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(588, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 94;
            label2.Text = "Date end";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(588, 29);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(196, 28);
            comboBoxClient.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 60);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 92;
            label3.Text = "Date start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(588, 6);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 91;
            label1.Text = "Client";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(588, 380);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(196, 29);
            buttonCreate.TabIndex = 90;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // listBoxStats
            // 
            listBoxStats.Dock = DockStyle.Fill;
            listBoxStats.FormattingEnabled = true;
            listBoxStats.Location = new Point(3, 3);
            listBoxStats.Name = "listBoxStats";
            listBoxStats.Size = new Size(786, 411);
            listBoxStats.TabIndex = 0;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "BillingForm";
            Text = "BillingForm";
            Load += BillingForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelPhone;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox txtName;
        private ListBox listBoxBins;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewHistory;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label2;
        private ComboBox comboBoxClient;
        private Label label3;
        private Label label1;
        private Button buttonCreate;
        private TabPage tabPage2;
        private ListBox listBoxStats;
    }
}