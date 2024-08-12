namespace TradersChamp.View.Admin
{
    partial class AddCarPart
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
            btnSave = new Button();
            txtName = new TextBox();
            txtManufacturer = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 48);
            txtName.Name = "txtName";
            txtName.PlaceholderText = " Part Name";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 2;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 77);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.PlaceholderText = " Manufacturer";
            txtManufacturer.Size = new Size(191, 23);
            txtManufacturer.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 106);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = " Description";
            txtDescription.Size = new Size(191, 23);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 135);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = " Price";
            txtPrice.Size = new Size(191, 23);
            txtPrice.TabIndex = 2;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 3;
            label1.Text = "Add Car Part";
            // 
            // CarPartAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtManufacturer);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarPartAdd";
            Text = "CarPartAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private TextBox txtManufacturer;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label1;
    }
}