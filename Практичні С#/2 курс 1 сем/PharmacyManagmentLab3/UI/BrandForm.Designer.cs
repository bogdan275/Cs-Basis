namespace UI
{
    partial class BrandForm
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
            listBoxBr = new ListBox();
            buttonAddBrand = new Button();
            buttonDelateBrand = new Button();
            buttonUpdateBrand = new Button();
            label1 = new Label();
            textBoxBrandName = new TextBox();
            SuspendLayout();
            // 
            // listBoxBr
            // 
            listBoxBr.Dock = DockStyle.Left;
            listBoxBr.FormattingEnabled = true;
            listBoxBr.Location = new Point(0, 0);
            listBoxBr.Name = "listBoxBr";
            listBoxBr.Size = new Size(476, 450);
            listBoxBr.TabIndex = 1;
            // 
            // buttonAddBrand
            // 
            buttonAddBrand.Location = new Point(644, 332);
            buttonAddBrand.Name = "buttonAddBrand";
            buttonAddBrand.Size = new Size(125, 29);
            buttonAddBrand.TabIndex = 12;
            buttonAddBrand.Text = "Add";
            buttonAddBrand.UseVisualStyleBackColor = true;
            buttonAddBrand.Click += buttonAddBrand_Click;
            // 
            // buttonDelateBrand
            // 
            buttonDelateBrand.Location = new Point(497, 332);
            buttonDelateBrand.Name = "buttonDelateBrand";
            buttonDelateBrand.Size = new Size(125, 29);
            buttonDelateBrand.TabIndex = 11;
            buttonDelateBrand.Text = "Delate";
            buttonDelateBrand.UseVisualStyleBackColor = true;
            buttonDelateBrand.Click += buttonDelateBrand_Click;
            // 
            // buttonUpdateBrand
            // 
            buttonUpdateBrand.Location = new Point(497, 405);
            buttonUpdateBrand.Name = "buttonUpdateBrand";
            buttonUpdateBrand.Size = new Size(125, 29);
            buttonUpdateBrand.TabIndex = 10;
            buttonUpdateBrand.Text = "Update";
            buttonUpdateBrand.UseVisualStyleBackColor = true;
            buttonUpdateBrand.Click += buttonUpdateBrand_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // textBoxBrandName
            // 
            textBoxBrandName.Location = new Point(497, 129);
            textBoxBrandName.Name = "textBoxBrandName";
            textBoxBrandName.Size = new Size(125, 27);
            textBoxBrandName.TabIndex = 8;
            // 
            // BrandForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddBrand);
            Controls.Add(buttonDelateBrand);
            Controls.Add(buttonUpdateBrand);
            Controls.Add(label1);
            Controls.Add(textBoxBrandName);
            Controls.Add(listBoxBr);
            Name = "BrandForm";
            Text = "BrandForm";
            Load += BrandForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBr;
        private Button buttonAddBrand;
        private Button buttonDelateBrand;
        private Button buttonUpdateBrand;
        private Button buttonAddAI;
        private Button buttonDelateAI;
        private Button buttonUpdateAi;
        private Label label1;
        private TextBox textBoxBrandName;
    }
}