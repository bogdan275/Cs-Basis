namespace UI.TechSpecialist
{
    partial class MaintenanceWindowsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxWindows = new ListBox();
            txtTitle = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            rtbReason = new RichTextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnStartMaint = new Button();
            btnCompleteMaint = new Button();
            lblTitle = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblReason = new Label();
            SuspendLayout();
            // 
            // listBoxWindows
            // 
            listBoxWindows.Dock = DockStyle.Left;
            listBoxWindows.FormattingEnabled = true;
            listBoxWindows.Location = new Point(0, 0);
            listBoxWindows.Name = "listBoxWindows";
            listBoxWindows.Size = new Size(280, 460);
            listBoxWindows.TabIndex = 0;
            listBoxWindows.SelectedIndexChanged += listBoxWindows_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(300, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(450, 27);
            txtTitle.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(300, 115);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(210, 27);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(530, 115);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(210, 27);
            dtpEnd.TabIndex = 3;
            // 
            // rtbReason
            // 
            rtbReason.Location = new Point(300, 185);
            rtbReason.Name = "rtbReason";
            rtbReason.Size = new Size(450, 120);
            rtbReason.TabIndex = 4;
            rtbReason.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 45);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Запланувати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(455, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(610, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(610, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnStartMaint
            // 
            btnStartMaint.BackColor = Color.White;
            btnStartMaint.Location = new Point(300, 380);
            btnStartMaint.Name = "btnStartMaint";
            btnStartMaint.Size = new Size(140, 45);
            btnStartMaint.TabIndex = 5;
            btnStartMaint.Text = "Розпочати";
            btnStartMaint.UseVisualStyleBackColor = false;
            btnStartMaint.Click += btnStartMaint_Click;
            // 
            // btnCompleteMaint
            // 
            btnCompleteMaint.BackColor = Color.White;
            btnCompleteMaint.Location = new Point(455, 380);
            btnCompleteMaint.Name = "btnCompleteMaint";
            btnCompleteMaint.Size = new Size(140, 45);
            btnCompleteMaint.TabIndex = 4;
            btnCompleteMaint.Text = "Завершити";
            btnCompleteMaint.UseVisualStyleBackColor = false;
            btnCompleteMaint.Click += btnCompleteMaint_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(300, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Name";
            // 
            // lblStart
            // 
            lblStart.Location = new Point(300, 90);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(200, 20);
            lblStart.TabIndex = 1;
            lblStart.Text = "Planned start";
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(530, 90);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(200, 20);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Planned completion";
            // 
            // lblReason
            // 
            lblReason.Location = new Point(300, 160);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(150, 20);
            lblReason.TabIndex = 3;
            lblReason.Text = "Description/Reason";
            // 
            // MaintenanceWindowsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 460);
            Controls.Add(lblTitle);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblReason);
            Controls.Add(btnCompleteMaint);
            Controls.Add(btnStartMaint);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(rtbReason);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(txtTitle);
            Controls.Add(listBoxWindows);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MaintenanceWindowsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Керування вікнами обслуговування";
            Load += MaintenanceWindowsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Додаємо нові кнопки в оголошення
        private Button btnStartMaint;
        private Button btnCompleteMaint;
        private ListBox listBoxWindows;
        private TextBox txtTitle;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private RichTextBox rtbReason;

        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblTitle;
        private Label lblStart;
        private Label lblEnd;
        private Label lblReason;
    }
}