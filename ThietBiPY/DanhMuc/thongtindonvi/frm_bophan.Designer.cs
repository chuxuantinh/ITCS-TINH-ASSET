namespace ThietBiPY.DanhMuc.thongtindonvi
{
    partial class frm_bophan
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
            this.lv_bophan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.txt_thongke = new System.Windows.Forms.TextBox();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_donvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_bophan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.contextmenu_dieukhien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_dieukhien_hieuchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_dieukhien_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.contextmenu_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_bophan
            // 
            this.lv_bophan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_bophan.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_bophan.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_bophan.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_bophan.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_bophan.Border.Class = "ListViewBorder";
            this.lv_bophan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_bophan.FullRowSelect = true;
            this.lv_bophan.GridLines = true;
            this.lv_bophan.Location = new System.Drawing.Point(12, 50);
            this.lv_bophan.Name = "lv_bophan";
            this.lv_bophan.Size = new System.Drawing.Size(672, 412);
            this.lv_bophan.TabIndex = 0;
            this.lv_bophan.UseCompatibleStateImageBehavior = false;
            this.lv_bophan.View = System.Windows.Forms.View.Details;
            this.lv_bophan.DoubleClick += new System.EventHandler(this.lv_bophan_DoubleClick);
            // 
            // txt_thongke
            // 
            this.txt_thongke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thongke.BackColor = System.Drawing.SystemColors.Info;
            this.txt_thongke.Location = new System.Drawing.Point(545, 468);
            this.txt_thongke.Name = "txt_thongke";
            this.txt_thongke.ReadOnly = true;
            this.txt_thongke.Size = new System.Drawing.Size(100, 20);
            this.txt_thongke.TabIndex = 1;
            this.txt_thongke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(12, 23);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(672, 28);
            this.panel_dieukhien.TabIndex = 2;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_donvi);
            this.bar_dieukhien.Controls.Add(this.txt_bophan);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem1,
            this.btn_themmoi,
            this.btn_sua,
            this.btn_xoadong,
            this.labelItem2,
            this.controlContainerItem2});
            this.bar_dieukhien.ItemSpacing = 3;
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(672, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_donvi
            // 
            this.cbo_donvi.DisplayMember = "Text";
            this.cbo_donvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvi.FormattingEnabled = true;
            this.cbo_donvi.ItemHeight = 17;
            this.cbo_donvi.Location = new System.Drawing.Point(134, 2);
            this.cbo_donvi.Name = "cbo_donvi";
            this.cbo_donvi.Size = new System.Drawing.Size(146, 23);
            this.cbo_donvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvi.TabIndex = 0;
            this.cbo_donvi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_donvi_DrawItem);
            this.cbo_donvi.DropDownClosed += new System.EventHandler(this.cbo_donvi_DropDownClosed);
            // 
            // txt_bophan
            // 
            this.txt_bophan.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_bophan.Border.Class = "TextBoxBorder";
            this.txt_bophan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_bophan.Location = new System.Drawing.Point(542, 2);
            this.txt_bophan.Name = "txt_bophan";
            this.txt_bophan.Size = new System.Drawing.Size(114, 23);
            this.txt_bophan.TabIndex = 1;
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
            this.labelItem1.Text = "  Đơn vị";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.cbo_donvi;
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
            this.btn_themmoi.Tooltip = "Thêm bộ phận mới";
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BeginGroup = true;
            this.btn_sua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_sua.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Text = "Hiệu chỉnh";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoadong
            // 
            this.btn_xoadong.BeginGroup = true;
            this.btn_xoadong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_xoadong.Image = global::ThietBiPY.Properties.Resources.Xoa16;
            this.btn_xoadong.Name = "btn_xoadong";
            this.btn_xoadong.Text = "Xóa dòng";
            this.btn_xoadong.Click += new System.EventHandler(this.btn_xoadong_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tìm bộ phận";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.txt_bophan;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // contextmenu_dieukhien
            // 
            this.contextmenu_dieukhien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_dieukhien_hieuchinh,
            this.contextmenu_dieukhien_xoadong});
            this.contextmenu_dieukhien.Name = "contextmenu_dieukhien";
            this.contextmenu_dieukhien.Size = new System.Drawing.Size(133, 48);
            // 
            // contextmenu_dieukhien_hieuchinh
            // 
            this.contextmenu_dieukhien_hieuchinh.Name = "contextmenu_dieukhien_hieuchinh";
            this.contextmenu_dieukhien_hieuchinh.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_dieukhien_hieuchinh.Text = "Hiệu chỉnh";
            this.contextmenu_dieukhien_hieuchinh.Click += new System.EventHandler(this.contextmenu_dieukhien_hieuchinh_Click);
            // 
            // contextmenu_dieukhien_xoadong
            // 
            this.contextmenu_dieukhien_xoadong.Name = "contextmenu_dieukhien_xoadong";
            this.contextmenu_dieukhien_xoadong.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_dieukhien_xoadong.Text = "Xóa";
            this.contextmenu_dieukhien_xoadong.Click += new System.EventHandler(this.contextmenu_dieukhien_xoadong_Click);
            // 
            // frm_bophan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(696, 495);
            this.Controls.Add(this.panel_dieukhien);
            this.Controls.Add(this.lv_bophan);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frm_bophan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bộ phận";
            this.Load += new System.EventHandler(this.frm_bophan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_bophan_KeyDown);
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.contextmenu_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_bophan;
        private System.Windows.Forms.TextBox txt_thongke;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_bophan;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private System.Windows.Forms.ContextMenuStrip contextmenu_dieukhien;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_dieukhien_hieuchinh;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_dieukhien_xoadong;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}