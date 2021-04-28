namespace ThietBiPY.BaoCao_ThongKe
{
    partial class frm_hoso_thuhoithietbi
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
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_nam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_namvanban = new DevComponents.DotNetBar.ControlContainerItem();
            this.btn_hieuchinh = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoadong = new DevComponents.DotNetBar.ButtonItem();
            this.btn_inchungtu = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            this.lv_danhsachchungtu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(7, 17);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(635, 27);
            this.panel_dieukhien.TabIndex = 0;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_nam);
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.controlContainerItem_namvanban,
            this.btn_hieuchinh,
            this.btn_xoadong,
            this.btn_inchungtu,
            this.lbl_thongke});
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(635, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // cbo_nam
            // 
            this.cbo_nam.DisplayMember = "Text";
            this.cbo_nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.ItemHeight = 17;
            this.cbo_nam.Location = new System.Drawing.Point(87, 2);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(121, 23);
            this.cbo_nam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nam.TabIndex = 0;
            // 
            // labelItem1
            // 
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Chọn năm";
            // 
            // controlContainerItem_namvanban
            // 
            this.controlContainerItem_namvanban.AllowItemResize = false;
            this.controlContainerItem_namvanban.Control = this.cbo_nam;
            this.controlContainerItem_namvanban.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_namvanban.Name = "controlContainerItem_namvanban";
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
            this.btn_xoadong.Text = "Xóa chứng từ";
            this.btn_xoadong.Click += new System.EventHandler(this.btn_xoadong_Click);
            // 
            // btn_inchungtu
            // 
            this.btn_inchungtu.BeginGroup = true;
            this.btn_inchungtu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_inchungtu.Image = global::ThietBiPY.Properties.Resources.In16;
            this.btn_inchungtu.Name = "btn_inchungtu";
            this.btn_inchungtu.Text = "In chứng từ";
            this.btn_inchungtu.Click += new System.EventHandler(this.btn_inchungtu_Click);
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Tổng số:";
            // 
            // lv_danhsachchungtu
            // 
            this.lv_danhsachchungtu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_danhsachchungtu.Border.Class = "ListViewBorder";
            this.lv_danhsachchungtu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_danhsachchungtu.FullRowSelect = true;
            this.lv_danhsachchungtu.GridLines = true;
            this.lv_danhsachchungtu.Location = new System.Drawing.Point(7, 46);
            this.lv_danhsachchungtu.Name = "lv_danhsachchungtu";
            this.lv_danhsachchungtu.Size = new System.Drawing.Size(635, 444);
            this.lv_danhsachchungtu.TabIndex = 1;
            this.lv_danhsachchungtu.UseCompatibleStateImageBehavior = false;
            this.lv_danhsachchungtu.View = System.Windows.Forms.View.Details;
            // 
            // frm_hoso_thuhoithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(648, 502);
            this.Controls.Add(this.lv_danhsachchungtu);
            this.Controls.Add(this.panel_dieukhien);
            this.DoubleBuffered = true;
            this.Name = "frm_hoso_thuhoithietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chứng từ thu hồi thiết bị";
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_namvanban;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nam;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_danhsachchungtu;
        private DevComponents.DotNetBar.ButtonItem btn_hieuchinh;
        private DevComponents.DotNetBar.ButtonItem btn_xoadong;
        private DevComponents.DotNetBar.ButtonItem btn_inchungtu;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
    }
}