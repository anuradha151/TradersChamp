namespace TradersChamp.View.Admin.Report
{
    partial class CarReport
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
            btnGenerateCarReport = new Button();
            SuspendLayout();
            // 
            // btnGenerateCarReport
            // 
            btnGenerateCarReport.Location = new Point(12, 12);
            btnGenerateCarReport.Name = "btnGenerateCarReport";
            btnGenerateCarReport.Size = new Size(197, 23);
            btnGenerateCarReport.TabIndex = 0;
            btnGenerateCarReport.Text = "Generate Car Report";
            btnGenerateCarReport.UseVisualStyleBackColor = true;
            btnGenerateCarReport.Click += btnGenerateCarReport_Click;
            // 
            // CarReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 544);
            Controls.Add(btnGenerateCarReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarReport";
            Text = "CarReport";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateCarReport;
    }
}