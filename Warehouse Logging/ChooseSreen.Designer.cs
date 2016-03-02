namespace Warehouse_Logging
{
    partial class ChooseSreen
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
            this.Create = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewClosedButton = new System.Windows.Forms.Button();
            this.ViewInButton = new System.Windows.Forms.Button();
            this.ViewNewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(59, 60);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(354, 74);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // InButton
            // 
            this.InButton.Location = new System.Drawing.Point(59, 168);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(354, 74);
            this.InButton.TabIndex = 1;
            this.InButton.Text = "In";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(59, 281);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(354, 74);
            this.OutButton.TabIndex = 2;
            this.OutButton.Text = "Out";
            this.OutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose an Option";
            // 
            // viewClosedButton
            // 
            this.viewClosedButton.Location = new System.Drawing.Point(341, 401);
            this.viewClosedButton.Name = "viewClosedButton";
            this.viewClosedButton.Size = new System.Drawing.Size(118, 74);
            this.viewClosedButton.TabIndex = 4;
            this.viewClosedButton.Text = "View Closed";
            this.viewClosedButton.UseVisualStyleBackColor = true;
            // 
            // ViewInButton
            // 
            this.ViewInButton.Location = new System.Drawing.Point(170, 401);
            this.ViewInButton.Name = "ViewInButton";
            this.ViewInButton.Size = new System.Drawing.Size(118, 74);
            this.ViewInButton.TabIndex = 5;
            this.ViewInButton.Text = "View In";
            this.ViewInButton.UseVisualStyleBackColor = true;
            // 
            // ViewNewButton
            // 
            this.ViewNewButton.Location = new System.Drawing.Point(12, 401);
            this.ViewNewButton.Name = "ViewNewButton";
            this.ViewNewButton.Size = new System.Drawing.Size(118, 74);
            this.ViewNewButton.TabIndex = 6;
            this.ViewNewButton.Text = "View New";
            this.ViewNewButton.UseVisualStyleBackColor = true;
            // 
            // ChooseSreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 487);
            this.Controls.Add(this.ViewNewButton);
            this.Controls.Add(this.ViewInButton);
            this.Controls.Add(this.viewClosedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.Create);
            this.Name = "ChooseSreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Logging";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseSreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewClosedButton;
        private System.Windows.Forms.Button ViewInButton;
        private System.Windows.Forms.Button ViewNewButton;
    }
}