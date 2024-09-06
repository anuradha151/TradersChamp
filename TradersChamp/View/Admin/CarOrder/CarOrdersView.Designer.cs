namespace TradersChamp.View.Admin.CarOrder
{
    partial class CarOrdersView
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
            ((System.ComponentModel.ISupportInitialize)tblData).BeginInit();
            SuspendLayout();
            // 
            // tblData
            // 
            tblData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblData.Dock = DockStyle.Bottom;
            tblData.Location = new Point(0, 52);
            tblData.Name = "tblData";
            tblData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblData.Size = new Size(1567, 492);
            tblData.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search by any detail";
            txtSearch.Size = new Size(265, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // CarOrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 544);
            Controls.Add(tblData);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarOrdersView";
            Text = "CarOrdersView";
            ((System.ComponentModel.ISupportInitialize)tblData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblData;
        private TextBox txtSearch;
    }
}