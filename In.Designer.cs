namespace Warehouse_Logging
{
    partial class In
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
            this.AccountSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PackageTypeSelection = new System.Windows.Forms.ComboBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.IDSelection = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.CarrierTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DamageReportButton = new System.Windows.Forms.Button();
            this.InFeeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PalletFeeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RampFeeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OnStackTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountSelection
            // 
            this.AccountSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountSelection.FormattingEnabled = true;
            this.AccountSelection.Location = new System.Drawing.Point(18, 37);
            this.AccountSelection.Name = "AccountSelection";
            this.AccountSelection.Size = new System.Drawing.Size(180, 37);
            this.AccountSelection.TabIndex = 0;
            this.AccountSelection.SelectedIndexChanged += new System.EventHandler(this.AccountSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Container ID:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuantityTextBox.Location = new System.Drawing.Point(38, 114);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(132, 35);
            this.QuantityTextBox.TabIndex = 4;
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(33, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(246, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Package Type:";
            // 
            // PackageTypeSelection
            // 
            this.PackageTypeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PackageTypeSelection.FormattingEnabled = true;
            this.PackageTypeSelection.Location = new System.Drawing.Point(251, 114);
            this.PackageTypeSelection.Name = "PackageTypeSelection";
            this.PackageTypeSelection.Size = new System.Drawing.Size(166, 37);
            this.PackageTypeSelection.TabIndex = 5;
            this.PackageTypeSelection.SelectedIndexChanged += new System.EventHandler(this.PackageTypeSelection_SelectedIndexChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WeightTextBox.Location = new System.Drawing.Point(251, 188);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(161, 35);
            this.WeightTextBox.TabIndex = 9;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(246, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weight (LBS):";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(16, 495);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(168, 65);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(489, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 65);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // IDSelection
            // 
            this.IDSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDSelection.FormattingEnabled = true;
            this.IDSelection.Location = new System.Drawing.Point(251, 37);
            this.IDSelection.Name = "IDSelection";
            this.IDSelection.Size = new System.Drawing.Size(180, 37);
            this.IDSelection.TabIndex = 2;
            this.IDSelection.SelectedIndexChanged += new System.EventHandler(this.IDSelection_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 235);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 35);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Drop Off Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(362, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "In:";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductTextBox.Location = new System.Drawing.Point(461, 114);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(165, 35);
            this.ProductTextBox.TabIndex = 6;
            // 
            // CarrierTextBox
            // 
            this.CarrierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CarrierTextBox.Location = new System.Drawing.Point(460, 39);
            this.CarrierTextBox.Name = "CarrierTextBox";
            this.CarrierTextBox.Size = new System.Drawing.Size(161, 35);
            this.CarrierTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(455, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Carrier:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(455, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Product:";
            // 
            // DamageReportButton
            // 
            this.DamageReportButton.Location = new System.Drawing.Point(213, 495);
            this.DamageReportButton.Name = "DamageReportButton";
            this.DamageReportButton.Size = new System.Drawing.Size(249, 65);
            this.DamageReportButton.TabIndex = 12;
            this.DamageReportButton.Text = "Report Damage";
            this.DamageReportButton.UseVisualStyleBackColor = true;
            this.DamageReportButton.Click += new System.EventHandler(this.DamageReportButton_Click);
            // 
            // InFeeTextBox
            // 
            this.InFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InFeeTextBox.Location = new System.Drawing.Point(363, 293);
            this.InFeeTextBox.Name = "InFeeTextBox";
            this.InFeeTextBox.Size = new System.Drawing.Size(119, 35);
            this.InFeeTextBox.TabIndex = 8;
            this.InFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fees:";
            // 
            // PalletFeeTextBox
            // 
            this.PalletFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PalletFeeTextBox.Location = new System.Drawing.Point(507, 293);
            this.PalletFeeTextBox.Name = "PalletFeeTextBox";
            this.PalletFeeTextBox.Size = new System.Drawing.Size(119, 35);
            this.PalletFeeTextBox.TabIndex = 25;
            this.PalletFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PalletFeeTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(502, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pallet:";
            // 
            // RampFeeTextBox
            // 
            this.RampFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RampFeeTextBox.Location = new System.Drawing.Point(363, 365);
            this.RampFeeTextBox.Name = "RampFeeTextBox";
            this.RampFeeTextBox.Size = new System.Drawing.Size(119, 35);
            this.RampFeeTextBox.TabIndex = 27;
            this.RampFeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RampFeeTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(362, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ramp:";
            // 
            // OnStackTextBox
            // 
            this.OnStackTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OnStackTextBox.Location = new System.Drawing.Point(507, 365);
            this.OnStackTextBox.Name = "OnStackTextBox";
            this.OnStackTextBox.Size = new System.Drawing.Size(119, 35);
            this.OnStackTextBox.TabIndex = 29;
            this.OnStackTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnStackTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(502, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "On-Stack";
            // 
            // In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 572);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OnStackTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RampFeeTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PalletFeeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DamageReportButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CarrierTextBox);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InFeeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.IDSelection);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.PackageTypeSelection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountSelection);
            this.Name = "In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.In_FormClosing);
            this.Load += new System.EventHandler(this.In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PackageTypeSelection;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox IDSelection;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox CarrierTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DamageReportButton;
        private System.Windows.Forms.TextBox InFeeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PalletFeeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RampFeeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OnStackTextBox;
        private System.Windows.Forms.Label label13;
    }
}