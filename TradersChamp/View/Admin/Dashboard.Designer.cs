namespace TradersChamp.View
{
    partial class Dashboard
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
            pnlHeader = new Panel();
            btnCar = new Button();
            btnCustomer = new Button();
            btnCarParts = new Button();
            lblDashboard = new Label();
            pnlMain = new Panel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnCar);
            pnlHeader.Controls.Add(btnCustomer);
            pnlHeader.Controls.Add(btnCarParts);
            pnlHeader.Controls.Add(lblDashboard);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1583, 96);
            pnlHeader.TabIndex = 0;
            // 
            // btnCar
            // 
            btnCar.Location = new Point(161, 12);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(75, 73);
            btnCar.TabIndex = 1;
            btnCar.Text = "Car";
            btnCar.UseVisualStyleBackColor = true;
            btnCar.Click += btnCar_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(323, 12);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(75, 73);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCarParts
            // 
            btnCarParts.Location = new Point(242, 12);
            btnCarParts.Name = "btnCarParts";
            btnCarParts.Size = new Size(75, 73);
            btnCarParts.TabIndex = 1;
            btnCarParts.Text = "Car Parts";
            btnCarParts.UseVisualStyleBackColor = true;
            btnCarParts.Click += btnCarParts_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(23, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(104, 64);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "ADMIN\r\nPORTAL";
            lblDashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Bottom;
            pnlMain.Location = new Point(0, 102);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1583, 583);
            pnlMain.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 685);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlMain;
        private Button btnCar;
        private Button btnCarParts;
        private Label lblDashboard;
        private Button btnCustomer;
    }
}