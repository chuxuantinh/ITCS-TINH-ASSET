namespace ThietBiPY.BaoCao_ThongKe
{
    partial class frm_hoso_kiemkethietbi
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
            this.lv_hosokiemke = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btn_inhoso = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            this.contextmenu_dieukhien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_dieukhien_hieuchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_dieukhieu_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem_nam = new DevComponents.DotNetBar.ControlContainerItem();
            this.cbo_nam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.contextmenu_dieukhien.SuspendLayout();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_hosokiemke
            // 
            this.lv_hosokiemke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_hosokiemke.Border.Class = "ListViewBorder";
            this.lv_hosokiemke.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_hosokiemke.FullRowSelect = true;
            this.lv_hosokiemke.GridLines = true;
            this.lv_hosokiemke.Location = new System.Drawing.Point(7, 45);
            this.lv_hosokiemke.Name = "lv_hosokiemke";
            this.lv_hosokiemke.Size = new System.Drawing.Size(648, 418);
            this.lv_hosokiemke.TabIndex = 2;
            this.lv_hosokiemke.UseCompatibleStateImageBehavior = false;
            this.lv_hosokiemke.View = System.Windows.Forms.View.Details;
            // 
            // btn_inhoso
            // 
            this.btn_inhoso.BeginGroup = true;
            this.btn_inhoso.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_inhoso.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_inhoso.Name = "btn_inhoso";
            this.btn_inhoso.Text = "In hồ sơ";
            this.btn_inhoso.Click += new System.EventHandler(this.btn_inhoso_Click);
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Tổng số:";
            // 
            // contextmenu_dieukhien
            // 
            this.contextmenu_dieukhien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_dieukhien_hieuchinh,
            this.contextmenu_dieukhieu_xoadong});
            this.contextmenu_dieukhien.Name = "contextmenu_dieukhien";
            this.contextmenu_dieukhien.Size = new System.Drawing.Size(133, 48);
            // 
            // contextmenu_dieukhien_hieuchinh
            // 
            this.contextmenu_dieukhien_hieuchinh.Name = "contextmenu_dieukhien_hieuchinh";
            this.contextmenu_dieukhien_hieuchinh.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_dieukhien_hieuchinh.Text = "Hiệu chỉnh";
            // 
            // contextmenu_dieukhieu_xoadong
            // 
            this.contextmenu_dieukhieu_xoadong.Name = "contextmenu_dieukhieu_xoadong";
            this.contextmenu_dieukhieu_xoadong.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_dieukhieu_xoadong.Text = "Xóa hồ sơ";
            // 
            // btn_xoadong
            // 
            this.btn_xoadong.BeginGroup = true;
            this.btn_xoadong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_xoadong.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_xoadong.Name = "btn_xoadong";
            this.btn_xoadong.Text = "Xóa hồ sơ";
            this.btn_xoadong.Click += new System.EventHandler(this.btn_xoadong_Click);
            // 
            // btn_hieuchinh
            // 
            this.btn_hieuchinh.BeginGroup = true;
            this.btn_hieuchinh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_hieuchinh.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_hieuchinh.Name = "btn_hieuchinh";
            this.btn_hieuchinh.Text = "Hiệu chỉnh";
            this.btn_hieuchinh.Click += new System.EventHandler(this.btn_hieuchinh_Click);
            // 
            // controlContainerItem_nam
            // 
            this.controlContainerItem_nam.AllowItemResize = false;
            this.controlContainerItem_nam.Control = this.cbo_nam;
            this.controlContainerItem_nam.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_nam.Name = "controlContainerItem_nam";
            // 
            // cbo_nam
            // 
            this.cbo_nam.DisplayMember = "Text";
            this.cbo_nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.ItemHeight = 17;
            this.cbo_nam.Location = new System.Drawing.Point(162, 2);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(96, 23);
            this.cbo_nam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nam.TabIndex = 0;
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(7, 18);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(648, 27);
            this.panel_dieukhien.TabIndex = 3;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_nam);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_nam,
            this.btn_hieuchinh,
            this.btn_xoadong,
            this.btn_inhoso,
            this.lbl_thongke});
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(648, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            this.btn_lamtuoi.Click += new System.EventHandler(this.btn_lamtuoi_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Chọn năm";
            // 
            // frm_hoso_kiemkethietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(663, 481);
            this.Controls.Add(this.lv_hosokiemke);
            this.Controls.Add(this.panel_dieukhien);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frm_hoso_kiemkethietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chứng từ kiểm kê";
            this.contextmenu_dieukhien.ResumeLayout(false);
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_hosokiemke;
        private DevComponents.DotNetBar.ButtonItem btn_inhoso;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
        private System.Windows.Forms.ContextMenuStrip contextmenu_dieukhien;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_dieukhien_hieuchinh;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_dieukhieu_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_hieuchinh;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_nam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nam;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
    }
}