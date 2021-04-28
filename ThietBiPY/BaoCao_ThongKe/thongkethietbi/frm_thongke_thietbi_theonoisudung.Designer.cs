namespace ThietBiPY.BaoCao_ThongKe.thongkethietbi
{
    partial class frm_thongke_thietbi_theonoisudung
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
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_bangdieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_loaitaisan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.cbo_tinhtrang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_kichthuockhung = new DevComponents.DotNetBar.ButtonItem();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_loaitaisan = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_tinhtrang = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_invanban = new DevComponents.DotNetBar.ButtonItem();
            this.btn_inthongke_cacdonvi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_inthongke_chitietdonvi = new DevComponents.DotNetBar.ButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_thongke_donvi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.lv_chitiet_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_demsoluong = new System.Windows.Forms.Panel();
            this.txt_demsoluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel_donvi = new System.Windows.Forms.Panel();
            this.cbo_bophan = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lbl_donvi = new DevComponents.DotNetBar.LabelX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextmenu_thongtinthietbi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_thongtinthietbi_xemchitiet = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).BeginInit();
            this.bar_bangdieukhien.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_demsoluong.SuspendLayout();
            this.panel_donvi.SuspendLayout();
            this.contextmenu_thongtinthietbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Controls.Add(this.bar_bangdieukhien);
            this.panel_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(849, 27);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar_bangdieukhien
            // 
            this.bar_bangdieukhien.AccessibleDescription = "DotNetBar Bar (bar_bangdieukhien)";
            this.bar_bangdieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_bangdieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_bangdieukhien.AntiAlias = true;
            this.bar_bangdieukhien.Controls.Add(this.cbo_loaitaisan);
            this.bar_bangdieukhien.Controls.Add(this.cbo_tinhtrang);
            this.bar_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_bangdieukhien.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar_bangdieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_bangdieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_kichthuockhung,
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_loaitaisan,
            this.labelItem2,
            this.controlContainerItem_tinhtrang,
            this.btn_invanban});
            this.bar_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_bangdieukhien.Name = "bar_bangdieukhien";
            this.bar_bangdieukhien.Size = new System.Drawing.Size(849, 28);
            this.bar_bangdieukhien.Stretch = true;
            this.bar_bangdieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_bangdieukhien.TabIndex = 0;
            this.bar_bangdieukhien.TabStop = false;
            this.bar_bangdieukhien.Text = "bar1";
            // 
            // cbo_loaitaisan
            // 
            this.cbo_loaitaisan.DisplayMember = "Text";
            this.cbo_loaitaisan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_loaitaisan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaitaisan.FormattingEnabled = true;
            this.cbo_loaitaisan.ItemHeight = 17;
            this.cbo_loaitaisan.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbo_loaitaisan.Location = new System.Drawing.Point(438, 2);
            this.cbo_loaitaisan.Name = "cbo_loaitaisan";
            this.cbo_loaitaisan.Size = new System.Drawing.Size(121, 23);
            this.cbo_loaitaisan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_loaitaisan.TabIndex = 0;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Thiết bị";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Tài sản cố định";
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.DisplayMember = "Text";
            this.cbo_tinhtrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.ItemHeight = 17;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(623, 2);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(121, 23);
            this.cbo_tinhtrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tinhtrang.TabIndex = 1;
            // 
            // btn_kichthuockhung
            // 
            this.btn_kichthuockhung.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn_kichthuockhung.Name = "btn_kichthuockhung";
            this.btn_kichthuockhung.Text = "Ẩn";
            this.btn_kichthuockhung.Tooltip = "Tăng/giảm kích thước khung làm việc";
            this.btn_kichthuockhung.Click += new System.EventHandler(this.btn_kichthuockhung_Click);
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            this.btn_lamtuoi.Tooltip = "F5 - Làm tươi dữ liệu";
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Loại tài sản";
            // 
            // controlContainerItem_loaitaisan
            // 
            this.controlContainerItem_loaitaisan.AllowItemResize = false;
            this.controlContainerItem_loaitaisan.Control = this.cbo_loaitaisan;
            this.controlContainerItem_loaitaisan.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_loaitaisan.Name = "controlContainerItem_loaitaisan";
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tình trạng";
            // 
            // controlContainerItem_tinhtrang
            // 
            this.controlContainerItem_tinhtrang.AllowItemResize = false;
            this.controlContainerItem_tinhtrang.Control = this.cbo_tinhtrang;
            this.controlContainerItem_tinhtrang.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_tinhtrang.Name = "controlContainerItem_tinhtrang";
            // 
            // btn_invanban
            // 
            this.btn_invanban.AutoExpandOnClick = true;
            this.btn_invanban.BeginGroup = true;
            this.btn_invanban.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_invanban.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_invanban.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btn_invanban.Name = "btn_invanban";
            this.btn_invanban.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_inthongke_cacdonvi,
            this.btn_inthongke_chitietdonvi});
            this.btn_invanban.Text = "In thống kê";
            // 
            // btn_inthongke_cacdonvi
            // 
            this.btn_inthongke_cacdonvi.Image = global::ThietBiPY.Properties.Resources.ThongKe24;
            this.btn_inthongke_cacdonvi.Name = "btn_inthongke_cacdonvi";
            this.btn_inthongke_cacdonvi.Text = "Theo các đơn vị";
            this.btn_inthongke_cacdonvi.Click += new System.EventHandler(this.btn_inthongke_cacdonvi_Click);
            // 
            // btn_inthongke_chitietdonvi
            // 
            this.btn_inthongke_chitietdonvi.Image = global::ThietBiPY.Properties.Resources.ThongKe16;
            this.btn_inthongke_chitietdonvi.Name = "btn_inthongke_chitietdonvi";
            this.btn_inthongke_chitietdonvi.Text = "Theo đơn vị chi tiết";
            this.btn_inthongke_chitietdonvi.Click += new System.EventHandler(this.btn_inthongke_chitietdonvi_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lv_thongke_donvi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_chitiet_thietbi);
            this.splitContainer1.Panel2.Controls.Add(this.panel_demsoluong);
            this.splitContainer1.Panel2.Controls.Add(this.panel_donvi);
            this.splitContainer1.Size = new System.Drawing.Size(849, 527);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // lv_thongke_donvi
            // 
            // 
            // 
            // 
            this.lv_thongke_donvi.Border.Class = "ListViewBorder";
            this.lv_thongke_donvi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thongke_donvi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_thongke_donvi.FullRowSelect = true;
            this.lv_thongke_donvi.GridLines = true;
            this.lv_thongke_donvi.Location = new System.Drawing.Point(0, 0);
            this.lv_thongke_donvi.Name = "lv_thongke_donvi";
            this.lv_thongke_donvi.Size = new System.Drawing.Size(274, 523);
            this.lv_thongke_donvi.TabIndex = 3;
            this.lv_thongke_donvi.UseCompatibleStateImageBehavior = false;
            this.lv_thongke_donvi.View = System.Windows.Forms.View.Details;
            this.lv_thongke_donvi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_thongke_donvi_ItemSelectionChanged);
            // 
            // lv_chitiet_thietbi
            // 
            // 
            // 
            // 
            this.lv_chitiet_thietbi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_chitiet_thietbi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_chitiet_thietbi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_chitiet_thietbi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_chitiet_thietbi.Border.Class = "ListViewBorder";
            this.lv_chitiet_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_chitiet_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_chitiet_thietbi.FullRowSelect = true;
            this.lv_chitiet_thietbi.GridLines = true;
            this.lv_chitiet_thietbi.Location = new System.Drawing.Point(0, 27);
            this.lv_chitiet_thietbi.Name = "lv_chitiet_thietbi";
            this.lv_chitiet_thietbi.Size = new System.Drawing.Size(560, 472);
            this.lv_chitiet_thietbi.TabIndex = 5;
            this.lv_chitiet_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_chitiet_thietbi.View = System.Windows.Forms.View.Details;
            this.lv_chitiet_thietbi.DoubleClick += new System.EventHandler(this.lv_chitiet_thietbi_DoubleClick);
            this.lv_chitiet_thietbi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_chitiet_thietbi_ItemSelectionChanged);
            // 
            // panel_demsoluong
            // 
            this.panel_demsoluong.Controls.Add(this.txt_demsoluong);
            this.panel_demsoluong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_demsoluong.Location = new System.Drawing.Point(0, 499);
            this.panel_demsoluong.Name = "panel_demsoluong";
            this.panel_demsoluong.Size = new System.Drawing.Size(560, 24);
            this.panel_demsoluong.TabIndex = 7;
            // 
            // txt_demsoluong
            // 
            this.txt_demsoluong.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_demsoluong.Border.Class = "TextBoxBorder";
            this.txt_demsoluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_demsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demsoluong.Location = new System.Drawing.Point(5, 2);
            this.txt_demsoluong.Name = "txt_demsoluong";
            this.txt_demsoluong.ReadOnly = true;
            this.txt_demsoluong.Size = new System.Drawing.Size(100, 20);
            this.txt_demsoluong.TabIndex = 0;
            this.txt_demsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_donvi
            // 
            this.panel_donvi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_donvi.Controls.Add(this.cbo_bophan);
            this.panel_donvi.Controls.Add(this.lbl_donvi);
            this.panel_donvi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_donvi.Location = new System.Drawing.Point(0, 0);
            this.panel_donvi.Name = "panel_donvi";
            this.panel_donvi.Size = new System.Drawing.Size(560, 27);
            this.panel_donvi.TabIndex = 6;
            // 
            // cbo_bophan
            // 
            this.cbo_bophan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_bophan.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbo_bophan.BackgroundStyle.Class = "TextBoxBorder";
            this.cbo_bophan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_bophan.ButtonDropDown.Visible = true;
            this.cbo_bophan.Location = new System.Drawing.Point(283, 0);
            this.cbo_bophan.Name = "cbo_bophan";
            this.cbo_bophan.Size = new System.Drawing.Size(270, 23);
            this.cbo_bophan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_bophan.TabIndex = 1;
            // 
            // lbl_donvi
            // 
            // 
            // 
            // 
            this.lbl_donvi.BackgroundStyle.Class = "";
            this.lbl_donvi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donvi.ForeColor = System.Drawing.Color.Black;
            this.lbl_donvi.Location = new System.Drawing.Point(3, 0);
            this.lbl_donvi.Name = "lbl_donvi";
            this.lbl_donvi.Size = new System.Drawing.Size(199, 23);
            this.lbl_donvi.TabIndex = 0;
            this.lbl_donvi.Text = "Đơn Vị Sử Dụng";
            // 
            // contextmenu_thongtinthietbi
            // 
            this.contextmenu_thongtinthietbi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_thongtinthietbi_xemchitiet});
            this.contextmenu_thongtinthietbi.Name = "contextmenu_thongtinthietbi";
            this.contextmenu_thongtinthietbi.Size = new System.Drawing.Size(190, 26);
            // 
            // contextmenu_thongtinthietbi_xemchitiet
            // 
            this.contextmenu_thongtinthietbi_xemchitiet.Name = "contextmenu_thongtinthietbi_xemchitiet";
            this.contextmenu_thongtinthietbi_xemchitiet.Size = new System.Drawing.Size(189, 22);
            this.contextmenu_thongtinthietbi_xemchitiet.Text = "Xem thông tin chi tiết";
            this.contextmenu_thongtinthietbi_xemchitiet.Click += new System.EventHandler(this.contextmenu_thongtinthietbi_xemchitiet_Click);
            // 
            // frm_thongke_thietbi_theonoisudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(849, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_bangdieukhien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_thongke_thietbi_theonoisudung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê theo đơn vị";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_thongke_thietbi_theonoisudung_KeyDown);
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).EndInit();
            this.bar_bangdieukhien.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel_demsoluong.ResumeLayout(false);
            this.panel_donvi.ResumeLayout(false);
            this.contextmenu_thongtinthietbi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_bangdieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thongke_donvi;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_chitiet_thietbi;
        private System.Windows.Forms.Panel panel_donvi;
        private DevComponents.DotNetBar.LabelX lbl_donvi;
        private DevComponents.DotNetBar.Controls.ComboTree cbo_bophan;
        private DevComponents.DotNetBar.ButtonItem btn_invanban;
        private DevComponents.DotNetBar.ButtonItem btn_inthongke_chitietdonvi;
        private DevComponents.DotNetBar.ButtonItem btn_inthongke_cacdonvi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextmenu_thongtinthietbi;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_thongtinthietbi_xemchitiet;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_loaitaisan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_loaitaisan;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tinhtrang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tinhtrang;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btn_kichthuockhung;
        private System.Windows.Forms.Panel panel_demsoluong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_demsoluong;
    }
}