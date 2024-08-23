namespace TradersChamp.View.Customer.Car
{
    partial class CarView
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
            txtSearch = new TextBox();
            tblData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblData).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search by any detail";
            txtSearch.Size = new Size(265, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // tblData
            // 
            tblData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblData.Dock = DockStyle.Bottom;
            tblData.Location = new Point(0, 41);
            tblData.Name = "tblData";
            tblData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblData.Size = new Size(1583, 542);
            tblData.TabIndex = 4;
            tblData.CellDoubleClick += tblData_CellDoubleClick;
            // 
            // CarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(tblData);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarView";
            Text = "CarView";
            ((System.ComponentModel.ISupportInitialize)tblData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView tblData;
    }
}