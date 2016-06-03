namespace Warehouse_Logging
{
    partial class ViewClosed
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
            this.ViewClosedGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewClosedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewClosedGrid
            // 
            this.ViewClosedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ViewClosedGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewClosedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClosedGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewClosedGrid.Location = new System.Drawing.Point(0, 0);
            this.ViewClosedGrid.Name = "ViewClosedGrid";
            this.ViewClosedGrid.ReadOnly = true;
            this.ViewClosedGrid.RowTemplate.Height = 28;
            this.ViewClosedGrid.Size = new System.Drawing.Size(881, 457);
            this.ViewClosedGrid.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 457);
            this.Controls.Add(this.ViewClosedGrid);
            this.Name = "ViewClosed";
            this.Text = "ViewClosed";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewClosed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewClosedGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewClosedGrid;
        private System.Windows.Forms.Timer timer1;
    }
}