namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    partial class frm_loaithietbi_capnhat
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
            this.cbo_nhomthietbi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_loaithietbi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_diengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_themnhomthietbi = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chọn nhóm thiết bị";
            // 
            // cbo_nhomthietbi
            // 
            this.cbo_nhomthietbi.DisplayMember = "Text";
            this.cbo_nhomthietbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhomthietbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nhomthietbi.FormattingEnabled = true;
            this.cbo_nhomthietbi.ItemHeight = 14;
            this.cbo_nhomthietbi.Location = new System.Drawing.Point(14, 55);
            this.cbo_nhomthietbi.Name = "cbo_nhomthietbi";
            this.cbo_nhomthietbi.Size = new System.Drawing.Size(279, 20);
            this.cbo_nhomthietbi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nhomthietbi.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Loại thiết bị";
            // 
            // txt_loaithietbi
            // 
            // 
            // 
            // 
            this.txt_loaithietbi.Border.Class = "TextBoxBorder";
            this.txt_loaithietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_loaithietbi.Location = new System.Drawing.Point(14, 100);
            this.txt_loaithietbi.Name = "txt_loaithietbi";
            this.txt_loaithietbi.Size = new System.Drawing.Size(306, 20);
            this.txt_loaithietbi.TabIndex = 1;
            this.txt_loaithietbi.WatermarkText = "nhập loại thiết bị";
            this.txt_loaithietbi.Validated += new System.EventHandler(this.txt_loaithietbi_Validated);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 126);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 22);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Diễn giải";
            // 
            // txt_diengiai
            // 
            // 
            // 
            // 
            this.txt_diengiai.Border.Class = "TextBoxBorder";
            this.txt_diengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diengiai.Location = new System.Drawing.Point(12, 145);
            this.txt_diengiai.Multiline = true;
            this.txt_diengiai.Name = "txt_diengiai";
            this.txt_diengiai.Size = new System.Drawing.Size(306, 137);
            this.txt_diengiai.TabIndex = 2;
            this.txt_diengiai.WatermarkText = "mô tả chi tiết loại thiết bị";
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(76, 293);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 3;
            this.btn_luulai.Text = "Lưu (F8)";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(183, 293);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 4;
            this.btn_huybo.Text = "Đóng (ESC)";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_themnhomthietbi
            // 
            this.btn_themnhomthietbi.Location = new System.Drawing.Point(294, 54);
            this.btn_themnhomthietbi.Name = "btn_themnhomthietbi";
            this.btn_themnhomthietbi.Size = new System.Drawing.Size(26, 23);
            this.btn_themnhomthietbi.TabIndex = 8;
            this.btn_themnhomthietbi.Text = "+";
            this.toolTip1.SetToolTip(this.btn_themnhomthietbi, "Thêm nhóm thiết bị");
            this.btn_themnhomthietbi.UseVisualStyleBackColor = true;
            this.btn_themnhomthietbi.Click += new System.EventHandler(this.btn_themnhomthietbi_Click);
            // 
            // frm_loaithietbi_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 337);
            this.Controls.Add(this.btn_themnhomthietbi);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.txt_diengiai);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txt_loaithietbi);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbo_nhomthietbi);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_loaithietbi_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_loaithietbi_capnhat";
            this.Load += new System.EventHandler(this.frm_loaithietbi_capnhat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_loaithietbi_capnhat_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nhomthietbi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_loaithietbi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diengiai;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private System.Windows.Forms.Button btn_themnhomthietbi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}