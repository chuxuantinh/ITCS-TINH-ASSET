namespace ThietBiPY.DanhMuc
{
    partial class frm_nhanvien_dschon
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
            this.lv_nhanvien = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btn_chon = new DevComponents.DotNetBar.ButtonX();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.cbo_donvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_timtheo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_tukhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_nhanvien
            // 
            // 
            // 
            // 
            this.lv_nhanvien.Border.Class = "ListViewBorder";
            this.lv_nhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_nhanvien.FullRowSelect = true;
            this.lv_nhanvien.GridLines = true;
            this.lv_nhanvien.Location = new System.Drawing.Point(12, 43);
            this.lv_nhanvien.Name = "lv_nhanvien";
            this.lv_nhanvien.Size = new System.Drawing.Size(637, 434);
            this.lv_nhanvien.TabIndex = 0;
            this.lv_nhanvien.UseCompatibleStateImageBehavior = false;
            this.lv_nhanvien.View = System.Windows.Forms.View.Details;
            this.lv_nhanvien.DoubleClick += new System.EventHandler(this.lv_nhanvien_DoubleClick);
            // 
            // btn_chon
            // 
            this.btn_chon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chon.Location = new System.Drawing.Point(12, 483);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_chon.Size = new System.Drawing.Size(75, 23);
            this.btn_chon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chon.TabIndex = 1;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(574, 483);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 2;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.cbo_donvi);
            this.bar_dieukhien.Controls.Add(this.cbo_timtheo);
            this.bar_dieukhien.Controls.Add(this.txt_tukhoa);
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem1,
            this.labelItem2,
            this.controlContainerItem2,
            this.controlContainerItem3,
            this.lbl_thongke});
            this.bar_dieukhien.Location = new System.Drawing.Point(12, 16);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(637, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 3;
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
            this.cbo_donvi.Location = new System.Drawing.Point(128, 2);
            this.cbo_donvi.Name = "cbo_donvi";
            this.cbo_donvi.Size = new System.Drawing.Size(159, 23);
            this.cbo_donvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvi.TabIndex = 0;
            // 
            // cbo_timtheo
            // 
            this.cbo_timtheo.DisplayMember = "Text";
            this.cbo_timtheo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_timtheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_timtheo.FormattingEnabled = true;
            this.cbo_timtheo.ItemHeight = 17;
            this.cbo_timtheo.Location = new System.Drawing.Point(365, 2);
            this.cbo_timtheo.Name = "cbo_timtheo";
            this.cbo_timtheo.Size = new System.Drawing.Size(75, 23);
            this.cbo_timtheo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_timtheo.TabIndex = 1;
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_tukhoa.Border.Class = "TextBoxBorder";
            this.txt_tukhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tukhoa.Location = new System.Drawing.Point(444, 2);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(131, 23);
            this.txt_tukhoa.TabIndex = 2;
            this.txt_tukhoa.WatermarkText = "nhập từ khóa cần tìm";
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
            this.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelItem1.Text = "  Đơn vị";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.cbo_donvi;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tìm kiếm";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.cbo_timtheo;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.txt_tukhoa;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Số lượng:";
            // 
            // frm_nhanvien_dschon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(661, 517);
            this.Controls.Add(this.bar_dieukhien);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.lv_nhanvien);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_nhanvien_dschon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn nhân viên ...";
            this.Load += new System.EventHandler(this.frm_nhanvien_dschon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhanvien_dschon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_nhanvien;
        private DevComponents.DotNetBar.ButtonX btn_chon;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_timtheo;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tukhoa;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
    }
}