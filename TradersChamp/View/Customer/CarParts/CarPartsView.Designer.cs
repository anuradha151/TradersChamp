namespace TradersChamp.View.Customer.CarParts
{
    partial class CarPartsView
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
            tblData = new DataGridView();
            txtSearch = new TextBox();
            tblCart = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtItemName = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQty = new TextBox();
            label5 = new Label();
            txtAmount = new TextBox();
            btnAddToCart = new Button();
            txtTotal = new TextBox();
            label6 = new Label();
            btnProceed = new Button();
            ((System.ComponentModel.ISupportInitialize)tblData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCart).BeginInit();
            SuspendLayout();
            // 
            // tblData
            // 
            tblData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblData.Location = new Point(0, 41);
            tblData.Name = "tblData";
            tblData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblData.Size = new Size(501, 542);
            tblData.TabIndex = 6;
            tblData.CellDoubleClick += tblData_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search by any detail";
            txtSearch.Size = new Size(265, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tblCart
            // 
            tblCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCart.Location = new Point(638, 255);
            tblCart.Name = "tblCart";
            tblCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblCart.Size = new Size(629, 225);
            tblCart.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(638, 228);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 8;
            label1.Text = "Cart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 41);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Enabled = false;
            txtItemName.Location = new Point(762, 38);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(202, 23);
            txtItemName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 70);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(762, 67);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 23);
            txtPrice.TabIndex = 10;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 99);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(762, 96);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(202, 23);
            txtQty.TabIndex = 10;
            txtQty.Text = "1";
            txtQty.TextChanged += txtQty_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 128);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Location = new Point(762, 125);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(202, 23);
            txtAmount.TabIndex = 10;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(853, 154);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(111, 23);
            btnAddToCart.TabIndex = 11;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(1065, 486);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(202, 23);
            txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1027, 489);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 12;
            label6.Text = "Total";
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(1156, 515);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(111, 23);
            btnProceed.TabIndex = 11;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            // 
            // CarPartsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(btnProceed);
            Controls.Add(btnAddToCart);
            Controls.Add(txtAmount);
            Controls.Add(label5);
            Controls.Add(txtQty);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtItemName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tblCart);
            Controls.Add(tblData);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarPartsView";
            Text = "CarPartsView";
            ((System.ComponentModel.ISupportInitialize)tblData).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblData;
        private TextBox txtSearch;
        private DataGridView tblCart;
        private Label label1;
        private Label label2;
        private TextBox txtItemName;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQty;
        private Label label5;
        private TextBox txtAmount;
        private Button btnAddToCart;
        private TextBox txtTotal;
        private Label label6;
        private Button btnProceed;
    }
}