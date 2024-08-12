namespace TradersChamp.View.Admin
{
    partial class UpdateCarForm
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
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtFuelType = new TextBox();
            txtYear = new TextBox();
            txtMileage = new TextBox();
            txtBodyStyle = new TextBox();
            txtVIN = new TextBox();
            txtTransmission = new TextBox();
            txtColor = new TextBox();
            txtDrivetrain = new TextBox();
            txtDoors = new TextBox();
            txtSeatingCapacity = new TextBox();
            txtEngine = new TextBox();
            txtInteriorColor = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(12, 56);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = " Brand Name";
            txtBrand.Size = new Size(191, 23);
            txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 85);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = " Model Name";
            txtModel.Size = new Size(191, 23);
            txtModel.TabIndex = 0;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(209, 56);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.PlaceholderText = " Fuel Type";
            txtFuelType.Size = new Size(191, 23);
            txtFuelType.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 114);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = " Year";
            txtYear.Size = new Size(191, 23);
            txtYear.TabIndex = 0;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(209, 85);
            txtMileage.Name = "txtMileage";
            txtMileage.PlaceholderText = " Mileage";
            txtMileage.Size = new Size(191, 23);
            txtMileage.TabIndex = 0;
            // 
            // txtBodyStyle
            // 
            txtBodyStyle.Location = new Point(12, 143);
            txtBodyStyle.Name = "txtBodyStyle";
            txtBodyStyle.PlaceholderText = " Body Style";
            txtBodyStyle.Size = new Size(191, 23);
            txtBodyStyle.TabIndex = 0;
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(209, 114);
            txtVIN.Name = "txtVIN";
            txtVIN.PlaceholderText = " VIN";
            txtVIN.Size = new Size(191, 23);
            txtVIN.TabIndex = 0;
            // 
            // txtTransmission
            // 
            txtTransmission.Location = new Point(12, 201);
            txtTransmission.Name = "txtTransmission";
            txtTransmission.PlaceholderText = " Transmission";
            txtTransmission.Size = new Size(191, 23);
            txtTransmission.TabIndex = 0;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(209, 143);
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = " Color";
            txtColor.Size = new Size(191, 23);
            txtColor.TabIndex = 0;
            // 
            // txtDrivetrain
            // 
            txtDrivetrain.Location = new Point(12, 230);
            txtDrivetrain.Name = "txtDrivetrain";
            txtDrivetrain.PlaceholderText = " Drivetrain";
            txtDrivetrain.Size = new Size(191, 23);
            txtDrivetrain.TabIndex = 0;
            // 
            // txtDoors
            // 
            txtDoors.Location = new Point(209, 201);
            txtDoors.Name = "txtDoors";
            txtDoors.PlaceholderText = " Doors Count";
            txtDoors.Size = new Size(191, 23);
            txtDoors.TabIndex = 0;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.Location = new Point(209, 230);
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.PlaceholderText = " Seating Capacity";
            txtSeatingCapacity.Size = new Size(191, 23);
            txtSeatingCapacity.TabIndex = 0;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(12, 172);
            txtEngine.Name = "txtEngine";
            txtEngine.PlaceholderText = " Engine";
            txtEngine.Size = new Size(191, 23);
            txtEngine.TabIndex = 0;
            // 
            // txtInteriorColor
            // 
            txtInteriorColor.Location = new Point(209, 172);
            txtInteriorColor.Name = "txtInteriorColor";
            txtInteriorColor.PlaceholderText = " Interior Color";
            txtInteriorColor.Size = new Size(191, 23);
            txtInteriorColor.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(325, 259);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 2;
            label1.Text = "Update Car Details";
            // 
            // UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(txtBrand);
            Controls.Add(btnUpdate);
            Controls.Add(txtModel);
            Controls.Add(txtInteriorColor);
            Controls.Add(txtFuelType);
            Controls.Add(txtEngine);
            Controls.Add(txtYear);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtMileage);
            Controls.Add(txtDoors);
            Controls.Add(txtBodyStyle);
            Controls.Add(txtDrivetrain);
            Controls.Add(txtVIN);
            Controls.Add(txtColor);
            Controls.Add(txtTransmission);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCarForm";
            Text = "UpdateCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtFuelType;
        private TextBox txtYear;
        private TextBox txtMileage;
        private TextBox txtBodyStyle;
        private TextBox txtVIN;
        private TextBox txtTransmission;
        private TextBox txtColor;
        private TextBox txtDrivetrain;
        private TextBox txtDoors;
        private TextBox txtSeatingCapacity;
        private TextBox txtEngine;
        private TextBox txtInteriorColor;
        private Button btnUpdate;
        private Label label1;
    }
}