namespace ThietBiPY.DanhMuc.vitridiali
{
    partial class frm_nuoc_capnhat
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
            this.btn_luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.txt_tennuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btn_luu
            // 
            this.btn_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luu.Location = new System.Drawing.Point(290, 80);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_luu.Size = new System.Drawing.Size(59, 28);
            this.btn_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(366, 80);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(59, 28);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 2;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // txt_tennuoc
            // 
            // 
            // 
            // 
            this.txt_tennuoc.Border.Class = "TextBoxBorder";
            this.txt_tennuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tennuoc.Location = new System.Drawing.Point(19, 39);
            this.txt_tennuoc.Name = "txt_tennuoc";
            this.txt_tennuoc.Size = new System.Drawing.Size(407, 22);
            this.txt_tennuoc.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 25);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Tên nước";
            // 
            // frm_nuoc_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(435, 120);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.txt_tennuoc);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nuoc_capnhat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_nuoc_capnhat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_luu;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tennuoc;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}