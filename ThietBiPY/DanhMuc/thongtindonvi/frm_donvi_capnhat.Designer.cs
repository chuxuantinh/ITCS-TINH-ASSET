namespace ThietBiPY.DanhMuc.thongtindonvi
{
    partial class frm_donvi_capnhat
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_donvi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_dienthoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Đơn vị";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 68);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(55, 15);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Điện thoại";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 115);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 14);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Diễn giải";
            // 
            // txt_diengiai
            // 
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 133);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_diengiai.Size = new System.Drawing.Size(402, 147);
            this.txt_diengiai.TabIndex = 2;
            this.txt_diengiai.WatermarkText = "Mô tả về đơn vị";
            // 
            // txt_donvi
            // 
            // 
            // 
            // 
            this.txt_donvi.Border.Class = "TextBoxBorder";
            this.txt_donvi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_donvi.Location = new System.Drawing.Point(12, 38);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(402, 20);
            this.txt_donvi.TabIndex = 0;
            this.txt_donvi.WatermarkText = "nhập tên đơn vị";
            // 
            // txt_dienthoai
            // 
            // 
            // 
            // 
            this.txt_dienthoai.Border.Class = "TextBoxBorder";
            this.txt_dienthoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dienthoai.Location = new System.Drawing.Point(12, 85);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(401, 20);
            this.txt_dienthoai.TabIndex = 1;
            this.txt_dienthoai.WatermarkText = "nhập điện thoại ";
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(339, 288);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(74, 23);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 4;
            this.btn_huybo.Text = "Đóng";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(248, 288);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(74, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 3;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // frm_donvi_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(426, 333);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.txt_dienthoai);
            this.Controls.Add(this.txt_donvi);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_donvi_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_donvi_capnhat";
            this.Load += new System.EventHandler(this.frm_donvi_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_donvi_capnhat_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_donvi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dienthoai;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
    }
}