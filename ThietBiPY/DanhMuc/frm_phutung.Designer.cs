namespace ThietBiPY.DanhMuc
{
    partial class frm_phutung
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
            this.lv_phutung = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btn_chon = new DevComponents.DotNetBar.ButtonX();
            this.panel_dieukhien = new System.Windows.Forms.Panel();
            this.bar_dieukhien = new DevComponents.DotNetBar.Bar();
            this.btn_lamtuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themphutung = new DevComponents.DotNetBar.ButtonItem();
            this.panel_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_phutung
            // 
            // 
            // 
            // 
            this.lv_phutung.Border.Class = "ListViewBorder";
            this.lv_phutung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_phutung.CheckBoxes = true;
            this.lv_phutung.FullRowSelect = true;
            this.lv_phutung.GridLines = true;
            this.lv_phutung.Location = new System.Drawing.Point(12, 43);
            this.lv_phutung.Name = "lv_phutung";
            this.lv_phutung.Size = new System.Drawing.Size(501, 441);
            this.lv_phutung.TabIndex = 0;
            this.lv_phutung.UseCompatibleStateImageBehavior = false;
            this.lv_phutung.View = System.Windows.Forms.View.Details;
            // 
            // btn_chon
            // 
            this.btn_chon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chon.Location = new System.Drawing.Point(12, 490);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_chon.Size = new System.Drawing.Size(75, 23);
            this.btn_chon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chon.TabIndex = 1;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // panel_dieukhien
            // 
            this.panel_dieukhien.Controls.Add(this.bar_dieukhien);
            this.panel_dieukhien.Location = new System.Drawing.Point(12, 14);
            this.panel_dieukhien.Name = "panel_dieukhien";
            this.panel_dieukhien.Size = new System.Drawing.Size(501, 28);
            this.panel_dieukhien.TabIndex = 2;
            // 
            // bar_dieukhien
            // 
            this.bar_dieukhien.AccessibleDescription = "DotNetBar Bar (bar_dieukhien)";
            this.bar_dieukhien.AccessibleName = "DotNetBar Bar";
            this.bar_dieukhien.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_dieukhien.AntiAlias = true;
            this.bar_dieukhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_dieukhien.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar_dieukhien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lamtuoi,
            this.btn_themphutung});
            this.bar_dieukhien.Location = new System.Drawing.Point(0, 0);
            this.bar_dieukhien.Name = "bar_dieukhien";
            this.bar_dieukhien.Size = new System.Drawing.Size(501, 25);
            this.bar_dieukhien.Stretch = true;
            this.bar_dieukhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar_dieukhien.TabIndex = 0;
            this.bar_dieukhien.TabStop = false;
            this.bar_dieukhien.Text = "bar1";
            // 
            // btn_lamtuoi
            // 
            this.btn_lamtuoi.BeginGroup = true;
            this.btn_lamtuoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_lamtuoi.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi.Name = "btn_lamtuoi";
            this.btn_lamtuoi.Text = "Làm tươi";
            // 
            // btn_themphutung
            // 
            this.btn_themphutung.BeginGroup = true;
            this.btn_themphutung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_themphutung.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_themphutung.Name = "btn_themphutung";
            this.btn_themphutung.Text = "Thêm mới";
            this.btn_themphutung.Click += new System.EventHandler(this.btn_themphutung_Click);
            // 
            // frm_phutung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(525, 520);
            this.Controls.Add(this.panel_dieukhien);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.lv_phutung);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_phutung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_dieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_dieukhien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lv_phutung;
        private DevComponents.DotNetBar.ButtonX btn_chon;
        private System.Windows.Forms.Panel panel_dieukhien;
        private DevComponents.DotNetBar.Bar bar_dieukhien;
        private DevComponents.DotNetBar.ButtonItem btn_themphutung;
        private DevComponents.DotNetBar.ButtonItem btn_lamtuoi;
    }
}