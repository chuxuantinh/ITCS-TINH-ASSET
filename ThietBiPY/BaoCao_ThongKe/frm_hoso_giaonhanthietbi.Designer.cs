namespace ThietBiPY.BaoCao_ThongKe
{
    partial class frm_hoso_giaonhanthietbi
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
            this.lv_giaonhanthietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_namgiaonhan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_chondonvi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_namgiaonhan = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.btn_invanban = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            this.contextmenu_bangdieukhien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_bangdieukhien_inhoso = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_bangdieukhien_hieuchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_bangdieukhien_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.contextmenu_bangdieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_giaonhanthietbi
            // 
            this.lv_giaonhanthietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_giaonhanthietbi.Border.Class = "ListViewBorder";
            this.lv_giaonhanthietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_giaonhanthietbi.FullRowSelect = true;
            this.lv_giaonhanthietbi.GridLines = true;
            this.lv_giaonhanthietbi.Location = new System.Drawing.Point(8, 44);
            this.lv_giaonhanthietbi.Name = "lv_giaonhanthietbi";
            this.lv_giaonhanthietbi.Size = new System.Drawing.Size(744, 429);
            this.lv_giaonhanthietbi.TabIndex = 0;
            this.lv_giaonhanthietbi.UseCompatibleStateImageBehavior = false;
            this.lv_giaonhanthietbi.View = System.Windows.Forms.View.Details;
            this.lv_giaonhanthietbi.DoubleClick += new System.EventHandler(this.lv_giaonhanthietbi_DoubleClick);
            this.lv_giaonhanthietbi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_giaonhanthietbi_ItemSelectionChanged);
            this.lv_giaonhanthietbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_giaonhanthietbi_KeyDown);
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(8, 16);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(744, 28);
            this.panel_dieukhien.TabIndex = 1;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_namgiaonhan);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.btn_chondonvi,
            this.labelItem1,
            this.controlContainerItem_namgiaonhan,
            this.btn_hieuchinh,
            this.btn_xoadong,
            this.btn_invanban,
            this.lbl_thongke});
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(744, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_namgiaonhan
            // 
            this.cbo_namgiaonhan.DisplayMember = "Text";
            this.cbo_namgiaonhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_namgiaonhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_namgiaonhan.FormattingEnabled = true;
            this.cbo_namgiaonhan.ItemHeight = 17;
            this.cbo_namgiaonhan.Location = new System.Drawing.Point(226, 2);
            this.cbo_namgiaonhan.Name = "cbo_namgiaonhan";
            this.cbo_namgiaonhan.Size = new System.Drawing.Size(121, 23);
            this.cbo_namgiaonhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_namgiaonhan.TabIndex = 0;
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            this.btn_lamtuoi.Tooltip = "F5-Làm tươi hồ sơ giao nhận thiết bị";
            this.btn_lamtuoi.Click += new System.EventHandler(this.btn_lamtuoi_Click);
            // 
            // btn_chondonvi
            // 
            this.btn_chondonvi.BeginGroup = true;
            this.btn_chondonvi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_chondonvi.Image = global::ThietBiPY.Properties.Resources.DonVi16;
            this.btn_chondonvi.Name = "btn_chondonvi";
            this.btn_chondonvi.Text = "Chọn đơn vị";
            this.btn_chondonvi.Tooltip = "Chọn đơn vị nhận";
            this.btn_chondonvi.Click += new System.EventHandler(this.btn_chondonvi_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Năm";
            // 
            // controlContainerItem_namgiaonhan
            // 
            this.controlContainerItem_namgiaonhan.AllowItemResize = false;
            this.controlContainerItem_namgiaonhan.Control = this.cbo_namgiaonhan;
            this.controlContainerItem_namgiaonhan.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_namgiaonhan.Name = "controlContainerItem_namgiaonhan";
            // 
            // btn_hieuchinh
            // 
            this.btn_hieuchinh.BeginGroup = true;
            this.btn_hieuchinh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_hieuchinh.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_hieuchinh.Name = "btn_hieuchinh";
            this.btn_hieuchinh.Text = "Hiệu chỉnh";
            this.btn_hieuchinh.Tooltip = "F7-Hiệu chỉnh hồ sơ giao nhận thiết bị";
            this.btn_hieuchinh.Click += new System.EventHandler(this.btn_hieuchinh_Click);
            // 
            // btn_xoadong
            // 
            this.btn_xoadong.BeginGroup = true;
            this.btn_xoadong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_xoadong.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_xoadong.Name = "btn_xoadong";
            this.btn_xoadong.Text = "Xóa dòng";
            this.btn_xoadong.Tooltip = "Delete- Xóa hồ sơ đang chọn";
            this.btn_xoadong.Click += new System.EventHandler(this.btn_xoadong_Click);
            // 
            // btn_invanban
            // 
            this.btn_invanban.BeginGroup = true;
            this.btn_invanban.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_invanban.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_invanban.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btn_invanban.Name = "btn_invanban";
            this.btn_invanban.Text = "In hồ sơ";
            this.btn_invanban.Tooltip = "F11- In hồ sơ đang chọn";
            this.btn_invanban.Click += new System.EventHandler(this.btn_invanban_Click);
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.BeginGroup = true;
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Số lượng: ";
            // 
            // contextmenu_bangdieukhien
            // 
            this.contextmenu_bangdieukhien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_bangdieukhien_inhoso,
            this.contextmenu_bangdieukhien_hieuchinh,
            this.contextmenu_bangdieukhien_xoadong});
            this.contextmenu_bangdieukhien.Name = "contextmenu_bangdieukhien";
            this.contextmenu_bangdieukhien.Size = new System.Drawing.Size(133, 70);
            // 
            // contextmenu_bangdieukhien_inhoso
            // 
            this.contextmenu_bangdieukhien_inhoso.Name = "contextmenu_bangdieukhien_inhoso";
            this.contextmenu_bangdieukhien_inhoso.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_bangdieukhien_inhoso.Text = "In hồ sơ";
            this.contextmenu_bangdieukhien_inhoso.Click += new System.EventHandler(this.contextmenu_bangdieukhien_inhoso_Click);
            // 
            // contextmenu_bangdieukhien_hieuchinh
            // 
            this.contextmenu_bangdieukhien_hieuchinh.Name = "contextmenu_bangdieukhien_hieuchinh";
            this.contextmenu_bangdieukhien_hieuchinh.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_bangdieukhien_hieuchinh.Text = "Hiệu chỉnh";
            this.contextmenu_bangdieukhien_hieuchinh.Click += new System.EventHandler(this.contextmenu_bangdieukhien_hieuchinh_Click);
            // 
            // contextmenu_bangdieukhien_xoadong
            // 
            this.contextmenu_bangdieukhien_xoadong.Name = "contextmenu_bangdieukhien_xoadong";
            this.contextmenu_bangdieukhien_xoadong.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_bangdieukhien_xoadong.Text = "Xóa hồ sơ";
            this.contextmenu_bangdieukhien_xoadong.Click += new System.EventHandler(this.contextmenu_bangdieukhien_xoadong_Click);
            // 
            // frm_hoso_giaonhanthietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.lv_giaonhanthietbi);
            this.Controls.Add(this.panel_dieukhien);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frm_hoso_giaonhanthietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ giao nhận thiết bị";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_hoso_giaonhanthietbi_KeyDown);
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.contextmenu_bangdieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_giaonhanthietbi;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_namgiaonhan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_namgiaonhan;
        private DevComponents.DotNetBar.ButtonItem btn_invanban;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
        private DevComponents.DotNetBar.ButtonItem btn_hieuchinh;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private System.Windows.Forms.ContextMenuStrip contextmenu_bangdieukhien;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_bangdieukhien_inhoso;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_bangdieukhien_hieuchinh;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_bangdieukhien_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.ButtonItem btn_chondonvi;
    }
}