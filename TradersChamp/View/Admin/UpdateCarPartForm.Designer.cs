namespace TradersChamp.View.Admin
{
    partial class UpdateCarPartForm
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
            label1 = new Label();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtManufacturer = new TextBox();
            txtName = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 9;
            label1.Text = "Update Car Part";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 135);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = " Price";
            txtPrice.Size = new Size(191, 23);
            txtPrice.TabIndex = 5;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 106);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = " Description";
            txtDescription.Size = new Size(191, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 77);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.PlaceholderText = " Manufacturer";
            txtManufacturer.Size = new Size(191, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 48);
            txtName.Name = "txtName";
            txtName.PlaceholderText = " Part Name";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(128, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateCarPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 583);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtManufacturer);
            Controls.Add(txtName);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCarPartForm";
            Text = "UpdateCarPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtManufacturer;
        private TextBox txtName;
        private Button btnUpdate;
    }
}