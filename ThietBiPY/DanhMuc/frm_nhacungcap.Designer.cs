namespace ThietBiPY.DanhMuc
{
    partial class frm_nhacungcap
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
            this.txt_thongke = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_menu_hieuchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.context_meu_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.panel_chitiet = new System.Windows.Forms.Panel();
            this.rtb_chitiet = new System.Windows.Forms.RichTextBox();
            this.panel_tren = new System.Windows.Forms.Panel();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_bangdieukhien = new DevComponents.DotNetBar.Bar();
            this.txt_nhacungcap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_dieukhien_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_dieukhien_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_dieukhien_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.btn_dieukhien_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.lv_nhacungcap = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_chitiet.SuspendLayout();
            this.panel_tren.SuspendLayout();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).BeginInit();
            this.bar_bangdieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_thongke
            // 
            this.txt_thongke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thongke.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_thongke.Border.Class = "TextBoxBorder";
            this.txt_thongke.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_thongke.Enabled = false;
            this.txt_thongke.Location = new System.Drawing.Point(545, 458);
            this.txt_thongke.Name = "txt_thongke";
            this.txt_thongke.ReadOnly = true;
            this.txt_thongke.Size = new System.Drawing.Size(117, 20);
            this.txt_thongke.TabIndex = 2;
            this.txt_thongke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_menu_hieuchinh,
            this.context_meu_xoadong});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // context_menu_hieuchinh
            // 
            this.context_menu_hieuchinh.Name = "context_menu_hieuchinh";
            this.context_menu_hieuchinh.Size = new System.Drawing.Size(123, 22);
            this.context_menu_hieuchinh.Text = "Hiệu chỉnh";
            this.context_menu_hieuchinh.Click += new System.EventHandler(this.context_menu_hieuchinh_Click);
            // 
            // context_meu_xoadong
            // 
            this.context_meu_xoadong.Name = "context_meu_xoadong";
            this.context_meu_xoadong.Size = new System.Drawing.Size(123, 22);
            this.context_meu_xoadong.Text = "Xóa dòng";
            this.context_meu_xoadong.Click += new System.EventHandler(this.context_meu_xoadong_Click);
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.dockSite4;
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.LeftDockSite = this.dockSite1;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.dockSite2;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager1.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 489);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(674, 0);
            this.dockSite4.TabIndex = 8;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 489);
            this.dockSite1.TabIndex = 5;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(674, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 489);
            this.dockSite2.TabIndex = 6;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 489);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(674, 0);
            this.dockSite8.TabIndex = 12;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 489);
            this.dockSite5.TabIndex = 9;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(674, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 489);
            this.dockSite6.TabIndex = 10;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(674, 0);
            this.dockSite7.TabIndex = 11;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(674, 0);
            this.dockSite3.TabIndex = 7;
            this.dockSite3.TabStop = false;
            // 
            // panel_chitiet
            // 
            this.panel_chitiet.Controls.Add(this.rtb_chitiet);
            this.panel_chitiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_chitiet.Location = new System.Drawing.Point(0, 407);
            this.panel_chitiet.Name = "panel_chitiet";
            this.panel_chitiet.Size = new System.Drawing.Size(674, 82);
            this.panel_chitiet.TabIndex = 13;
            this.panel_chitiet.Visible = false;
            // 
            // rtb_chitiet
            // 
            this.rtb_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_chitiet.Location = new System.Drawing.Point(0, 0);
            this.rtb_chitiet.Name = "rtb_chitiet";
            this.rtb_chitiet.Size = new System.Drawing.Size(674, 82);
            this.rtb_chitiet.TabIndex = 0;
            this.rtb_chitiet.Text = "";
            // 
            // panel_tren
            // 
            this.panel_tren.Controls.Add(this.txt_thongke);
            this.panel_tren.Controls.Add(this.panel_dieukhien);
            this.panel_tren.Controls.Add(this.lv_nhacungcap);
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(674, 489);
            this.panel_tren.TabIndex = 14;
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_bangdieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(12, 12);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(650, 29);
            this.panel_dieukhien.TabIndex = 5;
            // 
            // bar_bangdieukhien
            // 
            this.bar_bangdieukhien.AccessibleDescription = "DotNetBar Bar (bar_bangdieukhien)";
            this.bar_bangdieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_bangdieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_bangdieukhien.AntiAlias = true;
            this.bar_bangdieukhien.Controls.Add(this.txt_nhacungcap);
            this.bar_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_bangdieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_bangdieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_dieukhien_lamtuoi,
            this.btn_dieukhien_themmoi,
            this.btn_dieukhien_hieuchinh,
            this.btn_dieukhien_xoa,
            this.labelItem1,
            this.controlContainerItem1});
            this.bar_bangdieukhien.ItemSpacing = 3;
            this.bar_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_bangdieukhien.Name = "bar_bangdieukhien";
            this.bar_bangdieukhien.Size = new System.Drawing.Size(650, 26);
            this.bar_bangdieukhien.Stretch = true;
            this.bar_bangdieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_bangdieukhien.TabIndex = 1;
            this.bar_bangdieukhien.TabStop = false;
            this.bar_bangdieukhien.Text = "bar1";
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_nhacungcap.Border.Class = "TextBoxBorder";
            this.txt_nhacungcap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nhacungcap.Location = new System.Drawing.Point(450, 2);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(173, 21);
            this.txt_nhacungcap.TabIndex = 0;
            this.txt_nhacungcap.WatermarkText = "nhập tên nhà cung cấp";
            // 
            // btn_dieukhien_lamtuoi
            // 
            this.btn_dieukhien_lamtuoi.BeginGroup = true;
            this.btn_dieukhien_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_dieukhien_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_dieukhien_lamtuoi.Name = "btn_dieukhien_lamtuoi";
            this.btn_dieukhien_lamtuoi.Text = "Làm tươi";
            // 
            // btn_dieukhien_themmoi
            // 
            this.btn_dieukhien_themmoi.BeginGroup = true;
            this.btn_dieukhien_themmoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_dieukhien_themmoi.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_dieukhien_themmoi.Name = "btn_dieukhien_themmoi";
            this.btn_dieukhien_themmoi.Text = "Thêm mới";
            // 
            // btn_dieukhien_hieuchinh
            // 
            this.btn_dieukhien_hieuchinh.BeginGroup = true;
            this.btn_dieukhien_hieuchinh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_dieukhien_hieuchinh.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_dieukhien_hieuchinh.Name = "btn_dieukhien_hieuchinh";
            this.btn_dieukhien_hieuchinh.Text = "Hiệu chỉnh";
            // 
            // btn_dieukhien_xoa
            // 
            this.btn_dieukhien_xoa.BeginGroup = true;
            this.btn_dieukhien_xoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_dieukhien_xoa.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_dieukhien_xoa.Name = "btn_dieukhien_xoa";
            this.btn_dieukhien_xoa.Text = "Xóa dòng";
            this.btn_dieukhien_xoa.Click += new System.EventHandler(this.btn_dieukhien_xoa_Click_1);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = " Tìm nhà cung cấp";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.txt_nhacungcap;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // lv_nhacungcap
            // 
            this.lv_nhacungcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_nhacungcap.Border.Class = "ListViewBorder";
            this.lv_nhacungcap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_nhacungcap.FullRowSelect = true;
            this.lv_nhacungcap.GridLines = true;
            this.lv_nhacungcap.Location = new System.Drawing.Point(12, 42);
            this.lv_nhacungcap.Name = "lv_nhacungcap";
            this.lv_nhacungcap.ShowItemToolTips = true;
            this.lv_nhacungcap.Size = new System.Drawing.Size(650, 413);
            this.lv_nhacungcap.TabIndex = 4;
            this.lv_nhacungcap.UseCompatibleStateImageBehavior = false;
            this.lv_nhacungcap.View = System.Windows.Forms.View.Details;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandableSplitter1.ExpandableControl = this.panel_chitiet;
            this.expandableSplitter1.Expanded = false;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 482);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(674, 7);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 15;
            this.expandableSplitter1.TabStop = false;
            // 
            // frm_nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panel_tren);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Controls.Add(this.panel_chitiet);
            this.KeyPreview = true;
            this.Name = "frm_nhacungcap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_nhacungcap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhacungcap_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_chitiet.ResumeLayout(false);
            this.panel_tren.ResumeLayout(false);
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).EndInit();
            this.bar_bangdieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_thongke;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem context_menu_hieuchinh;
        private System.Windows.Forms.ToolStripMenuItem context_meu_xoadong;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private System.Windows.Forms.Panel panel_chitiet;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_bangdieukhien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_nhacungcap;
        private DevComponents.DotNetBar.ButtonItem btn_dieukhien_lamtuoi;
        private DevComponents.DotNetBar.ButtonItem btn_dieukhien_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_dieukhien_hieuchinh;
        private DevComponents.DotNetBar.ButtonItem btn_dieukhien_xoa;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_nhacungcap;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.RichTextBox rtb_chitiet;
    }
}