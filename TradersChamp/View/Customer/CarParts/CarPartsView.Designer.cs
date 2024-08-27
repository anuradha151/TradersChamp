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
            tblCarPartsOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCarPartsOrder).BeginInit();
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
            // tblCarPartsOrder
            // 
            tblCarPartsOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCarPartsOrder.Location = new Point(639, 82);
            tblCarPartsOrder.Name = "tblCarPartsOrder";
            tblCarPartsOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblCarPartsOrder.Size = new Size(629, 225);
            tblCarPartsOrder.TabIndex = 7;
            // 
            // CarPartsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(tblCarPartsOrder);
            Controls.Add(tblData);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarPartsView";
            Text = "CarPartsView";
            ((System.ComponentModel.ISupportInitialize)tblData).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCarPartsOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblData;
        private TextBox txtSearch;
        private DataGridView tblCarPartsOrder;
    }
}