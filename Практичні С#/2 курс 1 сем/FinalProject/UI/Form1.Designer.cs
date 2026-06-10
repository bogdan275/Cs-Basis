namespace UI
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
            tabPage3 = new TabPage();
            labelInvoices = new Label();
            buttonBilling = new Button();
            labelRevenue = new Label();
            tabPage2 = new TabPage();
            buttonBins = new Button();
            buttonZones = new Button();
            buttonWarehouses = new Button();
            labelLastActivity = new Label();
            labelOccupancy = new Label();
            labelTotalStock = new Label();
            buttonInfrastructure = new Button();
            tabPage1 = new TabPage();
            buttonTariffs = new Button();
            buttonProducts = new Button();
            buttonClients = new Button();
            labelTariffsStat = new Label();
            labelProductsStat = new Label();
            labelClientsStat = new Label();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(labelInvoices);
            tabPage3.Controls.Add(buttonBilling);
            tabPage3.Controls.Add(labelRevenue);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Finance";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelInvoices
            // 
            labelInvoices.AutoSize = true;
            labelInvoices.Font = new Font("Segoe UI", 12F);
            labelInvoices.Location = new Point(62, 90);
            labelInvoices.Name = "labelInvoices";
            labelInvoices.Size = new Size(65, 28);
            labelInvoices.TabIndex = 2;
            labelInvoices.Text = "label2";
            // 
            // buttonBilling
            // 
            buttonBilling.Location = new Point(62, 344);
            buttonBilling.Name = "buttonBilling";
            buttonBilling.Size = new Size(100, 35);
            buttonBilling.TabIndex = 1;
            buttonBilling.Text = "Billing";
            buttonBilling.UseVisualStyleBackColor = true;
            buttonBilling.Click += buttonBilling_Click;
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Font = new Font("Segoe UI", 12F);
            labelRevenue.Location = new Point(62, 35);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(65, 28);
            labelRevenue.TabIndex = 0;
            labelRevenue.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonBins);
            tabPage2.Controls.Add(buttonZones);
            tabPage2.Controls.Add(buttonWarehouses);
            tabPage2.Controls.Add(labelLastActivity);
            tabPage2.Controls.Add(labelOccupancy);
            tabPage2.Controls.Add(labelTotalStock);
            tabPage2.Controls.Add(buttonInfrastructure);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Warehouse";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBins
            // 
            buttonBins.Location = new Point(274, 344);
            buttonBins.Name = "buttonBins";
            buttonBins.Size = new Size(100, 35);
            buttonBins.TabIndex = 6;
            buttonBins.Text = "Bins";
            buttonBins.UseVisualStyleBackColor = true;
            buttonBins.Click += buttonBins_Click;
            // 
            // buttonZones
            // 
            buttonZones.Location = new Point(168, 344);
            buttonZones.Name = "buttonZones";
            buttonZones.Size = new Size(100, 35);
            buttonZones.TabIndex = 5;
            buttonZones.Text = "Zones";
            buttonZones.UseVisualStyleBackColor = true;
            buttonZones.Click += buttonZones_Click;
            // 
            // buttonWarehouses
            // 
            buttonWarehouses.Location = new Point(62, 344);
            buttonWarehouses.Name = "buttonWarehouses";
            buttonWarehouses.Size = new Size(100, 35);
            buttonWarehouses.TabIndex = 4;
            buttonWarehouses.Text = "Warehouses";
            buttonWarehouses.UseVisualStyleBackColor = true;
            buttonWarehouses.Click += buttonWarehouses_Click;
            // 
            // labelLastActivity
            // 
            labelLastActivity.AutoSize = true;
            labelLastActivity.Font = new Font("Segoe UI", 12F);
            labelLastActivity.Location = new Point(62, 147);
            labelLastActivity.Name = "labelLastActivity";
            labelLastActivity.Size = new Size(65, 28);
            labelLastActivity.TabIndex = 3;
            labelLastActivity.Text = "label3";
            // 
            // labelOccupancy
            // 
            labelOccupancy.AutoSize = true;
            labelOccupancy.Font = new Font("Segoe UI", 12F);
            labelOccupancy.Location = new Point(62, 90);
            labelOccupancy.Name = "labelOccupancy";
            labelOccupancy.Size = new Size(65, 28);
            labelOccupancy.TabIndex = 2;
            labelOccupancy.Text = "label2";
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Font = new Font("Segoe UI", 12F);
            labelTotalStock.Location = new Point(62, 35);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(65, 28);
            labelTotalStock.TabIndex = 1;
            labelTotalStock.Text = "label1";
            // 
            // buttonInfrastructure
            // 
            buttonInfrastructure.Location = new Point(459, 344);
            buttonInfrastructure.Name = "buttonInfrastructure";
            buttonInfrastructure.Size = new Size(94, 35);
            buttonInfrastructure.TabIndex = 0;
            buttonInfrastructure.Text = "Locate";
            buttonInfrastructure.UseVisualStyleBackColor = true;
            buttonInfrastructure.Click += buttonInfrastructure_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonTariffs);
            tabPage1.Controls.Add(buttonProducts);
            tabPage1.Controls.Add(buttonClients);
            tabPage1.Controls.Add(labelTariffsStat);
            tabPage1.Controls.Add(labelProductsStat);
            tabPage1.Controls.Add(labelClientsStat);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonTariffs
            // 
            buttonTariffs.Location = new Point(274, 354);
            buttonTariffs.Name = "buttonTariffs";
            buttonTariffs.Size = new Size(100, 35);
            buttonTariffs.TabIndex = 6;
            buttonTariffs.Text = "Tariffs";
            buttonTariffs.UseVisualStyleBackColor = true;
            buttonTariffs.Click += buttonTariffs_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(168, 354);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(100, 35);
            buttonProducts.TabIndex = 5;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonClients
            // 
            buttonClients.Location = new Point(62, 354);
            buttonClients.Name = "buttonClients";
            buttonClients.Size = new Size(100, 35);
            buttonClients.TabIndex = 4;
            buttonClients.Text = "Clients";
            buttonClients.UseVisualStyleBackColor = true;
            buttonClients.Click += buttonClients_Click;
            // 
            // labelTariffsStat
            // 
            labelTariffsStat.AutoSize = true;
            labelTariffsStat.Font = new Font("Segoe UI", 12F);
            labelTariffsStat.Location = new Point(62, 147);
            labelTariffsStat.Name = "labelTariffsStat";
            labelTariffsStat.Size = new Size(65, 28);
            labelTariffsStat.TabIndex = 2;
            labelTariffsStat.Text = "label3";
            // 
            // labelProductsStat
            // 
            labelProductsStat.AutoSize = true;
            labelProductsStat.Font = new Font("Segoe UI", 12F);
            labelProductsStat.Location = new Point(62, 90);
            labelProductsStat.Name = "labelProductsStat";
            labelProductsStat.Size = new Size(65, 28);
            labelProductsStat.TabIndex = 1;
            labelProductsStat.Text = "label2";
            // 
            // labelClientsStat
            // 
            labelClientsStat.AutoSize = true;
            labelClientsStat.Font = new Font("Segoe UI", 12F);
            labelClientsStat.Location = new Point(62, 35);
            labelClientsStat.Name = "labelClientsStat";
            labelClientsStat.Size = new Size(65, 28);
            labelClientsStat.TabIndex = 0;
            labelClientsStat.Text = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.warehouse_interior_with_cardboard_boxes_107791_3324;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private Label labelInvoices;
        private Button buttonBilling;
        private Label labelRevenue;
        private TabPage tabPage2;
        private Button buttonBins;
        private Button buttonZones;
        private Button buttonWarehouses;
        private Label labelLastActivity;
        private Label labelOccupancy;
        private Label labelTotalStock;
        private Button buttonInfrastructure;
        private TabPage tabPage1;
        private Button buttonTariffs;
        private Button buttonProducts;
        private Button buttonClients;
        private Label labelTariffsStat;
        private Label labelProductsStat;
        private Label labelClientsStat;
        private TabControl tabControl1;
        private Panel panelMenu;
        private Button buttonDashboard;
        private Panel panelContent;
        private Button buttonCatalog;
        private Button buttonInventory;
    }
}
