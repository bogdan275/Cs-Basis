namespace UI
{
    partial class StockMoveForm
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
            gridHistory = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            comboBoxReciveProduct = new ComboBox();
            comboBoxReciveTo = new ComboBox();
            numericUpDownReciveQ = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            btnReceive = new Button();
            tabPage2 = new TabPage();
            label5 = new Label();
            comboBoxShipProduct = new ComboBox();
            btnShip = new Button();
            label6 = new Label();
            label7 = new Label();
            comboBoxShipTo = new ComboBox();
            numericUpDownShipQ = new NumericUpDown();
            label8 = new Label();
            comboBoxShipFrom = new ComboBox();
            tabPage3 = new TabPage();
            label9 = new Label();
            comboBoxRelocateProduct = new ComboBox();
            btnRelocate = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBoxRelocateTo = new ComboBox();
            comboBoxRelocateFrom = new ComboBox();
            numericUpDownRelocateQ = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReciveQ).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShipQ).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelocateQ).BeginInit();
            SuspendLayout();
            // 
            // gridHistory
            // 
            gridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHistory.Dock = DockStyle.Left;
            gridHistory.Location = new Point(0, 0);
            gridHistory.Name = "gridHistory";
            gridHistory.RowHeadersWidth = 51;
            gridHistory.Size = new Size(577, 450);
            gridHistory.TabIndex = 25;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(577, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(223, 450);
            tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBoxReciveProduct);
            tabPage1.Controls.Add(comboBoxReciveTo);
            tabPage1.Controls.Add(numericUpDownReciveQ);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnReceive);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(215, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Receive";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 5);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 35;
            label4.Text = "Product";
            // 
            // comboBoxReciveProduct
            // 
            comboBoxReciveProduct.FormattingEnabled = true;
            comboBoxReciveProduct.Location = new Point(6, 28);
            comboBoxReciveProduct.Name = "comboBoxReciveProduct";
            comboBoxReciveProduct.Size = new Size(196, 28);
            comboBoxReciveProduct.TabIndex = 34;
            // 
            // comboBoxReciveTo
            // 
            comboBoxReciveTo.FormattingEnabled = true;
            comboBoxReciveTo.Location = new Point(6, 135);
            comboBoxReciveTo.Name = "comboBoxReciveTo";
            comboBoxReciveTo.Size = new Size(196, 28);
            comboBoxReciveTo.TabIndex = 33;
            // 
            // numericUpDownReciveQ
            // 
            numericUpDownReciveQ.Location = new Point(6, 82);
            numericUpDownReciveQ.Name = "numericUpDownReciveQ";
            numericUpDownReciveQ.Size = new Size(196, 27);
            numericUpDownReciveQ.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 30;
            label3.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 28;
            label1.Text = "Quantity";
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(6, 369);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(196, 42);
            btnReceive.TabIndex = 25;
            btnReceive.Text = "Receive";
            btnReceive.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBoxShipProduct);
            tabPage2.Controls.Add(btnShip);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(comboBoxShipTo);
            tabPage2.Controls.Add(numericUpDownShipQ);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboBoxShipFrom);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(215, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ship";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 4);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 43;
            label5.Text = "Product";
            // 
            // comboBoxShipProduct
            // 
            comboBoxShipProduct.FormattingEnabled = true;
            comboBoxShipProduct.Location = new Point(6, 27);
            comboBoxShipProduct.Name = "comboBoxShipProduct";
            comboBoxShipProduct.Size = new Size(196, 28);
            comboBoxShipProduct.TabIndex = 42;
            // 
            // btnShip
            // 
            btnShip.Location = new Point(6, 367);
            btnShip.Name = "btnShip";
            btnShip.Size = new Size(196, 42);
            btnShip.TabIndex = 26;
            btnShip.Text = "Ship";
            btnShip.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 165);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 38;
            label6.Text = "To";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 111);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 37;
            label7.Text = "From";
            // 
            // comboBoxShipTo
            // 
            comboBoxShipTo.FormattingEnabled = true;
            comboBoxShipTo.Location = new Point(6, 188);
            comboBoxShipTo.Name = "comboBoxShipTo";
            comboBoxShipTo.Size = new Size(196, 28);
            comboBoxShipTo.TabIndex = 41;
            // 
            // numericUpDownShipQ
            // 
            numericUpDownShipQ.Location = new Point(6, 81);
            numericUpDownShipQ.Name = "numericUpDownShipQ";
            numericUpDownShipQ.Size = new Size(196, 27);
            numericUpDownShipQ.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 58);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 36;
            label8.Text = "Quantity";
            // 
            // comboBoxShipFrom
            // 
            comboBoxShipFrom.FormattingEnabled = true;
            comboBoxShipFrom.Location = new Point(6, 134);
            comboBoxShipFrom.Name = "comboBoxShipFrom";
            comboBoxShipFrom.Size = new Size(196, 28);
            comboBoxShipFrom.TabIndex = 40;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(comboBoxRelocateProduct);
            tabPage3.Controls.Add(btnRelocate);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(comboBoxRelocateTo);
            tabPage3.Controls.Add(comboBoxRelocateFrom);
            tabPage3.Controls.Add(numericUpDownRelocateQ);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(215, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Relocate";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 4);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 43;
            label9.Text = "Product";
            // 
            // comboBoxRelocateProduct
            // 
            comboBoxRelocateProduct.FormattingEnabled = true;
            comboBoxRelocateProduct.Location = new Point(9, 27);
            comboBoxRelocateProduct.Name = "comboBoxRelocateProduct";
            comboBoxRelocateProduct.Size = new Size(196, 28);
            comboBoxRelocateProduct.TabIndex = 42;
            // 
            // btnRelocate
            // 
            btnRelocate.Location = new Point(6, 367);
            btnRelocate.Name = "btnRelocate";
            btnRelocate.Size = new Size(196, 42);
            btnRelocate.TabIndex = 27;
            btnRelocate.Text = "Relocate";
            btnRelocate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 165);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 38;
            label10.Text = "To";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 111);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 37;
            label11.Text = "From";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 58);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 36;
            label12.Text = "Quantity";
            // 
            // comboBoxRelocateTo
            // 
            comboBoxRelocateTo.FormattingEnabled = true;
            comboBoxRelocateTo.Location = new Point(9, 188);
            comboBoxRelocateTo.Name = "comboBoxRelocateTo";
            comboBoxRelocateTo.Size = new Size(196, 28);
            comboBoxRelocateTo.TabIndex = 41;
            // 
            // comboBoxRelocateFrom
            // 
            comboBoxRelocateFrom.FormattingEnabled = true;
            comboBoxRelocateFrom.Location = new Point(9, 134);
            comboBoxRelocateFrom.Name = "comboBoxRelocateFrom";
            comboBoxRelocateFrom.Size = new Size(196, 28);
            comboBoxRelocateFrom.TabIndex = 40;
            // 
            // numericUpDownRelocateQ
            // 
            numericUpDownRelocateQ.Location = new Point(9, 81);
            numericUpDownRelocateQ.Name = "numericUpDownRelocateQ";
            numericUpDownRelocateQ.Size = new Size(196, 27);
            numericUpDownRelocateQ.TabIndex = 39;
            // 
            // StockMoveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(gridHistory);
            Name = "StockMoveForm";
            Text = "StockMoveForm";
            Load += StockMoveForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReciveQ).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShipQ).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelocateQ).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridHistory;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private ComboBox comboBoxReciveProduct;
        private ComboBox comboBoxReciveTo;
        private NumericUpDown numericUpDownReciveQ;
        private Label label3;
        private Label label1;
        private Button btnRelocate;
        private Button btnShip;
        private Button btnReceive;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private ComboBox comboBoxShipProduct;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxShipTo;
        private NumericUpDown numericUpDownShipQ;
        private Label label8;
        private ComboBox comboBoxShipFrom;
        private Label label9;
        private ComboBox comboBoxRelocateProduct;
        private ComboBox comboBoxRelocateTo;
        private ComboBox comboBoxRelocateFrom;
        private NumericUpDown numericUpDownRelocateQ;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}