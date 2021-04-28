namespace ThietBiPY.DanhMuc
{
    partial class frm_nhacungcap_dschon
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
            this.lv_nhacungcap = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btn_chonnhacungcap = new DevComponents.DotNetBar.ButtonX();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.txt_nhacungcap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.lbl_thongke = new DevComponents.DotNetBar.LabelItem();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.bar_dieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_nhacungcap
            // 
            // 
            // 
            // 
            this.lv_nhacungcap.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_nhacungcap.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_nhacungcap.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_nhacungcap.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.lv_nhacungcap.Border.Class = "ListViewBorder";
            this.lv_nhacungcap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_nhacungcap.FullRowSelect = true;
            this.lv_nhacungcap.GridLines = true;
            this.lv_nhacungcap.Location = new System.Drawing.Point(12, 39);
            this.lv_nhacungcap.Name = "lv_nhacungcap";
            this.lv_nhacungcap.Size = new System.Drawing.Size(535, 394);
            this.lv_nhacungcap.TabIndex = 0;
            this.lv_nhacungcap.UseCompatibleStateImageBehavior = false;
            this.lv_nhacungcap.View = System.Windows.Forms.View.Details;
            this.lv_nhacungcap.DoubleClick += new System.EventHandler(this.lv_nhacungcap_DoubleClick);
            // 
            // btn_chonnhacungcap
            // 
            this.btn_chonnhacungcap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chonnhacungcap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chonnhacungcap.Location = new System.Drawing.Point(12, 443);
            this.btn_chonnhacungcap.Name = "btn_chonnhacungcap";
            this.btn_chonnhacungcap.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_chonnhacungcap.Size = new System.Drawing.Size(75, 23);
            this.btn_chonnhacungcap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chonnhacungcap.TabIndex = 1;
            this.btn_chonnhacungcap.Text = "Chọn";
            this.btn_chonnhacungcap.Click += new System.EventHandler(this.btn_chonnhacungcap_Click);
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Controls.Add(this.txt_nhacungcap);
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem1,
            this.lbl_thongke});
            this.bar_dieukhien.ItemSpacing = 3;
            this.bar_dieukhien.Location = new System.Drawing.Point(12, 12);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(535, 28);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 2;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_nhacungcap.Border.Class = "TextBoxBorder";
            this.txt_nhacungcap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nhacungcap.Location = new System.Drawing.Point(207, 2);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(173, 23);
            this.txt_nhacungcap.TabIndex = 0;
            this.txt_nhacungcap.WatermarkText = "nhập nhà cung cấp cần tìm";
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
            this.labelItem1.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Tìm nhà cung cấp";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.txt_nhacungcap;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // lbl_thongke
            // 
            this.lbl_thongke.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lbl_thongke.Name = "lbl_thongke";
            this.lbl_thongke.Text = "Số lượng: ";
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(472, 443);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_nhacungcap_dschon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 480);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.bar_dieukhien);
            this.Controls.Add(this.btn_chonnhacungcap);
            this.Controls.Add(this.lv_nhacungcap);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_nhacungcap_dschon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn nhà cung cấp ..";
            this.Load += new System.EventHandler(this.frm_nhacungcap_dschon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhacungcap_dschon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.bar_dieukhien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_nhacungcap;
        private DevComponents.DotNetBar.ButtonX btn_chonnhacungcap;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_nhacungcap;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.LabelItem lbl_thongke;
    }
}