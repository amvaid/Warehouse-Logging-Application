namespace Warehouse_Logging
{
    partial class ViewIn
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
            this.ViewInGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewInGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewInGrid
            // 
            this.ViewInGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewInGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewInGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewInGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewInGrid.Location = new System.Drawing.Point(0, 0);
            this.ViewInGrid.Name = "ViewInGrid";
            this.ViewInGrid.ReadOnly = true;
            this.ViewInGrid.RowTemplate.Height = 28;
            this.ViewInGrid.Size = new System.Drawing.Size(881, 457);
            this.ViewInGrid.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 457);
            this.Controls.Add(this.ViewInGrid);
            this.Name = "ViewIn";
            this.Text = "ViewIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewInGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewInGrid;
        private System.Windows.Forms.Timer timer1;
    }
}