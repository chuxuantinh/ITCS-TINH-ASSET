namespace ThietBiPY.BaoCao_ThongKe
{
    partial class frm_hoso_bangiaothietbi
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
            this.lv_hosobangiao = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_bangdieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_nam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_chondonvi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_Nam = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.btn_inhoso = new DevComponents.DotNetBar.ButtonItem();
            this.txt_thongkesoluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).BeginInit();
            this.bar_bangdieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_hosobangiao
            // 
            this.lv_hosobangiao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_hosobangiao.Border.Class = "ListViewBorder";
            this.lv_hosobangiao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_hosobangiao.FullRowSelect = true;
            this.lv_hosobangiao.GridLines = true;
            this.lv_hosobangiao.Location = new System.Drawing.Point(5, 40);
            this.lv_hosobangiao.Name = "lv_hosobangiao";
            this.lv_hosobangiao.Size = new System.Drawing.Size(729, 425);
            this.lv_hosobangiao.TabIndex = 0;
            this.lv_hosobangiao.UseCompatibleStateImageBehavior = false;
            this.lv_hosobangiao.View = System.Windows.Forms.View.Details;
            this.lv_hosobangiao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_hosobangiao_KeyDown);
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_bangdieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(5, 12);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(729, 28);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar_bangdieukhien
            // 
            this.bar_bangdieukhien.AccessibleDescription = "DotNetBar Bar (bar_bangdieukhien)";
            this.bar_bangdieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_bangdieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_bangdieukhien.AntiAlias = true;
            this.bar_bangdieukhien.Controls.Add(this.cbo_nam);
            this.bar_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_bangdieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_bangdieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.btn_chondonvi,
            this.labelItem1,
            this.controlContainerItem_Nam,
            this.btn_hieuchinh,
            this.btn_xoadong,
            this.btn_inhoso});
            this.bar_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_bangdieukhien.Name = "bar_bangdieukhien";
            this.bar_bangdieukhien.Size = new System.Drawing.Size(729, 28);
            this.bar_bangdieukhien.Stretch = true;
            this.bar_bangdieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_bangdieukhien.TabIndex = 0;
            this.bar_bangdieukhien.TabStop = false;
            this.bar_bangdieukhien.Text = "bar1";
            // 
            // cbo_nam
            // 
            this.cbo_nam.DisplayMember = "Text";
            this.cbo_nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.ItemHeight = 17;
            this.cbo_nam.Location = new System.Drawing.Point(226, 2);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(121, 23);
            this.cbo_nam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nam.TabIndex = 0;
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            this.btn_lamtuoi.Tooltip = "F5-Làm tươi chứng từ bàn giao";
            this.btn_lamtuoi.Click += new System.EventHandler(this.btn_lamtuoi_Click);
            // 
            // btn_chondonvi
            // 
            this.btn_chondonvi.BeginGroup = true;
            this.btn_chondonvi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_chondonvi.Image = global::ThietBiPY.Properties.Resources.DonVi16;
            this.btn_chondonvi.Name = "btn_chondonvi";
            this.btn_chondonvi.Text = "Chọn đơn vị";
            this.btn_chondonvi.Tooltip = "Xem các chứng từ theo đơn vị bàn giao";
            this.btn_chondonvi.Click += new System.EventHandler(this.btn_chondonvi_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BeginGroup = true;
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Năm";
            // 
            // controlContainerItem_Nam
            // 
            this.controlContainerItem_Nam.AllowItemResize = false;
            this.controlContainerItem_Nam.Control = this.cbo_nam;
            this.controlContainerItem_Nam.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_Nam.Name = "controlContainerItem_Nam";
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
            // btn_inhoso
            // 
            this.btn_inhoso.BeginGroup = true;
            this.btn_inhoso.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_inhoso.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_inhoso.Name = "btn_inhoso";
            this.btn_inhoso.Text = "In hồ sơ";
            this.btn_inhoso.Click += new System.EventHandler(this.btn_inhoso_Click);
            // 
            // txt_thongkesoluong
            // 
            this.txt_thongkesoluong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thongkesoluong.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_thongkesoluong.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.txt_thongkesoluong.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.txt_thongkesoluong.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.txt_thongkesoluong.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.txt_thongkesoluong.Border.Class = "TextBoxBorder";
            this.txt_thongkesoluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_thongkesoluong.Location = new System.Drawing.Point(5, 467);
            this.txt_thongkesoluong.Name = "txt_thongkesoluong";
            this.txt_thongkesoluong.ReadOnly = true;
            this.txt_thongkesoluong.Size = new System.Drawing.Size(729, 20);
            this.txt_thongkesoluong.TabIndex = 2;
            // 
            // frm_hoso_bangiaothietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(739, 490);
            this.Controls.Add(this.txt_thongkesoluong);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.lv_hosobangiao);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frm_hoso_bangiaothietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hồ sơ bàn giao thiết bị";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_hoso_bangiaothietbi_KeyDown);
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).EndInit();
            this.bar_bangdieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_hosobangiao;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_bangdieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_Nam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nam;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.ButtonItem btn_hieuchinh;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_inhoso;
        private DevComponents.DotNetBar.ButtonItem btn_chondonvi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_thongkesoluong;
    }
}