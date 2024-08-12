namespace TradersChamp.View.Admin
{
    partial class AddCar
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
            txtYear = new TextBox();
            txtBodyStyle = new TextBox();
            txtTransmission = new TextBox();
            txtEngine = new TextBox();
            txtDrivetrain = new TextBox();
            txtFuelType = new TextBox();
            txtMileage = new TextBox();
            txtVIN = new TextBox();
            txtColor = new TextBox();
            txtDoors = new TextBox();
            txtSeatingCapacity = new TextBox();
            txtInteriorColor = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(12, 52);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = " Brand Name";
            txtBrand.Size = new Size(191, 23);
            txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 81);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = " Model Name";
            txtModel.Size = new Size(191, 23);
            txtModel.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(12, 110);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = " Year";
            txtYear.Size = new Size(191, 23);
            txtYear.TabIndex = 0;
            // 
            // txtBodyStyle
            // 
            txtBodyStyle.Location = new Point(12, 139);
            txtBodyStyle.Name = "txtBodyStyle";
            txtBodyStyle.PlaceholderText = " Body Style";
            txtBodyStyle.Size = new Size(191, 23);
            txtBodyStyle.TabIndex = 0;
            // 
            // txtTransmission
            // 
            txtTransmission.Location = new Point(12, 197);
            txtTransmission.Name = "txtTransmission";
            txtTransmission.PlaceholderText = " Transmission";
            txtTransmission.Size = new Size(191, 23);
            txtTransmission.TabIndex = 0;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(12, 168);
            txtEngine.Name = "txtEngine";
            txtEngine.PlaceholderText = " Engine";
            txtEngine.Size = new Size(191, 23);
            txtEngine.TabIndex = 0;
            // 
            // txtDrivetrain
            // 
            txtDrivetrain.Location = new Point(12, 226);
            txtDrivetrain.Name = "txtDrivetrain";
            txtDrivetrain.PlaceholderText = " Drivetrain";
            txtDrivetrain.Size = new Size(191, 23);
            txtDrivetrain.TabIndex = 0;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(12, 255);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.PlaceholderText = " Fuel Type";
            txtFuelType.Size = new Size(191, 23);
            txtFuelType.TabIndex = 0;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(209, 52);
            txtMileage.Name = "txtMileage";
            txtMileage.PlaceholderText = " Mileage";
            txtMileage.Size = new Size(191, 23);
            txtMileage.TabIndex = 0;
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(209, 81);
            txtVIN.Name = "txtVIN";
            txtVIN.PlaceholderText = " VIN";
            txtVIN.Size = new Size(191, 23);
            txtVIN.TabIndex = 0;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(209, 110);
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = " Color";
            txtColor.Size = new Size(191, 23);
            txtColor.TabIndex = 0;
            // 
            // txtDoors
            // 
            txtDoors.Location = new Point(209, 168);
            txtDoors.Name = "txtDoors";
            txtDoors.PlaceholderText = " Doors Count";
            txtDoors.Size = new Size(191, 23);
            txtDoors.TabIndex = 0;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.Location = new Point(209, 197);
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.PlaceholderText = " Seating Capacity";
            txtSeatingCapacity.Size = new Size(191, 23);
            txtSeatingCapacity.TabIndex = 0;
            // 
            // txtInteriorColor
            // 
            txtInteriorColor.Location = new Point(209, 139);
            txtInteriorColor.Name = "txtInteriorColor";
            txtInteriorColor.PlaceholderText = " Interior Color";
            txtInteriorColor.Size = new Size(191, 23);
            txtInteriorColor.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(325, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 2;
            label1.Text = "Add Car Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(209, 226);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = " Price";
            txtPrice.Size = new Size(191, 23);
            txtPrice.TabIndex = 0;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // AddNewCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtInteriorColor);
            Controls.Add(txtEngine);
            Controls.Add(txtPrice);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtDoors);
            Controls.Add(txtDrivetrain);
            Controls.Add(txtColor);
            Controls.Add(txtTransmission);
            Controls.Add(txtVIN);
            Controls.Add(txtBodyStyle);
            Controls.Add(txtMileage);
            Controls.Add(txtYear);
            Controls.Add(txtFuelType);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewCarForm";
            Text = "AddNewCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtBodyStyle;
        private TextBox txtTransmission;
        private TextBox txtEngine;
        private TextBox txtDrivetrain;
        private TextBox txtFuelType;
        private TextBox txtMileage;
        private TextBox txtVIN;
        private TextBox txtColor;
        private TextBox txtDoors;
        private TextBox txtSeatingCapacity;
        private TextBox txtInteriorColor;
        private Button btnSave;
        private Label label1;
        private TextBox txtPrice;
    }
}