namespace ThietBiPY.HeThong
{
    partial class frm_nguoidung_capquyen
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
            this.txt_taikhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbo_quyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbo_trangthai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_capnhat = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tài khoản";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_taikhoan.Border.Class = "TextBoxBorder";
            this.txt_taikhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taikhoan.Location = new System.Drawing.Point(72, 26);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.ReadOnly = true;
            this.txt_taikhoan.Size = new System.Drawing.Size(219, 20);
            this.txt_taikhoan.TabIndex = 0;
            // 
            // cbo_quyen
            // 
            this.cbo_quyen.DisplayMember = "Text";
            this.cbo_quyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_quyen.FormattingEnabled = true;
            this.cbo_quyen.ItemHeight = 14;
            this.cbo_quyen.Location = new System.Drawing.Point(72, 52);
            this.cbo_quyen.Name = "cbo_quyen";
            this.cbo_quyen.Size = new System.Drawing.Size(219, 20);
            this.cbo_quyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_quyen.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Quyền";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 18);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Trạng thái";
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DisplayMember = "Text";
            this.cbo_trangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.ItemHeight = 14;
            this.cbo_trangthai.Location = new System.Drawing.Point(72, 78);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(219, 20);
            this.cbo_trangthai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_trangthai.TabIndex = 2;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_capnhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_capnhat.Location = new System.Drawing.Point(216, 108);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // frm_nguoidung_capquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.cbo_trangthai);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbo_quyen);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nguoidung_capquyen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập quyền truy cập";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taikhoan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_quyen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_trangthai;
        private DevComponents.DotNetBar.ButtonX btn_capnhat;
    }
}