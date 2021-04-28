namespace ThietBiPY.DanhMuc.thongtinnhanvien
{
    partial class frm_chucvu_capnhat
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
            this.txt_chucvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.input_capbac = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.input_capbac)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chức vụ";
            // 
            // txt_chucvu
            // 
            // 
            // 
            // 
            this.txt_chucvu.Border.Class = "TextBoxBorder";
            this.txt_chucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_chucvu.Location = new System.Drawing.Point(12, 38);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(359, 20);
            this.txt_chucvu.TabIndex = 1;
            this.txt_chucvu.Validated += new System.EventHandler(this.txt_chucvu_Validated);
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(296, 228);
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
            this.btn_luulai.Location = new System.Drawing.Point(205, 228);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 3;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // txt_diengiai
            // 
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 111);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_diengiai.Size = new System.Drawing.Size(359, 110);
            this.txt_diengiai.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 93);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 16);
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
            this.labelX3.Location = new System.Drawing.Point(12, 69);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 14);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Cấp bậc";
            // 
            // input_capbac
            // 
            // 
            // 
            // 
            this.input_capbac.BackgroundStyle.Class = "DateTimeInputBackground";
            this.input_capbac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.input_capbac.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.input_capbac.Location = new System.Drawing.Point(61, 67);
            this.input_capbac.MaxValue = 10;
            this.input_capbac.MinValue = 0;
            this.input_capbac.Name = "input_capbac";
            this.input_capbac.ShowUpDown = true;
            this.input_capbac.Size = new System.Drawing.Size(86, 20);
            this.input_capbac.TabIndex = 7;
            this.input_capbac.Value = 1;
            // 
            // frm_chucvu_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(383, 267);
            this.Controls.Add(this.input_capbac);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.txt_chucvu);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_chucvu_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_chucvu_capnhat";
            this.Load += new System.EventHandler(this.frm_chucvu_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_chucvu_capnhat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.input_capbac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_chucvu;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput input_capbac;
    }
}