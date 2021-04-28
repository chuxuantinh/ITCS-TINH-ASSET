namespace ThietBiPY.DanhMuc.thongtindonvi
{
    partial class frm_donvi
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
            this.lv_donvi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.txt_donvi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.menustrip_btn_sua = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menustrip_btn_xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip_chitiet = new System.Windows.Forms.ToolTip(this.components);
            this.panel_thongke = new System.Windows.Forms.Panel();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_thongke.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_donvi
            // 
            this.lv_donvi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_donvi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_donvi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_donvi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_donvi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_donvi.Border.Class = "ListViewBorder";
            this.lv_donvi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_donvi.FullRowSelect = true;
            this.lv_donvi.GridLines = true;
            this.lv_donvi.Location = new System.Drawing.Point(12, 48);
            this.lv_donvi.Name = "lv_donvi";
            this.lv_donvi.Size = new System.Drawing.Size(682, 301);
            this.lv_donvi.TabIndex = 11;
            this.lv_donvi.UseCompatibleStateImageBehavior = false;
            this.lv_donvi.View = System.Windows.Forms.View.Details;
            this.lv_donvi.DoubleClick += new System.EventHandler(this.lv_donvi_DoubleClick);
            this.lv_donvi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_donvi_ItemSelectionChanged);
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(12, 18);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(682, 34);
            this.panel_bangdieukhien.TabIndex = 10;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.txt_donvi);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.btn_themmoi,
            this.btn_sua,
            this.btn_xoa,
            this.labelItem1,
            this.controlContainerItem1});
            this.bar_dieukhien.ItemSpacing = 3;
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(682, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // txt_donvi
            // 
            // 
            // 
            // 
            this.txt_donvi.Border.Class = "TextBoxBorder";
            this.txt_donvi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_donvi.Location = new System.Drawing.Point(508, 2);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(146, 23);
            this.txt_donvi.TabIndex = 0;
            this.txt_donvi.WatermarkText = "nhập đơn vị cần tìm";
            this.txt_donvi.TextChanged += new System.EventHandler(this.txt_donvi_TextChanged);
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi (F5)";
            this.btn_lamtuoi.Click += new System.EventHandler(this.btn_lamtuoi_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BeginGroup = true;
            this.btn_themmoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themmoi.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Text = "Thêm mới (F6)";
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BeginGroup = true;
            this.btn_sua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_sua.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Text = "Hiệu chỉnh (F7)";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BeginGroup = true;
            this.btn_xoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_xoa.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Text = "Xóa chọn (Delete)";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "  Tìm";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.txt_donvi;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // menustrip_btn_sua
            // 
            this.menustrip_btn_sua.Name = "menustrip_btn_sua";
            this.menustrip_btn_sua.Size = new System.Drawing.Size(96, 22);
            this.menustrip_btn_sua.Text = "Sửa ";
            this.menustrip_btn_sua.Click += new System.EventHandler(this.menustrip_btn_sua_Click);
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_thongke.BackgroundStyle.Class = "";
            this.lbl_thongke.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thongke.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongke.Location = new System.Drawing.Point(0, 0);
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Size = new System.Drawing.Size(203, 19);
            this.lbl_thongke.TabIndex = 4;
            this.lbl_thongke.Text = "Tổng số: ";
            this.lbl_thongke.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_btn_sua,
            this.menustrip_btn_xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 48);
            // 
            // menustrip_btn_xoa
            // 
            this.menustrip_btn_xoa.Name = "menustrip_btn_xoa";
            this.menustrip_btn_xoa.Size = new System.Drawing.Size(96, 22);
            this.menustrip_btn_xoa.Text = "Xóa";
            this.menustrip_btn_xoa.Click += new System.EventHandler(this.menustrip_btn_xoa_Click);
            // 
            // panel_thongke
            // 
            this.panel_thongke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_thongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_thongke.Controls.Add(this.lbl_thongke);
            this.panel_thongke.Location = new System.Drawing.Point(487, 355);
            this.panel_thongke.Name = "panel_thongke";
            this.panel_thongke.Size = new System.Drawing.Size(207, 23);
            this.panel_thongke.TabIndex = 9;
            // 
            // frm_donvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 393);
            this.Controls.Add(this.lv_donvi);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.panel_thongke);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frm_donvi";
            this.ShowInTaskbar = false;
            this.Text = "frm_donvi";
            this.Load += new System.EventHandler(this.frm_donvi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_donvi_KeyDown);
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_thongke.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_donvi;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_donvi;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_btn_sua;
        private DevComponents.DotNetBar.LabelX lbl_thongke;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustrip_btn_xoa;
        private System.Windows.Forms.ToolTip tooltip_chitiet;
        private System.Windows.Forms.Panel panel_thongke;
    }
}