namespace ThietBiPY.DanhMuc.vitridiali
{
    partial class frm_tinh_capnhat
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
            this.cbo_nuoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_tentinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_themnuoc = new System.Windows.Forms.Button();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // cbo_nuoc
            // 
            this.cbo_nuoc.DisplayMember = "Text";
            this.cbo_nuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nuoc.FormattingEnabled = true;
            this.cbo_nuoc.ItemHeight = 16;
            this.cbo_nuoc.Location = new System.Drawing.Point(12, 51);
            this.cbo_nuoc.Name = "cbo_nuoc";
            this.cbo_nuoc.Size = new System.Drawing.Size(315, 22);
            this.cbo_nuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nuoc.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 16);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Chọn nước";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 82);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 14);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên tỉnh/Tp";
            // 
            // txt_tentinh
            // 
            // 
            // 
            // 
            this.txt_tentinh.Border.Class = "TextBoxBorder";
            this.txt_tentinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tentinh.Location = new System.Drawing.Point(12, 97);
            this.txt_tentinh.Name = "txt_tentinh";
            this.txt_tentinh.Size = new System.Drawing.Size(352, 22);
            this.txt_tentinh.TabIndex = 3;
            // 
            // btn_themnuoc
            // 
            this.btn_themnuoc.Location = new System.Drawing.Point(333, 51);
            this.btn_themnuoc.Name = "btn_themnuoc";
            this.btn_themnuoc.Size = new System.Drawing.Size(31, 23);
            this.btn_themnuoc.TabIndex = 4;
            this.btn_themnuoc.Text = "+";
            this.btn_themnuoc.UseVisualStyleBackColor = true;
            this.btn_themnuoc.Click += new System.EventHandler(this.btn_themnuoc_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(312, 140);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(53, 27);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 5;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(253, 140);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Size = new System.Drawing.Size(53, 27);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 6;
            this.btn_luulai.Text = "Lưu";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // frm_tinh_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(377, 179);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_themnuoc);
            this.Controls.Add(this.txt_tentinh);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbo_nuoc);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_tinh_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tỉnh/tp";
            this.Load += new System.EventHandler(this.frm_tinh_capnhat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nuoc;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tentinh;
        private System.Windows.Forms.Button btn_themnuoc;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
    }
}