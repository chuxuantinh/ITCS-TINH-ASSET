namespace ThietBiPY.BaoCao_ThongKe.report
{
    partial class frm_bienban_kiemkethietbi
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_tren = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel_tren
            // 
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(665, 12);
            this.panel_tren.TabIndex = 1;
            // 
            // frm_bienban_kiemkethietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 479);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel_tren);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frm_bienban_kiemkethietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel_tren;
    }
}