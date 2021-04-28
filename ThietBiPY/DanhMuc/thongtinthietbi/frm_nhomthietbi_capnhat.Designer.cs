namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_nhomthietbi_capnhat
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
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luu = new DevComponents.DotNetBar.ButtonX();
            this.txt_nhomthietbi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txt_diengiai
            // 
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 82);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_diengiai.Size = new System.Drawing.Size(334, 114);
            this.txt_diengiai.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 17);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Diễn giải";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 20);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Nhóm thiết bị";
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(281, 203);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(65, 23);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 3;
            this.btn_huybo.Text = "Hủy (ESC)";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luu.Location = new System.Drawing.Point(210, 203);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(65, 23);
            this.btn_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu (F8)";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_nhomthietbi
            // 
            // 
            // 
            // 
            this.txt_nhomthietbi.Border.Class = "TextBoxBorder";
            this.txt_nhomthietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nhomthietbi.Location = new System.Drawing.Point(12, 35);
            this.txt_nhomthietbi.Name = "txt_nhomthietbi";
            this.txt_nhomthietbi.Size = new System.Drawing.Size(334, 20);
            this.txt_nhomthietbi.TabIndex = 0;
            this.txt_nhomthietbi.Validated += new System.EventHandler(this.txt_nhomthietbi_Validated);
            // 
            // frm_nhomthietbi_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(358, 241);
            this.Controls.Add(this.txt_nhomthietbi);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_luu);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_nhomthietbi_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_nhomthietbi_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_nhomthietbi_capnhat_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luu;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_nhomthietbi;
    }
}