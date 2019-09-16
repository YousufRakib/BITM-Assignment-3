namespace Assignment3
{
    partial class CustomerForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContactInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arraySize = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.txtQuantityInput = new System.Windows.Forms.TextBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.txtAddressInput = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyReceipt = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtContactInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.arraySize);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.txtQuantityInput);
            this.groupBox1.Controls.Add(this.comboBoxItem);
            this.groupBox1.Controls.Add(this.txtAddressInput);
            this.groupBox1.Controls.Add(this.txtNameInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Form";
            // 
            // txtContactInput
            // 
            this.txtContactInput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactInput.Location = new System.Drawing.Point(191, 147);
            this.txtContactInput.Name = "txtContactInput";
            this.txtContactInput.Size = new System.Drawing.Size(181, 26);
            this.txtContactInput.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customer Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "How many users data you want to take at a time ";
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(33, 64);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(339, 27);
            this.arraySize.TabIndex = 11;
            this.arraySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(191, 322);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 26);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // txtQuantityInput
            // 
            this.txtQuantityInput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityInput.Location = new System.Drawing.Point(191, 280);
            this.txtQuantityInput.Name = "txtQuantityInput";
            this.txtQuantityInput.Size = new System.Drawing.Size(181, 26);
            this.txtQuantityInput.TabIndex = 9;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Items.AddRange(new object[] {
            "Black Coffee",
            "Cold Coffee",
            "Hot Coffee",
            "Reguler Coffee"});
            this.comboBoxItem.Location = new System.Drawing.Point(191, 241);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(181, 27);
            this.comboBoxItem.TabIndex = 8;
            // 
            // txtAddressInput
            // 
            this.txtAddressInput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressInput.Location = new System.Drawing.Point(191, 188);
            this.txtAddressInput.Name = "txtAddressInput";
            this.txtAddressInput.Size = new System.Drawing.Size(181, 26);
            this.txtAddressInput.TabIndex = 7;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameInput.Location = new System.Drawing.Point(191, 108);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(181, 26);
            this.txtNameInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // MoneyReceipt
            // 
            this.MoneyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyReceipt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyReceipt.Location = new System.Drawing.Point(495, 65);
            this.MoneyReceipt.Name = "MoneyReceipt";
            this.MoneyReceipt.Size = new System.Drawing.Size(388, 340);
            this.MoneyReceipt.TabIndex = 1;
            this.MoneyReceipt.Text = "";
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(495, 23);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(388, 35);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Click to Show Data";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 456);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.MoneyReceipt);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerForm";
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantityInput;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.TextBox txtAddressInput;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox MoneyReceipt;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox arraySize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactInput;
    }
}

