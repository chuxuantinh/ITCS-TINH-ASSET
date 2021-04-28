using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace ThietBiDAL
{
   //Giao nhận thiết bị
   public class PHIEUNHAP_DAL
    {
       DBDataContext DB = new DBDataContext();

       public IEnumerable<PHIEUNHAP> phieunhap_danhsach()
       {
           return DB.PHIEUNHAPs.OrderByDescending(c => c.NgayVanBan.Value.Year);
       }
       public int phieunhap_them(PHIEUNHAP PHIEUNHAP, List<CTPHIEUNHAP> CTPHIEUNHAP)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               if (HETHONGDAL.TaiKhoan != "")
               {
                   NGUOIDUNG NGUOIDUNG = new NGUOIDUNG();
                   NGUOIDUNG.TaiKhoan = HETHONGDAL.TaiKhoan;
                   PHIEUNHAP.NguoiDungID = new NGUOIDUNG_DAL().nguoidung_thongtin_TK(NGUOIDUNG).NguoiDungID;
               }
               DB.PHIEUNHAPs.InsertOnSubmit(PHIEUNHAP);
               DB.SubmitChanges();

               foreach (var CT in CTPHIEUNHAP)
               {
                   CT.PhieuNhapID = PHIEUNHAP.PhieuNhapID;
               }
               DB.CTPHIEUNHAPs.InsertAllOnSubmit(CTPHIEUNHAP);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public int phieunhap_sua(PHIEUNHAP PHIEUNHAP, List<CTPHIEUNHAP> CTPHIEUNHAP)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;

               var PN_SUA = DB.PHIEUNHAPs.Single(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID);
               PN_SUA.KieuNhapTB = PHIEUNHAP.KieuNhapTB;
               PN_SUA.NgayNhap = PHIEUNHAP.NgayNhap;
               PN_SUA.NgayVanBan = PHIEUNHAP.NgayVanBan;
               PN_SUA.SoVanBan = PHIEUNHAP.SoVanBan;
               PN_SUA.ThamQuyenQD = PHIEUNHAP.ThamQuyenQD;

               PN_SUA.NCCID = PHIEUNHAP.NCCID;
               PN_SUA.NhanVienNhan1  = PHIEUNHAP.NhanVienNhan1;
               PN_SUA.NhanVienNhan2 = PHIEUNHAP.NhanVienNhan2;
               PN_SUA.DonViNhan = PHIEUNHAP.DonViNhan;
               PN_SUA.BoPhanNhan = PHIEUNHAP.BoPhanNhan;
               PN_SUA.GhiChu = PHIEUNHAP.GhiChu;
               //
               foreach (var CT in CTPHIEUNHAP)
               {
                   //Nếu cái cũ thì update lại : Kiểm tra xem phiếu nhập đó có thỏa 3 điều kiện của vuathongtin hay không:
                   // 1. Lấy ra phiếu nhập cần hiệu chỉnh.
                   // 2. Kiểm tra xem phiếu nhập vừa lấy có thiết bị cần hiệu chỉnh hay không
                   // 3. List phiếu nhập lấy ra có ID != 0

                   if (DB.CTPHIEUNHAPs.Where(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID && c.ThietBiID == CT.ThietBiID && CT.PhieuNhapID!=0).Count() > 0)
                   {
                       var CT_SUA = DB.CTPHIEUNHAPs.Single(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID && c.ThietBiID == CT.ThietBiID);
                       Int16 soluongbandau = CT_SUA.SoLuong;

                       CT_SUA.ThietBiID = CT.ThietBiID;
                       CT_SUA.SoLuong = CT.SoLuong;
                       CT_SUA.DonGia = CT.DonGia;

                       //kiểm tra xem số lượng nhập có thay đổi hok để cập nhật số lượng thiết bị
                      /* if (soluongbandau != CT_SUA.SoLuong)
                       {
                           var CT_CNSOLUONG = DB.THIETBIs.Single(c => c.ThietBiID == CT_SUA.ThietBiID);
                           CT_CNSOLUONG.SoLuong += (Int16)(CT_SUA.SoLuong - soluongbandau);
                       }
                       */
                   }
                   //Nếu cái mới thì add vào : kiểm tra trong phiếu nhập, có thiết bị đó chưa, nếu ID phiếu nhập khác 0 mà thiết bị ko có thì ==> mới
                   else if (CT.PhieuNhapID !=0)
                   {
                       CT.PhieuNhapID = PHIEUNHAP.PhieuNhapID;
                       DB.CTPHIEUNHAPs.InsertOnSubmit(CT);
                   }

                   //Dựa vào List yêu cầu hiệu chỉnh, để xác định phiếu nào ID=0 thì tức là xóa
                   else if (CT.PhieuNhapID == 0)
                   {
                       var CT_XOA = DB.CTPHIEUNHAPs.Single(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID && c.ThietBiID == CT.ThietBiID);
                       DB.CTPHIEUNHAPs.DeleteOnSubmit(CT_XOA);
                   }
               }

               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
               DB.Transaction.Rollback();
               return 0;
           }

       }
       public PHIEUNHAP phieunhap_thongtin(PHIEUNHAP PHIEUNHAP)
       {
           return DB.PHIEUNHAPs.SingleOrDefault(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID);
       }
       public int phieunhap_xoa(PHIEUNHAP PHIEUNHAP)
       {
           var PN_XOA = DB.PHIEUNHAPs.Single(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID);
           //var LST_CTPN_XOA = DB.CTPHIEUNHAPs.Where(c => c.PhieuNhapID == PHIEUNHAP.PhieuNhapID);
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               DB.PHIEUNHAPs.DeleteOnSubmit(PN_XOA);
              // DB.CTPHIEUNHAPs.DeleteAllOnSubmit(LST_CTPN_XOA);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
   }
   public class CTPHIEUNHAP_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<CTPHIEUNHAP> ctphieunhap_danhsach()
       {
           return DB.CTPHIEUNHAPs.OrderBy(c => c.THIETBI.TenThietBi);
       }
   }
   
   //Bàn giao thiết bị
   public class PHIEUBANGIAO_DAL
   {
       DBDataContext DB = new DBDataContext();

       public IEnumerable<BANGIAO> phieubangiao_danhsach()
       {
           return DB.BANGIAOs.OrderByDescending(c => c.NgayBanGiao);
       }
       public int phieubangiao_them(BANGIAO BANGIAO, List<CTBANGIAO> LST_CTBANGIAO)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               DB.BANGIAOs.InsertOnSubmit(BANGIAO);
               DB.SubmitChanges();

               foreach (var CT in LST_CTBANGIAO)
               {
                   CT.BanGiaoID = BANGIAO.BanGiaoID;
               }

               DB.CTBANGIAOs.InsertAllOnSubmit(LST_CTBANGIAO);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }

       public int phieubangiao_sua(BANGIAO BANGIAO, List<CTBANGIAO> LST_CTBANGIAO)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;

               var PHIEUBANGIAO_SUA = DB.BANGIAOs.Single (c=>c.BanGiaoID == BANGIAO.BanGiaoID);
               PHIEUBANGIAO_SUA.SoVanBan = BANGIAO.SoVanBan;
               PHIEUBANGIAO_SUA.NgayVanBan = BANGIAO.NgayVanBan;
               PHIEUBANGIAO_SUA.ThamQuyenQD = BANGIAO.ThamQuyenQD;

               PHIEUBANGIAO_SUA.NgayBanGiao = BANGIAO.NgayBanGiao;

               PHIEUBANGIAO_SUA.DonViBanGiao = BANGIAO.DonViBanGiao;
               PHIEUBANGIAO_SUA.BoPhanBanGiao = BANGIAO.BoPhanBanGiao;
               PHIEUBANGIAO_SUA.NhanVienBanGiao = BANGIAO.NhanVienBanGiao;

               PHIEUBANGIAO_SUA.DonViNhan = BANGIAO.DonViNhan ;
               PHIEUBANGIAO_SUA.BoPhanNhan = BANGIAO.BoPhanNhan ;
               PHIEUBANGIAO_SUA.NhanVienNhan = BANGIAO.NhanVienNhan ;
               PHIEUBANGIAO_SUA.GhiChu = BANGIAO.GhiChu;

               //
               foreach (var BG in LST_CTBANGIAO)
               {
                   if (DB.CTBANGIAOs.Where(c => c.BanGiaoID == BANGIAO.BanGiaoID && c.GTThietBiID == BG.GTThietBiID && BG.BanGiaoID != 0).Count() > 0)
                   {

                       var CT_SUA = DB.CTBANGIAOs.Single(c => c.BanGiaoID == BANGIAO.BanGiaoID && c.GTThietBiID == BG.GTThietBiID);
                   }
                   else if (BG.BanGiaoID != 0) //chỉ thỏa 1 điều kiện
                   {
                       DB.CTBANGIAOs.InsertOnSubmit(BG);
                   }
                   else if (BG.BanGiaoID == 0)
                   {
                       var BG_XOA = DB.CTBANGIAOs.Single(c => c.BanGiaoID ==BANGIAO.BanGiaoID && c.GTThietBiID == BG.GTThietBiID);
                       DB.CTBANGIAOs.DeleteOnSubmit(BG_XOA);
                   }
               }
               //
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }

       public int phieubangiao_xoa(BANGIAO BANGIAO)
       {
           var BG_XOA = DB.BANGIAOs.Single(c => c.BanGiaoID == BANGIAO.BanGiaoID);
           var LST_CTBG_XOA = DB.CTBANGIAOs.Where(c => c.BanGiaoID == BANGIAO.BanGiaoID);
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;

               DB.BANGIAOs.DeleteOnSubmit(BG_XOA);
               DB.CTBANGIAOs.DeleteAllOnSubmit(LST_CTBG_XOA);
               DB.SubmitChanges();

               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public BANGIAO phieubangiao_thongtin(BANGIAO BANGIAO)
       {
           return DB.BANGIAOs.SingleOrDefault(c => c.BanGiaoID == BANGIAO.BanGiaoID);
       }
   }
   public class CTBANGIAO_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<CTBANGIAO> ctbangiao_danhsach(BANGIAO BANGIAO)
       {
           return DB.CTBANGIAOs.Where(c => c.BanGiaoID == BANGIAO.BanGiaoID);
       }
       public IEnumerable<CTBANGIAO> ctbangiao_danhsach()
       {
           return DB.CTBANGIAOs;
       }
   }

   //Thanh lý thiết bi
   public class PHIEUTHANHLY_DAL
   {
       DBDataContext DB = new DBDataContext();

       public IEnumerable<THANHLY> phieuthanhly_danhsach()
       {
           return DB.THANHLies.OrderByDescending(c => c.NgayThanhLy.Value.Year);
       }
       public int phieuthanhly_them(THANHLY THANHLY, List<CTTHANHLY> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               DB.THANHLies.InsertOnSubmit(THANHLY);
               DB.SubmitChanges();

               foreach (var T in LST)
               {
                   T.ThanhLyID = THANHLY.ThanhLyID;
               }
               DB.CTTHANHLies.InsertAllOnSubmit(LST);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public int phieuthanhly_sua(THANHLY THANHLY, List<CTTHANHLY> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;

               var THANHLY_SUA = DB.THANHLies.Single(c => c.ThanhLyID == THANHLY.ThanhLyID);
               THANHLY_SUA.SoVanBan = THANHLY.SoVanBan;
               THANHLY_SUA.NgayVanBan = THANHLY.NgayVanBan;
               THANHLY_SUA.ThamQuyenQD = THANHLY.ThamQuyenQD;

               THANHLY_SUA.NgayThanhLy = THANHLY.NgayThanhLy;
               THANHLY_SUA.DaiDienThanhLy = THANHLY.DaiDienThanhLy;
               THANHLY_SUA.DaiDienBenMua = THANHLY.DaiDienBenMua;
               THANHLY_SUA.GhiChu = THANHLY.GhiChu;

               foreach (var T in LST)
               {
                   if (DB.CTTHANHLies.Where(c => c.ThanhLyID == THANHLY.ThanhLyID && c.GTThietBiID == T.GTThietBiID && T.ThanhLyID != 0).Count() > 0)
                   {
                       var CT_SUA = DB.CTTHANHLies.Single(c => c.ThanhLyID == THANHLY.ThanhLyID && c.GTThietBiID == T.GTThietBiID);
                       CT_SUA.GiaTriThanhLy = T.GiaTriThanhLy;
                   }
                   else if (T.ThanhLyID != 0)
                   {
                       DB.CTTHANHLies.InsertOnSubmit(T);
                   }
                   else if (T.ThanhLyID == 0)
                   {
                       var CT_XOA = DB.CTTHANHLies.Single(c => c.ThanhLyID == THANHLY.ThanhLyID && c.GTThietBiID == T.GTThietBiID);
                       DB.CTTHANHLies.DeleteOnSubmit(CT_XOA);
                   }
               }

               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public int phieuthanhly_xoa(THANHLY THANHLY)
       {
           try
           {
               var THANHLY_XOA = DB.THANHLies.Single(c => c.ThanhLyID == THANHLY.ThanhLyID);
               DB.THANHLies.DeleteOnSubmit(THANHLY_XOA);
               DB.SubmitChanges();
               return 1;
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public THANHLY phieuthanhly_thongtin(THANHLY THANHLY)
       {
           return DB.THANHLies.SingleOrDefault(c => c.ThanhLyID == THANHLY.ThanhLyID);
       }
   }
   public class CTTHANHLY_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<CTTHANHLY> ctthanhly_danhsach(THANHLY THANHLY)
       {
           return DB.CTTHANHLies.Where(c => c.ThanhLyID == THANHLY.ThanhLyID).OrderBy(c => c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi);
       }
   }

    //Thu hồi thiết bị
   public class PHIEUTHUHOI_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<THUHOI> phieuthuhoi_danhsach()
       {
           return DB.THUHOIs.OrderByDescending(c => c.NgayThuHoi.Value.Year);
       }
       public int phieuthuhoi_them(THUHOI THUHOI,List <CTTHUHOI> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               DB.THUHOIs.InsertOnSubmit(THUHOI);
               DB.SubmitChanges();
               foreach (var TH in LST)
               {
                   TH.ThuHoiID = THUHOI.ThuHoiID;
               }
               DB.CTTHUHOIs.InsertAllOnSubmit(LST);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
           
       }
       public int phieuthuhoi_sua(THUHOI THUHOI, List<CTTHUHOI> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;

               var THUHOI_SUA = DB.THUHOIs.Single(c => c.ThuHoiID == THUHOI.ThuHoiID);
               THUHOI_SUA.SoVanBan = THUHOI.SoVanBan;
               THUHOI_SUA.NgayVanBan = THUHOI.NgayVanBan;
               THUHOI_SUA.NgayThuHoi = THUHOI.NgayThuHoi;
               THUHOI_SUA.ThamQuyenQD = THUHOI.ThamQuyenQD;

               THUHOI_SUA.DonViThuHoi = THUHOI.DonViThuHoi;
               THUHOI_SUA.DaiDienThuHoi = THUHOI.DaiDienThuHoi;
               THUHOI_SUA.DonViSuDung = THUHOI.DonViSuDung;
               THUHOI_SUA.BoPhanSuDung = THUHOI.BoPhanSuDung;

               THUHOI_SUA.LiDoThuHoi = THUHOI.LiDoThuHoi;
               THUHOI_SUA.GhiChu = THUHOI.GhiChu;

               foreach (var TB in LST)
               {
                   //
                   if (DB.CTTHUHOIs.Where(c => c.ThuHoiID == THUHOI.ThuHoiID && c.ThietBiID == TB.ThietBiID && TB.ThuHoiID != 0).Count() > 0)
                   {
                       var TB_SUA = DB.CTTHUHOIs.Single(c => c.ThuHoiID == THUHOI.ThuHoiID && c.ThietBiID == TB.ThietBiID);
                       TB_SUA.SoLuong = TB.SoLuong;
                       TB_SUA.HienTrang = TB.HienTrang;
                   }
                   //
                   else if (TB.ThuHoiID != 0)
                   {
                       DB.CTTHUHOIs.InsertOnSubmit(TB);
                   }
                   //
                   else if(TB.ThuHoiID ==0)
                   {

                       DB.CTTHUHOIs.DeleteOnSubmit(DB.CTTHUHOIs.Single(c => c.ThietBiID == TB.ThietBiID));
                   }
               }
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public int phieuthuhoi_xoa(THUHOI THUHOI)
       {
           try
           {
               var THUHOI_XOA = DB.THUHOIs.Single(c => c.ThuHoiID == THUHOI.ThuHoiID);
               DB.THUHOIs.DeleteOnSubmit(THUHOI_XOA);
               DB.SubmitChanges();
               return 1;
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public THUHOI phieuthuhoi_thongtin(THUHOI THUHOI)
       {
           return DB.THUHOIs.SingleOrDefault(c => c.ThuHoiID == THUHOI.ThuHoiID);
       }
   }
   public class CTTHUHOI_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<CTTHUHOI> ctthuhoi_danhsach(THUHOI THUHOI)
       {
           return DB.CTTHUHOIs.Where(c => c.ThuHoiID == THUHOI.ThuHoiID);
       }
   }

    //Kiểm kê thiết bị
   public class PHIEUKIEMKE_DAL
   {
       DBDataContext DB = new DBDataContext();

       public IEnumerable<KIEMKE> phieukiemke_danhsach()
       {
           return DB.KIEMKEs.OrderByDescending(c => c.NgayKiemKe.Value.Date.Year);
       }
       public int phieukiemke_them(KIEMKE KK,List<DAIDIENKIEMKE> LST_DDKK, List<CTKIEMKE> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               DB.KIEMKEs.InsertOnSubmit(KK);
               DB.SubmitChanges();
               foreach (var T in LST)
               {
                   T.KiemKeID = KK.KiemKeID;
               }

               foreach (var DD in LST_DDKK)
               {
                   DD.KiemKeID = KK.KiemKeID;
               }
               DB.CTKIEMKEs.InsertAllOnSubmit(LST);
               DB.DAIDIENKIEMKEs.InsertAllOnSubmit(LST_DDKK);
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 1;
           }
       }
       public int phieukiemke_sua(KIEMKE KK,List<DAIDIENKIEMKE> LST_DDKK, List<CTKIEMKE> LST)
       {
           try
           {
               DB.Connection.Open();
               DbTransaction trs = DB.Connection.BeginTransaction();
               DB.Transaction = trs;
               var KK_SUA = DB.KIEMKEs.Single(c => c.KiemKeID == KK.KiemKeID);
               KK_SUA.NgayKiemKe = KK.NgayKiemKe;
               KK_SUA.NgayVanBan = KK.NgayVanBan;
               KK_SUA.SoVanBan = KK.SoVanBan;
               KK_SUA.ThamQuyenQD = KK.ThamQuyenQD;

               KK_SUA.DonViKiemKe = KK.DonViKiemKe;
               KK_SUA.BoPhanKiemKe = KK.BoPhanKiemKe;
               KK_SUA.GhiChu = KK.GhiChu;

               foreach (var T in LST)
               {
                   if (DB.CTKIEMKEs.Where(c => c.KiemKeID == KK.KiemKeID && c.GTThietBiID == T.GTThietBiID && T.KiemKeID != 0).Count() > 0)
                   {
                       var CT_SUA = DB.CTKIEMKEs.Single(c => c.KiemKeID == KK.KiemKeID && c.GTThietBiID == T.GTThietBiID);
                       CT_SUA.TinhTrang1 = T.TinhTrang1;
                       CT_SUA.HienTrang1 = T.HienTrang1;
                   }
                   else if (T.KiemKeID != 0)
                   {
                       DB.CTKIEMKEs.InsertOnSubmit(T);
                   }
                   else if (T.KiemKeID == 0)
                   {
                       var CT_XOA = DB.CTKIEMKEs.Single(c => c.KiemKeID == KK.KiemKeID && c.GTThietBiID == T.GTThietBiID);
                       DB.CTKIEMKEs.DeleteOnSubmit(CT_XOA);
                   }
               }

               foreach (var DD in LST_DDKK)
               {
                   if (DB.DAIDIENKIEMKEs.Where(c => c.KiemKeID == KK.KiemKeID && c.NhanVienID == DD.NhanVienID && DD.KiemKeID != 0).Count() > 0)
                   {
                       var CT_DD_SUA = DB.DAIDIENKIEMKEs.Single(c => c.KiemKeID == DD.KiemKeID && c.NhanVienID == DD.NhanVienID);
                       CT_DD_SUA.QuyenKiemKe = DD.QuyenKiemKe;
                   }
                   else if (DD.KiemKeID != 0)
                   {
                       DB.DAIDIENKIEMKEs.InsertOnSubmit(DD);
                   }
                   else if (DD.KiemKeID == 0)
                   {
                       var CT_DD_XOA = DB.DAIDIENKIEMKEs.Single(c => c.KiemKeID == DD.KiemKeID && c.NhanVienID == DD.NhanVienID);
                       DB.DAIDIENKIEMKEs.DeleteOnSubmit(CT_DD_XOA);
                   }
               }
               DB.SubmitChanges();
               DB.Transaction.Commit();
               return 1;
           }
           catch (Exception ex)
           {
               DB.Transaction.Rollback();
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public int phieukiemke_xoa(KIEMKE KK)
       {
           try
           {
               var KK_XOA = DB.KIEMKEs.Single(c => c.KiemKeID == KK.KiemKeID);
               DB.KIEMKEs.DeleteOnSubmit(KK_XOA);
               DB.SubmitChanges();
               return 1;
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
               return 0;
           }
       }
       public KIEMKE phieukiemke_thongtin(KIEMKE KK)
       {
           return DB.KIEMKEs.SingleOrDefault(c => c.KiemKeID == KK.KiemKeID);
       }
   }
   public class CTKIEMKE_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<CTKIEMKE> ctkiemke_danhsach(KIEMKE KK)
       {
           return DB.CTKIEMKEs.Where(c => c.KiemKeID == KK.KiemKeID);
       }
   }

   public class DAIDIENKIEMKE_DAL
   {
       DBDataContext DB = new DBDataContext();
       public IEnumerable<DAIDIENKIEMKE> ddkiemke_danhsach(KIEMKE KK)
       {
           return DB.DAIDIENKIEMKEs.Where(c => c.KiemKeID == KK.KiemKeID);
       }
   }
}
