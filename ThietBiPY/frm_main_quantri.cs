using System;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiBLL;
using System.IO;
using ThietBiPY.DanhMuc;
//
using ThietBiPY.DanhMuc.vitridiali;
using ThietBiPY.DanhMuc.thongtinthietbi;
using ThietBiPY.HeThong;
using ThietBiPY.DanhMuc.thongtinnhanvien;
using ThietBiPY.DanhMuc.thongtindonvi;
using ThietBiPY.NghiepVu;
using ThietBiPY.BaoCao_ThongKe.thongkethietbi;
using ThietBiPY.BaoCao_ThongKe;
using ThietBiPY.LopHoTro;
using ThietBiPY.BaoCao_ThongKe.report;
//

namespace ThietBiPY
{
    public partial class frm_main_quantri : Office2007RibbonForm 
    {
        HETHONGBLL HETHONG = new HETHONGBLL();

        #region "Khởi tạo form"
        public frm_main_quantri()
        {
            InitializeComponent();

              //
                //HETHONG.ThongSo(HETHONG.TenServer(),HETHONG.TenCSDL() ,HETHONG.LayUSerID(),HETHONG.LayPwd());
                //
                status_btn_tenserver.Text = "Server: " + HETHONG.TenServer();
                status_btn_tencsdl.Text = "CSDL: " + HETHONG.TenCSDL();

                string TenPC = HETHONG.TenPC();
                status_btn_tenpc.Text = TenPC;
                status_btn_tentaikhoan.Text = "Tài khoản: " + HETHONG.TenTaiKhoan();
                status_btn_tenpc.Tooltip = "Tên PC : " + TenPC.Substring(0, TenPC.IndexOf(':')) + Environment.NewLine + "Địa chỉ MAC: " + TenPC.Substring(TenPC.IndexOf(':') + 1);
               
                //
                status_btn_date.Text = "Date: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
                Timer status_time = new Timer();
                status_time.Interval = 1000;
                status_time.Start();
                status_time.Tick += new EventHandler(Time_Tick);

                //
                var NV = new NGUOIDUNG_BLL().nguoidung_thongtin_TK(HETHONG.TenTaiKhoan());

                this.Text = "Đơn vị: " + (NV.NHANVIEN.DonViID != 0 ? NV.NHANVIEN.DONVI.TenDonVi : "Chưa xác định");
                status_btn_tentaikhoan.Tooltip = "Họ tên: " + NV.NHANVIEN.HoNV + " " + NV.NHANVIEN.TenNV + Environment.NewLine +
                    "Quyền truy cập: Quản trị thiết bị";

                PHANQUYEN.quyen = NV.Quyen;

                //Menu phải
                lv_thongtinchung.Columns.Add("TT", lv_thongtinchung.Width - 2);
                btn_lamtuoi_menuphai_thongtinchung_Click(null, null);

                //

        }
        #endregion

        //

        public void danhmuc_donvisudung()
        {
            dockContainerItem1.Text = "Đơn vị";
            trv_phongban.Nodes.Clear();
            var DV = from tk_dv in
                                   ((from so in new SOTHEODOI_BLL().sotheodoi_danhsach()
                                     select new
                                     {
                                         DonViSD = so.DonViSD,
                                         GTThietBiID = so.GTThietBiID,
                                     }).GroupBy(g => g.DonViSD)
                                       .Select(c => new { DonViID = c.Key, SoLuong = c.Count() }))
                               join dv in new DONVI_BLL().donvi_danhsach() on tk_dv.DonViID equals dv.DonViID
                               select new
                               {
                                   DonViID = tk_dv.DonViID,
                                   TenDonVi = dv.TenDonVi,
                                   SoLuong = tk_dv.SoLuong,
                               };
           
            if (DV != null)
            {
                TreeNode nutgoc = new TreeNode("Tổng số : "+DV.Count().ToString ()+ " đơn vị");
                nutgoc.ImageIndex = 0;
                nutgoc.SelectedImageIndex = 0;
                foreach (var P in DV)
                {
                    TreeNode nutcon = new TreeNode(P.TenDonVi);
                    nutcon.ImageIndex =1;
                    nutcon.SelectedImageIndex = 1;
                    nutcon.Tag = P.DonViID;
                    nutcon.ToolTipText = "Số lượng: " + P.SoLuong.ToString();
                    nutgoc.Nodes.Add(nutcon);
                }
                nutgoc.Expand();
                trv_phongban.Nodes.Add(nutgoc);
            }
        }
     
        #region "Sự kiện cho form"
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        private void frm_main_quantri_Load(object sender, EventArgs e)
        {
            btn_banlamviec_Click(null, null);
        }
        #endregion

        #region "Thanh menu trái"
    
        private void btn_banlamviec_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_banlamviec")
                {
                   f.BringToFront();
                    return;
                }
            }
            frm_banlamviec frm = new frm_banlamviec();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion
        
        #region "Thanh menu trên"

        //-------- Hệ thống
        private void btn_hethong_saoluu_Click(object sender, EventArgs e)
        {
            HeThong.frm_saoluu_phuchoi_CSDL frm = new HeThong.frm_saoluu_phuchoi_CSDL("saoluu");
            frm.ShowDialog();
        }
        private void btn_hethong_phuchoi_Click(object sender, EventArgs e)
        {
            HeThong.frm_saoluu_phuchoi_CSDL frm = new HeThong.frm_saoluu_phuchoi_CSDL("phuchoi");
            frm.ShowDialog();
        }


        //-------- Danh Mục ----------
        private void btn_start_doimatkhau_Click(object sender, EventArgs e)
        {
            frm_nguoidung frm = new frm_nguoidung("doimatkhau");
            frm.ShowDialog();
        }
        
        //
        private void btn_ribbon_nguoidung_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_nguoidung_quantri")) { f.Activate(); return; }
            }

            HeThong.frm_nguoidung_quantri frm = new HeThong.frm_nguoidung_quantri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_nhatkitruycap_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nhatkihethong")) { f.Activate(); return; }
            }
            frm_nhatkihethong frm = new frm_nhatkihethong();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //
        private void btn_ribbon_nuoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nuoc"))
                {
                    f.Activate();
                    return;
                }
            }
            frm_nuoc frm = new frm_nuoc();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_tinh_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_tinh"))
                {
                    f.Activate();
                    return;
                }
            }
            frm_tinh frm = new frm_tinh();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_donvitinh_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_donvitinh")) { f.Activate(); return; }
            }
            frm_donvitinh frm = new frm_donvitinh();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //
        private void btn_ribbon_nhomthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nhomthietbi")) { f.Activate(); return; }
            }
            frm_nhomthietbi frm = new frm_nhomthietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_loaithietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_loaithietbi")) { f.Activate(); return; }
            }
            frm_loaithietbi frm = new frm_loaithietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ribbon_tylehaomon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_tylehaomon")) { f.Activate(); return; }
            }

            frm_tylehaomon frm = new frm_tylehaomon();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ribbon_tinhtrangthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_tinhtrangthietbi")) { f.Activate(); return; }
            }
            frm_tinhtrangthietbi frm = new frm_tinhtrangthietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        
        //
        private void btn_ribbon_chucvu_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_chucvu")) { f.Activate(); return; }
            }
            frm_chucvu frm = new frm_chucvu();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_donvi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_donvi")) { f.Activate(); return; }
            }

            frm_donvi frm = new frm_donvi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_bophan_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_bophan")) { f.Activate(); return; }
            }

            frm_bophan frm = new frm_bophan();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        
        //
        private void btn_ribbon_nhacungcap_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nhacungcap")) { f.Activate(); return; }
            }

            frm_nhacungcap frm = new frm_nhacungcap();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_nhanvien_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_nhanvien")) { f.Activate(); return; }
            }

            frm_nhanvien frm = new frm_nhanvien();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_thietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("frm_thietbi")) { f.Activate(); return; }
            }

            frm_thietbi frm = new frm_thietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();

        }

        //-------- Nghiệp vụ ----------
        private void btn_ribbon_giaonhanthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_giaonhanthietbi_capnhat")) { f.Activate(); return; }
            }

            frm_giaonhanthietbi_capnhat frm = new frm_giaonhanthietbi_capnhat();
            frm.DuLieu = new frm_giaonhanthietbi_capnhat.passData(loadloai_menuphai);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion

        #region "Các hàm khác"
        //đồng hồ
        public void Time_Tick(object sender, EventArgs e)
        {
            status_btn_time.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        private void btn_ribbon_thanhlythietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_thanhlythietbi_capnhat")) { f.Activate(); return; }
            }

            frm_thanhlythietbi_capnhat frm = new frm_thanhlythietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
  
        private void btn_ribbon_danhsachchungtu_bangiaothietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_bangiaothietbi")) { f.Activate(); return; }
            }

            frm_hoso_bangiaothietbi frm = new frm_hoso_bangiaothietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ribbon_danhsachchungtu_thanhlythietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_thanhlythietbi")) { f.Activate(); return; }
            }

            frm_hoso_thanhlythietbi frm = new frm_hoso_thanhlythietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //Thống kê
        private void btn_ribbon_thongkethietbi_theodonvi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_thongke_thietbi_theonoisudung")) { f.Activate(); return; }
            }

            frm_thongke_thietbi_theonoisudung frm = new frm_thongke_thietbi_theonoisudung();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_thongkethietbi_theoloai_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_thongke_thietbi_theoloaithietbi")) { f.Activate(); return; }
            }

            frm_thongke_thietbi_theoloaithietbi frm = new frm_thongke_thietbi_theoloaithietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //
        private void btn_nvgpane_menu_thietbicapmacabiet_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_thietbi_macabiet")) { f.Activate(); return; }
            }

            frm_thietbi_macabiet frm = new frm_thietbi_macabiet();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ribbon_danhsachchungtu_giaonhan_tunhacungcap_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_giaonhan_tunhacungcap"))
                {
                    f.Activate(); return;
                }
            }

            BaoCao_ThongKe.frm_hoso_giaonhanthietbi frm = new ThietBiPY.BaoCao_ThongKe.frm_hoso_giaonhanthietbi((int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_ribbon_danhsachchungtu_giaonhan_tunguonkhac_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_giaonhan_tunguonkhac"))
                {
                    f.Activate(); return;
                }
            }

            BaoCao_ThongKe.frm_hoso_giaonhanthietbi frm = new ThietBiPY.BaoCao_ThongKe.frm_hoso_giaonhanthietbi((int)LopHoTro.KIEUPHIEUNHAP.tunguonkhac);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        #region "Thanh menu phải"
        public void loadloai_menuphai(string giatri)
        {
            if (giatri != "")
            {
                //
                danhmuc_donvisudung();
                //
                lv_thongtinchung.Items.Clear();
                lv_thongtinchung.Items.Add("Tổng số thiết bị: " + new THIETBI_BLL().thietbi_danhsach().Sum(c => c.SoLuong).ToString());
                var CT_TB = (from k in
                                 ((from std in new SOTHEODOI_BLL().sotheodoi_danhsach()
                                   select new
                                   {
                                       TinhTrangID = std.TinhTrang,
                                       GTThietBi = std.GTThietBiID,
                                   }).GroupBy(c => c.TinhTrangID)
                                     .Select(k => new { TinhTrangID = k.Key, SoLuong = k.Count() }).ToList())
                             join tt in new TINHTRANG_BLL().tinhtrang_danhsach() on k.TinhTrangID equals tt.TinhTrangID into k_tt
                             from f in k_tt.DefaultIfEmpty()
                             select new
                             {
                                 TrangThai = (f != null ? f.TrangThai : true),
                                 TenTinhTrang = (f != null ? f.TenTinhTrang : "Chưa xác định"),
                                 SoLuong = k.SoLuong,
                             }).Where(k => k.TrangThai == true).ToList();

                foreach (var CT in CT_TB.ToList())
                {
                    lv_thongtinchung.Items.Add(CT.TenTinhTrang + ": " + CT.SoLuong.ToString());
                }
            }
        }
        private void trv_phongban_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name.Equals("frm_thongke_thietbi_theonoisudung"))
                    {
                        f.Activate(); return;
                    }
                }
                frm_thongke_thietbi_theonoisudung frm = new frm_thongke_thietbi_theonoisudung(int.Parse(trv_phongban.SelectedNode.Tag.ToString()));
                frm.MaximizeBox = false; frm.MinimizeBox = false;
                frm.Text = "";
                frm.ShowDialog();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        private void btn_lamtuoi_menuphai_thongtinchung_Click(object sender, EventArgs e)
        {
            loadloai_menuphai("loadlai");
        }
        #endregion

        private void btn_ribbon_kiemkethietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_kiemkethietbi_capnhat"))
                {
                    f.Activate(); return;
                }
            }

            frm_kiemkethietbi_capnhat frm = new frm_kiemkethietbi_capnhat();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_ribbon_danhsachchungtu_kiemkethietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_kiemkethietbi")) { f.Activate(); return; }
            }

            frm_hoso_kiemkethietbi frm = new frm_hoso_kiemkethietbi();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }


        private void btn_nvgpane_menu_tracuumacabiet_Click(object sender, EventArgs e)
        {
            string macabiet="";
            if (new INPUTBOX().InputBox("", "Tra cứu thiết bị",ref macabiet) == DialogResult.OK)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name.Equals("frm_thietbi_thongtinchitiet" + macabiet)) { f.Activate(); return; }
                }

                frm_thietbi_thongtinchitiet frm = new frm_thietbi_thongtinchitiet(macabiet);
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_start_dangxuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btn_start_thoatchuongtrinh_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        //==== Bàn làm việc =====//
        private void btn_blv_hethong_quanlynguoidung_Click(object sender, EventArgs e)
        {
            btn_ribbon_nguoidung_Click(null, null);
        }
        private void btn_blv_hethong_saoluu_Click(object sender, EventArgs e)
        {
            btn_hethong_saoluu_Click(null, null);
        }
        private void btn_blv_hethong_phuchoi_Click(object sender, EventArgs e)
        {
            btn_hethong_phuchoi_Click(null, null);
        }

        private void btn_blv_danhmuc_nhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap_capnhat frm = new frm_nhacungcap_capnhat();
            frm.ShowDialog();
        }
        private void btn_blv_danhmuc_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat();
            frm.ShowDialog();
        }
        private void btn_blv_danhmuc_thietbi_Click(object sender, EventArgs e)
        {
            frm_thietbi_capnhat frm = new frm_thietbi_capnhat();
            frm.ShowDialog();
        }

        private void btn_blv_nghiepvu_giaonhanthietbi_Click(object sender, EventArgs e)
        {
            btn_ribbon_giaonhanthietbi_Click(null, null);
        }
        private void btn_blv_nghiepvu_kiemkethietbi_Click(object sender, EventArgs e)
        {
            btn_ribbon_kiemkethietbi_Click(null, null);
        }
        private void btn_blv_nghiepvu_thanhlythietbi_Click(object sender, EventArgs e)
        {
            btn_ribbon_thanhlythietbi_Click(null, null);
        }

        private void btn_blv_thongke_tinhtrang_Click(object sender, EventArgs e)
        {
            frm_bienban_thongketinhtrang frm = new frm_bienban_thongketinhtrang();
            frm.ShowDialog();
        }

        private void btn_blv_tuhoso_giaonhanthietbi_Click(object sender, EventArgs e)
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

        private void btn_blv_tuhoso_kiemkethietbi_Click(object sender, EventArgs e)
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

        private void btn_blv_tuhoso_thanhlythietbi_Click(object sender, EventArgs e)
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

        private void ribbonTabItem5_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void labelItem3_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ribbonTabItem5_Click_1(object sender, EventArgs e)
        {

        }


        //
    }

    //
    public class INPUTBOX
    {
        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            //Form form = new Form();

            DevComponents.DotNetBar.Office2007Form form = new DevComponents.DotNetBar.Office2007Form();
            DevComponents.DotNetBar.LabelX label = new DevComponents.DotNetBar.LabelX();

            DevComponents.DotNetBar.Controls.TextBoxX textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.DotNetBar.ButtonX buttonOk = new DevComponents.DotNetBar.ButtonX();
            DevComponents.DotNetBar.ButtonX buttonCancel = new DevComponents.DotNetBar.ButtonX();

            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
            foreach (var str in new GTTHIETBI_BLL().gtthietbi_danhsach().Skip(0).Take (10).Select(c => c.MaCaBiet).ToList())
            {
                Str_Col.Add(str);
            }
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = Str_Col;

            form.EnableGlass = false;
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;
            textBox.CharacterCasing = CharacterCasing.Upper;

            buttonOk.Text = "Xem";
            buttonCancel.Text = "Đóng";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;


            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
