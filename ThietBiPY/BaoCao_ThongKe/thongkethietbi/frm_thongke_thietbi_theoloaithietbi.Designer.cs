namespace ThietBiPY.BaoCao_ThongKe.thongkethietbi
{
    partial class frm_thongke_thietbi_theoloaithietbi
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
            this.lv_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.cbo_nhomthietbi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem_Nhomthietbi = new DevComponents.DotNetBar.ControlContainerItem();
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_menu_xemdanhsachthietbi = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_thongke = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.context_menu.SuspendLayout();
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
            this.lv_thietbi.Border.Class = "ListViewBorder";
            this.lv_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thietbi.FullRowSelect = true;
            this.lv_thietbi.GridLines = true;
            this.lv_thietbi.Location = new System.Drawing.Point(12, 41);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(677, 402);
            this.lv_thietbi.TabIndex = 0;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            this.lv_thietbi.DoubleClick += new System.EventHandler(this.lv_thietbi_DoubleClick);
            this.lv_thietbi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_thietbi_ItemSelectionChanged);
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar1);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(12, 12);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(677, 28);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AntiAlias = true;
            this.bar1.Controls.Add(this.cbo_nhomthietbi);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.labelItem1,
            this.controlContainerItem_Nhomthietbi});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(677, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // cbo_nhomthietbi
            // 
            this.cbo_nhomthietbi.DisplayMember = "Text";
            this.cbo_nhomthietbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhomthietbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nhomthietbi.FormattingEnabled = true;
            this.cbo_nhomthietbi.ItemHeight = 17;
            this.cbo_nhomthietbi.Location = new System.Drawing.Point(161, 2);
            this.cbo_nhomthietbi.Name = "cbo_nhomthietbi";
            this.cbo_nhomthietbi.Size = new System.Drawing.Size(288, 23);
            this.cbo_nhomthietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nhomthietbi.TabIndex = 0;
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
            this.labelItem1.Text = "Nhóm thiết bị";
            // 
            // controlContainerItem_Nhomthietbi
            // 
            this.controlContainerItem_Nhomthietbi.AllowItemResize = false;
            this.controlContainerItem_Nhomthietbi.Control = this.cbo_nhomthietbi;
            this.controlContainerItem_Nhomthietbi.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem_Nhomthietbi.Name = "controlContainerItem_Nhomthietbi";
            // 
            // context_menu
            // 
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_menu_xemdanhsachthietbi});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(196, 26);
            // 
            // context_menu_xemdanhsachthietbi
            // 
            this.context_menu_xemdanhsachthietbi.Name = "context_menu_xemdanhsachthietbi";
            this.context_menu_xemdanhsachthietbi.Size = new System.Drawing.Size(195, 22);
            this.context_menu_xemdanhsachthietbi.Text = "Xem danh sách thiết bị";
            this.context_menu_xemdanhsachthietbi.Click += new System.EventHandler(this.context_menu_xemdanhsachthietbi_Click);
            // 
            // txt_thongke
            // 
            this.txt_thongke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_thongke.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_thongke.Border.Class = "TextBoxBorder";
            this.txt_thongke.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_thongke.Location = new System.Drawing.Point(12, 445);
            this.txt_thongke.Name = "txt_thongke";
            this.txt_thongke.ReadOnly = true;
            this.txt_thongke.Size = new System.Drawing.Size(261, 20);
            this.txt_thongke.TabIndex = 3;
            this.txt_thongke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_thongke_thietbi_theoloaithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.txt_thongke);
            this.Controls.Add(this.lv_thietbi);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_thongke_thietbi_theoloaithietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Thống kê thiết bị";
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.context_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem_Nhomthietbi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nhomthietbi;
        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem context_menu_xemdanhsachthietbi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_thongke;
    }
}