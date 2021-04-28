namespace ThietBiPY.HeThong
{
    partial class frm_saoluu_phuchoi_CSDL
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
            this.panel_tren = new System.Windows.Forms.Panel();
            this.lbl_tieude = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_chonduongdan = new System.Windows.Forms.Button();
            this.txt_duongdan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_thuchien = new DevComponents.DotNetBar.ButtonX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.panel_tren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tren
            // 
            this.panel_tren.Controls.Add(this.lbl_tieude);
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(387, 34);
            this.panel_tren.TabIndex = 2;
            // 
            // lbl_tieude
            // 
            // 
            // 
            // 
            this.lbl_tieude.BackgroundStyle.Class = "";
            this.lbl_tieude.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_tieude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tieude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.ForeColor = System.Drawing.Color.Navy;
            this.lbl_tieude.Location = new System.Drawing.Point(0, 0);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(387, 34);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "Tiêu đề";
            this.lbl_tieude.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_chonduongdan);
            this.groupBox1.Controls.Add(this.txt_duongdan);
            this.groupBox1.Location = new System.Drawing.Point(8, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đường dẫn";
            // 
            // btn_chonduongdan
            // 
            this.btn_chonduongdan.Location = new System.Drawing.Point(332, 22);
            this.btn_chonduongdan.Name = "btn_chonduongdan";
            this.btn_chonduongdan.Size = new System.Drawing.Size(33, 22);
            this.btn_chonduongdan.TabIndex = 1;
            this.btn_chonduongdan.Text = "...";
            this.btn_chonduongdan.UseVisualStyleBackColor = true;
            this.btn_chonduongdan.Click += new System.EventHandler(this.btn_chonduongdan_Click);
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txt_duongdan.Border.Class = "TextBoxBorder";
            this.txt_duongdan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_duongdan.Location = new System.Drawing.Point(7, 22);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.ReadOnly = true;
            this.txt_duongdan.Size = new System.Drawing.Size(322, 22);
            this.txt_duongdan.TabIndex = 0;
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thuchien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thuchien.Location = new System.Drawing.Point(243, 115);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_thuchien.Size = new System.Drawing.Size(65, 28);
            this.btn_thuchien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thuchien.TabIndex = 19;
            this.btn_thuchien.Text = "Xử lý";
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(314, 115);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_huybo.Size = new System.Drawing.Size(65, 28);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 21;
            this.btn_huybo.Text = "Đóng";
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // frm_saoluu_phuchoi_CSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(387, 156);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_tren);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_saoluu_phuchoi_CSDL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_tren.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_thuchien;
        private System.Windows.Forms.Button btn_chonduongdan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_duongdan;
        private DevComponents.DotNetBar.LabelX lbl_tieude;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
    }
}