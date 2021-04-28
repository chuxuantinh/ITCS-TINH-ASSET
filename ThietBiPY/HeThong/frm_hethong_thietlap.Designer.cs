namespace ThietBiPY.HeThong
{
    partial class frm_hethong_thietlap
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
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btn_apdung_server = new DevComponents.DotNetBar.ButtonX();
            this.chk_luuketnoi = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAuthentication = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.winAuth = new DevComponents.Editors.ComboItem();
            this.sqlServerAuth = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_hethong_matkhauserver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_hethong_taikhoanserver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_hethong_csdl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_hethong_server = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem_Server = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(405, 226);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 0;
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem_Server});
            this.superTabControl1.TabVerticalSpacing = 0;
            this.superTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.superTabControl1_SelectedTabChanged);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.btn_apdung_server);
            this.superTabControlPanel1.Controls.Add(this.chk_luuketnoi);
            this.superTabControlPanel1.Controls.Add(this.groupBox1);
            this.superTabControlPanel1.Controls.Add(this.txt_hethong_csdl);
            this.superTabControlPanel1.Controls.Add(this.labelX2);
            this.superTabControlPanel1.Controls.Add(this.txt_hethong_server);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 17);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(405, 209);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem_Server;
            // 
            // btn_apdung_server
            // 
            this.btn_apdung_server.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_apdung_server.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_apdung_server.Location = new System.Drawing.Point(318, 171);
            this.btn_apdung_server.Name = "btn_apdung_server";
            this.btn_apdung_server.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_apdung_server.Size = new System.Drawing.Size(75, 23);
            this.btn_apdung_server.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_apdung_server.TabIndex = 6;
            this.btn_apdung_server.Text = "Áp dụng";
            this.btn_apdung_server.Click += new System.EventHandler(this.btn_apdung_server_Click);
            // 
            // chk_luuketnoi
            // 
            this.chk_luuketnoi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk_luuketnoi.BackgroundStyle.Class = "";
            this.chk_luuketnoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_luuketnoi.Location = new System.Drawing.Point(15, 171);
            this.chk_luuketnoi.Name = "chk_luuketnoi";
            this.chk_luuketnoi.Size = new System.Drawing.Size(155, 23);
            this.chk_luuketnoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_luuketnoi.TabIndex = 5;
            this.chk_luuketnoi.Text = "Lưu thông tin kết nối server";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbAuthentication);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txt_hethong_matkhauserver);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txt_hethong_taikhoanserver);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmbAuthentication
            // 
            this.cmbAuthentication.DisplayMember = "Text";
            this.cmbAuthentication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAuthentication.FormattingEnabled = true;
            this.cmbAuthentication.ItemHeight = 14;
            this.cmbAuthentication.Items.AddRange(new object[] {
            this.winAuth,
            this.sqlServerAuth});
            this.cmbAuthentication.Location = new System.Drawing.Point(71, 16);
            this.cmbAuthentication.Name = "cmbAuthentication";
            this.cmbAuthentication.Size = new System.Drawing.Size(305, 20);
            this.cmbAuthentication.TabIndex = 18;
            this.cmbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cmbAuthentication_SelectedIndexChanged);
            // 
            // winAuth
            // 
            this.winAuth.Text = "Windows Authentication";
            // 
            // sqlServerAuth
            // 
            this.sqlServerAuth.Text = "SQL Server Authentication";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(7, 18);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(58, 18);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Kiểu kết nối";
            // 
            // txt_hethong_matkhauserver
            // 
            // 
            // 
            // 
            this.txt_hethong_matkhauserver.Border.Class = "TextBoxBorder";
            this.txt_hethong_matkhauserver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hethong_matkhauserver.Enabled = false;
            this.txt_hethong_matkhauserver.Location = new System.Drawing.Point(71, 69);
            this.txt_hethong_matkhauserver.Name = "txt_hethong_matkhauserver";
            this.txt_hethong_matkhauserver.Size = new System.Drawing.Size(305, 20);
            this.txt_hethong_matkhauserver.TabIndex = 11;
            this.txt_hethong_matkhauserver.UseSystemPasswordChar = true;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(7, 69);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 17);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Mật khẩu";
            // 
            // txt_hethong_taikhoanserver
            // 
            // 
            // 
            // 
            this.txt_hethong_taikhoanserver.Border.Class = "TextBoxBorder";
            this.txt_hethong_taikhoanserver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hethong_taikhoanserver.Enabled = false;
            this.txt_hethong_taikhoanserver.Location = new System.Drawing.Point(71, 43);
            this.txt_hethong_taikhoanserver.Name = "txt_hethong_taikhoanserver";
            this.txt_hethong_taikhoanserver.Size = new System.Drawing.Size(305, 20);
            this.txt_hethong_taikhoanserver.TabIndex = 9;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(7, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 17);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Tài khoản";
            // 
            // txt_hethong_csdl
            // 
            // 
            // 
            // 
            this.txt_hethong_csdl.Border.Class = "TextBoxBorder";
            this.txt_hethong_csdl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hethong_csdl.Location = new System.Drawing.Point(76, 40);
            this.txt_hethong_csdl.Name = "txt_hethong_csdl";
            this.txt_hethong_csdl.Size = new System.Drawing.Size(308, 20);
            this.txt_hethong_csdl.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(47, 17);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Dữ liệu";
            // 
            // txt_hethong_server
            // 
            // 
            // 
            // 
            this.txt_hethong_server.Border.Class = "";
            this.txt_hethong_server.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hethong_server.Location = new System.Drawing.Point(76, 14);
            this.txt_hethong_server.Name = "txt_hethong_server";
            this.txt_hethong_server.Size = new System.Drawing.Size(308, 20);
            this.txt_hethong_server.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(47, 16);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Máy chủ";
            // 
            // superTabItem_Server
            // 
            this.superTabItem_Server.AttachedControl = this.superTabControlPanel1;
            this.superTabItem_Server.GlobalItem = false;
            this.superTabItem_Server.Name = "superTabItem_Server";
            this.superTabItem_Server.Text = "Kết nối Server";
            // 
            // frm_hethong_thietlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 226);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_hethong_thietlap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập";
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem_Server;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hethong_server;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hethong_csdl;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hethong_matkhauserver;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hethong_taikhoanserver;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_luuketnoi;
        private DevComponents.DotNetBar.ButtonX btn_apdung_server;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbAuthentication;
        private DevComponents.Editors.ComboItem winAuth;
        private DevComponents.Editors.ComboItem sqlServerAuth;
    }
}