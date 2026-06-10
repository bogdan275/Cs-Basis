namespace UI.TechSpecialist
{
    partial class AuditLogForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvLogs = new DataGridView();
            cbUserFilter = new ComboBox();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 15);
            label1.Text = "Specialist:";
            // 
            // cbUserFilter
            // 
            cbUserFilter.Location = new Point(12, 38);
            cbUserFilter.Size = new Size(200, 28);
            // 
            // label2
            // 
            label2.Location = new Point(230, 15);
            label2.Text = "Date from:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(230, 38);
            dtpFrom.Size = new Size(180, 27);
            // 
            // label3
            // 
            label3.Location = new Point(420, 15);
            label3.Text = "Date to:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(420, 38);
            dtpTo.Size = new Size(180, 27);
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(620, 35);
            btnRefresh.Size = new Size(120, 32);
            btnRefresh.Text = "Update list";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(750, 35);
            btnDelete.Size = new Size(130, 32);
            btnDelete.Text = "Delete selected";
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = SystemColors.Window;
            dgvLogs.Location = new Point(12, 85);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(960, 453);
            dgvLogs.TabIndex = 0;
            // 
            // AuditLogForm
            // 
            ClientSize = new Size(984, 550);
            Controls.Add(dgvLogs);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(dtpTo);
            Controls.Add(label2);
            Controls.Add(dtpFrom);
            Controls.Add(label1);
            Controls.Add(cbUserFilter);
            Name = "AuditLogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "System Audit Logs";
            Load += AuditLogForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvLogs;
        private ComboBox cbUserFilter;
        private Label label1;
        private DateTimePicker dtpFrom;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label3;
        private Button btnRefresh;
        private Button btnDelete;
    }
}