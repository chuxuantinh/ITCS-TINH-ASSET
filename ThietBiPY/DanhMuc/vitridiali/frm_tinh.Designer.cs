namespace ThietBiPY.DanhMuc.vitridiali
{
    partial class frm_tinh
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
            this.menustrip_chucnangphu_suadong = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_danhmuc = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelX();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_tennuoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_danhmuc_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_danhmuc_them = new DevComponents.DotNetBar.ButtonItem();
            this.btn_danhmuc_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_danhmuc_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.panel_duoi = new System.Windows.Forms.Panel();
            this.menustrip_chucnangphu_nhandoidong = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_tren = new System.Windows.Forms.Panel();
            this.menustrip_chucnangphu_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_chucnangphu_lamtuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_chucnangphu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.panel_duoi.SuspendLayout();
            this.menustrip_chucnangphu.SuspendLayout();
            this.panel_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustrip_chucnangphu_suadong
            // 
            this.menustrip_chucnangphu_suadong.Name = "menustrip_chucnangphu_suadong";
            this.menustrip_chucnangphu_suadong.Size = new System.Drawing.Size(123, 22);
            this.menustrip_chucnangphu_suadong.Text = "Hiệu chỉnh";
            // 
            // lv_danhmuc
            // 
            // 
            // 
            // 
            this.lv_danhmuc.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_danhmuc.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_danhmuc.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_danhmuc.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_danhmuc.Border.Class = "ListViewBorder";
            this.lv_danhmuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_danhmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_danhmuc.FullRowSelect = true;
            this.lv_danhmuc.GridLines = true;
            this.lv_danhmuc.Location = new System.Drawing.Point(0, 59);
            this.lv_danhmuc.Name = "lv_danhmuc";
            this.lv_danhmuc.Size = new System.Drawing.Size(785, 347);
            this.lv_danhmuc.TabIndex = 11;
            this.lv_danhmuc.UseCompatibleStateImageBehavior = false;
            this.lv_danhmuc.View = System.Windows.Forms.View.Details;
            this.lv_danhmuc.DoubleClick += new System.EventHandler(this.lv_danhmuc_DoubleClick);
            this.lv_danhmuc.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_danhmuc_ItemSelectionChanged);
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.lbl_thongke.BackgroundStyle.Class = "";
            this.lbl_thongke.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_thongke.Location = new System.Drawing.Point(14, 5);
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Size = new System.Drawing.Size(268, 14);
            this.lbl_thongke.TabIndex = 0;
            this.lbl_thongke.Text = "Số lượng : ";
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_tennuoc);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_danhmuc_lamtuoi,
            this.labelItem1,
            this.controlContainerItem1,
            this.btn_danhmuc_them,
            this.btn_danhmuc_sua,
            this.btn_danhmuc_xoa});
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(785, 26);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_tennuoc
            // 
            this.cbo_tennuoc.DisplayMember = "Text";
            this.cbo_tennuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tennuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tennuoc.FormattingEnabled = true;
            this.cbo_tennuoc.ItemHeight = 15;
            this.cbo_tennuoc.Location = new System.Drawing.Point(156, 2);
            this.cbo_tennuoc.Name = "cbo_tennuoc";
            this.cbo_tennuoc.Size = new System.Drawing.Size(140, 21);
            this.cbo_tennuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tennuoc.TabIndex = 0;
            // 
            // btn_danhmuc_lamtuoi
            // 
            this.btn_danhmuc_lamtuoi.BeginGroup = true;
            this.btn_danhmuc_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_danhmuc_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_danhmuc_lamtuoi.Name = "btn_danhmuc_lamtuoi";
            this.btn_danhmuc_lamtuoi.Text = "Làm tươi";
            this.btn_danhmuc_lamtuoi.Click += new System.EventHandler(this.btn_danhmuc_lamtuoi_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Chọn nước";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.cbo_tennuoc;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // btn_danhmuc_them
            // 
            this.btn_danhmuc_them.BeginGroup = true;
            this.btn_danhmuc_them.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_danhmuc_them.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_danhmuc_them.Name = "btn_danhmuc_them";
            this.btn_danhmuc_them.Text = "Thêm mới";
            this.btn_danhmuc_them.Click += new System.EventHandler(this.btn_danhmuc_them_Click);
            // 
            // btn_danhmuc_sua
            // 
            this.btn_danhmuc_sua.BeginGroup = true;
            this.btn_danhmuc_sua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_danhmuc_sua.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_danhmuc_sua.Name = "btn_danhmuc_sua";
            this.btn_danhmuc_sua.Text = "Hiệu chỉnh";
            this.btn_danhmuc_sua.Click += new System.EventHandler(this.btn_danhmuc_sua_Click);
            // 
            // btn_danhmuc_xoa
            // 
            this.btn_danhmuc_xoa.BeginGroup = true;
            this.btn_danhmuc_xoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_danhmuc_xoa.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_danhmuc_xoa.Name = "btn_danhmuc_xoa";
            this.btn_danhmuc_xoa.Text = "Xóa dòng";
            this.btn_danhmuc_xoa.Click += new System.EventHandler(this.btn_danhmuc_xoa_Click);
            // 
            // panel_duoi
            // 
            this.panel_duoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_duoi.Controls.Add(this.lbl_thongke);
            this.panel_duoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_duoi.Location = new System.Drawing.Point(0, 406);
            this.panel_duoi.Name = "panel_duoi";
            this.panel_duoi.Size = new System.Drawing.Size(785, 28);
            this.panel_duoi.TabIndex = 9;
            // 
            // menustrip_chucnangphu_nhandoidong
            // 
            this.menustrip_chucnangphu_nhandoidong.Name = "menustrip_chucnangphu_nhandoidong";
            this.menustrip_chucnangphu_nhandoidong.Size = new System.Drawing.Size(123, 22);
            this.menustrip_chucnangphu_nhandoidong.Text = "Nhân đôi";
            // 
            // panel_tren
            // 
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(785, 31);
            this.panel_tren.TabIndex = 8;
            // 
            // menustrip_chucnangphu_xoadong
            // 
            this.menustrip_chucnangphu_xoadong.Name = "menustrip_chucnangphu_xoadong";
            this.menustrip_chucnangphu_xoadong.Size = new System.Drawing.Size(123, 22);
            this.menustrip_chucnangphu_xoadong.Text = "Xóa dòng";
            this.menustrip_chucnangphu_xoadong.Click += new System.EventHandler(this.menustrip_chucnangphu_xoadong_Click);
            // 
            // menustrip_chucnangphu_lamtuoi
            // 
            this.menustrip_chucnangphu_lamtuoi.Name = "menustrip_chucnangphu_lamtuoi";
            this.menustrip_chucnangphu_lamtuoi.Size = new System.Drawing.Size(123, 22);
            this.menustrip_chucnangphu_lamtuoi.Text = "Làm tươi";
            this.menustrip_chucnangphu_lamtuoi.Click += new System.EventHandler(this.menustrip_chucnangphu_lamtuoi_Click);
            // 
            // menustrip_chucnangphu
            // 
            this.menustrip_chucnangphu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_chucnangphu_suadong,
            this.menustrip_chucnangphu_xoadong,
            this.menustrip_chucnangphu_nhandoidong,
            this.menustrip_chucnangphu_lamtuoi});
            this.menustrip_chucnangphu.Name = "menustrip_chucnangphu";
            this.menustrip_chucnangphu.Size = new System.Drawing.Size(124, 92);
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_dieukhien.Location = new System.Drawing.Point(0, 31);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(785, 28);
            this.panel_dieukhien.TabIndex = 10;
            // 
            // frm_tinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.lv_danhmuc);
            this.Controls.Add(this.panel_duoi);
            this.Controls.Add(this.panel_dieukhien);
            this.Controls.Add(this.panel_tren);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frm_tinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tỉnh/TP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tinh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_tinh_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.panel_duoi.ResumeLayout(false);
            this.menustrip_chucnangphu.ResumeLayout(false);
            this.panel_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menustrip_chucnangphu_suadong;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_danhmuc;
        private DevComponents.DotNetBar.LabelX lbl_thongke;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_danhmuc_them;
        private DevComponents.DotNetBar.ButtonItem btn_danhmuc_sua;
        private DevComponents.DotNetBar.ButtonItem btn_danhmuc_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_danhmuc_lamtuoi;
        private System.Windows.Forms.Panel panel_duoi;
        private System.Windows.Forms.ToolStripMenuItem menustrip_chucnangphu_nhandoidong;
        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.ToolStripMenuItem menustrip_chucnangphu_xoadong;
        private System.Windows.Forms.ToolStripMenuItem menustrip_chucnangphu_lamtuoi;
        private System.Windows.Forms.ContextMenuStrip menustrip_chucnangphu;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tennuoc;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
    }
}