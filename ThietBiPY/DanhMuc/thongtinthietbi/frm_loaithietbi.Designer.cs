namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_loaithietbi
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
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_nhomthietbi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_loaithietbi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.lv_loaithietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_thongke = new System.Windows.Forms.Panel();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menustrip_btn_sua = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_btn_xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.panel_thongke.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(14, 20);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(871, 31);
            this.panel_bangdieukhien.TabIndex = 0;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "bar1 (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "bar1";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_nhomthietbi);
            this.bar_dieukhien.Controls.Add(this.txt_loaithietbi);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem1,
            this.btn_themmoi,
            this.btn_sua,
            this.btn_xoa,
            this.labelItem2,
            this.controlContainerItem2});
            this.bar_dieukhien.ItemSpacing = 3;
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(871, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_nhomthietbi
            // 
            this.cbo_nhomthietbi.DisplayMember = "Text";
            this.cbo_nhomthietbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhomthietbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nhomthietbi.FormattingEnabled = true;
            this.cbo_nhomthietbi.ItemHeight = 17;
            this.cbo_nhomthietbi.Location = new System.Drawing.Point(167, 2);
            this.cbo_nhomthietbi.Name = "cbo_nhomthietbi";
            this.cbo_nhomthietbi.Size = new System.Drawing.Size(145, 23);
            this.cbo_nhomthietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nhomthietbi.TabIndex = 0;
            // 
            // txt_loaithietbi
            // 
            // 
            // 
            // 
            this.txt_loaithietbi.Border.Class = "TextBoxBorder";
            this.txt_loaithietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_loaithietbi.Location = new System.Drawing.Point(621, 2);
            this.txt_loaithietbi.Name = "txt_loaithietbi";
            this.txt_loaithietbi.Size = new System.Drawing.Size(141, 23);
            this.txt_loaithietbi.TabIndex = 1;
            this.txt_loaithietbi.WatermarkText = "nhập loại thiết bị cần tìm";
            this.txt_loaithietbi.TextChanged += new System.EventHandler(this.txt_loaithietbi_TextChanged);
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            this.btn_lamtuoi.Click += new System.EventHandler(this.btn_lamtuoi_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Nhóm thiết bị";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.cbo_nhomthietbi;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BeginGroup = true;
            this.btn_themmoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themmoi.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.Tooltip = "(F6) Thêm loại thiết bị mới";
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BeginGroup = true;
            this.btn_sua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_sua.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Text = "Hiệu chỉnh ";
            this.btn_sua.Tooltip = "(F7) hiệu chỉnh thông tin loại thiết bị đang chọn";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BeginGroup = true;
            this.btn_xoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_xoa.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Text = "Xóa chọn ";
            this.btn_xoa.Tooltip = "(Delete) Xóa loại thiết bị đang chọn";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem2.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tìm";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.txt_loaithietbi;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // lv_loaithietbi
            // 
            this.lv_loaithietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_loaithietbi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_loaithietbi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_loaithietbi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_loaithietbi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_loaithietbi.Border.Class = "ListViewBorder";
            this.lv_loaithietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_loaithietbi.FullRowSelect = true;
            this.lv_loaithietbi.GridLines = true;
            this.lv_loaithietbi.Location = new System.Drawing.Point(14, 51);
            this.lv_loaithietbi.Name = "lv_loaithietbi";
            this.lv_loaithietbi.Size = new System.Drawing.Size(871, 426);
            this.lv_loaithietbi.TabIndex = 1;
            this.lv_loaithietbi.UseCompatibleStateImageBehavior = false;
            this.lv_loaithietbi.View = System.Windows.Forms.View.Details;
            this.lv_loaithietbi.DoubleClick += new System.EventHandler(this.lv_loaithietbi_DoubleClick);
            this.lv_loaithietbi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_loaithietbi_ItemSelectionChanged);
            // 
            // panel_thongke
            // 
            this.panel_thongke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_thongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_thongke.Controls.Add(this.lbl_thongke);
            this.panel_thongke.Location = new System.Drawing.Point(758, 482);
            this.panel_thongke.Name = "panel_thongke";
            this.panel_thongke.Size = new System.Drawing.Size(127, 22);
            this.panel_thongke.TabIndex = 2;
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.lbl_thongke.BackgroundStyle.Class = "";
            this.lbl_thongke.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thongke.Location = new System.Drawing.Point(0, 0);
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Size = new System.Drawing.Size(123, 18);
            this.lbl_thongke.TabIndex = 0;
            this.lbl_thongke.Text = "Tổng số : ";
            this.lbl_thongke.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_btn_sua,
            this.menustrip_btn_xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // menustrip_btn_sua
            // 
            this.menustrip_btn_sua.Name = "menustrip_btn_sua";
            this.menustrip_btn_sua.Size = new System.Drawing.Size(94, 22);
            this.menustrip_btn_sua.Text = "Sửa";
            this.menustrip_btn_sua.Click += new System.EventHandler(this.menustrip_btn_sua_Click);
            // 
            // menustrip_btn_xoa
            // 
            this.menustrip_btn_xoa.Name = "menustrip_btn_xoa";
            this.menustrip_btn_xoa.Size = new System.Drawing.Size(94, 22);
            this.menustrip_btn_xoa.Text = "Xóa";
            this.menustrip_btn_xoa.Click += new System.EventHandler(this.menustrip_btn_xoa_Click);
            // 
            // frm_loaithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.panel_thongke);
            this.Controls.Add(this.lv_loaithietbi);
            this.Controls.Add(this.panel_bangdieukhien);
            this.DoubleBuffered = true;
            this.Name = "frm_loaithietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Loại thiết bị";
            this.Load += new System.EventHandler(this.frm_loaithietbi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_loaithietbi_KeyDown);
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.panel_thongke.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nhomthietbi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_loaithietbi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_loaithietbi;
        private System.Windows.Forms.Panel panel_thongke;
        private DevComponents.DotNetBar.LabelX lbl_thongke;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_btn_sua;
        private System.Windows.Forms.ToolStripMenuItem menustrip_btn_xoa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}