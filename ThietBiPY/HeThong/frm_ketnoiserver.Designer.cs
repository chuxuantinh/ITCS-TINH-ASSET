namespace ThietBiPY.HeThong
{
    partial class frm_ketnoiserver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ketnoiserver));
            this.panelLine = new System.Windows.Forms.Panel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.winAuth = new DevComponents.Editors.ComboItem();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnTestConnection = new DevComponents.DotNetBar.ButtonX();
            this.sqlServerAuth = new DevComponents.Editors.ComboItem();
            this.cmbDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbAuthentication = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanelLeft = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboServers = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_laydanhsachserver = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLine.Location = new System.Drawing.Point(172, 225);
            this.panelLine.Name = "panelLine";
            this.panelLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelLine.Size = new System.Drawing.Size(270, 1);
            this.panelLine.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(355, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // winAuth
            // 
            this.winAuth.Text = "Windows Authentication";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(262, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 23);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTestConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTestConnection.Location = new System.Drawing.Point(262, 150);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(110, 23);
            this.btnTestConnection.TabIndex = 20;
            this.btnTestConnection.Text = "Test Connect";
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // sqlServerAuth
            // 
            this.sqlServerAuth.Text = "SQL Server Authentication";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DisplayMember = "Text";
            this.cmbDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDatabase.Enabled = false;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.ItemHeight = 14;
            this.cmbDatabase.Location = new System.Drawing.Point(262, 195);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(180, 20);
            this.cmbDatabase.TabIndex = 21;
            this.cmbDatabase.Text = "ITCSASET";
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
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
            this.cmbAuthentication.Location = new System.Drawing.Point(262, 45);
            this.cmbAuthentication.Name = "cmbAuthentication";
            this.cmbAuthentication.Size = new System.Drawing.Size(180, 20);
            this.cmbAuthentication.TabIndex = 17;
            this.cmbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cmbAuthentication_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(262, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.WatermarkText = "Mật khẩu hệ thống";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.Location = new System.Drawing.Point(262, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.WatermarkText = "Tên đăng nhập hệ thống";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(172, 195);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(88, 20);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Database:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(172, 120);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(88, 20);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Password:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(172, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 20);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Username:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(172, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 20);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Authentication:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(172, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 20);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Server:";
            // 
            // groupPanelLeft
            // 
            this.groupPanelLeft.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLeft.Name = "groupPanelLeft";
            this.groupPanelLeft.Size = new System.Drawing.Size(150, 278);
            // 
            // 
            // 
            this.groupPanelLeft.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLeft.Style.BackColorGradientAngle = 90;
            this.groupPanelLeft.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLeft.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLeft.Style.BorderBottomWidth = 1;
            this.groupPanelLeft.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLeft.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLeft.Style.BorderLeftWidth = 1;
            this.groupPanelLeft.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLeft.Style.BorderRightWidth = 1;
            this.groupPanelLeft.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLeft.Style.BorderTopWidth = 1;
            this.groupPanelLeft.Style.Class = "";
            this.groupPanelLeft.Style.CornerDiameter = 4;
            this.groupPanelLeft.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLeft.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLeft.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLeft.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLeft.StyleMouseDown.Class = "";
            this.groupPanelLeft.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLeft.StyleMouseOver.Class = "";
            this.groupPanelLeft.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLeft.TabIndex = 11;
            // 
            // cboServers
            // 
            this.cboServers.DisplayMember = "Text";
            this.cboServers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServers.FormattingEnabled = true;
            this.cboServers.ItemHeight = 14;
            this.cboServers.Location = new System.Drawing.Point(262, 15);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(162, 20);
            this.cboServers.TabIndex = 24;
            this.cboServers.Text = "(local)";
            // 
            // btn_laydanhsachserver
            // 
            this.btn_laydanhsachserver.Location = new System.Drawing.Point(423, 15);
            this.btn_laydanhsachserver.Name = "btn_laydanhsachserver";
            this.btn_laydanhsachserver.Size = new System.Drawing.Size(22, 20);
            this.btn_laydanhsachserver.TabIndex = 25;
            this.btn_laydanhsachserver.Text = "..";
            this.toolTip1.SetToolTip(this.btn_laydanhsachserver, "Lấy danh sách Server");
            this.btn_laydanhsachserver.UseVisualStyleBackColor = true;
            this.btn_laydanhsachserver.Click += new System.EventHandler(this.btn_laydanhsachserver_Click);
            // 
            // frm_ketnoiserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(460, 278);
            this.Controls.Add(this.btn_laydanhsachserver);
            this.Controls.Add(this.cboServers);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.cmbAuthentication);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanelLeft);
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ketnoiserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.Editors.ComboItem winAuth;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.ButtonX btnTestConnection;
        private DevComponents.Editors.ComboItem sqlServerAuth;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDatabase;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbAuthentication;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLeft;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cboServers;
        private System.Windows.Forms.Button btn_laydanhsachserver;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}