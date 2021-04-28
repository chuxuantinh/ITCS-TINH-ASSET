namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_tylehaomon
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
            this.lv_haomon = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_bangdieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_nhomthietbi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_nhomthietbi = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_menu_hieuchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.context_menu_xoadong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).BeginInit();
            this.bar_bangdieukhien.SuspendLayout();
            this.context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_haomon
            // 
            this.lv_haomon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_haomon.Border.Class = "ListViewBorder";
            this.lv_haomon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_haomon.FullRowSelect = true;
            this.lv_haomon.GridLines = true;
            this.lv_haomon.Location = new System.Drawing.Point(7, 47);
            this.lv_haomon.Name = "lv_haomon";
            this.lv_haomon.Size = new System.Drawing.Size(655, 386);
            this.lv_haomon.TabIndex = 0;
            this.lv_haomon.UseCompatibleStateImageBehavior = false;
            this.lv_haomon.View = System.Windows.Forms.View.Details;
            this.lv_haomon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_haomon_ItemSelectionChanged);
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_bangdieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(7, 21);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(655, 28);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar_bangdieukhien
            // 
            this.bar_bangdieukhien.AccessibleDescription = "bar1 (bar_bangdieukhien)";
            this.bar_bangdieukhien.AccessibleName = "bar1";
            this.bar_bangdieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_bangdieukhien.AntiAlias = true;
            this.bar_bangdieukhien.Controls.Add(this.cbo_nhomthietbi);
            this.bar_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_bangdieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_bangdieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_nhomthietbi,
            this.btn_themmoi,
            this.btn_hieuchinh,
            this.btn_xoadong,
            this.lbl_thongke});
            this.bar_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_bangdieukhien.Name = "bar_bangdieukhien";
            this.bar_bangdieukhien.Size = new System.Drawing.Size(655, 28);
            this.bar_bangdieukhien.Stretch = true;
            this.bar_bangdieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_bangdieukhien.TabIndex = 0;
            this.bar_bangdieukhien.TabStop = false;
            this.bar_bangdieukhien.Text = "bar1";
            // 
            // cbo_nhomthietbi
            // 
            this.cbo_nhomthietbi.DisplayMember = "Text";
            this.cbo_nhomthietbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhomthietbi.FormattingEnabled = true;
            this.cbo_nhomthietbi.ItemHeight = 17;
            this.cbo_nhomthietbi.Location = new System.Drawing.Point(161, 2);
            this.cbo_nhomthietbi.Name = "cbo_nhomthietbi";
            this.cbo_nhomthietbi.Size = new System.Drawing.Size(163, 23);
            this.cbo_nhomthietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nhomthietbi.TabIndex = 0;
            this.cbo_nhomthietbi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbo_nhomthietbi_DrawItem);
            this.cbo_nhomthietbi.DropDownClosed += new System.EventHandler(this.cbo_nhomthietbi_DropDownClosed);
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
            // controlContainerItem_nhomthietbi
            // 
            this.controlContainerItem_nhomthietbi.AllowItemResize = false;
            this.controlContainerItem_nhomthietbi.Control = this.cbo_nhomthietbi;
            this.controlContainerItem_nhomthietbi.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_nhomthietbi.Name = "controlContainerItem_nhomthietbi";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BeginGroup = true;
            this.btn_themmoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themmoi.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.Tooltip = "Thêm tỷ lệ hao mòn";
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_hieuchinh
            // 
            this.btn_hieuchinh.BeginGroup = true;
            this.btn_hieuchinh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_hieuchinh.Image = global::ThietBiPY.Properties.Resources.Sua16;
            this.btn_hieuchinh.Name = "btn_hieuchinh";
            this.btn_hieuchinh.Text = "Hiệu chỉnh";
            this.btn_hieuchinh.Click += new System.EventHandler(this.btn_hieuchinh_Click);
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
            // lbl_thongke
            // 
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Số lượng: ";
            // 
            // context_menu
            // 
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_menu_hieuchinh,
            this.context_menu_xoadong});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(133, 48);
            // 
            // context_menu_hieuchinh
            // 
            this.context_menu_hieuchinh.Name = "context_menu_hieuchinh";
            this.context_menu_hieuchinh.Size = new System.Drawing.Size(132, 22);
            this.context_menu_hieuchinh.Text = "Hiệu chỉnh";
            this.context_menu_hieuchinh.Click += new System.EventHandler(this.context_menu_hieuchinh_Click);
            // 
            // context_menu_xoadong
            // 
            this.context_menu_xoadong.Name = "context_menu_xoadong";
            this.context_menu_xoadong.Size = new System.Drawing.Size(132, 22);
            this.context_menu_xoadong.Text = "Xóa dòng";
            this.context_menu_xoadong.Click += new System.EventHandler(this.context_menu_xoadong_Click);
            // 
            // frm_tylehaomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(668, 445);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.lv_haomon);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frm_tylehaomon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tỷ lệ hao mòn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_tylehaomon_KeyDown);
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).EndInit();
            this.bar_bangdieukhien.ResumeLayout(false);
            this.context_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_haomon;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_bangdieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_nhomthietbi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nhomthietbi;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_hieuchinh;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem context_menu_hieuchinh;
        private System.Windows.Forms.ToolStripMenuItem context_menu_xoadong;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}