namespace ThietBiPY.DanhMuc
{
    partial class frm_thietbi_capnhat_tufile
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
            this.panel_bangdieukhien = new System.Windows.Forms.Panel();
            this.bar_bangdieukhien = new DevComponents.DotNetBar.Bar();
            this.btn_chonfile = new DevComponents.DotNetBar.ButtonItem();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.panel_bangdieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).BeginInit();
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
            this.lv_thietbi.CheckBoxes = true;
            this.lv_thietbi.FullRowSelect = true;
            this.lv_thietbi.GridLines = true;
            this.lv_thietbi.Location = new System.Drawing.Point(8, 43);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(679, 468);
            this.lv_thietbi.TabIndex = 0;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            // 
            // panel_bangdieukhien
            // 
            this.panel_bangdieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bangdieukhien.Controls.Add(this.bar_bangdieukhien);
            this.panel_bangdieukhien.Location = new System.Drawing.Point(8, 17);
            this.panel_bangdieukhien.Name = "panel_bangdieukhien";
            this.panel_bangdieukhien.Size = new System.Drawing.Size(679, 26);
            this.panel_bangdieukhien.TabIndex = 1;
            // 
            // bar_bangdieukhien
            // 
            this.bar_bangdieukhien.AccessibleDescription = "DotNetBar Bar (bar_bangdieukhien)";
            this.bar_bangdieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_bangdieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_bangdieukhien.AntiAlias = true;
            this.bar_bangdieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_bangdieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_bangdieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_chonfile});
            this.bar_bangdieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_bangdieukhien.Name = "bar_bangdieukhien";
            this.bar_bangdieukhien.Size = new System.Drawing.Size(679, 25);
            this.bar_bangdieukhien.Stretch = true;
            this.bar_bangdieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar_bangdieukhien.TabIndex = 0;
            this.bar_bangdieukhien.TabStop = false;
            this.bar_bangdieukhien.Text = "bar1";
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.BeginGroup = true;
            this.btn_chonfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Text = "Chọn file Excel";
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Location = new System.Drawing.Point(8, 513);
            this.btn_them.Name = "btn_them";
            this.btn_them.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frm_thietbi_capnhat_tufile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(694, 546);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.panel_bangdieukhien);
            this.Controls.Add(this.lv_thietbi);
            this.EnableGlass = false;
            this.Name = "frm_thietbi_capnhat_tufile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập danh sách thiết bị từ tệp tin Excel";
            this.panel_bangdieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_bangdieukhien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private System.Windows.Forms.Panel panel_bangdieukhien;
        private DevComponents.DotNetBar.Bar bar_bangdieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_chonfile;
        private DevComponents.DotNetBar.ButtonX btn_them;
    }
}