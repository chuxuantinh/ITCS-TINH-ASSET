namespace ThietBiPY.NghiepVu
{
    partial class frm_danhgialaithietbi
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
            this.panel_tren = new System.Windows.Forms.Panel();
            this.cbo_donvisudung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trv_bophan = new System.Windows.Forms.TreeView();
            this.lv_thietbi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panel_thietbi_duoi = new System.Windows.Forms.Panel();
            this.txt_tongsothietbi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contextmenu_thietbi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenu_thietbi_danhgialai = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_tren.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_thietbi_duoi.SuspendLayout();
            this.contextmenu_thietbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tren
            // 
            this.panel_tren.Controls.Add(this.cbo_donvisudung);
            this.panel_tren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tren.Location = new System.Drawing.Point(0, 0);
            this.panel_tren.Name = "panel_tren";
            this.panel_tren.Size = new System.Drawing.Size(725, 34);
            this.panel_tren.TabIndex = 0;
            // 
            // cbo_donvisudung
            // 
            this.cbo_donvisudung.DisplayMember = "Text";
            this.cbo_donvisudung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_donvisudung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_donvisudung.FormattingEnabled = true;
            this.cbo_donvisudung.ItemHeight = 14;
            this.cbo_donvisudung.Location = new System.Drawing.Point(12, 8);
            this.cbo_donvisudung.Name = "cbo_donvisudung";
            this.cbo_donvisudung.Size = new System.Drawing.Size(272, 20);
            this.cbo_donvisudung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_donvisudung.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trv_bophan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_thietbi);
            this.splitContainer1.Panel2.Controls.Add(this.panel_thietbi_duoi);
            this.splitContainer1.Size = new System.Drawing.Size(725, 517);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // trv_bophan
            // 
            this.trv_bophan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trv_bophan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_bophan.FullRowSelect = true;
            this.trv_bophan.HideSelection = false;
            this.trv_bophan.Location = new System.Drawing.Point(0, 0);
            this.trv_bophan.Name = "trv_bophan";
            this.trv_bophan.Size = new System.Drawing.Size(198, 513);
            this.trv_bophan.TabIndex = 0;
            this.trv_bophan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_bophan_AfterSelect);
            // 
            // lv_thietbi
            // 
            // 
            // 
            // 
            this.lv_thietbi.Border.Class = "ListViewBorder";
            this.lv_thietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_thietbi.FullRowSelect = true;
            this.lv_thietbi.GridLines = true;
            this.lv_thietbi.Location = new System.Drawing.Point(0, 0);
            this.lv_thietbi.Name = "lv_thietbi";
            this.lv_thietbi.Size = new System.Drawing.Size(514, 485);
            this.lv_thietbi.TabIndex = 2;
            this.lv_thietbi.UseCompatibleStateImageBehavior = false;
            this.lv_thietbi.View = System.Windows.Forms.View.Details;
            this.lv_thietbi.DoubleClick += new System.EventHandler(this.lv_thietbi_DoubleClick);
            this.lv_thietbi.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_thietbi_ItemSelectionChanged);
            // 
            // panel_thietbi_duoi
            // 
            this.panel_thietbi_duoi.Controls.Add(this.txt_tongsothietbi);
            this.panel_thietbi_duoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_thietbi_duoi.Location = new System.Drawing.Point(0, 485);
            this.panel_thietbi_duoi.Name = "panel_thietbi_duoi";
            this.panel_thietbi_duoi.Size = new System.Drawing.Size(514, 28);
            this.panel_thietbi_duoi.TabIndex = 3;
            // 
            // txt_tongsothietbi
            // 
            this.txt_tongsothietbi.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txt_tongsothietbi.Border.Class = "TextBoxBorder";
            this.txt_tongsothietbi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tongsothietbi.Location = new System.Drawing.Point(3, 4);
            this.txt_tongsothietbi.Name = "txt_tongsothietbi";
            this.txt_tongsothietbi.ReadOnly = true;
            this.txt_tongsothietbi.Size = new System.Drawing.Size(100, 20);
            this.txt_tongsothietbi.TabIndex = 0;
            this.txt_tongsothietbi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextmenu_thietbi
            // 
            this.contextmenu_thietbi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenu_thietbi_danhgialai});
            this.contextmenu_thietbi.Name = "contextmenu_thietbi";
            this.contextmenu_thietbi.Size = new System.Drawing.Size(137, 26);
            // 
            // contextmenu_thietbi_danhgialai
            // 
            this.contextmenu_thietbi_danhgialai.Name = "contextmenu_thietbi_danhgialai";
            this.contextmenu_thietbi_danhgialai.Size = new System.Drawing.Size(136, 22);
            this.contextmenu_thietbi_danhgialai.Text = "Đánh giá lại";
            this.contextmenu_thietbi_danhgialai.Click += new System.EventHandler(this.contextmenu_thietbi_danhgialai_Click);
            // 
            // frm_danhgialaithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(725, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_tren);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frm_danhgialaithietbi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá lại thiết bị";
            this.panel_tren.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel_thietbi_duoi.ResumeLayout(false);
            this.contextmenu_thietbi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tren;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_thietbi;
        private System.Windows.Forms.TreeView trv_bophan;
        private System.Windows.Forms.Panel panel_thietbi_duoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tongsothietbi;
        private System.Windows.Forms.ContextMenuStrip contextmenu_thietbi;
        private System.Windows.Forms.ToolStripMenuItem contextmenu_thietbi_danhgialai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_donvisudung;
    }
}