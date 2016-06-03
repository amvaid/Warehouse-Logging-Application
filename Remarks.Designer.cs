namespace Warehouse_Logging
{
    partial class Remarks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemarksTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AccountSelection = new System.Windows.Forms.ComboBox();
            this.IDSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(215, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Container ID:";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemarksTextBox.Location = new System.Drawing.Point(12, 92);
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(387, 196);
            this.RemarksTextBox.TabIndex = 4;
            this.RemarksTextBox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(85, 302);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(221, 61);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AccountSelection
            // 
            this.AccountSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountSelection.FormattingEnabled = true;
            this.AccountSelection.Location = new System.Drawing.Point(12, 49);
            this.AccountSelection.Name = "AccountSelection";
            this.AccountSelection.Size = new System.Drawing.Size(177, 37);
            this.AccountSelection.TabIndex = 6;
            this.AccountSelection.SelectedIndexChanged += new System.EventHandler(this.AccountSelection_SelectedIndexChanged);
            // 
            // IDSelection
            // 
            this.IDSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDSelection.FormattingEnabled = true;
            this.IDSelection.Location = new System.Drawing.Point(220, 49);
            this.IDSelection.Name = "IDSelection";
            this.IDSelection.Size = new System.Drawing.Size(179, 37);
            this.IDSelection.TabIndex = 7;
            this.IDSelection.SelectedIndexChanged += new System.EventHandler(this.IDSelection_SelectedIndexChanged);
            // 
            // Remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 375);
            this.Controls.Add(this.IDSelection);
            this.Controls.Add(this.AccountSelection);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Remarks";
            this.Text = "Remarks";
            this.Load += new System.EventHandler(this.Remarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RemarksTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox AccountSelection;
        private System.Windows.Forms.ComboBox IDSelection;
    }
}