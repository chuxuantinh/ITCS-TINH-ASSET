namespace ThietBiPY
{
    partial class frm_main_khac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main_khac));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.status_btn_tenserver = new DevComponents.DotNetBar.ButtonItem();
            this.status_btn_tenpc = new DevComponents.DotNetBar.ButtonItem();
            this.status_btn_tencsdl = new DevComponents.DotNetBar.ButtonItem();
            this.status_btn_tentaikhoan = new DevComponents.DotNetBar.ButtonItem();
            this.status_btn_time = new DevComponents.DotNetBar.ButtonItem();
            this.status_btn_date = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.lv_thongtinchung = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_menuphai_lamtuoi = new System.Windows.Forms.Panel();
            this.btn_menuphai_lamtuoi = new System.Windows.Forms.Button();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.bar4 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.trv_bophan = new System.Windows.Forms.TreeView();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btn_hethong = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hethong_thaydoimatkhau = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hethong_dangnhaplai = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hethong_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themthietbi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_bangiaothietbi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_danhgialaithietbi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thongkethietbi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thongkethietbi_theobophan = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thongkethietbi_bangiao = new DevComponents.DotNetBar.ButtonItem();
            this.btn_timkiem = new DevComponents.DotNetBar.ButtonItem();
            this.btn_timkiem_thongtinthietbi = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.tab_chinh = new DevComponents.DotNetBar.TabStrip();
            this.panel_main_trai = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.dockSite2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.bar3.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            this.panel_menuphai_lamtuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).BeginInit();
            this.bar4.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.dockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.status_btn_tenserver,
            this.status_btn_tenpc,
            this.status_btn_tencsdl,
            this.status_btn_tentaikhoan,
            this.status_btn_time,
            this.status_btn_date});
            this.bar1.Location = new System.Drawing.Point(0, 483);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(760, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // status_btn_tenserver
            // 
            this.status_btn_tenserver.BeginGroup = true;
            this.status_btn_tenserver.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_tenserver.Image = global::ThietBiPY.Properties.Resources.Server32;
            this.status_btn_tenserver.Name = "status_btn_tenserver";
            this.status_btn_tenserver.Text = "Máy chủ:";
            // 
            // status_btn_tenpc
            // 
            this.status_btn_tenpc.BeginGroup = true;
            this.status_btn_tenpc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_tenpc.Image = global::ThietBiPY.Properties.Resources.ClientName16;
            this.status_btn_tenpc.Name = "status_btn_tenpc";
            this.status_btn_tenpc.Text = "PC:";
            // 
            // status_btn_tencsdl
            // 
            this.status_btn_tencsdl.BeginGroup = true;
            this.status_btn_tencsdl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_tencsdl.Image = global::ThietBiPY.Properties.Resources.Database16;
            this.status_btn_tencsdl.Name = "status_btn_tencsdl";
            this.status_btn_tencsdl.Text = "CSDL:";
            // 
            // status_btn_tentaikhoan
            // 
            this.status_btn_tentaikhoan.BeginGroup = true;
            this.status_btn_tentaikhoan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_tentaikhoan.Image = global::ThietBiPY.Properties.Resources.TaiKhoan16;
            this.status_btn_tentaikhoan.Name = "status_btn_tentaikhoan";
            this.status_btn_tentaikhoan.Text = "TK:";
            // 
            // status_btn_time
            // 
            this.status_btn_time.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_time.Image = global::ThietBiPY.Properties.Resources.Time16;
            this.status_btn_time.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.status_btn_time.Name = "status_btn_time";
            this.status_btn_time.Text = "Bây giờ:";
            // 
            // status_btn_date
            // 
            this.status_btn_date.BeginGroup = true;
            this.status_btn_date.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.status_btn_date.Image = global::ThietBiPY.Properties.Resources.Date16;
            this.status_btn_date.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.status_btn_date.Name = "status_btn_date";
            this.status_btn_date.Text = "Ngày:";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
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
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.dockSite4.Location = new System.Drawing.Point(0, 508);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(760, 0);
            this.dockSite4.TabIndex = 4;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 55);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 428);
            this.dockSite1.TabIndex = 1;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Controls.Add(this.bar3);
            this.dockSite2.Controls.Add(this.bar4);
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar4, 183, 211))),
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar3, 183, 214)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.dockSite2.Location = new System.Drawing.Point(574, 55);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(186, 428);
            this.dockSite2.TabIndex = 2;
            this.dockSite2.TabStop = false;
            // 
            // bar3
            // 
            this.bar3.AccessibleDescription = "DotNetBar Bar (bar3)";
            this.bar3.AccessibleName = "DotNetBar Bar";
            this.bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar3.AutoSyncBarCaption = true;
            this.bar3.CloseSingleTab = true;
            this.bar3.Controls.Add(this.panelDockContainer2);
            this.bar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar3.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem2});
            this.bar3.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar3.Location = new System.Drawing.Point(3, 214);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(183, 214);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 2;
            this.bar3.TabStop = false;
            this.bar3.Text = "Thông tin chung";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer2.Controls.Add(this.lv_thongtinchung);
            this.panelDockContainer2.Controls.Add(this.panel_menuphai_lamtuoi);
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(177, 188);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 0;
            // 
            // lv_thongtinchung
            // 
            // 
            // 
            // 
            this.lv_thongtinchung.Border.Class = "ListViewBorder";
            this.lv_thongtinchung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thongtinchung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_thongtinchung.FullRowSelect = true;
            this.lv_thongtinchung.GridLines = true;
            this.lv_thongtinchung.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_thongtinchung.Location = new System.Drawing.Point(0, 26);
            this.lv_thongtinchung.Name = "lv_thongtinchung";
            this.lv_thongtinchung.Size = new System.Drawing.Size(177, 162);
            this.lv_thongtinchung.TabIndex = 0;
            this.lv_thongtinchung.UseCompatibleStateImageBehavior = false;
            this.lv_thongtinchung.View = System.Windows.Forms.View.Details;
            // 
            // panel_menuphai_lamtuoi
            // 
            this.panel_menuphai_lamtuoi.BackColor = System.Drawing.Color.Transparent;
            this.panel_menuphai_lamtuoi.Controls.Add(this.btn_menuphai_lamtuoi);
            this.panel_menuphai_lamtuoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuphai_lamtuoi.Location = new System.Drawing.Point(0, 0);
            this.panel_menuphai_lamtuoi.Name = "panel_menuphai_lamtuoi";
            this.panel_menuphai_lamtuoi.Size = new System.Drawing.Size(177, 26);
            this.panel_menuphai_lamtuoi.TabIndex = 1;
            // 
            // btn_menuphai_lamtuoi
            // 
            this.btn_menuphai_lamtuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuphai_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_menuphai_lamtuoi.Location = new System.Drawing.Point(139, 2);
            this.btn_menuphai_lamtuoi.Name = "btn_menuphai_lamtuoi";
            this.btn_menuphai_lamtuoi.Size = new System.Drawing.Size(35, 23);
            this.btn_menuphai_lamtuoi.TabIndex = 0;
            this.btn_menuphai_lamtuoi.UseVisualStyleBackColor = true;
            this.btn_menuphai_lamtuoi.Click += new System.EventHandler(this.btn_menuphai_lamtuoi_Click);
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Control = this.panelDockContainer2;
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "Thông tin chung";
            // 
            // bar4
            // 
            this.bar4.AccessibleDescription = "DotNetBar Bar (bar4)";
            this.bar4.AccessibleName = "DotNetBar Bar";
            this.bar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar4.AutoSyncBarCaption = true;
            this.bar4.CloseSingleTab = true;
            this.bar4.Controls.Add(this.panelDockContainer1);
            this.bar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar4.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem1});
            this.bar4.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar4.Location = new System.Drawing.Point(3, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(183, 211);
            this.bar4.Stretch = true;
            this.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar4.TabIndex = 1;
            this.bar4.TabStop = false;
            this.bar4.Text = "Bộ phận";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDockContainer1.Controls.Add(this.trv_bophan);
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(177, 185);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // trv_bophan
            // 
            this.trv_bophan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_bophan.FullRowSelect = true;
            this.trv_bophan.HideSelection = false;
            this.trv_bophan.Location = new System.Drawing.Point(0, 0);
            this.trv_bophan.Name = "trv_bophan";
            this.trv_bophan.Size = new System.Drawing.Size(177, 185);
            this.trv_bophan.TabIndex = 0;
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Control = this.panelDockContainer1;
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "Bộ phận";
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 508);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(760, 0);
            this.dockSite8.TabIndex = 8;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 55);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 453);
            this.dockSite5.TabIndex = 5;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(760, 55);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 453);
            this.dockSite6.TabIndex = 6;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Controls.Add(this.bar2);
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(760, 55);
            this.dockSite7.TabIndex = 7;
            this.dockSite7.TabStop = false;
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_hethong,
            this.btn_themthietbi,
            this.btn_bangiaothietbi,
            this.btn_danhgialaithietbi,
            this.btn_thongkethietbi,
            this.btn_timkiem});
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(413, 55);
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 0;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btn_hethong
            // 
            this.btn_hethong.AutoExpandOnClick = true;
            this.btn_hethong.Image = global::ThietBiPY.Properties.Resources.HeThong_Home32;
            this.btn_hethong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_hethong.Name = "btn_hethong";
            this.btn_hethong.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_hethong_thaydoimatkhau,
            this.btn_hethong_dangnhaplai,
            this.btn_hethong_thoat});
            this.btn_hethong.Text = "Hệ thống";
            // 
            // btn_hethong_thaydoimatkhau
            // 
            this.btn_hethong_thaydoimatkhau.Name = "btn_hethong_thaydoimatkhau";
            this.btn_hethong_thaydoimatkhau.Text = "Đổi mật khẩu";
            this.btn_hethong_thaydoimatkhau.Click += new System.EventHandler(this.btn_hethong_thaydoimatkhau_Click);
            // 
            // btn_hethong_dangnhaplai
            // 
            this.btn_hethong_dangnhaplai.Name = "btn_hethong_dangnhaplai";
            this.btn_hethong_dangnhaplai.Text = "Đăng nhập lại";
            this.btn_hethong_dangnhaplai.Tooltip = "Đăng nhập lại hệ thống";
            this.btn_hethong_dangnhaplai.Click += new System.EventHandler(this.btn_hethong_dangnhaplai_Click);
            // 
            // btn_hethong_thoat
            // 
            this.btn_hethong_thoat.Name = "btn_hethong_thoat";
            this.btn_hethong_thoat.Text = "Thoát khỏi";
            this.btn_hethong_thoat.Tooltip = "Thoát khỏi hệ thống";
            this.btn_hethong_thoat.Click += new System.EventHandler(this.btn_hethong_thoat_Click);
            // 
            // btn_themthietbi
            // 
            this.btn_themthietbi.BeginGroup = true;
            this.btn_themthietbi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themthietbi.Image = global::ThietBiPY.Properties.Resources.GiaoNhan32;
            this.btn_themthietbi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_themthietbi.Name = "btn_themthietbi";
            this.btn_themthietbi.Text = "Thêm thiết bị";
            this.btn_themthietbi.Click += new System.EventHandler(this.btn_themthietbi_Click);
            // 
            // btn_bangiaothietbi
            // 
            this.btn_bangiaothietbi.BeginGroup = true;
            this.btn_bangiaothietbi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_bangiaothietbi.Image = global::ThietBiPY.Properties.Resources.BanGiao32;
            this.btn_bangiaothietbi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_bangiaothietbi.Name = "btn_bangiaothietbi";
            this.btn_bangiaothietbi.Text = "Bàn giao";
            this.btn_bangiaothietbi.Tooltip = "Bàn giao, điều chuyển, phân bổ thiết bị đến các bộ phận của đơn vị";
            this.btn_bangiaothietbi.Click += new System.EventHandler(this.btn_bangiaothietbi_Click);
            // 
            // btn_danhgialaithietbi
            // 
            this.btn_danhgialaithietbi.BeginGroup = true;
            this.btn_danhgialaithietbi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_danhgialaithietbi.Image = global::ThietBiPY.Properties.Resources.DanhGiaLai32;
            this.btn_danhgialaithietbi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_danhgialaithietbi.Name = "btn_danhgialaithietbi";
            this.btn_danhgialaithietbi.Text = "Đánh giá lại";
            this.btn_danhgialaithietbi.Click += new System.EventHandler(this.btn_danhgialaithietbi_Click);
            // 
            // btn_thongkethietbi
            // 
            this.btn_thongkethietbi.AutoExpandOnClick = true;
            this.btn_thongkethietbi.BeginGroup = true;
            this.btn_thongkethietbi.Image = global::ThietBiPY.Properties.Resources.ThongKe32;
            this.btn_thongkethietbi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_thongkethietbi.Name = "btn_thongkethietbi";
            this.btn_thongkethietbi.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_thongkethietbi_theobophan,
            this.btn_thongkethietbi_bangiao});
            this.btn_thongkethietbi.Text = "Thống kê";
            // 
            // btn_thongkethietbi_theobophan
            // 
            this.btn_thongkethietbi_theobophan.Name = "btn_thongkethietbi_theobophan";
            this.btn_thongkethietbi_theobophan.Text = "Theo bộ phận";
            this.btn_thongkethietbi_theobophan.Click += new System.EventHandler(this.btn_thongkethietbi_theobophan_Click);
            // 
            // btn_thongkethietbi_bangiao
            // 
            this.btn_thongkethietbi_bangiao.Name = "btn_thongkethietbi_bangiao";
            this.btn_thongkethietbi_bangiao.Text = "Chứng từ bàn giao";
            this.btn_thongkethietbi_bangiao.Click += new System.EventHandler(this.btn_thongkethietbi_bangiao_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.AutoExpandOnClick = true;
            this.btn_timkiem.BeginGroup = true;
            this.btn_timkiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_timkiem.Image = global::ThietBiPY.Properties.Resources.Tim32;
            this.btn_timkiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_timkiem_thongtinthietbi});
            this.btn_timkiem.Text = "Tìm kiếm";
            // 
            // btn_timkiem_thongtinthietbi
            // 
            this.btn_timkiem_thongtinthietbi.Name = "btn_timkiem_thongtinthietbi";
            this.btn_timkiem_thongtinthietbi.Text = "Thông tin thiết bị";
            this.btn_timkiem_thongtinthietbi.Click += new System.EventHandler(this.btn_timkiem_thongtinthietbi_Click);
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 55);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(760, 0);
            this.dockSite3.TabIndex = 3;
            this.dockSite3.TabStop = false;
            // 
            // tab_chinh
            // 
            this.tab_chinh.AutoSelectAttachedControl = true;
            this.tab_chinh.CanReorderTabs = true;
            this.tab_chinh.CloseButtonOnTabsVisible = true;
            this.tab_chinh.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tab_chinh.CloseButtonVisible = true;
            this.tab_chinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_chinh.Location = new System.Drawing.Point(0, 55);
            this.tab_chinh.MdiForm = this;
            this.tab_chinh.MdiTabbedDocuments = true;
            this.tab_chinh.Name = "tab_chinh";
            this.tab_chinh.SelectedTab = null;
            this.tab_chinh.ShowMdiChildIcon = false;
            this.tab_chinh.Size = new System.Drawing.Size(574, 26);
            this.tab_chinh.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tab_chinh.TabIndex = 10;
            this.tab_chinh.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox;
            this.tab_chinh.Text = "tabStrip1";
            // 
            // panel_main_trai
            // 
            this.panel_main_trai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main_trai.Location = new System.Drawing.Point(0, 81);
            this.panel_main_trai.Name = "panel_main_trai";
            this.panel_main_trai.Size = new System.Drawing.Size(10, 402);
            this.panel_main_trai.TabIndex = 11;
            // 
            // frm_main_khac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::ThietBiPY.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(760, 508);
            this.Controls.Add(this.panel_main_trai);
            this.Controls.Add(this.tab_chinh);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_main_khac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.dockSite2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.bar3.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            this.panel_menuphai_lamtuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).EndInit();
            this.bar4.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.dockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btn_bangiaothietbi;
        private DevComponents.DotNetBar.ButtonItem btn_thongkethietbi;
        private DevComponents.DotNetBar.TabStrip tab_chinh;
        private DevComponents.DotNetBar.ButtonItem btn_danhgialaithietbi;
        private DevComponents.DotNetBar.ButtonItem btn_timkiem;
        private DevComponents.DotNetBar.ButtonItem btn_thongkethietbi_theobophan;
        private DevComponents.DotNetBar.ButtonItem btn_thongkethietbi_bangiao;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private DevComponents.DotNetBar.Bar bar4;
        private DevComponents.DotNetBar.ButtonItem btn_timkiem_thongtinthietbi;
        private System.Windows.Forms.Panel panel_main_trai;
        private System.Windows.Forms.TreeView trv_bophan;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thongtinchung;
        private DevComponents.DotNetBar.ButtonItem status_btn_tenpc;
        private DevComponents.DotNetBar.ButtonItem status_btn_time;
        private DevComponents.DotNetBar.ButtonItem status_btn_date;
        private DevComponents.DotNetBar.ButtonItem status_btn_tenserver;
        private DevComponents.DotNetBar.ButtonItem status_btn_tentaikhoan;
        private DevComponents.DotNetBar.ButtonItem status_btn_tencsdl;
        private DevComponents.DotNetBar.ButtonItem btn_hethong;
        private System.Windows.Forms.Panel panel_menuphai_lamtuoi;
        private System.Windows.Forms.Button btn_menuphai_lamtuoi;
        private DevComponents.DotNetBar.ButtonItem btn_hethong_dangnhaplai;
        private DevComponents.DotNetBar.ButtonItem btn_hethong_thoat;
        private DevComponents.DotNetBar.ButtonItem btn_hethong_thaydoimatkhau;
        private DevComponents.DotNetBar.ButtonItem btn_themthietbi;
    }
}