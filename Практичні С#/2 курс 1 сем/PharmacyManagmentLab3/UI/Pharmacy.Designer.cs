namespace UI
{
    partial class Pharmacy
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
            buttonActiveIngredient = new Button();
            buttonBatch = new Button();
            buttonBrand = new Button();
            buttonMedicine = new Button();
            buttonPurchaseOrder = new Button();
            buttonPurchaseOrderItem = new Button();
            buttonRecipe = new Button();
            buttonRefrigerator = new Button();
            buttonLogs = new Button();
            buttonReturnPolicy = new Button();
            buttonSale = new Button();
            buttonShelf = new Button();
            buttonShelfItem = new Button();
            buttonSupplier = new Button();
            SuspendLayout();
            // 
            // buttonActiveIngredient
            // 
            buttonActiveIngredient.Location = new Point(12, 12);
            buttonActiveIngredient.Name = "buttonActiveIngredient";
            buttonActiveIngredient.Size = new Size(176, 29);
            buttonActiveIngredient.TabIndex = 1;
            buttonActiveIngredient.Text = "Active ingredient";
            buttonActiveIngredient.UseVisualStyleBackColor = true;
            buttonActiveIngredient.Click += button1_Click;
            // 
            // buttonBatch
            // 
            buttonBatch.Location = new Point(12, 47);
            buttonBatch.Name = "buttonBatch";
            buttonBatch.Size = new Size(176, 29);
            buttonBatch.TabIndex = 2;
            buttonBatch.Text = "Batch";
            buttonBatch.UseVisualStyleBackColor = true;
            buttonBatch.Click += buttonBatch_Click;
            // 
            // buttonBrand
            // 
            buttonBrand.Location = new Point(12, 82);
            buttonBrand.Name = "buttonBrand";
            buttonBrand.Size = new Size(176, 29);
            buttonBrand.TabIndex = 3;
            buttonBrand.Text = "Brand";
            buttonBrand.UseVisualStyleBackColor = true;
            buttonBrand.Click += buttonBrand_Click;
            // 
            // buttonMedicine
            // 
            buttonMedicine.Location = new Point(12, 117);
            buttonMedicine.Name = "buttonMedicine";
            buttonMedicine.Size = new Size(176, 29);
            buttonMedicine.TabIndex = 4;
            buttonMedicine.Text = "Medicine";
            buttonMedicine.UseVisualStyleBackColor = true;
            buttonMedicine.Click += buttonMedicine_Click;
            // 
            // buttonPurchaseOrder
            // 
            buttonPurchaseOrder.Location = new Point(12, 152);
            buttonPurchaseOrder.Name = "buttonPurchaseOrder";
            buttonPurchaseOrder.Size = new Size(176, 29);
            buttonPurchaseOrder.TabIndex = 5;
            buttonPurchaseOrder.Text = "Purchase order";
            buttonPurchaseOrder.UseVisualStyleBackColor = true;
            buttonPurchaseOrder.Click += buttonPurchaseOrder_Click;
            // 
            // buttonPurchaseOrderItem
            // 
            buttonPurchaseOrderItem.Location = new Point(12, 187);
            buttonPurchaseOrderItem.Name = "buttonPurchaseOrderItem";
            buttonPurchaseOrderItem.Size = new Size(176, 29);
            buttonPurchaseOrderItem.TabIndex = 6;
            buttonPurchaseOrderItem.Text = "Purchase order item";
            buttonPurchaseOrderItem.UseVisualStyleBackColor = true;
            buttonPurchaseOrderItem.Click += buttonPurchaseOrderItem_Click;
            // 
            // buttonRecipe
            // 
            buttonRecipe.Location = new Point(12, 222);
            buttonRecipe.Name = "buttonRecipe";
            buttonRecipe.Size = new Size(176, 29);
            buttonRecipe.TabIndex = 7;
            buttonRecipe.Text = "Recipe";
            buttonRecipe.UseVisualStyleBackColor = true;
            buttonRecipe.Click += buttonRecipe_Click;
            // 
            // buttonRefrigerator
            // 
            buttonRefrigerator.Location = new Point(12, 257);
            buttonRefrigerator.Name = "buttonRefrigerator";
            buttonRefrigerator.Size = new Size(176, 29);
            buttonRefrigerator.TabIndex = 8;
            buttonRefrigerator.Text = "Refrigerator";
            buttonRefrigerator.UseVisualStyleBackColor = true;
            buttonRefrigerator.Click += buttonRefrigerator_Click;
            // 
            // buttonLogs
            // 
            buttonLogs.Location = new Point(12, 292);
            buttonLogs.Name = "buttonLogs";
            buttonLogs.Size = new Size(176, 29);
            buttonLogs.TabIndex = 9;
            buttonLogs.Text = "Refrigerator log";
            buttonLogs.UseVisualStyleBackColor = true;
            buttonLogs.Click += buttonLogs_Click;
            // 
            // buttonReturnPolicy
            // 
            buttonReturnPolicy.Location = new Point(12, 327);
            buttonReturnPolicy.Name = "buttonReturnPolicy";
            buttonReturnPolicy.Size = new Size(176, 29);
            buttonReturnPolicy.TabIndex = 10;
            buttonReturnPolicy.Text = "Return policity";
            buttonReturnPolicy.UseVisualStyleBackColor = true;
            buttonReturnPolicy.Click += buttonReturnPolicy_Click;
            // 
            // buttonSale
            // 
            buttonSale.Location = new Point(12, 362);
            buttonSale.Name = "buttonSale";
            buttonSale.Size = new Size(176, 29);
            buttonSale.TabIndex = 11;
            buttonSale.Text = "Sale";
            buttonSale.UseVisualStyleBackColor = true;
            buttonSale.Click += buttonSale_Click;
            // 
            // buttonShelf
            // 
            buttonShelf.Location = new Point(12, 397);
            buttonShelf.Name = "buttonShelf";
            buttonShelf.Size = new Size(176, 29);
            buttonShelf.TabIndex = 12;
            buttonShelf.Text = "Shef";
            buttonShelf.UseVisualStyleBackColor = true;
            buttonShelf.Click += buttonShelf_Click;
            // 
            // buttonShelfItem
            // 
            buttonShelfItem.Location = new Point(12, 432);
            buttonShelfItem.Name = "buttonShelfItem";
            buttonShelfItem.Size = new Size(176, 29);
            buttonShelfItem.TabIndex = 13;
            buttonShelfItem.Text = "Shelf item";
            buttonShelfItem.UseVisualStyleBackColor = true;
            buttonShelfItem.Click += buttonShelfItem_Click;
            // 
            // buttonSupplier
            // 
            buttonSupplier.Location = new Point(12, 467);
            buttonSupplier.Name = "buttonSupplier";
            buttonSupplier.Size = new Size(176, 29);
            buttonSupplier.TabIndex = 14;
            buttonSupplier.Text = "Supplier";
            buttonSupplier.UseVisualStyleBackColor = true;
            buttonSupplier.Click += buttonSupplier_Click;
            // 
            // Pharmacy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_xxv3p9xxv3p9xxv3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 513);
            Controls.Add(buttonSupplier);
            Controls.Add(buttonShelfItem);
            Controls.Add(buttonShelf);
            Controls.Add(buttonSale);
            Controls.Add(buttonReturnPolicy);
            Controls.Add(buttonLogs);
            Controls.Add(buttonRefrigerator);
            Controls.Add(buttonRecipe);
            Controls.Add(buttonPurchaseOrderItem);
            Controls.Add(buttonPurchaseOrder);
            Controls.Add(buttonMedicine);
            Controls.Add(buttonBrand);
            Controls.Add(buttonBatch);
            Controls.Add(buttonActiveIngredient);
            Name = "Pharmacy";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonActiveIngredient;
        private Button buttonBatch;
        private Button buttonBrand;
        private Button buttonMedicine;
        private Button buttonPurchaseOrder;
        private Button buttonPurchaseOrderItem;
        private Button buttonRecipe;
        private Button buttonRefrigerator;
        private Button buttonLogs;
        private Button buttonReturnPolicy;
        private Button buttonSale;
        private Button buttonShelf;
        private Button buttonShelfItem;
        private Button buttonSupplier;
    }
}
