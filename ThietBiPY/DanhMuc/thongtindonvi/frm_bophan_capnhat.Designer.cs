namespace ThietBiPY.DanhMuc.thongtindonvi
{
    partial class frm_bophan_capnhat
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_tenbophan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.cbo_donvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_themdonvi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 20);
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
            this.labelX2.Location = new System.Drawing.Point(12, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên bộ phận";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 73);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 17);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Diễn giải";
            // 
            // txt_tenbophan
            // 
            this.txt_tenbophan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_tenbophan.Border.Class = "TextBoxBorder";
            this.txt_tenbophan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tenbophan.Location = new System.Drawing.Point(87, 48);
            this.txt_tenbophan.Name = "txt_tenbophan";
            this.txt_tenbophan.Size = new System.Drawing.Size(283, 20);
            this.txt_tenbophan.TabIndex = 3;
            this.txt_tenbophan.Validated += new System.EventHandler(this.txt_tenbophan_Validated);
            // 
            // txt_diengiai
            // 
            this.txt_diengiai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 96);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_diengiai.Size = new System.Drawing.Size(358, 110);
            this.txt_diengiai.TabIndex = 4;
            this.txt_diengiai.WatermarkText = "nhập thông tin chi tiết";
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(295, 212);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 6;
            this.btn_huybo.Text = "Đóng";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(205, 212);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 7;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // cbo_donvi
            // 
            this.cbo_donvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_donvi.DisplayMember = "Text";
            this.cbo_donvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvi.FormattingEnabled = true;
            this.cbo_donvi.ItemHeight = 14;
            this.cbo_donvi.Location = new System.Drawing.Point(87, 21);
            this.cbo_donvi.Name = "cbo_donvi";
            this.cbo_donvi.Size = new System.Drawing.Size(257, 20);
            this.cbo_donvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvi.TabIndex = 8;
            // 
            // btn_themdonvi
            // 
            this.btn_themdonvi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themdonvi.Location = new System.Drawing.Point(346, 21);
            this.btn_themdonvi.Name = "btn_themdonvi";
            this.btn_themdonvi.Size = new System.Drawing.Size(24, 20);
            this.btn_themdonvi.TabIndex = 9;
            this.btn_themdonvi.Text = "+";
            this.btn_themdonvi.UseVisualStyleBackColor = true;
            this.btn_themdonvi.Click += new System.EventHandler(this.btn_themdonvi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_bophan_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(382, 246);
            this.Controls.Add(this.btn_themdonvi);
            this.Controls.Add(this.cbo_donvi);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.txt_tenbophan);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_bophan_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_bophan";
            this.Load += new System.EventHandler(this.frm_bophan_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_bophan_capnhat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenbophan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvi;
        private System.Windows.Forms.Button btn_themdonvi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}