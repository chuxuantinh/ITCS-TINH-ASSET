namespace ThietBiPY.HeThong
{
    partial class frm_nguoidung_quantri
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
            this.lv_nguoidung = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_trangthai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_tieuchi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_tukhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_trangthai = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_tieuchi = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem_tukhoa = new DevComponents.DotNetBar.ControlContainerItem();
            this.contextmenu_dieukhien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_hieuchinh_capquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_themnguoidung = new DevComponents.DotNetBar.ButtonItem();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.contextmenu_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_nguoidung
            // 
            this.lv_nguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_nguoidung.Border.Class = "ListViewBorder";
            this.lv_nguoidung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_nguoidung.FullRowSelect = true;
            this.lv_nguoidung.GridLines = true;
            this.lv_nguoidung.Location = new System.Drawing.Point(8, 42);
            this.lv_nguoidung.Name = "lv_nguoidung";
            this.lv_nguoidung.Size = new System.Drawing.Size(796, 465);
            this.lv_nguoidung.TabIndex = 0;
            this.lv_nguoidung.UseCompatibleStateImageBehavior = false;
            this.lv_nguoidung.View = System.Windows.Forms.View.Details;
            this.lv_nguoidung.DoubleClick += new System.EventHandler(this.lv_nguoidung_DoubleClick);
            this.lv_nguoidung.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_nguoidung_ItemSelectionChanged);
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(8, 12);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(796, 28);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_trangthai);
            this.bar_dieukhien.Controls.Add(this.cbo_tieuchi);
            this.bar_dieukhien.Controls.Add(this.txt_tukhoa);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_trangthai,
            this.labelItem2,
            this.controlContainerItem_tieuchi,
            this.controlContainerItem_tukhoa,
            this.btn_themnguoidung});
            this.bar_dieukhien.ItemSpacing = 3;
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(796, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DisplayMember = "Text";
            this.cbo_trangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.ItemHeight = 17;
            this.cbo_trangthai.Location = new System.Drawing.Point(147, 2);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(105, 23);
            this.cbo_trangthai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_trangthai.TabIndex = 0;
            // 
            // cbo_tieuchi
            // 
            this.cbo_tieuchi.DisplayMember = "Text";
            this.cbo_tieuchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tieuchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tieuchi.FormattingEnabled = true;
            this.cbo_tieuchi.ItemHeight = 17;
            this.cbo_tieuchi.Location = new System.Drawing.Point(336, 2);
            this.cbo_tieuchi.Name = "cbo_tieuchi";
            this.cbo_tieuchi.Size = new System.Drawing.Size(111, 23);
            this.cbo_tieuchi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tieuchi.TabIndex = 1;
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_tukhoa.Border.Class = "TextBoxBorder";
            this.txt_tukhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tukhoa.Location = new System.Drawing.Point(454, 2);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(178, 23);
            this.txt_tukhoa.TabIndex = 2;
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Trạng thái";
            // 
            // controlContainerItem_trangthai
            // 
            this.controlContainerItem_trangthai.AllowItemResize = false;
            this.controlContainerItem_trangthai.Control = this.cbo_trangthai;
            this.controlContainerItem_trangthai.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_trangthai.Name = "controlContainerItem_trangthai";
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tìm kiếm";
            // 
            // controlContainerItem_tieuchi
            // 
            this.controlContainerItem_tieuchi.AllowItemResize = false;
            this.controlContainerItem_tieuchi.Control = this.cbo_tieuchi;
            this.controlContainerItem_tieuchi.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_tieuchi.Name = "controlContainerItem_tieuchi";
            // 
            // controlContainerItem_tukhoa
            // 
            this.controlContainerItem_tukhoa.AllowItemResize = false;
            this.controlContainerItem_tukhoa.Control = this.txt_tukhoa;
            this.controlContainerItem_tukhoa.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_tukhoa.Name = "controlContainerItem_tukhoa";
            // 
            // contextmenu_dieukhien
            // 
            this.contextmenu_dieukhien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_hieuchinh_capquyen});
            this.contextmenu_dieukhien.Name = "contextmenu_dieukhien";
            this.contextmenu_dieukhien.Size = new System.Drawing.Size(133, 26);
            // 
            // contextmenu_hieuchinh_capquyen
            // 
            this.contextmenu_hieuchinh_capquyen.Name = "contextmenu_hieuchinh_capquyen";
            this.contextmenu_hieuchinh_capquyen.Size = new System.Drawing.Size(132, 22);
            this.contextmenu_hieuchinh_capquyen.Text = "Hiệu chỉnh";
            this.contextmenu_hieuchinh_capquyen.Click += new System.EventHandler(this.contextmenu_hieuchinh_capquyen_Click);
            // 
            // btn_themnguoidung
            // 
            this.btn_themnguoidung.BeginGroup = true;
            this.btn_themnguoidung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themnguoidung.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_themnguoidung.Name = "btn_themnguoidung";
            this.btn_themnguoidung.Text = "Thêm mới";
            this.btn_themnguoidung.Click += new System.EventHandler(this.btn_themnguoidung_Click);
            // 
            // frm_nguoidung_quantri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(812, 526);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.lv_nguoidung);
            this.DoubleBuffered = true;
            this.Name = "frm_nguoidung_quantri";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Người dùng";
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.contextmenu_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_nguoidung;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_trangthai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_trangthai;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tieuchi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tieuchi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tukhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tukhoa;
        private System.Windows.Forms.ContextMenuStrip contextmenu_dieukhien;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_hieuchinh_capquyen;
        private DevComponents.DotNetBar.ButtonItem btn_themnguoidung;
    }
}