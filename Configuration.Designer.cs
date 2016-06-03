namespace Warehouse_Logging
{
    partial class Configuration
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
            this.components = new System.ComponentModel.Container();
            this.AccountSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateCreatedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.StateSelection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterAccountLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AccountSelection
            // 
            this.AccountSelection.FormattingEnabled = true;
            this.AccountSelection.Location = new System.Drawing.Point(38, 66);
            this.AccountSelection.Name = "AccountSelection";
            this.AccountSelection.Size = new System.Drawing.Size(164, 28);
            this.AccountSelection.TabIndex = 0;
            this.AccountSelection.SelectedIndexChanged += new System.EventHandler(this.AccountSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Account:";
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(38, 134);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.ReadOnly = true;
            this.RateTextBox.Size = new System.Drawing.Size(164, 26);
            this.RateTextBox.TabIndex = 2;
            this.RateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RateTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rate:";
            // 
            // DateCreatedTextBox
            // 
            this.DateCreatedTextBox.Location = new System.Drawing.Point(304, 134);
            this.DateCreatedTextBox.Name = "DateCreatedTextBox";
            this.DateCreatedTextBox.ReadOnly = true;
            this.DateCreatedTextBox.Size = new System.Drawing.Size(196, 26);
            this.DateCreatedTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Created:";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(18, 423);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(137, 56);
            this.CreateNewButton.TabIndex = 10;
            this.CreateNewButton.Text = "Create New";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(399, 423);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 56);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(304, 68);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(164, 26);
            this.IDTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(38, 216);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(498, 26);
            this.AddressTextBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(38, 270);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.ReadOnly = true;
            this.CityTextBox.Size = new System.Drawing.Size(164, 26);
            this.CityTextBox.TabIndex = 5;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(427, 272);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.ReadOnly = true;
            this.ZipCodeTextBox.Size = new System.Drawing.Size(109, 26);
            this.ZipCodeTextBox.TabIndex = 7;
            this.ZipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox_KeyPress);
            // 
            // StateSelection
            // 
            this.StateSelection.Enabled = false;
            this.StateSelection.FormattingEnabled = true;
            this.StateSelection.Location = new System.Drawing.Point(216, 270);
            this.StateSelection.Name = "StateSelection";
            this.StateSelection.Size = new System.Drawing.Size(193, 28);
            this.StateSelection.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Zip Code:";
            // 
            // PhoneNumberTextBox1
            // 
            this.PhoneNumberTextBox1.Location = new System.Drawing.Point(38, 348);
            this.PhoneNumberTextBox1.Name = "PhoneNumberTextBox1";
            this.PhoneNumberTextBox1.ReadOnly = true;
            this.PhoneNumberTextBox1.Size = new System.Drawing.Size(164, 26);
            this.PhoneNumberTextBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone 1:";
            // 
            // PhoneNumberTextBox2
            // 
            this.PhoneNumberTextBox2.Location = new System.Drawing.Point(336, 348);
            this.PhoneNumberTextBox2.Name = "PhoneNumberTextBox2";
            this.PhoneNumberTextBox2.ReadOnly = true;
            this.PhoneNumberTextBox2.Size = new System.Drawing.Size(164, 26);
            this.PhoneNumberTextBox2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Phone 2:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(205, 423);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(137, 56);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(106, 503);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(137, 56);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(304, 503);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 56);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Location = new System.Drawing.Point(38, 68);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(164, 26);
            this.AccountNameTextBox.TabIndex = 1;
            this.AccountNameTextBox.Visible = false;
            // 
            // EnterAccountLabel
            // 
            this.EnterAccountLabel.AutoSize = true;
            this.EnterAccountLabel.Location = new System.Drawing.Point(34, 43);
            this.EnterAccountLabel.Name = "EnterAccountLabel";
            this.EnterAccountLabel.Size = new System.Drawing.Size(161, 20);
            this.EnterAccountLabel.TabIndex = 29;
            this.EnterAccountLabel.Text = "Enter Account Name:";
            this.EnterAccountLabel.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 60000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 571);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EnterAccountLabel);
            this.Controls.Add(this.AccountNameTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PhoneNumberTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhoneNumberTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StateSelection);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateCreatedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountSelection);
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateCreatedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.ComboBox StateSelection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneNumberTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PhoneNumberTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.Label EnterAccountLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}