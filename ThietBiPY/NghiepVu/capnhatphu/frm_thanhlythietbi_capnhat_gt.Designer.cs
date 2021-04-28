namespace ThietBiPY.NghiepVu.capnhatphu
{
    partial class frm_thanhlythietbi_capnhat_gt
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_dongia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_capnhat = new DevComponents.DotNetBar.ButtonX();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            this.lbl_dongia = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Giá trị";
            // 
            // txt_dongia
            // 
            // 
            // 
            // 
            this.txt_dongia.Border.Class = "TextBoxBorder";
            this.txt_dongia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dongia.Location = new System.Drawing.Point(76, 19);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(150, 20);
            this.txt_dongia.TabIndex = 1;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_capnhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_capnhat.Location = new System.Drawing.Point(115, 73);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(58, 23);
            this.btn_capnhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(180, 73);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(46, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // lbl_dongia
            // 
            // 
            // 
            // 
            this.lbl_dongia.BackgroundStyle.Class = "";
            this.lbl_dongia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dongia.ForeColor = System.Drawing.Color.Navy;
            this.lbl_dongia.Location = new System.Drawing.Point(1, 44);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(237, 16);
            this.lbl_dongia.TabIndex = 4;
            this.lbl_dongia.Text = "(0 đ)";
            this.lbl_dongia.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frm_thanhlythietbi_capnhatsl_gt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 105);
            this.Controls.Add(this.lbl_dongia);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_thanhlythietbi_capnhatsl_gt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_giaonhanthietbi_capnhatsl_dg_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dongia;
        private DevComponents.DotNetBar.ButtonX btn_capnhat;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.LabelX lbl_dongia;
    }
}