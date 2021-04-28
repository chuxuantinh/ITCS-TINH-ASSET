namespace ThietBiPY.BaoCao_ThongKe.report
{
    partial class frm_bienban_theodonvisudung
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
            this.bar_boloc = new DevComponents.DotNetBar.Bar();
            this.cbo_bophan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_donvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_tinhtrang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_donvi = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_donvi = new DevComponents.DotNetBar.ControlContainerItem();
            this.lbl_bophan = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_bophan = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_tinhtrang = new DevComponents.DotNetBar.ControlContainerItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar_boloc)).BeginInit();
            this.bar_boloc.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(781, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // bar_boloc
            // 
            this.bar_boloc.AntiAlias = true;
            this.bar_boloc.Controls.Add(this.cbo_donvi);
            this.bar_boloc.Controls.Add(this.cbo_bophan);
            this.bar_boloc.Controls.Add(this.cbo_tinhtrang);
            this.bar_boloc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_boloc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_donvi,
            this.controlContainerItem_donvi,
            this.lbl_bophan,
            this.controlContainerItem_bophan,
            this.labelItem1,
            this.controlContainerItem_tinhtrang});
            this.bar_boloc.Location = new System.Drawing.Point(0, 0);
            this.bar_boloc.Name = "bar_boloc";
            this.bar_boloc.Size = new System.Drawing.Size(781, 28);
            this.bar_boloc.Stretch = true;
            this.bar_boloc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_boloc.TabIndex = 1;
            this.bar_boloc.TabStop = false;
            this.bar_boloc.Text = "bar1";
            // 
            // cbo_bophan
            // 
            this.cbo_bophan.DisplayMember = "Text";
            this.cbo_bophan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_bophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bophan.FormattingEnabled = true;
            this.cbo_bophan.ItemHeight = 17;
            this.cbo_bophan.Location = new System.Drawing.Point(327, 2);
            this.cbo_bophan.Name = "cbo_bophan";
            this.cbo_bophan.Size = new System.Drawing.Size(247, 23);
            this.cbo_bophan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_bophan.TabIndex = 1;
            // 
            // cbo_donvi
            // 
            this.cbo_donvi.DisplayMember = "Text";
            this.cbo_donvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvi.FormattingEnabled = true;
            this.cbo_donvi.ItemHeight = 17;
            this.cbo_donvi.Location = new System.Drawing.Point(40, 2);
            this.cbo_donvi.Name = "cbo_donvi";
            this.cbo_donvi.Size = new System.Drawing.Size(234, 23);
            this.cbo_donvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvi.TabIndex = 2;
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.DisplayMember = "Text";
            this.cbo_tinhtrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.ItemHeight = 17;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(638, 2);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(121, 23);
            this.cbo_tinhtrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tinhtrang.TabIndex = 3;
            // 
            // lbl_donvi
            // 
            this.lbl_donvi.BeginGroup = true;
            this.lbl_donvi.Name = "lbl_donvi";
            this.lbl_donvi.Text = "Đơn vị";
            this.lbl_donvi.Visible = false;
            // 
            // controlContainerItem_donvi
            // 
            this.controlContainerItem_donvi.AllowItemResize = false;
            this.controlContainerItem_donvi.Control = this.cbo_donvi;
            this.controlContainerItem_donvi.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_donvi.Name = "controlContainerItem_donvi";
            this.controlContainerItem_donvi.Visible = false;
            // 
            // lbl_bophan
            // 
            this.lbl_bophan.BeginGroup = true;
            this.lbl_bophan.Name = "lbl_bophan";
            this.lbl_bophan.Text = "Bộ phận";
            // 
            // controlContainerItem_bophan
            // 
            this.controlContainerItem_bophan.AllowItemResize = false;
            this.controlContainerItem_bophan.Control = this.cbo_bophan;
            this.controlContainerItem_bophan.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_bophan.Name = "controlContainerItem_bophan";
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Tình trạng";
            // 
            // controlContainerItem_tinhtrang
            // 
            this.controlContainerItem_tinhtrang.AllowItemResize = false;
            this.controlContainerItem_tinhtrang.Control = this.cbo_tinhtrang;
            this.controlContainerItem_tinhtrang.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_tinhtrang.Name = "controlContainerItem_tinhtrang";
            // 
            // frm_bienban_theodonvisudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(781, 480);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bar_boloc);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frm_bienban_theodonvisudung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bar_boloc)).EndInit();
            this.bar_boloc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.DotNetBar.Bar bar_boloc;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem lbl_bophan;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_bophan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_bophan;
        private DevComponents.DotNetBar.LabelItem lbl_donvi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_donvi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tinhtrang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tinhtrang;
    }
}