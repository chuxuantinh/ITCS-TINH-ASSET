using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThietBiPY.NghiepVu;
using ThietBiPY.BaoCao_ThongKe;
using ThietBiPY.DanhMuc;
using ThietBiPY.HeThong;
using ThietBiPY.BaoCao_ThongKe.report;

namespace ThietBiPY
{
    public partial class frm_banlamviec : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_banlamviec()
        {
            InitializeComponent();
        }

        private void frm_banlamviec_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               case Keys.Escape :this.Close();break;
            }
        }

        private void lbl_giaonhanthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_giaonhanthietbi_capnhat")) { f.Activate(); return; }
            }

            frm_giaonhanthietbi_capnhat frm = new frm_giaonhanthietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        //Tủ hồ sơ
        private void pictureBox_tuhoso_Click(object sender, EventArgs e)
        {
            contextMenuStrip_tuhoso.Show();
            contextMenuStrip_tuhoso.Top = Cursor.Position.Y;
            contextMenuStrip_tuhoso.Left = Cursor.Position.X;
        }
        
        private void contextmenu_tuhoso_giaonhanthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_hoso_giaonhanthietbi")) { f.Activate(); return; }
            }

            frm_hoso_giaonhanthietbi frm = new frm_hoso_giaonhanthietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_tuhoso_bangiaothietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_hoso_bangiaothietbi")) { f.Activate(); return; }
            }

            frm_hoso_bangiaothietbi frm = new frm_hoso_bangiaothietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_tuhoso_kiemkethietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_hoso_kiemkethietbi")) { f.Activate(); return; }
            }

            frm_hoso_kiemkethietbi frm = new frm_hoso_kiemkethietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_tuhoso_thanhlythietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_hoso_thanhlythietbi")) { f.Activate(); return; }
            }

            frm_hoso_thanhlythietbi frm = new frm_hoso_thanhlythietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void pictureBox_danhmuc_Click(object sender, EventArgs e)
        {
            contextMenuStrip_danhmuc.Show();
            contextMenuStrip_danhmuc.Top = Cursor.Position.Y;
            contextMenuStrip_danhmuc.Left = Cursor.Position.X;
        }

        private void contextmenu_danhmuc_nhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap_capnhat frm = new frm_nhacungcap_capnhat();
            frm.ShowDialog();
        }
        private void contextmenu_danhmuc_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat();
            frm.ShowDialog();
        }
        private void contextmenu_danhmuc_thietbi_Click(object sender, EventArgs e)
        {
            frm_thietbi_capnhat frm = new frm_thietbi_capnhat();
            frm.ShowDialog();
        }

        //Hệ thống
        private void pictureBox_hethong_Click(object sender, EventArgs e)
        {
            contextMenuStrip_hethong.Show();
            contextMenuStrip_hethong.Top = Cursor.Position.Y;
            contextMenuStrip_hethong.Left = Cursor.Position.X;
        }
        private void contextmenu_hethong_quanlynguoidung_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nguoidung_quantri")) { f.Activate(); return; }
            }

            frm_nguoidung_quantri frm = new frm_nguoidung_quantri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_hethong_nhatkitruycap_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nhatkihethong")) { f.Activate(); return; }
            }

            frm_nhatkihethong frm = new frm_nhatkihethong();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_hethong_saoluu_Click(object sender, EventArgs e)
        {
            frm_saoluu_phuchoi_CSDL frm = new frm_saoluu_phuchoi_CSDL("saoluu");
            frm.ShowDialog();
        }
        private void contextmenu_hethong_phuchoi_Click(object sender, EventArgs e)
        {
            frm_saoluu_phuchoi_CSDL frm = new frm_saoluu_phuchoi_CSDL("phuchoi");
            frm.ShowDialog();
        }

        private void pictureBox_thoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (DevComponents.DotNetBar.MessageBoxEx.Show("Thoát chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void pictureBox_ThongKe_Click(object sender, EventArgs e)
        {
            contextMenuStrip_thongke.Show();
            contextMenuStrip_thongke.Top = Cursor.Position.Y;
            contextMenuStrip_thongke.Left = Cursor.Position.X;
        }
        private void contextmenu_thongke_theotinhtrang_Click(object sender, EventArgs e)
        {
            frm_bienban_thongketinhtrang frm = new frm_bienban_thongketinhtrang();
            frm.ShowDialog();
        }

        //Nghiệp vụ
        private void pictureBox_nghiepvu_Click(object sender, EventArgs e)
        {
            contextMenuStrip_nghiepvu.Show();
            contextMenuStrip_nghiepvu.Top = Cursor.Position.Y;
            contextMenuStrip_nghiepvu.Left = Cursor.Position.X;
        }
        private void contextmenu_nghiepvu_giaonhanthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_giaonhanthietbi_capnhat")) { f.Activate(); return; }
            }

            frm_giaonhanthietbi_capnhat frm = new frm_giaonhanthietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_nghiepvu_kiemkethietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_kiemkethietbi_capnhat")) { f.Activate(); return; }
            }

            frm_kiemkethietbi_capnhat frm = new frm_kiemkethietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void contextmenu_nghiepvu_thanhlythietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_thanhlythietbi_capnhat")) { f.Activate(); return; }
            }

            frm_thanhlythietbi_capnhat frm = new frm_thanhlythietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        //

    }
}
