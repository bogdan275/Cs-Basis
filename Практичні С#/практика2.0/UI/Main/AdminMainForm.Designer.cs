using System.Windows.Forms;

namespace UI.Main
{
    partial class AdminMainForm
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
            labelMaintenanceToday = new Label();
            labelTotalEmployees = new Label();
            labelCriticalUnresolved = new Label();
            labelResolvedToday = new Label();
            labelActiveServices = new Label();
            labelActiveIncidents = new Label();
            labelTotalIncidents = new Label();
            labelCriticalServices = new Label();
            labelTotalServices = new Label();
            tabPage2 = new TabPage();
            dataGridViewServices = new DataGridView();
            tabPage3 = new TabPage();
            richTextBoxReport = new RichTextBox();
            buttonExportToDocx = new Button();
            buttonExportToXLSX = new Button();
            buttonGenerateReport = new Button();
            menuStrip1 = new MenuStrip();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            manageServiceCategoriesToolStripMenuItem = new ToolStripMenuItem();
            manageSpecializationsToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            tabPage3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(682, 425);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelMaintenanceToday);
            tabPage1.Controls.Add(labelTotalEmployees);
            tabPage1.Controls.Add(labelCriticalUnresolved);
            tabPage1.Controls.Add(labelResolvedToday);
            tabPage1.Controls.Add(labelActiveServices);
            tabPage1.Controls.Add(labelActiveIncidents);
            tabPage1.Controls.Add(labelTotalIncidents);
            tabPage1.Controls.Add(labelCriticalServices);
            tabPage1.Controls.Add(labelTotalServices);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(674, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelMaintenanceToday
            // 
            labelMaintenanceToday.AutoSize = true;
            labelMaintenanceToday.Location = new Point(29, 301);
            labelMaintenanceToday.Name = "labelMaintenanceToday";
            labelMaintenanceToday.Size = new Size(50, 20);
            labelMaintenanceToday.TabIndex = 8;
            labelMaintenanceToday.Text = "label1";
            // 
            // labelTotalEmployees
            // 
            labelTotalEmployees.AutoSize = true;
            labelTotalEmployees.Location = new Point(29, 265);
            labelTotalEmployees.Name = "labelTotalEmployees";
            labelTotalEmployees.Size = new Size(50, 20);
            labelTotalEmployees.TabIndex = 7;
            labelTotalEmployees.Text = "label1";
            // 
            // labelCriticalUnresolved
            // 
            labelCriticalUnresolved.AutoSize = true;
            labelCriticalUnresolved.Location = new Point(29, 232);
            labelCriticalUnresolved.Name = "labelCriticalUnresolved";
            labelCriticalUnresolved.Size = new Size(50, 20);
            labelCriticalUnresolved.TabIndex = 6;
            labelCriticalUnresolved.Text = "label1";
            // 
            // labelResolvedToday
            // 
            labelResolvedToday.AutoSize = true;
            labelResolvedToday.Location = new Point(29, 200);
            labelResolvedToday.Name = "labelResolvedToday";
            labelResolvedToday.Size = new Size(50, 20);
            labelResolvedToday.TabIndex = 5;
            labelResolvedToday.Text = "label1";
            // 
            // labelActiveServices
            // 
            labelActiveServices.AutoSize = true;
            labelActiveServices.Location = new Point(29, 165);
            labelActiveServices.Name = "labelActiveServices";
            labelActiveServices.Size = new Size(50, 20);
            labelActiveServices.TabIndex = 4;
            labelActiveServices.Text = "label1";
            // 
            // labelActiveIncidents
            // 
            labelActiveIncidents.AutoSize = true;
            labelActiveIncidents.Location = new Point(29, 130);
            labelActiveIncidents.Name = "labelActiveIncidents";
            labelActiveIncidents.Size = new Size(50, 20);
            labelActiveIncidents.TabIndex = 3;
            labelActiveIncidents.Text = "label1";
            // 
            // labelTotalIncidents
            // 
            labelTotalIncidents.AutoSize = true;
            labelTotalIncidents.Location = new Point(29, 95);
            labelTotalIncidents.Name = "labelTotalIncidents";
            labelTotalIncidents.Size = new Size(50, 20);
            labelTotalIncidents.TabIndex = 2;
            labelTotalIncidents.Text = "label1";
            // 
            // labelCriticalServices
            // 
            labelCriticalServices.AutoSize = true;
            labelCriticalServices.Location = new Point(29, 60);
            labelCriticalServices.Name = "labelCriticalServices";
            labelCriticalServices.Size = new Size(50, 20);
            labelCriticalServices.TabIndex = 1;
            labelCriticalServices.Text = "label1";
            // 
            // labelTotalServices
            // 
            labelTotalServices.AutoSize = true;
            labelTotalServices.Location = new Point(29, 25);
            labelTotalServices.Name = "labelTotalServices";
            labelTotalServices.Size = new Size(50, 20);
            labelTotalServices.TabIndex = 0;
            labelTotalServices.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewServices);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(674, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Incidents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Dock = DockStyle.Fill;
            dataGridViewServices.GridColor = SystemColors.HighlightText;
            dataGridViewServices.Location = new Point(3, 3);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(668, 386);
            dataGridViewServices.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBoxReport);
            tabPage3.Controls.Add(buttonExportToDocx);
            tabPage3.Controls.Add(buttonExportToXLSX);
            tabPage3.Controls.Add(buttonGenerateReport);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(674, 392);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReport
            // 
            richTextBoxReport.Dock = DockStyle.Top;
            richTextBoxReport.Location = new Point(3, 3);
            richTextBoxReport.Name = "richTextBoxReport";
            richTextBoxReport.Size = new Size(668, 331);
            richTextBoxReport.TabIndex = 3;
            richTextBoxReport.Text = "";
            // 
            // buttonExportToDocx
            // 
            buttonExportToDocx.Enabled = false;
            buttonExportToDocx.Location = new Point(528, 340);
            buttonExportToDocx.Name = "buttonExportToDocx";
            buttonExportToDocx.Size = new Size(127, 29);
            buttonExportToDocx.TabIndex = 2;
            buttonExportToDocx.Text = "Export to Docx";
            buttonExportToDocx.UseVisualStyleBackColor = true;
            buttonExportToDocx.Click += buttonExportToDocx_Click;
            // 
            // buttonExportToXLSX
            // 
            buttonExportToXLSX.Enabled = false;
            buttonExportToXLSX.Location = new Point(395, 340);
            buttonExportToXLSX.Name = "buttonExportToXLSX";
            buttonExportToXLSX.Size = new Size(127, 29);
            buttonExportToXLSX.TabIndex = 1;
            buttonExportToXLSX.Text = "Export to XLSX";
            buttonExportToXLSX.UseVisualStyleBackColor = true;
            buttonExportToXLSX.Click += buttonExportToXLSX_Click;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(21, 340);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(127, 29);
            buttonGenerateReport.TabIndex = 0;
            buttonGenerateReport.Text = "Generate report";
            buttonGenerateReport.UseVisualStyleBackColor = true;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { departmentsToolStripMenuItem, manageServiceCategoriesToolStripMenuItem, manageSpecializationsToolStripMenuItem, otherToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(682, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(109, 24);
            departmentsToolStripMenuItem.Text = "Departments";
            departmentsToolStripMenuItem.Click += departmentsToolStripMenuItem_Click;
            // 
            // manageServiceCategoriesToolStripMenuItem
            // 
            manageServiceCategoriesToolStripMenuItem.Name = "manageServiceCategoriesToolStripMenuItem";
            manageServiceCategoriesToolStripMenuItem.Size = new Size(143, 24);
            manageServiceCategoriesToolStripMenuItem.Text = "Service categories";
            manageServiceCategoriesToolStripMenuItem.Click += manageServiceCategoriesToolStripMenuItem_Click;
            // 
            // manageSpecializationsToolStripMenuItem
            // 
            manageSpecializationsToolStripMenuItem.Name = "manageSpecializationsToolStripMenuItem";
            manageSpecializationsToolStripMenuItem.Size = new Size(122, 24);
            manageSpecializationsToolStripMenuItem.Text = "Specializations";
            manageSpecializationsToolStripMenuItem.Click += manageSpecializationsToolStripMenuItem_Click;
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(66, 24);
            otherToolStripMenuItem.Text = "Others";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "AdminMainForm";
            Text = "Form1";
            Load += AdminMainForm_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            tabPage3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox richTextBoxReport;
        private Button buttonExportToDocx;
        private Button buttonExportToXLSX;
        private Button buttonGenerateReport;
        private DataGridView dataGridViewServices;
        private Label labelTotalServices;
        private Label labelActiveIncidents;
        private Label labelTotalIncidents;
        private Label labelCriticalServices;
        private Label labelMaintenanceToday;
        private Label labelTotalEmployees;
        private Label labelCriticalUnresolved;
        private Label labelResolvedToday;
        private Label labelActiveServices;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem manageServiceCategoriesToolStripMenuItem;
        private ToolStripMenuItem manageSpecializationsToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}