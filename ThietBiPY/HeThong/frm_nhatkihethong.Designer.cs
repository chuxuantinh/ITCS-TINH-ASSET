namespace ThietBiPY.HeThong
{
    partial class frm_nhatkihethong
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
            this.lv_danhsachlog = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.opt_mocthoigian = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.opt_thoigiancuthe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel_bientrai = new System.Windows.Forms.Panel();
            this.panel_bienduoi = new System.Windows.Forms.Panel();
            this.lbl_soluongthaotac = new DevComponents.DotNetBar.LabelX();
            this.panel_bienphai = new System.Windows.Forms.Panel();
            this.panel_bientren = new System.Windows.Forms.Panel();
            this.dtp_ngaycuthe = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbo_thoigian = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menustrip_btn_xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_bienduoi.SuspendLayout();
            this.panel_bientren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaycuthe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_danhsachlog
            // 
            // 
            // 
            // 
            this.lv_danhsachlog.Border.Class = "ListViewBorder";
            this.lv_danhsachlog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_danhsachlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_danhsachlog.FullRowSelect = true;
            this.lv_danhsachlog.GridLines = true;
            this.lv_danhsachlog.Location = new System.Drawing.Point(10, 38);
            this.lv_danhsachlog.Name = "lv_danhsachlog";
            this.lv_danhsachlog.Size = new System.Drawing.Size(668, 421);
            this.lv_danhsachlog.TabIndex = 10;
            this.lv_danhsachlog.UseCompatibleStateImageBehavior = false;
            this.lv_danhsachlog.View = System.Windows.Forms.View.Details;
            this.lv_danhsachlog.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_danhsachlog_ItemSelectionChanged);
            // 
            // opt_mocthoigian
            // 
            this.opt_mocthoigian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.opt_mocthoigian.BackgroundStyle.Class = "";
            this.opt_mocthoigian.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.opt_mocthoigian.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_mocthoigian.Checked = true;
            this.opt_mocthoigian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opt_mocthoigian.CheckValue = "Y";
            this.opt_mocthoigian.Location = new System.Drawing.Point(95, 7);
            this.opt_mocthoigian.Name = "opt_mocthoigian";
            this.opt_mocthoigian.Size = new System.Drawing.Size(96, 21);
            this.opt_mocthoigian.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.opt_mocthoigian.TabIndex = 4;
            this.opt_mocthoigian.Text = "Mốc thời gian";
            this.opt_mocthoigian.CheckedChanged += new System.EventHandler(this.opt_mocthoigian_CheckedChanged);
            // 
            // opt_thoigiancuthe
            // 
            this.opt_thoigiancuthe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.opt_thoigiancuthe.BackgroundStyle.Class = "";
            this.opt_thoigiancuthe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.opt_thoigiancuthe.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_thoigiancuthe.Location = new System.Drawing.Point(335, 6);
            this.opt_thoigiancuthe.Name = "opt_thoigiancuthe";
            this.opt_thoigiancuthe.Size = new System.Drawing.Size(111, 22);
            this.opt_thoigiancuthe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.opt_thoigiancuthe.TabIndex = 5;
            this.opt_thoigiancuthe.Text = "Thời gian cụ thể";
            // 
            // panel_bientrai
            // 
            this.panel_bientrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bientrai.Location = new System.Drawing.Point(0, 0);
            this.panel_bientrai.Name = "panel_bientrai";
            this.panel_bientrai.Size = new System.Drawing.Size(10, 488);
            this.panel_bientrai.TabIndex = 6;
            // 
            // panel_bienduoi
            // 
            this.panel_bienduoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bienduoi.Controls.Add(this.lbl_soluongthaotac);
            this.panel_bienduoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bienduoi.Location = new System.Drawing.Point(10, 459);
            this.panel_bienduoi.Name = "panel_bienduoi";
            this.panel_bienduoi.Size = new System.Drawing.Size(668, 29);
            this.panel_bienduoi.TabIndex = 8;
            // 
            // lbl_soluongthaotac
            // 
            // 
            // 
            // 
            this.lbl_soluongthaotac.BackgroundStyle.Class = "";
            this.lbl_soluongthaotac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_soluongthaotac.Location = new System.Drawing.Point(6, 3);
            this.lbl_soluongthaotac.Name = "lbl_soluongthaotac";
            this.lbl_soluongthaotac.Size = new System.Drawing.Size(180, 13);
            this.lbl_soluongthaotac.TabIndex = 0;
            this.lbl_soluongthaotac.Text = "Tổng số thao tác : ";
            // 
            // panel_bienphai
            // 
            this.panel_bienphai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_bienphai.Location = new System.Drawing.Point(678, 0);
            this.panel_bienphai.Name = "panel_bienphai";
            this.panel_bienphai.Size = new System.Drawing.Size(10, 488);
            this.panel_bienphai.TabIndex = 7;
            // 
            // panel_bientren
            // 
            this.panel_bientren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bientren.Controls.Add(this.opt_thoigiancuthe);
            this.panel_bientren.Controls.Add(this.opt_mocthoigian);
            this.panel_bientren.Controls.Add(this.dtp_ngaycuthe);
            this.panel_bientren.Controls.Add(this.cbo_thoigian);
            this.panel_bientren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bientren.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_bientren.Location = new System.Drawing.Point(10, 0);
            this.panel_bientren.Name = "panel_bientren";
            this.panel_bientren.Size = new System.Drawing.Size(668, 38);
            this.panel_bientren.TabIndex = 9;
            // 
            // dtp_ngaycuthe
            // 
            this.dtp_ngaycuthe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtp_ngaycuthe.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_ngaycuthe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaycuthe.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_ngaycuthe.ButtonDropDown.Visible = true;
            this.dtp_ngaycuthe.Enabled = false;
            this.dtp_ngaycuthe.Location = new System.Drawing.Point(449, 6);
            // 
            // 
            // 
            this.dtp_ngaycuthe.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_ngaycuthe.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_ngaycuthe.MonthCalendar.BackgroundStyle.Class = "";
            this.dtp_ngaycuthe.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaycuthe.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtp_ngaycuthe.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaycuthe.MonthCalendar.DisplayMonth = new System.DateTime(2011, 4, 1, 0, 0, 0, 0);
            this.dtp_ngaycuthe.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_ngaycuthe.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_ngaycuthe.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_ngaycuthe.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_ngaycuthe.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_ngaycuthe.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtp_ngaycuthe.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtp_ngaycuthe.MonthCalendar.TodayButtonVisible = true;
            this.dtp_ngaycuthe.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_ngaycuthe.Name = "dtp_ngaycuthe";
            this.dtp_ngaycuthe.Size = new System.Drawing.Size(120, 22);
            this.dtp_ngaycuthe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtp_ngaycuthe.TabIndex = 2;
            // 
            // cbo_thoigian
            // 
            this.cbo_thoigian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_thoigian.DisplayMember = "Text";
            this.cbo_thoigian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_thoigian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_thoigian.FormattingEnabled = true;
            this.cbo_thoigian.ItemHeight = 16;
            this.cbo_thoigian.Location = new System.Drawing.Point(195, 6);
            this.cbo_thoigian.Name = "cbo_thoigian";
            this.cbo_thoigian.Size = new System.Drawing.Size(127, 22);
            this.cbo_thoigian.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_thoigian.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_btn_xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // menustrip_btn_xoa
            // 
            this.menustrip_btn_xoa.Name = "menustrip_btn_xoa";
            this.menustrip_btn_xoa.Size = new System.Drawing.Size(152, 22);
            this.menustrip_btn_xoa.Text = "Xóa dòng";
            this.menustrip_btn_xoa.Click += new System.EventHandler(this.menustrip_btn_xoa_Click);
            // 
            // frm_nhatkihethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(688, 488);
            this.Controls.Add(this.lv_danhsachlog);
            this.Controls.Add(this.panel_bienduoi);
            this.Controls.Add(this.panel_bientren);
            this.Controls.Add(this.panel_bientrai);
            this.Controls.Add(this.panel_bienphai);
            this.Name = "frm_nhatkihethong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nhật kí hệ thống";
            this.panel_bienduoi.ResumeLayout(false);
            this.panel_bientren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_ngaycuthe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_danhsachlog;
        private DevComponents.DotNetBar.Controls.CheckBoxX opt_mocthoigian;
        private DevComponents.DotNetBar.Controls.CheckBoxX opt_thoigiancuthe;
        private System.Windows.Forms.Panel panel_bientrai;
        private System.Windows.Forms.Panel panel_bienduoi;
        private DevComponents.DotNetBar.LabelX lbl_soluongthaotac;
        private System.Windows.Forms.Panel panel_bienphai;
        private System.Windows.Forms.Panel panel_bientren;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_ngaycuthe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_thoigian;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_btn_xoa;
    }
}