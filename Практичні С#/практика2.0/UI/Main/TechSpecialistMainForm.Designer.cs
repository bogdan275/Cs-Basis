namespace UI.Main
{
    partial class TechSpecialistMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            incidentsToolStripMenuItem = new ToolStripMenuItem();
            logsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lblNewIncidents = new Label();
            lblGridTitle = new Label();
            dgvActiveTasks = new DataGridView();
            othersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveTasks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { servicesToolStripMenuItem, incidentsToolStripMenuItem, logsToolStripMenuItem, logoutToolStripMenuItem, othersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(132, 24);
            servicesToolStripMenuItem.Text = "Manage services";
            servicesToolStripMenuItem.Click += btnOpenServices_Click;
            // 
            // incidentsToolStripMenuItem
            // 
            incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            incidentsToolStripMenuItem.Size = new Size(138, 24);
            incidentsToolStripMenuItem.Text = "Analyze incidents";
            incidentsToolStripMenuItem.Click += btnOpenIncidents_Click;
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(136, 24);
            logsToolStripMenuItem.Text = "View system logs";
            logsToolStripMenuItem.Click += btnOpenLogs_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // lblNewIncidents
            // 
            lblNewIncidents.AutoSize = true;
            lblNewIncidents.Font = new Font("Segoe UI", 9F);
            lblNewIncidents.ForeColor = SystemColors.ActiveCaptionText;
            lblNewIncidents.Location = new Point(12, 45);
            lblNewIncidents.Name = "lblNewIncidents";
            lblNewIncidents.Size = new Size(195, 20);
            lblNewIncidents.TabIndex = 4;
            lblNewIncidents.Text = "New unassigned incidents: 0";
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Location = new Point(12, 80);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(181, 20);
            lblGridTitle.TabIndex = 5;
            lblGridTitle.Text = "Active incidents in system:";
            // 
            // dgvActiveTasks
            // 
            dgvActiveTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveTasks.BackgroundColor = SystemColors.Window;
            dgvActiveTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveTasks.Dock = DockStyle.Bottom;
            dgvActiveTasks.Location = new Point(0, 103);
            dgvActiveTasks.Name = "dgvActiveTasks";
            dgvActiveTasks.ReadOnly = true;
            dgvActiveTasks.RowHeadersWidth = 51;
            dgvActiveTasks.Size = new Size(900, 447);
            dgvActiveTasks.TabIndex = 6;
            // 
            // othersToolStripMenuItem
            // 
            othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            othersToolStripMenuItem.Size = new Size(66, 24);
            othersToolStripMenuItem.Text = "Others";
            // 
            // TechSpecialistMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(dgvActiveTasks);
            Controls.Add(lblGridTitle);
            Controls.Add(lblNewIncidents);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TechSpecialistMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitoring System - Specialist Terminal";
            Load += TechSpecialistMainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem incidentsToolStripMenuItem;
        private ToolStripMenuItem logsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label lblNewIncidents;
        private Label lblGridTitle;
        private DataGridView dgvActiveTasks;
        private ToolStripMenuItem othersToolStripMenuItem;
    }
}