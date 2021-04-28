namespace ThietBiPY.DanhMuc
{
    partial class frm_thietbi_dschon
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
            this.lv_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btn_chon = new DevComponents.DotNetBar.ButtonX();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien_thietbi = new DevComponents.DotNetBar.Bar();
            this.cbo_loaithietbi = new DevComponents.DotNetBar.Controls.ComboTree();
            this.cbo_tieuchi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_tukhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_loaithietbi = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_tieuchi = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem_tukhoa = new DevComponents.DotNetBar.ControlContainerItem();
            this.opt_batki = new DevComponents.DotNetBar.CheckBoxItem();
            this.opt_loaithietbi = new DevComponents.DotNetBar.CheckBoxItem();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien_thietbi)).BeginInit();
            this.bar_dieukhien_thietbi.SuspendLayout();
            this.SuspendLayout();
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
            this.lv_thietbi.Location = new System.Drawing.Point(5, 49);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(786, 391);
            this.lv_thietbi.TabIndex = 0;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            this.lv_thietbi.DoubleClick += new System.EventHandler(this.lv_thietbi_DoubleClick);
            // 
            // btn_chon
            // 
            this.btn_chon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chon.Location = new System.Drawing.Point(6, 446);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_chon.Size = new System.Drawing.Size(75, 23);
            this.btn_chon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chon.TabIndex = 2;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien_thietbi);
            this.panel_dieukhien.Location = new System.Drawing.Point(6, 17);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(785, 30);
            this.panel_dieukhien.TabIndex = 3;
            // 
            // bar_dieukhien_thietbi
            // 
            this.bar_dieukhien_thietbi.AccessibleDescription = "DotNetBar Bar (bar_dieukhien_thietbi)";
            this.bar_dieukhien_thietbi.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien_thietbi.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien_thietbi.AntiAlias = true;
            this.bar_dieukhien_thietbi.Controls.Add(this.cbo_loaithietbi);
            this.bar_dieukhien_thietbi.Controls.Add(this.cbo_tieuchi);
            this.bar_dieukhien_thietbi.Controls.Add(this.txt_tukhoa);
            this.bar_dieukhien_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien_thietbi.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien_thietbi.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_loaithietbi,
            this.labelItem2,
            this.controlContainerItem_tieuchi,
            this.controlContainerItem_tukhoa,
            this.opt_batki,
            this.opt_loaithietbi});
            this.bar_dieukhien_thietbi.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien_thietbi.Name = "bar_dieukhien_thietbi";
            this.bar_dieukhien_thietbi.Size = new System.Drawing.Size(785, 28);
            this.bar_dieukhien_thietbi.Stretch = true;
            this.bar_dieukhien_thietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien_thietbi.TabIndex = 2;
            this.bar_dieukhien_thietbi.TabStop = false;
            this.bar_dieukhien_thietbi.Text = "bar1";
            // 
            // cbo_loaithietbi
            // 
            this.cbo_loaithietbi.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbo_loaithietbi.BackgroundStyle.Class = "TextBoxBorder";
            this.cbo_loaithietbi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_loaithietbi.ButtonDropDown.Visible = true;
            this.cbo_loaithietbi.Location = new System.Drawing.Point(140, 2);
            this.cbo_loaithietbi.Name = "cbo_loaithietbi";
            this.cbo_loaithietbi.Size = new System.Drawing.Size(163, 23);
            this.cbo_loaithietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_loaithietbi.TabIndex = 0;
            // 
            // cbo_tieuchi
            // 
            this.cbo_tieuchi.DisplayMember = "Text";
            this.cbo_tieuchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tieuchi.FormattingEnabled = true;
            this.cbo_tieuchi.ItemHeight = 15;
            this.cbo_tieuchi.Location = new System.Drawing.Point(395, 3);
            this.cbo_tieuchi.Name = "cbo_tieuchi";
            this.cbo_tieuchi.Size = new System.Drawing.Size(84, 21);
            this.cbo_tieuchi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tieuchi.TabIndex = 1;
            // 
            // txt_tukhoa
            // 
            // 
            // 
            // 
            this.txt_tukhoa.Border.Class = "TextBoxBorder";
            this.txt_tukhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tukhoa.Location = new System.Drawing.Point(483, 3);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(150, 21);
            this.txt_tukhoa.TabIndex = 2;
            // 
            // btn_lamtuoi
            // 
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
            this.labelItem1.Text = "Loại thiết bị";
            // 
            // controlContainerItem_loaithietbi
            // 
            this.controlContainerItem_loaithietbi.AllowItemResize = false;
            this.controlContainerItem_loaithietbi.Control = this.cbo_loaithietbi;
            this.controlContainerItem_loaithietbi.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_loaithietbi.Name = "controlContainerItem_loaithietbi";
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Image = global::ThietBiPY.Properties.Resources.Tim16;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Tra cứu theo";
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
            // opt_batki
            // 
            this.opt_batki.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_batki.Name = "opt_batki";
            this.opt_batki.Text = "Bất kì";
            this.opt_batki.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.opt_batki_CheckedChanged);
            // 
            // opt_loaithietbi
            // 
            this.opt_loaithietbi.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.opt_loaithietbi.Checked = true;
            this.opt_loaithietbi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opt_loaithietbi.Name = "opt_loaithietbi";
            this.opt_loaithietbi.Text = "Loại thiết bị";
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(716, 446);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_thietbi_dschon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.panel_dieukhien);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.lv_thietbi);
            this.EnableGlass = false;
            this.KeyPreview = true;
            this.Name = "frm_thietbi_dschon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn thiết bị ....";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_thietbi_dschon_KeyDown);
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien_thietbi)).EndInit();
            this.bar_dieukhien_thietbi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private DevComponents.DotNetBar.ButtonX btn_chon;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien_thietbi;
        private DevComponents.DotNetBar.Controls.ComboTree cbo_loaithietbi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tieuchi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tukhoa;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_loaithietbi;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tieuchi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_tukhoa;
        private DevComponents.DotNetBar.CheckBoxItem opt_batki;
        private DevComponents.DotNetBar.CheckBoxItem opt_loaithietbi;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
    }
}