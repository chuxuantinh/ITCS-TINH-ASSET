namespace ThietBiPY.NghiepVu.capnhatphu
{
    partial class frm_thuhoithietbi_capnhatsl_ht
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
            this.txt_hientrang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.input_soluong = new DevComponents.Editors.IntegerInput();
            this.btn_luulai = new DevComponents.DotNetBar.ButtonX();
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
            this.labelX1.Location = new System.Drawing.Point(6, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 20);
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
            this.labelX2.Location = new System.Drawing.Point(6, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(53, 18);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Hiện trạng";
            // 
            // txt_hientrang
            // 
            this.txt_hientrang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_hientrang.Border.Class = "TextBoxBorder";
            this.txt_hientrang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hientrang.Location = new System.Drawing.Point(6, 69);
            this.txt_hientrang.Multiline = true;
            this.txt_hientrang.Name = "txt_hientrang";
            this.txt_hientrang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_hientrang.Size = new System.Drawing.Size(347, 123);
            this.txt_hientrang.TabIndex = 2;
            // 
            // input_soluong
            // 
            // 
            // 
            // 
            this.input_soluong.BackgroundStyle.Class = "DateTimeInputBackground";
            this.input_soluong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.input_soluong.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.input_soluong.Location = new System.Drawing.Point(65, 21);
            this.input_soluong.MaxValue = 1000;
            this.input_soluong.MinValue = 0;
            this.input_soluong.Name = "input_soluong";
            this.input_soluong.ShowUpDown = true;
            this.input_soluong.Size = new System.Drawing.Size(83, 20);
            this.input_soluong.TabIndex = 3;
            // 
            // btn_luulai
            // 
            this.btn_luulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luulai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luulai.Location = new System.Drawing.Point(278, 198);
            this.btn_luulai.Name = "btn_luulai";
            this.btn_luulai.Size = new System.Drawing.Size(75, 23);
            this.btn_luulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luulai.TabIndex = 4;
            this.btn_luulai.Text = "Lưu lại";
            this.btn_luulai.Click += new System.EventHandler(this.btn_luulai_Click);
            // 
            // frm_thuhoithietbi_capnhatsl_ht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.btn_luulai);
            this.Controls.Add(this.input_soluong);
            this.Controls.Add(this.txt_hientrang);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_thuhoithietbi_capnhatsl_ht";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_thuhoithietbi_capnhatsl_ht_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_thuhoithietbi_capnhatsl_ht_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.input_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hientrang;
        private DevComponents.Editors.IntegerInput input_soluong;
        private DevComponents.DotNetBar.ButtonX btn_luulai;
    }
}