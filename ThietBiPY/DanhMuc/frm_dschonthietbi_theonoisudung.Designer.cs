namespace ThietBiPY.DanhMuc
{
    partial class frm_dschonthietbi_theonoisudung
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
            this.panel_locdulieu = new System.Windows.Forms.Panel();
            this.txt_macabiet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbo_tinhtrang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbo_donvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel_chinh = new System.Windows.Forms.Panel();
            this.btn_chon = new DevComponents.DotNetBar.ButtonX();
            this.lv_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_locdulieu.SuspendLayout();
            this.panel_chinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_locdulieu
            // 
            this.panel_locdulieu.Controls.Add(this.txt_macabiet);
            this.panel_locdulieu.Controls.Add(this.labelX3);
            this.panel_locdulieu.Controls.Add(this.cbo_tinhtrang);
            this.panel_locdulieu.Controls.Add(this.labelX2);
            this.panel_locdulieu.Controls.Add(this.cbo_donvi);
            this.panel_locdulieu.Controls.Add(this.labelX1);
            this.panel_locdulieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_locdulieu.Location = new System.Drawing.Point(0, 0);
            this.panel_locdulieu.Name = "panel_locdulieu";
            this.panel_locdulieu.Size = new System.Drawing.Size(752, 31);
            this.panel_locdulieu.TabIndex = 2;
            // 
            // txt_macabiet
            // 
            // 
            // 
            // 
            this.txt_macabiet.Border.Class = "TextBoxBorder";
            this.txt_macabiet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_macabiet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_macabiet.Location = new System.Drawing.Point(550, 5);
            this.txt_macabiet.Name = "txt_macabiet";
            this.txt_macabiet.Size = new System.Drawing.Size(192, 20);
            this.txt_macabiet.TabIndex = 5;
            this.txt_macabiet.WatermarkText = "nhập mã cá biệt";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(521, 6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(23, 19);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Tìm";
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.DisplayMember = "Text";
            this.cbo_tinhtrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.ItemHeight = 14;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(338, 5);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(177, 20);
            this.cbo_tinhtrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tinhtrang.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(277, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(55, 20);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tình trạng";
            // 
            // cbo_donvi
            // 
            this.cbo_donvi.DisplayMember = "Text";
            this.cbo_donvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvi.FormattingEnabled = true;
            this.cbo_donvi.ItemHeight = 14;
            this.cbo_donvi.Location = new System.Drawing.Point(52, 5);
            this.cbo_donvi.Name = "cbo_donvi";
            this.cbo_donvi.Size = new System.Drawing.Size(219, 20);
            this.cbo_donvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvi.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(35, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Đơn vị";
            // 
            // panel_chinh
            // 
            this.panel_chinh.Controls.Add(this.btn_chon);
            this.panel_chinh.Controls.Add(this.lv_thietbi);
            this.panel_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chinh.Location = new System.Drawing.Point(0, 31);
            this.panel_chinh.Name = "panel_chinh";
            this.panel_chinh.Size = new System.Drawing.Size(752, 495);
            this.panel_chinh.TabIndex = 3;
            // 
            // btn_chon
            // 
            this.btn_chon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chon.Location = new System.Drawing.Point(11, 459);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_chon.Size = new System.Drawing.Size(73, 23);
            this.btn_chon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chon.TabIndex = 3;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // lv_thietbi
            // 
            this.lv_thietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lv_thietbi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_thietbi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_thietbi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_thietbi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.lv_thietbi.Border.Class = "ListViewBorder";
            this.lv_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thietbi.CheckBoxes = true;
            this.lv_thietbi.FullRowSelect = true;
            this.lv_thietbi.GridLines = true;
            this.lv_thietbi.Location = new System.Drawing.Point(11, 3);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(731, 451);
            this.lv_thietbi.TabIndex = 2;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            this.lv_thietbi.DoubleClick += new System.EventHandler(this.lv_thietbi_DoubleClick);
            // 
            // frm_dschonthietbi_theonoisudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(752, 526);
            this.Controls.Add(this.panel_chinh);
            this.Controls.Add(this.panel_locdulieu);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.KeyPreview = true;
            this.Name = "frm_dschonthietbi_theonoisudung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thiết bị";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dschonthietbi_theonoisudung_KeyDown);
            this.panel_locdulieu.ResumeLayout(false);
            this.panel_chinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_chinh;
        private DevComponents.DotNetBar.ButtonX btn_chon;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tinhtrang;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_macabiet;
        public System.Windows.Forms.Panel panel_locdulieu;
    }
}