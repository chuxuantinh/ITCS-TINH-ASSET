namespace ThietBiPY.DanhMuc
{
    partial class frm_thietbi_thongtinchitiet
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mã thiết bị");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Loại thiết bị");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Số hiệu");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Nước sản xuất");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Năm sản xuất");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Hạn bảo hành");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Tài liệu đính kèm");
            this.panel_tren = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pic_hinhanh = new System.Windows.Forms.PictureBox();
            this.panel_macabiet = new System.Windows.Forms.Panel();
            this.pic_macabiet = new System.Windows.Forms.PictureBox();
            this.lv_thongtincoban = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.wb_thongtin_thietbi = new System.Windows.Forms.WebBrowser();
            this.lv_thongtingiatri_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh)).BeginInit();
            this.panel_macabiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_macabiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tren
            // 
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(791, 13);
            this.panel_tren.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_thongtingiatri_thietbi);
            this.splitContainer1.Size = new System.Drawing.Size(791, 494);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.wb_thongtin_thietbi);
            this.splitContainer2.Size = new System.Drawing.Size(791, 411);
            this.splitContainer2.SplitterDistance = 236;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pic_hinhanh);
            this.splitContainer3.Panel1.Controls.Add(this.panel_macabiet);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lv_thongtincoban);
            this.splitContainer3.Size = new System.Drawing.Size(236, 411);
            this.splitContainer3.SplitterDistance = 222;
            this.splitContainer3.TabIndex = 0;
            // 
            // pic_hinhanh
            // 
            this.pic_hinhanh.BackColor = System.Drawing.Color.White;
            this.pic_hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_hinhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_hinhanh.Image = global::ThietBiPY.Properties.Resources.no_image;
            this.pic_hinhanh.Location = new System.Drawing.Point(0, 43);
            this.pic_hinhanh.Name = "pic_hinhanh";
            this.pic_hinhanh.Size = new System.Drawing.Size(232, 175);
            this.pic_hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hinhanh.TabIndex = 0;
            this.pic_hinhanh.TabStop = false;
            // 
            // panel_macabiet
            // 
            this.panel_macabiet.Controls.Add(this.pic_macabiet);
            this.panel_macabiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_macabiet.Location = new System.Drawing.Point(0, 0);
            this.panel_macabiet.Name = "panel_macabiet";
            this.panel_macabiet.Size = new System.Drawing.Size(232, 43);
            this.panel_macabiet.TabIndex = 1;
            // 
            // pic_macabiet
            // 
            this.pic_macabiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_macabiet.BackColor = System.Drawing.Color.Transparent;
            this.pic_macabiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_macabiet.Location = new System.Drawing.Point(52, 1);
            this.pic_macabiet.Name = "pic_macabiet";
            this.pic_macabiet.Size = new System.Drawing.Size(128, 42);
            this.pic_macabiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_macabiet.TabIndex = 2;
            this.pic_macabiet.TabStop = false;
            this.pic_macabiet.DoubleClick += new System.EventHandler(this.pic_macabiet_DoubleClick);
            this.pic_macabiet.MouseHover += new System.EventHandler(this.pic_macabiet_MouseHover);
            // 
            // lv_thongtincoban
            // 
            // 
            // 
            // 
            this.lv_thongtincoban.Border.Class = "ListViewBorder";
            this.lv_thongtincoban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thongtincoban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_thongtincoban.FullRowSelect = true;
            this.lv_thongtincoban.GridLines = true;
            this.lv_thongtincoban.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_thongtincoban.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lv_thongtincoban.Location = new System.Drawing.Point(0, 0);
            this.lv_thongtincoban.Name = "lv_thongtincoban";
            this.lv_thongtincoban.Size = new System.Drawing.Size(232, 181);
            this.lv_thongtincoban.TabIndex = 1;
            this.lv_thongtincoban.UseCompatibleStateImageBehavior = false;
            this.lv_thongtincoban.View = System.Windows.Forms.View.Details;
            // 
            // wb_thongtin_thietbi
            // 
            this.wb_thongtin_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_thongtin_thietbi.Location = new System.Drawing.Point(0, 0);
            this.wb_thongtin_thietbi.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_thongtin_thietbi.Name = "wb_thongtin_thietbi";
            this.wb_thongtin_thietbi.Size = new System.Drawing.Size(547, 407);
            this.wb_thongtin_thietbi.TabIndex = 0;
            // 
            // lv_thongtingiatri_thietbi
            // 
            // 
            // 
            // 
            this.lv_thongtingiatri_thietbi.Border.Class = "ListViewBorder";
            this.lv_thongtingiatri_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thongtingiatri_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_thongtingiatri_thietbi.FullRowSelect = true;
            this.lv_thongtingiatri_thietbi.GridLines = true;
            this.lv_thongtingiatri_thietbi.Location = new System.Drawing.Point(0, 0);
            this.lv_thongtingiatri_thietbi.Name = "lv_thongtingiatri_thietbi";
            this.lv_thongtingiatri_thietbi.Size = new System.Drawing.Size(791, 76);
            this.lv_thongtingiatri_thietbi.TabIndex = 0;
            this.lv_thongtingiatri_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thongtingiatri_thietbi.View = System.Windows.Forms.View.Details;
            // 
            // frm_thietbi_thongtinchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(791, 507);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_tren);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frm_thietbi_thongtinchitiet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết của thiết bị";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_thietbi_thongtinchitiet_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh)).EndInit();
            this.panel_macabiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_macabiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser wb_thongtin_thietbi;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thongtingiatri_thietbi;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pic_hinhanh;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thongtincoban;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_macabiet;
        private System.Windows.Forms.PictureBox pic_macabiet;

    }
}