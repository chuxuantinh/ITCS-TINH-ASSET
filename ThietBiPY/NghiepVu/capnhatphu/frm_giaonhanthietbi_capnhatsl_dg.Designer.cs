namespace ThietBiPY.NghiepVu.capnhatphu
{
    partial class frm_giaonhanthietbi_capnhatsl_dg
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
            this.input_soluong = new DevComponents.Editors.IntegerInput();
            this.txt_dongia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_capnhat = new DevComponents.DotNetBar.ButtonX();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            this.lbl_dongia = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.input_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Số lượng";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Đơn giá";
            // 
            // input_soluong
            // 
            // 
            // 
            // 
            this.input_soluong.BackgroundStyle.Class = "DateTimeInputBackground";
            this.input_soluong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.input_soluong.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.input_soluong.Location = new System.Drawing.Point(76, 15);
            this.input_soluong.MaxValue = 1000;
            this.input_soluong.MinValue = 0;
            this.input_soluong.Name = "input_soluong";
            this.input_soluong.ShowUpDown = true;
            this.input_soluong.Size = new System.Drawing.Size(83, 20);
            this.input_soluong.TabIndex = 0;
            // 
            // txt_dongia
            // 
            // 
            // 
            // 
            this.txt_dongia.Border.Class = "TextBoxBorder";
            this.txt_dongia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dongia.Location = new System.Drawing.Point(76, 41);
            this.txt_dongia.MaxLength = 29;
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(150, 20);
            this.txt_dongia.TabIndex = 1;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_capnhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_capnhat.Location = new System.Drawing.Point(115, 95);
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
            this.btn_dong.Location = new System.Drawing.Point(180, 95);
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
            this.lbl_dongia.Location = new System.Drawing.Point(1, 66);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(237, 16);
            this.lbl_dongia.TabIndex = 4;
            this.lbl_dongia.Text = "(0 đ)";
            this.lbl_dongia.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frm_giaonhanthietbi_capnhatsl_dg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 127);
            this.Controls.Add(this.lbl_dongia);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.input_soluong);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_giaonhanthietbi_capnhatsl_dg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_giaonhanthietbi_capnhatsl_dg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.input_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput input_soluong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dongia;
        private DevComponents.DotNetBar.ButtonX btn_capnhat;
        private DevComponents.DotNetBar.ButtonX btn_dong;
        private DevComponents.DotNetBar.LabelX lbl_dongia;
    }
}