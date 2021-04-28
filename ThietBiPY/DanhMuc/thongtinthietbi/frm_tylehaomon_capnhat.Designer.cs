namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_tylehaomon_capnhat
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
            this.cbo_loaithietbi = new DevComponents.DotNetBar.Controls.ComboTree();
            this.btn_themloaithietbi = new System.Windows.Forms.Button();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.input_thoigiansudung = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dinput_tylehaomon = new DevComponents.Editors.DoubleInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.btn_dong = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.input_thoigiansudung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinput_tylehaomon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại thiết bị";
            // 
            // cbo_loaithietbi
            // 
            this.cbo_loaithietbi.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbo_loaithietbi.BackgroundStyle.Class = "TextBoxBorder";
            this.cbo_loaithietbi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_loaithietbi.ButtonDropDown.Visible = true;
            this.cbo_loaithietbi.Location = new System.Drawing.Point(74, 21);
            this.cbo_loaithietbi.Name = "cbo_loaithietbi";
            this.cbo_loaithietbi.Size = new System.Drawing.Size(291, 21);
            this.cbo_loaithietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_loaithietbi.TabIndex = 1;
            this.cbo_loaithietbi.Validated += new System.EventHandler(this.cbo_loaithietbi_Validated);
            // 
            // btn_themloaithietbi
            // 
            this.btn_themloaithietbi.Location = new System.Drawing.Point(366, 21);
            this.btn_themloaithietbi.Name = "btn_themloaithietbi";
            this.btn_themloaithietbi.Size = new System.Drawing.Size(28, 21);
            this.btn_themloaithietbi.TabIndex = 2;
            this.btn_themloaithietbi.Text = "+";
            this.btn_themloaithietbi.UseVisualStyleBackColor = true;
            this.btn_themloaithietbi.Click += new System.EventHandler(this.btn_themloaithietbi_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(5, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 19);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Thời gian sử dụng";
            // 
            // input_thoigiansudung
            // 
            // 
            // 
            // 
            this.input_thoigiansudung.BackgroundStyle.Class = "DateTimeInputBackground";
            this.input_thoigiansudung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.input_thoigiansudung.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.input_thoigiansudung.Location = new System.Drawing.Point(100, 48);
            this.input_thoigiansudung.Name = "input_thoigiansudung";
            this.input_thoigiansudung.ShowUpDown = true;
            this.input_thoigiansudung.Size = new System.Drawing.Size(80, 20);
            this.input_thoigiansudung.TabIndex = 4;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(5, 73);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(78, 20);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Tỷ lệ hao mòn";
            // 
            // dinput_tylehaomon
            // 
            // 
            // 
            // 
            this.dinput_tylehaomon.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dinput_tylehaomon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dinput_tylehaomon.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dinput_tylehaomon.Increment = 1;
            this.dinput_tylehaomon.Location = new System.Drawing.Point(100, 74);
            this.dinput_tylehaomon.Name = "dinput_tylehaomon";
            this.dinput_tylehaomon.ShowUpDown = true;
            this.dinput_tylehaomon.Size = new System.Drawing.Size(80, 20);
            this.dinput_tylehaomon.TabIndex = 6;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(186, 48);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(35, 20);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "(năm)";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(186, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(51, 20);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "(%/năm)";
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(232, 105);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 9;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dong.Location = new System.Drawing.Point(313, 105);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dong.TabIndex = 10;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_tylehaomon_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(397, 136);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dinput_tylehaomon);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.input_thoigiansudung);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btn_themloaithietbi);
            this.Controls.Add(this.cbo_loaithietbi);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_tylehaomon_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tỷ lệ hao mòn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_tylehaomon_capnhat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.input_thoigiansudung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinput_tylehaomon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboTree cbo_loaithietbi;
        private System.Windows.Forms.Button btn_themloaithietbi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput input_thoigiansudung;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput dinput_tylehaomon;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.ButtonX btn_dong;
    }
}