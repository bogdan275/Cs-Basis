namespace UI
{
    partial class WarehouseForm
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
            label1 = new Label();
            buttonDelate = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            listBoxWarehouses = new ListBox();
            label2 = new Label();
            textBoxAdress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // buttonDelate
            // 
            buttonDelate.Location = new Point(694, 397);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(94, 29);
            buttonDelate.TabIndex = 13;
            buttonDelate.Text = "Delate";
            buttonDelate.UseVisualStyleBackColor = true;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(694, 345);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(592, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(592, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(196, 27);
            textBoxName.TabIndex = 9;
            // 
            // listBoxWarehouses
            // 
            listBoxWarehouses.Dock = DockStyle.Left;
            listBoxWarehouses.FormattingEnabled = true;
            listBoxWarehouses.Location = new Point(0, 0);
            listBoxWarehouses.Name = "listBoxWarehouses";
            listBoxWarehouses.Size = new Size(478, 450);
            listBoxWarehouses.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 87);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 15;
            label2.Text = "Adress";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(592, 110);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(196, 27);
            textBoxAdress.TabIndex = 16;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAdress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(listBoxWarehouses);
            Name = "WarehouseForm";
            Text = "WarehouseForm";
            Load += WarehouseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonDelate;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBoxName;
        private ListBox listBoxWarehouses;
        private Label label2;
        private TextBox textBoxAdress;
    }
}