﻿namespace TradersChamp.View.Admin
{
    partial class ViewAllCars
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
            btnAddNew = new Button();
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
            txtSearch.TabIndex = 0;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(1496, 12);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // tblData
            // 
            tblData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblData.Dock = DockStyle.Bottom;
            tblData.Location = new Point(0, 41);
            tblData.Name = "tblData";
            tblData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblData.Size = new Size(1583, 542);
            tblData.TabIndex = 3;
            tblData.CellDoubleClick += tblData_CellDoubleClick;
            // 
            // ViewAllCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(tblData);
            Controls.Add(btnAddNew);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAllCars";
            Text = "AdminCarAllView";
            ((System.ComponentModel.ISupportInitialize)tblData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnAddNew;
        private DataGridView tblData;
    }
}