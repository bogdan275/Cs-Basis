namespace UI.TechSpecialist
{
    partial class IncidentsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxIncidents = new ListBox();
            txtTitle = new TextBox();
            label1 = new Label();
            rtbDesc = new RichTextBox();
            label2 = new Label();
            cbPriority = new ComboBox();
            label3 = new Label();
            cbStatus = new ComboBox();
            label4 = new Label();
            rtbRootCause = new RichTextBox();
            label5 = new Label();
            rtbSolution = new RichTextBox();
            label6 = new Label();
            cbAuthor = new ComboBox();
            label7 = new Label();
            btnUpdate = new Button();
            btnResolve = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBoxIncidents
            // 
            listBoxIncidents.Dock = DockStyle.Left;
            listBoxIncidents.Location = new Point(0, 0);
            listBoxIncidents.Name = "listBoxIncidents";
            listBoxIncidents.Size = new Size(260, 520);
            listBoxIncidents.TabIndex = 0;
            listBoxIncidents.SelectedIndexChanged += listBoxIncidents_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(280, 40);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 27);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(280, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "Incident title";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(280, 100);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(300, 80);
            rtbDesc.TabIndex = 3;
            rtbDesc.Text = "";
            // 
            // label2
            // 
            label2.Location = new Point(280, 80);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Description of failure";
            // 
            // cbPriority
            // 
            cbPriority.Location = new Point(280, 210);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(140, 28);
            cbPriority.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(280, 190);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 6;
            label3.Text = "Priority*";
            // 
            // cbStatus
            // 
            cbStatus.Location = new Point(440, 210);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(140, 28);
            cbStatus.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(440, 190);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Status*";
            // 
            // rtbRootCause
            // 
            rtbRootCause.Location = new Point(600, 40);
            rtbRootCause.Name = "rtbRootCause";
            rtbRootCause.Size = new Size(192, 198);
            rtbRootCause.TabIndex = 9;
            rtbRootCause.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(600, 20);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Root cause analysis";
            // 
            // rtbSolution
            // 
            rtbSolution.Location = new Point(280, 267);
            rtbSolution.Name = "rtbSolution";
            rtbSolution.Size = new Size(300, 95);
            rtbSolution.TabIndex = 11;
            rtbSolution.Text = "";
            // 
            // label6
            // 
            label6.Location = new Point(280, 241);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Solution details";
            // 
            // cbAuthor
            // 
            cbAuthor.Location = new Point(280, 385);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(300, 28);
            cbAuthor.TabIndex = 13;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(280, 360);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 14;
            label7.Text = "Action author (Current Specialist)*";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(280, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnResolve
            // 
            btnResolve.BackColor = SystemColors.ButtonHighlight;
            btnResolve.Location = new Point(400, 440);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(130, 35);
            btnResolve.TabIndex = 16;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = false;
            btnResolve.Click += btnResolve_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(692, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // IncidentsForm
            // 
            ClientSize = new Size(814, 520);
            Controls.Add(listBoxIncidents);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(rtbDesc);
            Controls.Add(label2);
            Controls.Add(cbPriority);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(label4);
            Controls.Add(rtbRootCause);
            Controls.Add(label5);
            Controls.Add(rtbSolution);
            Controls.Add(label6);
            Controls.Add(cbAuthor);
            Controls.Add(label7);
            Controls.Add(btnUpdate);
            Controls.Add(btnResolve);
            Controls.Add(btnDelete);
            Name = "IncidentsForm";
            Text = "Incident Analysis & Resolution";
            Load += IncidentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxIncidents;
        private TextBox txtTitle;
        private Label label1;
        private RichTextBox rtbDesc;
        private Label label2;
        private ComboBox cbPriority;
        private Label label3;
        private ComboBox cbStatus;
        private Label label4;
        private RichTextBox rtbRootCause;
        private Label label5;
        private RichTextBox rtbSolution;
        private Label label6;
        private ComboBox cbAuthor;
        private Label label7;
        private Button btnUpdate;
        private Button btnResolve;
        private Button btnDelete;
    }
}