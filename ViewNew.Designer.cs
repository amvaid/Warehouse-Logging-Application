namespace Warehouse_Logging
{
    partial class ViewNew
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
            this.ViewNewGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewNewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewNewGrid
            // 
            this.ViewNewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ViewNewGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewNewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewNewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewNewGrid.Location = new System.Drawing.Point(0, 0);
            this.ViewNewGrid.Name = "ViewNewGrid";
            this.ViewNewGrid.ReadOnly = true;
            this.ViewNewGrid.RowTemplate.Height = 28;
            this.ViewNewGrid.Size = new System.Drawing.Size(881, 457);
            this.ViewNewGrid.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 457);
            this.Controls.Add(this.ViewNewGrid);
            this.Name = "ViewNew";
            this.Text = "ViewNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewNewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewNewGrid;
        private System.Windows.Forms.Timer timer1;
    }
}