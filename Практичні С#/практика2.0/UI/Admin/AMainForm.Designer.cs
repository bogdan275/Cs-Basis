

namespace UI
{
    partial class AMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewServices = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewIncidents = new DataGridView();
            tabPage3 = new TabPage();
            richTextBoxReport = new RichTextBox();
            buttonExportToDocx = new Button();
            buttonExportToXLSX = new Button();
            buttonGenerateReport = new Button();
            menuStrip1 = new MenuStrip();
            mainToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            incidentsToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            logsToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncidents).BeginInit();
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
            tabControl1.Size = new Size(800, 422);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewServices);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Services";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Dock = DockStyle.Fill;
            dataGridViewServices.GridColor = SystemColors.HighlightText;
            dataGridViewServices.Location = new Point(3, 3);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(786, 383);
            dataGridViewServices.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewIncidents);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 389);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Incidents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIncidents
            // 
            dataGridViewIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIncidents.Dock = DockStyle.Fill;
            dataGridViewIncidents.GridColor = SystemColors.HighlightText;
            dataGridViewIncidents.Location = new Point(3, 3);
            dataGridViewIncidents.Name = "dataGridViewIncidents";
            dataGridViewIncidents.RowHeadersWidth = 51;
            dataGridViewIncidents.Size = new Size(786, 383);
            dataGridViewIncidents.TabIndex = 1;
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
            tabPage3.Size = new Size(792, 389);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReport
            // 
            richTextBoxReport.Dock = DockStyle.Top;
            richTextBoxReport.Location = new Point(3, 3);
            richTextBoxReport.Name = "richTextBoxReport";
            richTextBoxReport.Size = new Size(786, 331);
            richTextBoxReport.TabIndex = 3;
            richTextBoxReport.Text = "";
            // 
            // buttonExportToDocx
            // 
            buttonExportToDocx.Enabled = false;
            buttonExportToDocx.Location = new Point(642, 340);
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
            buttonExportToXLSX.Location = new Point(509, 340);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { servicesToolStripMenuItem, incidentsToolStripMenuItem, employeeToolStripMenuItem, logsToolStripMenuItem });
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new Size(103, 24);
            mainToolStripMenuItem.Text = "Managment";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(224, 26);
            servicesToolStripMenuItem.Text = "Services";
            servicesToolStripMenuItem.Click += servicesToolStripMenuItem_Click;
            // 
            // incidentsToolStripMenuItem
            // 
            incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            incidentsToolStripMenuItem.Size = new Size(224, 26);
            incidentsToolStripMenuItem.Text = "Incidents";
            incidentsToolStripMenuItem.Click += incidentsToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 26);
            employeeToolStripMenuItem.Text = "Employees";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(224, 26);
            logsToolStripMenuItem.Text = "Logs";
            logsToolStripMenuItem.Click += logsToolStripMenuItem_Click;
            // 
            // AMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AMainForm";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncidents).EndInit();
            tabPage3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewServices;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private TabPage tabPage3;
        private DataGridView dataGridViewIncidents;
        private Button buttonGenerateReport;
        private Button buttonExportToDocx;
        private Button buttonExportToXLSX;
        private RichTextBox richTextBoxReport;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem incidentsToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem logsToolStripMenuItem;
    }
}
