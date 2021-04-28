namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_tinhtrangthietbi_capnhat
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
            this.txt_tinhtrang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chk_macdinh = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_trangthai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txt_tinhtrang
            // 
            // 
            // 
            // 
            this.txt_tinhtrang.Border.Class = "TextBoxBorder";
            this.txt_tinhtrang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tinhtrang.Location = new System.Drawing.Point(12, 40);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(337, 20);
            this.txt_tinhtrang.TabIndex = 0;
            this.txt_tinhtrang.Validated += new System.EventHandler(this.txt_tinhtrang_Validated);
            // 
            // txt_diengiai
            // 
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 85);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_diengiai.Size = new System.Drawing.Size(337, 111);
            this.txt_diengiai.TabIndex = 1;
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(274, 235);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 2;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(179, 235);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 3;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 18);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Tình trạng";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 13);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Diễn giải";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 202);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(47, 18);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Mặc định";
            // 
            // chk_macdinh
            // 
            // 
            // 
            // 
            this.chk_macdinh.BackgroundStyle.Class = "";
            this.chk_macdinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_macdinh.Location = new System.Drawing.Point(65, 202);
            this.chk_macdinh.Name = "chk_macdinh";
            this.chk_macdinh.Size = new System.Drawing.Size(22, 18);
            this.chk_macdinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_macdinh.TabIndex = 7;
            // 
            // chk_trangthai
            // 
            // 
            // 
            // 
            this.chk_trangthai.BackgroundStyle.Class = "";
            this.chk_trangthai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_trangthai.Checked = true;
            this.chk_trangthai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_trangthai.CheckValue = "Y";
            this.chk_trangthai.Location = new System.Drawing.Point(329, 202);
            this.chk_trangthai.Name = "chk_trangthai";
            this.chk_trangthai.Size = new System.Drawing.Size(20, 18);
            this.chk_trangthai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_trangthai.TabIndex = 8;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(274, 202);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(53, 18);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Trạng thái";
            // 
            // frm_tinhtrangthietbi_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(361, 269);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.chk_trangthai);
            this.Controls.Add(this.chk_macdinh);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.txt_tinhtrang);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_tinhtrangthietbi_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_tinhtrangthietbi_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_tinhtrangthietbi_capnhat_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_tinhtrang;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_macdinh;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_trangthai;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}