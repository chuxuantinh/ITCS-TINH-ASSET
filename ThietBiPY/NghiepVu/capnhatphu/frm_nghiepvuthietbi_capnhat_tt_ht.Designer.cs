namespace ThietBiPY.NghiepVu.capnhatphu
{
    partial class frm_nghiepvuthietbi_capnhat_tt_ht
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
            this.txt_hientrang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            this.cbo_tinhtrang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_lamtuoi_tinhtrang = new System.Windows.Forms.Button();
            this.btn_them_tinhtrang = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.labelX1.Size = new System.Drawing.Size(55, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tình trạng";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(55, 19);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Hiện trạng";
            // 
            // txt_hientrang
            // 
            this.txt_hientrang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_hientrang.Border.Class = "TextBoxBorder";
            this.txt_hientrang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hientrang.Location = new System.Drawing.Point(12, 69);
            this.txt_hientrang.Multiline = true;
            this.txt_hientrang.Name = "txt_hientrang";
            this.txt_hientrang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_hientrang.Size = new System.Drawing.Size(360, 211);
            this.txt_hientrang.TabIndex = 3;
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(216, 290);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 5;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(297, 290);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.DisplayMember = "Text";
            this.cbo_tinhtrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.ItemHeight = 14;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(73, 22);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(247, 20);
            this.cbo_tinhtrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_tinhtrang.TabIndex = 7;
            // 
            // btn_lamtuoi_tinhtrang
            // 
            this.btn_lamtuoi_tinhtrang.Image = global::ThietBiPY.Properties.Resources.LamTuoi16;
            this.btn_lamtuoi_tinhtrang.Location = new System.Drawing.Point(320, 22);
            this.btn_lamtuoi_tinhtrang.Name = "btn_lamtuoi_tinhtrang";
            this.btn_lamtuoi_tinhtrang.Size = new System.Drawing.Size(28, 20);
            this.btn_lamtuoi_tinhtrang.TabIndex = 8;
            this.btn_lamtuoi_tinhtrang.UseVisualStyleBackColor = true;
            this.btn_lamtuoi_tinhtrang.Click += new System.EventHandler(this.btn_lamtuoi_tinhtrang_Click);
            // 
            // btn_them_tinhtrang
            // 
            this.btn_them_tinhtrang.Image = global::ThietBiPY.Properties.Resources.Them16;
            this.btn_them_tinhtrang.Location = new System.Drawing.Point(348, 22);
            this.btn_them_tinhtrang.Name = "btn_them_tinhtrang";
            this.btn_them_tinhtrang.Size = new System.Drawing.Size(28, 20);
            this.btn_them_tinhtrang.TabIndex = 9;
            this.btn_them_tinhtrang.UseVisualStyleBackColor = true;
            this.btn_them_tinhtrang.Click += new System.EventHandler(this.btn_them_tinhtrang_Click);
            // 
            // frm_bangiaothietbi_capnhat_tt_ht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(381, 326);
            this.Controls.Add(this.btn_them_tinhtrang);
            this.Controls.Add(this.btn_lamtuoi_tinhtrang);
            this.Controls.Add(this.cbo_tinhtrang);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.txt_hientrang);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bangiaothietbi_capnhat_tt_ht";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_bangiaothietbi_capnhat_sl_ht_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_bangiaothietbi_capnhat_sl_ht_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hientrang;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_tinhtrang;
        private System.Windows.Forms.Button btn_lamtuoi_tinhtrang;
        private System.Windows.Forms.Button btn_them_tinhtrang;
    }
}