namespace ThietBiPY.DanhMuc
{
    partial class frm_thietbi_macabiet
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.tabControl_chonkieu = new System.Windows.Forms.TabControl();
            this.tabPage_loaithietbi = new System.Windows.Forms.TabPage();
            this.btn_lamtuoi_loaithietbi = new System.Windows.Forms.Button();
            this.cbo_loaithietbi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabPage_donvi = new System.Windows.Forms.TabPage();
            this.btn_lamtuoi_donvisudung = new System.Windows.Forms.Button();
            this.cbo_donvisudung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabPage_ngaynhap = new System.Windows.Forms.TabPage();
            this.dtp_phanloai_ngaynhap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panel_page_thietbi = new System.Windows.Forms.Panel();
            this.txt_page_thietbi_tongso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_thietbi_lui = new System.Windows.Forms.Button();
            this.btn_thietbi_tien = new System.Windows.Forms.Button();
            this.txt_page_thietbi_vitri = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_in_dsmacabiet = new DevComponents.DotNetBar.ButtonX();
            this.lbl_macabiet = new System.Windows.Forms.Label();
            this.pic_mavach = new System.Windows.Forms.PictureBox();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.opt_timtheo_tatca = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.opt_timtheo_ngaynhapve = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.opt_timtheo_sovanban = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txt_sovanban = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtp_ngaynhapve = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lv_thietbi_giatri = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextmenu_giatrithietbi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_giatrithietbi_capnhatmacabiet = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_giatrithietbi_xemchitiet = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_chonkieu.SuspendLayout();
            this.tabPage_loaithietbi.SuspendLayout();
            this.tabPage_donvi.SuspendLayout();
            this.tabPage_ngaynhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_phanloai_ngaynhap)).BeginInit();
            this.panel_page_thietbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mavach)).BeginInit();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhapve)).BeginInit();
            this.contextmenu_giatrithietbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lv_thietbi);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_chonkieu);
            this.splitContainer1.Panel1.Controls.Add(this.panel_page_thietbi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_in_dsmacabiet);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_macabiet);
            this.splitContainer1.Panel2.Controls.Add(this.pic_mavach);
            this.splitContainer1.Panel2.Controls.Add(this.panel_dieukhien);
            this.splitContainer1.Panel2.Controls.Add(this.lv_thietbi_giatri);
            this.splitContainer1.Size = new System.Drawing.Size(872, 475);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // lv_thietbi
            // 
            this.lv_thietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_thietbi.Border.Class = "ListViewBorder";
            this.lv_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thietbi.FullRowSelect = true;
            this.lv_thietbi.GridLines = true;
            this.lv_thietbi.Location = new System.Drawing.Point(0, 54);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(282, 385);
            this.lv_thietbi.TabIndex = 19;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            // 
            // tabControl_chonkieu
            // 
            this.tabControl_chonkieu.Controls.Add(this.tabPage_loaithietbi);
            this.tabControl_chonkieu.Controls.Add(this.tabPage_donvi);
            this.tabControl_chonkieu.Controls.Add(this.tabPage_ngaynhap);
            this.tabControl_chonkieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_chonkieu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_chonkieu.Name = "tabControl_chonkieu";
            this.tabControl_chonkieu.SelectedIndex = 0;
            this.tabControl_chonkieu.Size = new System.Drawing.Size(282, 52);
            this.tabControl_chonkieu.TabIndex = 20;
            this.tabControl_chonkieu.SelectedIndexChanged += new System.EventHandler(this.tabControl_chonkieu_SelectedIndexChanged);
            // 
            // tabPage_loaithietbi
            // 
            this.tabPage_loaithietbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.tabPage_loaithietbi.Controls.Add(this.btn_lamtuoi_loaithietbi);
            this.tabPage_loaithietbi.Controls.Add(this.cbo_loaithietbi);
            this.tabPage_loaithietbi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_loaithietbi.Name = "tabPage_loaithietbi";
            this.tabPage_loaithietbi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_loaithietbi.Size = new System.Drawing.Size(274, 26);
            this.tabPage_loaithietbi.TabIndex = 0;
            this.tabPage_loaithietbi.Text = "Loại thiết bị";
            // 
            // btn_lamtuoi_loaithietbi
            // 
            this.btn_lamtuoi_loaithietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lamtuoi_loaithietbi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi_loaithietbi.Location = new System.Drawing.Point(249, 3);
            this.btn_lamtuoi_loaithietbi.Name = "btn_lamtuoi_loaithietbi";
            this.btn_lamtuoi_loaithietbi.Size = new System.Drawing.Size(25, 20);
            this.btn_lamtuoi_loaithietbi.TabIndex = 24;
            this.btn_lamtuoi_loaithietbi.UseVisualStyleBackColor = true;
            this.btn_lamtuoi_loaithietbi.Click += new System.EventHandler(this.btn_lamtuoi_loaithietbi_Click);
            // 
            // cbo_loaithietbi
            // 
            this.cbo_loaithietbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_loaithietbi.DisplayMember = "Text";
            this.cbo_loaithietbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_loaithietbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaithietbi.FormattingEnabled = true;
            this.cbo_loaithietbi.ItemHeight = 14;
            this.cbo_loaithietbi.Location = new System.Drawing.Point(2, 3);
            this.cbo_loaithietbi.Name = "cbo_loaithietbi";
            this.cbo_loaithietbi.Size = new System.Drawing.Size(247, 20);
            this.cbo_loaithietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_loaithietbi.TabIndex = 23;
            // 
            // tabPage_donvi
            // 
            this.tabPage_donvi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.tabPage_donvi.Controls.Add(this.btn_lamtuoi_donvisudung);
            this.tabPage_donvi.Controls.Add(this.cbo_donvisudung);
            this.tabPage_donvi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_donvi.Name = "tabPage_donvi";
            this.tabPage_donvi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_donvi.Size = new System.Drawing.Size(274, 26);
            this.tabPage_donvi.TabIndex = 1;
            this.tabPage_donvi.Text = "Đơn vị sử dụng";
            // 
            // btn_lamtuoi_donvisudung
            // 
            this.btn_lamtuoi_donvisudung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lamtuoi_donvisudung.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi_donvisudung.Location = new System.Drawing.Point(248, 3);
            this.btn_lamtuoi_donvisudung.Name = "btn_lamtuoi_donvisudung";
            this.btn_lamtuoi_donvisudung.Size = new System.Drawing.Size(25, 20);
            this.btn_lamtuoi_donvisudung.TabIndex = 26;
            this.btn_lamtuoi_donvisudung.UseVisualStyleBackColor = true;
            // 
            // cbo_donvisudung
            // 
            this.cbo_donvisudung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_donvisudung.DisplayMember = "Text";
            this.cbo_donvisudung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvisudung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvisudung.FormattingEnabled = true;
            this.cbo_donvisudung.ItemHeight = 14;
            this.cbo_donvisudung.Location = new System.Drawing.Point(1, 3);
            this.cbo_donvisudung.Name = "cbo_donvisudung";
            this.cbo_donvisudung.Size = new System.Drawing.Size(247, 20);
            this.cbo_donvisudung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvisudung.TabIndex = 25;
            // 
            // tabPage_ngaynhap
            // 
            this.tabPage_ngaynhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.tabPage_ngaynhap.Controls.Add(this.dtp_phanloai_ngaynhap);
            this.tabPage_ngaynhap.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ngaynhap.Name = "tabPage_ngaynhap";
            this.tabPage_ngaynhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ngaynhap.Size = new System.Drawing.Size(274, 26);
            this.tabPage_ngaynhap.TabIndex = 2;
            this.tabPage_ngaynhap.Text = "Ngày nhập";
            // 
            // dtp_phanloai_ngaynhap
            // 
            this.dtp_phanloai_ngaynhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.dtp_phanloai_ngaynhap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_phanloai_ngaynhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_phanloai_ngaynhap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_phanloai_ngaynhap.ButtonDropDown.Visible = true;
            this.dtp_phanloai_ngaynhap.Location = new System.Drawing.Point(4, 3);
            // 
            // 
            // 
            this.dtp_phanloai_ngaynhap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_phanloai_ngaynhap.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_phanloai_ngaynhap.MonthCalendar.BackgroundStyle.Class = "";
            this.dtp_phanloai_ngaynhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_phanloai_ngaynhap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtp_phanloai_ngaynhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_phanloai_ngaynhap.MonthCalendar.DisplayMonth = new System.DateTime(2011, 7, 1, 0, 0, 0, 0);
            this.dtp_phanloai_ngaynhap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_phanloai_ngaynhap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_phanloai_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_phanloai_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_phanloai_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_phanloai_ngaynhap.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtp_phanloai_ngaynhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_phanloai_ngaynhap.MonthCalendar.TodayButtonVisible = true;
            this.dtp_phanloai_ngaynhap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_phanloai_ngaynhap.Name = "dtp_phanloai_ngaynhap";
            this.dtp_phanloai_ngaynhap.Size = new System.Drawing.Size(266, 20);
            this.dtp_phanloai_ngaynhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_phanloai_ngaynhap.TabIndex = 0;
            // 
            // panel_page_thietbi
            // 
            this.panel_page_thietbi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_page_thietbi.Controls.Add(this.txt_page_thietbi_tongso);
            this.panel_page_thietbi.Controls.Add(this.btn_thietbi_lui);
            this.panel_page_thietbi.Controls.Add(this.btn_thietbi_tien);
            this.panel_page_thietbi.Controls.Add(this.txt_page_thietbi_vitri);
            this.panel_page_thietbi.Location = new System.Drawing.Point(35, 442);
            this.panel_page_thietbi.Name = "panel_page_thietbi";
            this.panel_page_thietbi.Size = new System.Drawing.Size(212, 26);
            this.panel_page_thietbi.TabIndex = 16;
            // 
            // txt_page_thietbi_tongso
            // 
            this.txt_page_thietbi_tongso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_page_thietbi_tongso.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_page_thietbi_tongso.Border.Class = "TextBoxBorder";
            this.txt_page_thietbi_tongso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_page_thietbi_tongso.Location = new System.Drawing.Point(111, 3);
            this.txt_page_thietbi_tongso.Name = "txt_page_thietbi_tongso";
            this.txt_page_thietbi_tongso.ReadOnly = true;
            this.txt_page_thietbi_tongso.Size = new System.Drawing.Size(65, 20);
            this.txt_page_thietbi_tongso.TabIndex = 3;
            this.txt_page_thietbi_tongso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_page_thietbi_tongso, "tổng số trang");
            // 
            // btn_thietbi_lui
            // 
            this.btn_thietbi_lui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_thietbi_lui.Location = new System.Drawing.Point(3, 3);
            this.btn_thietbi_lui.Name = "btn_thietbi_lui";
            this.btn_thietbi_lui.Size = new System.Drawing.Size(32, 20);
            this.btn_thietbi_lui.TabIndex = 2;
            this.btn_thietbi_lui.Text = "<";
            this.toolTip1.SetToolTip(this.btn_thietbi_lui, "xem trang trước");
            this.btn_thietbi_lui.UseVisualStyleBackColor = true;
            this.btn_thietbi_lui.Click += new System.EventHandler(this.btn_thietbi_lui_Click);
            // 
            // btn_thietbi_tien
            // 
            this.btn_thietbi_tien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_thietbi_tien.Location = new System.Drawing.Point(178, 3);
            this.btn_thietbi_tien.Name = "btn_thietbi_tien";
            this.btn_thietbi_tien.Size = new System.Drawing.Size(32, 20);
            this.btn_thietbi_tien.TabIndex = 1;
            this.btn_thietbi_tien.Text = ">";
            this.toolTip1.SetToolTip(this.btn_thietbi_tien, "xem trang tiếp theo");
            this.btn_thietbi_tien.UseVisualStyleBackColor = true;
            this.btn_thietbi_tien.Click += new System.EventHandler(this.btn_thietbi_tien_Click);
            // 
            // txt_page_thietbi_vitri
            // 
            this.txt_page_thietbi_vitri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_page_thietbi_vitri.Border.Class = "TextBoxBorder";
            this.txt_page_thietbi_vitri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_page_thietbi_vitri.Location = new System.Drawing.Point(37, 3);
            this.txt_page_thietbi_vitri.Name = "txt_page_thietbi_vitri";
            this.txt_page_thietbi_vitri.ReadOnly = true;
            this.txt_page_thietbi_vitri.Size = new System.Drawing.Size(71, 20);
            this.txt_page_thietbi_vitri.TabIndex = 0;
            this.txt_page_thietbi_vitri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_page_thietbi_vitri, "trang hiện tại");
            // 
            // btn_in_dsmacabiet
            // 
            this.btn_in_dsmacabiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_in_dsmacabiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_in_dsmacabiet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_in_dsmacabiet.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_in_dsmacabiet.Location = new System.Drawing.Point(470, 439);
            this.btn_in_dsmacabiet.Name = "btn_in_dsmacabiet";
            this.btn_in_dsmacabiet.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_in_dsmacabiet.Size = new System.Drawing.Size(106, 25);
            this.btn_in_dsmacabiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_in_dsmacabiet.TabIndex = 13;
            this.btn_in_dsmacabiet.Text = "DS mã cá biệt";
            this.btn_in_dsmacabiet.Click += new System.EventHandler(this.btn_in_dsmacabiet_Click);
            // 
            // lbl_macabiet
            // 
            this.lbl_macabiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_macabiet.AutoSize = true;
            this.lbl_macabiet.Location = new System.Drawing.Point(137, 448);
            this.lbl_macabiet.Name = "lbl_macabiet";
            this.lbl_macabiet.Size = new System.Drawing.Size(55, 13);
            this.lbl_macabiet.TabIndex = 12;
            this.lbl_macabiet.Text = "00000000";
            // 
            // pic_mavach
            // 
            this.pic_mavach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_mavach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_mavach.Location = new System.Drawing.Point(7, 440);
            this.pic_mavach.Name = "pic_mavach";
            this.pic_mavach.Size = new System.Drawing.Size(128, 28);
            this.pic_mavach.TabIndex = 11;
            this.pic_mavach.TabStop = false;
            this.pic_mavach.DoubleClick += new System.EventHandler(this.pic_mavach_DoubleClick);
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.opt_timtheo_tatca);
            this.panel_dieukhien.Controls.Add(this.opt_timtheo_ngaynhapve);
            this.panel_dieukhien.Controls.Add(this.opt_timtheo_sovanban);
            this.panel_dieukhien.Controls.Add(this.txt_sovanban);
            this.panel_dieukhien.Controls.Add(this.labelX1);
            this.panel_dieukhien.Controls.Add(this.dtp_ngaynhapve);
            this.panel_dieukhien.Enabled = false;
            this.panel_dieukhien.Location = new System.Drawing.Point(0, 15);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(576, 26);
            this.panel_dieukhien.TabIndex = 10;
            // 
            // opt_timtheo_tatca
            // 
            this.opt_timtheo_tatca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.opt_timtheo_tatca.BackgroundStyle.Class = "";
            this.opt_timtheo_tatca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.opt_timtheo_tatca.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_timtheo_tatca.Checked = true;
            this.opt_timtheo_tatca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opt_timtheo_tatca.CheckValue = "Y";
            this.opt_timtheo_tatca.Location = new System.Drawing.Point(486, 5);
            this.opt_timtheo_tatca.Name = "opt_timtheo_tatca";
            this.opt_timtheo_tatca.Size = new System.Drawing.Size(53, 18);
            this.opt_timtheo_tatca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.opt_timtheo_tatca.TabIndex = 5;
            this.opt_timtheo_tatca.Text = "Tất cả";
            this.opt_timtheo_tatca.CheckedChanged += new System.EventHandler(this.opt_timtheo_tatca_CheckedChanged);
            // 
            // opt_timtheo_ngaynhapve
            // 
            this.opt_timtheo_ngaynhapve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.opt_timtheo_ngaynhapve.BackgroundStyle.Class = "";
            this.opt_timtheo_ngaynhapve.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.opt_timtheo_ngaynhapve.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_timtheo_ngaynhapve.Location = new System.Drawing.Point(296, 5);
            this.opt_timtheo_ngaynhapve.Name = "opt_timtheo_ngaynhapve";
            this.opt_timtheo_ngaynhapve.Size = new System.Drawing.Size(92, 18);
            this.opt_timtheo_ngaynhapve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.opt_timtheo_ngaynhapve.TabIndex = 4;
            this.opt_timtheo_ngaynhapve.Text = "Ngày nhập về";
            this.opt_timtheo_ngaynhapve.CheckedChanged += new System.EventHandler(this.opt_timtheo_ngaynhapve_CheckedChanged);
            // 
            // opt_timtheo_sovanban
            // 
            this.opt_timtheo_sovanban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.opt_timtheo_sovanban.BackgroundStyle.Class = "";
            this.opt_timtheo_sovanban.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.opt_timtheo_sovanban.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_timtheo_sovanban.Location = new System.Drawing.Point(89, 5);
            this.opt_timtheo_sovanban.Name = "opt_timtheo_sovanban";
            this.opt_timtheo_sovanban.Size = new System.Drawing.Size(79, 15);
            this.opt_timtheo_sovanban.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.opt_timtheo_sovanban.TabIndex = 3;
            this.opt_timtheo_sovanban.Text = "Số văn bản";
            this.opt_timtheo_sovanban.CheckedChanged += new System.EventHandler(this.opt_timtheo_sovanban_CheckedChanged);
            // 
            // txt_sovanban
            // 
            this.txt_sovanban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txt_sovanban.Border.Class = "TextBoxBorder";
            this.txt_sovanban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sovanban.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sovanban.Enabled = false;
            this.txt_sovanban.Location = new System.Drawing.Point(170, 3);
            this.txt_sovanban.Name = "txt_sovanban";
            this.txt_sovanban.Size = new System.Drawing.Size(119, 20);
            this.txt_sovanban.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 15);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tìm theo";
            // 
            // dtp_ngaynhapve
            // 
            this.dtp_ngaynhapve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtp_ngaynhapve.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_ngaynhapve.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaynhapve.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_ngaynhapve.ButtonDropDown.Visible = true;
            this.dtp_ngaynhapve.Enabled = false;
            this.dtp_ngaynhapve.Location = new System.Drawing.Point(394, 3);
            // 
            // 
            // 
            this.dtp_ngaynhapve.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_ngaynhapve.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_ngaynhapve.MonthCalendar.BackgroundStyle.Class = "";
            this.dtp_ngaynhapve.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaynhapve.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtp_ngaynhapve.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaynhapve.MonthCalendar.DisplayMonth = new System.DateTime(2011, 7, 1, 0, 0, 0, 0);
            this.dtp_ngaynhapve.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_ngaynhapve.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_ngaynhapve.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_ngaynhapve.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_ngaynhapve.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_ngaynhapve.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtp_ngaynhapve.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaynhapve.MonthCalendar.TodayButtonVisible = true;
            this.dtp_ngaynhapve.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_ngaynhapve.Name = "dtp_ngaynhapve";
            this.dtp_ngaynhapve.Size = new System.Drawing.Size(86, 20);
            this.dtp_ngaynhapve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_ngaynhapve.TabIndex = 0;
            // 
            // lv_thietbi_giatri
            // 
            this.lv_thietbi_giatri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_thietbi_giatri.Border.Class = "ListViewBorder";
            this.lv_thietbi_giatri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thietbi_giatri.FullRowSelect = true;
            this.lv_thietbi_giatri.GridLines = true;
            this.lv_thietbi_giatri.Location = new System.Drawing.Point(0, 41);
            this.lv_thietbi_giatri.Name = "lv_thietbi_giatri";
            this.lv_thietbi_giatri.Size = new System.Drawing.Size(576, 395);
            this.lv_thietbi_giatri.TabIndex = 7;
            this.lv_thietbi_giatri.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi_giatri.View = System.Windows.Forms.View.Details;
            this.lv_thietbi_giatri.DoubleClick += new System.EventHandler(this.lv_thietbi_giatri_DoubleClick);
            this.lv_thietbi_giatri.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_thietbi_giatri_ItemSelectionChanged);
            // 
            // contextmenu_giatrithietbi
            // 
            this.contextmenu_giatrithietbi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_giatrithietbi_capnhatmacabiet,
            this.contextmenu_giatrithietbi_xemchitiet});
            this.contextmenu_giatrithietbi.Name = "contextmenu_giatrithietbi";
            this.contextmenu_giatrithietbi.Size = new System.Drawing.Size(181, 48);
            // 
            // contextmenu_giatrithietbi_capnhatmacabiet
            // 
            this.contextmenu_giatrithietbi_capnhatmacabiet.Name = "contextmenu_giatrithietbi_capnhatmacabiet";
            this.contextmenu_giatrithietbi_capnhatmacabiet.Size = new System.Drawing.Size(180, 22);
            this.contextmenu_giatrithietbi_capnhatmacabiet.Text = "Cập nhật mã cá biệt";
            this.contextmenu_giatrithietbi_capnhatmacabiet.Click += new System.EventHandler(this.contextmenu_giatrithietbi_capnhatmacabiet_Click);
            // 
            // contextmenu_giatrithietbi_xemchitiet
            // 
            this.contextmenu_giatrithietbi_xemchitiet.Name = "contextmenu_giatrithietbi_xemchitiet";
            this.contextmenu_giatrithietbi_xemchitiet.Size = new System.Drawing.Size(180, 22);
            this.contextmenu_giatrithietbi_xemchitiet.Text = "Xem chi tiết";
            this.contextmenu_giatrithietbi_xemchitiet.Click += new System.EventHandler(this.contextmenu_giatrithietbi_xemchitiet_Click);
            // 
            // frm_thietbi_macabiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 475);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frm_thietbi_macabiet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quản lý thiết bị theo mã cá biệt";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_chonkieu.ResumeLayout(false);
            this.tabPage_loaithietbi.ResumeLayout(false);
            this.tabPage_donvi.ResumeLayout(false);
            this.tabPage_ngaynhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_phanloai_ngaynhap)).EndInit();
            this.panel_page_thietbi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mavach)).EndInit();
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaynhapve)).EndInit();
            this.contextmenu_giatrithietbi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi_giatri;
        private System.Windows.Forms.Panel panel_page_thietbi;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private System.Windows.Forms.Button btn_thietbi_lui;
        private System.Windows.Forms.Button btn_thietbi_tien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_page_thietbi_vitri;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_page_thietbi_tongso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextmenu_giatrithietbi;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_giatrithietbi_capnhatmacabiet;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_ngaynhapve;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sovanban;
        private DevComponents.DotNetBar.Controls.CheckBoxX opt_timtheo_ngaynhapve;
        private DevComponents.DotNetBar.Controls.CheckBoxX opt_timtheo_sovanban;
        private DevComponents.DotNetBar.Controls.CheckBoxX opt_timtheo_tatca;
        private System.Windows.Forms.PictureBox pic_mavach;
        private System.Windows.Forms.Label lbl_macabiet;
        private System.Windows.Forms.TabControl tabControl_chonkieu;
        private System.Windows.Forms.TabPage tabPage_loaithietbi;
        private System.Windows.Forms.TabPage tabPage_donvi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_loaithietbi;
        private System.Windows.Forms.Button btn_lamtuoi_donvisudung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvisudung;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_giatrithietbi_xemchitiet;
        private DevComponents.DotNetBar.ButtonX btn_in_dsmacabiet;
        private System.Windows.Forms.TabPage tabPage_ngaynhap;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_phanloai_ngaynhap;
        private System.Windows.Forms.Button btn_lamtuoi_loaithietbi;

    }
}