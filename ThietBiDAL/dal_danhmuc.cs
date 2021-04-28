using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data.Common;

namespace ThietBiDAL
{
   
    //Nước
    public class NUOC_DAL
    {
        DBDataContext DB = new DBDataContext();

        //
        public IEnumerable<NUOC> nuoc_danhsach()
        {
            return DB.NUOCs.OrderBy(c => c.TenNuoc);
        }
        public int nuoc_them(NUOC NUOC)
        {
            try
            {
                DB.NUOCs.InsertOnSubmit(NUOC);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception n)
            {
                Console.WriteLine(n.Message);
                return 0;
            }
        }
        public int nuoc_sua(NUOC NUOC)
        {
            try
            {
                NUOC NUOC_SUA = DB.NUOCs.Single(c => c.NuocID == NUOC.NuocID);
                NUOC_SUA.TenNuoc = NUOC.TenNuoc;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception n)
            {
                Console.WriteLine(n.Message);
                return 0;
            }

        }
        public int nuoc_xoa(NUOC NUOC)
        {
            try
            {
                NUOC NUOC_XOA = DB.NUOCs.Single(c => c.NuocID == NUOC.NuocID);
                DB.NUOCs.DeleteOnSubmit(NUOC_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception n)
            {
                Console.WriteLine(n.Message);
                return 0;
            }
        }
        public NUOC nuoc_thongtin(NUOC NUOC)
        {
            return DB.NUOCs.SingleOrDefault(c => c.NuocID == NUOC.NuocID);
        }
    }

    //Tỉnh
    public class TINH_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<TINH> tinh_danhsach()
        {
            return from c in DB.TINHs orderby c.TenTinh select c;
        }
        public int tinh_them(TINH TINH)
        {
            try
            {
                DB.TINHs.InsertOnSubmit(TINH);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message);
                return 0;
            }
        }
        public int tinh_sua(TINH TINH)
        {
            try
            {
                TINH TINH_SUA = DB.TINHs.Single(c => c.TinhID == TINH.TinhID);
                TINH_SUA.TenTinh = TINH.TenTinh;
                TINH_SUA.NuocID = TINH.NuocID;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message);
                return 0;
            }
        }
        public int tinh_xoa(TINH TINH)
        {
            try
            {
                TINH TINH_XOA = DB.TINHs.Single(c => c.TinhID == TINH.TinhID);
                DB.TINHs.DeleteOnSubmit(TINH_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message);
                return 0;
            }
        }
        public TINH tinh_thongtin(TINH TINH)
        {
            return DB.TINHs.SingleOrDefault(c => c.TinhID == TINH.TinhID);
        }
    }

    //Đơn vị tính
    public class DONVITINH_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<DONVITINH> donvitinh_danhsach()
        {
            return DB.DONVITINHs.OrderBy(c => c.TenDVT);
        }
        public int donvitinh_them(DONVITINH DVT)
        {
            try
            {
                DB.DONVITINHs.InsertOnSubmit(DVT);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception dvt)
            {
                Console.WriteLine(dvt.Message);
                return 0;
            }

        }
        public int donvitinh_sua(DONVITINH DVT)
        {
            DONVITINH DVT_SUA = DB.DONVITINHs.Single(c => c.DVTID == DVT.DVTID);
            try
            {
                DVT_SUA.TenDVT = DVT.TenDVT;
                DVT_SUA.DienGiai = DVT.DienGiai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int donvitinh_xoa(DONVITINH DVT)
        {
            DONVITINH DVT_XOA = DB.DONVITINHs.Single(c => c.DVTID == DVT.DVTID);
            try
            {
                DB.DONVITINHs.DeleteOnSubmit(DVT_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool donvitinh_kiemtra(DONVITINH DVT)
        {
            DONVITINH DVT_KT = DB.DONVITINHs.SingleOrDefault(c => c.TenDVT.ToUpper().Equals(DVT.TenDVT.ToUpper()));
            if (DVT_KT != null) return true;
            return false;
        }
        public DONVITINH donvitinh_thongtin(DONVITINH DVT)
        {
            return DB.DONVITINHs.SingleOrDefault(c => c.DVTID == DVT.DVTID);
        }
    }

    //Nhóm thiết bị
    public class NHOMTHIETBI_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<NHOMTHIETBI> nhomthietbi_danhsach()
        {
            return DB.NHOMTHIETBIs.OrderBy(c => c.TenNhomTB);
        }
        public int nhomthietbi_them(NHOMTHIETBI NHOMTB)
        {
            try
            {
                DB.NHOMTHIETBIs.InsertOnSubmit(NHOMTB);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhomthietbi_sua(NHOMTHIETBI NHOMTB)
        {
            NHOMTHIETBI NHOMTB_SUA = DB.NHOMTHIETBIs.Single(c => c.NhomTBID == NHOMTB.NhomTBID);
            try
            {
                NHOMTB_SUA.TenNhomTB = NHOMTB.TenNhomTB;
                NHOMTB_SUA.DienGiai = NHOMTB.DienGiai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhomthietbi_xoa(NHOMTHIETBI NHOMTB)
        {
            NHOMTHIETBI NHOMTB_XOA = DB.NHOMTHIETBIs.Single(c => c.NhomTBID == NHOMTB.NhomTBID);
            try
            {
                DB.NHOMTHIETBIs.DeleteOnSubmit(NHOMTB_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool nhomthietbi_kiemtra(NHOMTHIETBI NHOMTB)
        {
            NHOMTHIETBI NHOMTB_KT = DB.NHOMTHIETBIs.SingleOrDefault(c => c.TenNhomTB.ToUpper().Equals(NHOMTB.TenNhomTB.ToUpper()));
            if (NHOMTB_KT != null) return true;
            return false;
        }
        public NHOMTHIETBI nhomthietbi_thongtin(NHOMTHIETBI NHOMTB)
        {
            return DB.NHOMTHIETBIs.SingleOrDefault(c => c.NhomTBID == NHOMTB.NhomTBID);
        }
    }

    //Loại thiết bị
    public class LOAITHIETBI_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<LOAITHIETBI> loaithietbi_danhsach()
        {
            return DB.LOAITHIETBIs.OrderBy(c => c.TenLoaiTB);
        }
        public int loaithietbi_them(LOAITHIETBI LOAITB)
        {
            try
            {
                DB.LOAITHIETBIs.InsertOnSubmit(LOAITB);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int loaithietbi_sua(LOAITHIETBI LOAITB)
        {
            try
            {
                LOAITHIETBI LOAITB_SUA = DB.LOAITHIETBIs.Single(c => c.LoaiTBID == LOAITB.LoaiTBID);
                LOAITB_SUA.NhomTBID = LOAITB.NhomTBID;
                LOAITB_SUA.TenLoaiTB = LOAITB.TenLoaiTB;
                LOAITB_SUA.DienGiai = LOAITB.DienGiai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int loaithietbi_xoa(LOAITHIETBI LOAITB)
        {
            try
            {
                LOAITHIETBI LOAITB_XOA = DB.LOAITHIETBIs.Single(c => c.LoaiTBID == LOAITB.LoaiTBID);
                DB.LOAITHIETBIs.DeleteOnSubmit(LOAITB_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool loaithietbi_kiemtraten(LOAITHIETBI LOAITB)
        {
            var LOAITB_KT = DB.LOAITHIETBIs.SingleOrDefault(c => c.TenLoaiTB.ToUpper().Equals(LOAITB.TenLoaiTB.ToUpper()));
            return (LOAITB_KT != null ? true : false);
        }
        public LOAITHIETBI loaithietbi_thongtin(LOAITHIETBI LOAITB)
        {
            return DB.LOAITHIETBIs.SingleOrDefault(c => c.LoaiTBID == LOAITB.LoaiTBID);
        }
    }

    //Tỷ lệ hao mòn
    public class TYLEHAOMON_DAL
    {
        DBDataContext DB = new DBDataContext();
        public IEnumerable<TYLEHAOMON> tylehaomon_danhsach()
        {
            return DB.TYLEHAOMONs.OrderByDescending(c => c.TyLeHaoMonID);
        }
        public int tylehaomon_them(TYLEHAOMON HAOMON)
        {
            try
            {
                DB.TYLEHAOMONs.InsertOnSubmit(HAOMON);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int tylehaomon_sua(TYLEHAOMON HAOMON)
        {
            try
            {
                var HAOMON_SUA = DB.TYLEHAOMONs.Single(c => c.TyLeHaoMonID == HAOMON.TyLeHaoMonID);
                HAOMON_SUA.LoaiTBID = HAOMON.LoaiTBID;
                HAOMON_SUA.ThoiGianSD = HAOMON.ThoiGianSD;
                HAOMON_SUA.TLHaoMon = HAOMON.TLHaoMon;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
        public int tylehaomon_xoa(TYLEHAOMON HAOMON)
        {
            try
            {
                var HAOMON_XOA = DB.TYLEHAOMONs.Single(c => c.TyLeHaoMonID == HAOMON.TyLeHaoMonID);
                DB.TYLEHAOMONs.DeleteOnSubmit(HAOMON_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public TYLEHAOMON tylehaomon_thongtin(TYLEHAOMON HAOMON)
        {
            return DB.TYLEHAOMONs.SingleOrDefault(c => c.TyLeHaoMonID == HAOMON.TyLeHaoMonID);
        }

        public bool tylehaomon_ktloaithietbi(TYLEHAOMON HAOMON)
        {
            return (DB.TYLEHAOMONs.SingleOrDefault(c => c.LoaiTBID == HAOMON.LoaiTBID) != null ? true : false);
        }
    }

    //Tình trạng thiết bị
    public class TINHTRANG_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<TINHTRANG> tinhtrang_danhsach()
        {
            return DB.TINHTRANGs.OrderBy(c => c.TenTinhTrang);
        }
        public int tinhtrang_them(TINHTRANG TINHTRANG)
        {
            try
            {
                DB.TINHTRANGs.InsertOnSubmit(TINHTRANG);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int tinhtrang_sua(TINHTRANG TINHTRANG)
        {
            TINHTRANG TINHTRANG_SUA = DB.TINHTRANGs.Single(c => c.TinhTrangID == TINHTRANG.TinhTrangID);
            try
            {
                TINHTRANG_SUA.TenTinhTrang = TINHTRANG.TenTinhTrang;
                TINHTRANG_SUA.DienGiai = TINHTRANG.DienGiai;
                TINHTRANG_SUA.MacDinh = TINHTRANG.MacDinh;
                TINHTRANG_SUA.TrangThai = TINHTRANG.TrangThai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int tinhtrang_xoa(TINHTRANG TINHTRANG)
        {
            try
            {
                TINHTRANG TINHTRANG_XOA = DB.TINHTRANGs.Single(c => c.TinhTrangID == TINHTRANG.TinhTrangID);
                DB.TINHTRANGs.DeleteOnSubmit(TINHTRANG_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public TINHTRANG tinhtrang_thongtin(TINHTRANG TINHTRANG)
        {
            return DB.TINHTRANGs.SingleOrDefault(c => c.TinhTrangID == TINHTRANG.TinhTrangID);
        }
        public bool tinhtrang_kiemtra(TINHTRANG TINHTRANG)
        {
            var TT = DB.TINHTRANGs.SingleOrDefault(c => c.TenTinhTrang.ToUpper().Equals(TINHTRANG.TenTinhTrang.ToUpper()));
            if (TT == null) return false;
            return true;
        }
    }

    //Chức vụ
    public class CHUCVU_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<CHUCVU> chucvu_danhsach()
        {
            return DB.CHUCVUs.OrderBy(c => c.CapBac);
        }
        public int chucvu_them(CHUCVU CHUCVU)
        {
            try
            {
                DB.CHUCVUs.InsertOnSubmit(CHUCVU);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int chucvu_sua(CHUCVU CHUCVU)
        {
            CHUCVU CHUCVU_SUA = DB.CHUCVUs.Single(c => c.ChucVuID == CHUCVU.ChucVuID);
            try
            {
                CHUCVU_SUA.TenChucVu = CHUCVU.TenChucVu;
                CHUCVU_SUA.CapBac = CHUCVU.CapBac;
                CHUCVU_SUA.DienGiai = CHUCVU.DienGiai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int chucvu_xoa(CHUCVU CHUCVU)
        {
            CHUCVU CHUCVU_XOA = DB.CHUCVUs.Single(c => c.ChucVuID == CHUCVU.ChucVuID);
            try
            {
                DB.CHUCVUs.DeleteOnSubmit(CHUCVU_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool chucvu_kiemtra(CHUCVU CHUCVU)
        {
            CHUCVU CHUCVU_KT = DB.CHUCVUs.SingleOrDefault(c => c.TenChucVu.ToUpper().Contains(CHUCVU.TenChucVu.ToUpper()));
            return (CHUCVU_KT != null ? true : false);
        }
        public CHUCVU chucvu_thongtin(CHUCVU CHUCVU)
        {
            return DB.CHUCVUs.SingleOrDefault(c => c.ChucVuID == CHUCVU.ChucVuID);
        }
    }

    //Đơn vị
    public class DONVI_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<DONVI> donvi_danhsach()
        {
            return from c in DB.DONVIs orderby c.TenDonVi select c;
        }
        public int donvi_them(DONVI DONVI)
        {
            try
            {
                DB.DONVIs.InsertOnSubmit(DONVI);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool donvi_kiemtra(DONVI DONVI)
        {
            var DV = DB.DONVIs.SingleOrDefault(c => c.TenDonVi.ToUpper().Contains(DONVI.TenDonVi.ToUpper()));
            return (DV != null ? true : false);
        }
        public int donvi_sua(DONVI DONVI)
        {
            DONVI DV_SUA = DB.DONVIs.Single(c => c.DonViID == DONVI.DonViID);
            try
            {
                DV_SUA.TenDonVi = DONVI.TenDonVi;
                DV_SUA.DienThoai = DONVI.DienThoai;
                DV_SUA.DienGiai = DONVI.DienGiai;

                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int donvi_xoa(DONVI DONVI)
        {
            DONVI DONVI_XOA = DB.DONVIs.Single(c => c.DonViID == DONVI.DonViID);
            try
            {
                DB.DONVIs.DeleteOnSubmit(DONVI_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public DONVI donvi_thongtin(DONVI DONVI)
        {
            return DB.DONVIs.SingleOrDefault(c => c.DonViID == DONVI.DonViID);
        }
    }

    //Bộ phận
    public class BOPHAN_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<BOPHAN> bophan_danhsach()
        {
            return DB.BOPHANs.OrderBy(c => c.TenBoPhan);
        }
        public int bophan_them(BOPHAN BOPHAN)
        {
            try
            {
                DB.BOPHANs.InsertOnSubmit(BOPHAN);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int bophan_sua(BOPHAN BOPHAN)
        {
            try
            {
                BOPHAN BOPHAN_SUA = DB.BOPHANs.Single(c => c.BoPhanID == BOPHAN.BoPhanID);
                BOPHAN_SUA.TenBoPhan = BOPHAN.TenBoPhan;
                BOPHAN_SUA.DonViID = BOPHAN.DonViID;
                BOPHAN_SUA.DienGiai = BOPHAN.DienGiai;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int bophan_xoa(BOPHAN BOPHAN)
        {
            try
            {
                BOPHAN BOPHAN_XOA = DB.BOPHANs.Single(c => c.BoPhanID == BOPHAN.BoPhanID);
                DB.BOPHANs.DeleteOnSubmit(BOPHAN_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public bool bophan_kiemtra(BOPHAN BOPHAN)
        {
            BOPHAN BOPHAN_KT = DB.BOPHANs.SingleOrDefault(c => c.TenBoPhan.ToUpper().Equals(BOPHAN.TenBoPhan.ToUpper()));
            return (BOPHAN_KT != null ? true : false);
        }
        public BOPHAN bophan_thongtin(BOPHAN BOPHAN)
        {
            return DB.BOPHANs.SingleOrDefault(c => c.BoPhanID == BOPHAN.BoPhanID);
        }
    }

    //Nhân viên
    public class NHANVIEN_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<NHANVIEN> nhanvien_danhsach()
        {
            return DB.NHANVIENs.OrderBy(c => c.TenNV);
        }
        public int nhanvien_them(NHANVIEN NHANVIEN)
        {
            try
            {
                DB.NHANVIENs.InsertOnSubmit(NHANVIEN);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhanvien_sua(NHANVIEN NHANVIEN)
        {
            NHANVIEN NHANVIEN_SUA = DB.NHANVIENs.Single(c => c.NhanVienID == NHANVIEN.NhanVienID);
            NHANVIEN_SUA.MaNV = NHANVIEN.MaNV;
            NHANVIEN_SUA.HoNV = NHANVIEN.HoNV;
            NHANVIEN_SUA.TenNV = NHANVIEN.TenNV;
            NHANVIEN_SUA.GioiTinh = NHANVIEN.GioiTinh;
            NHANVIEN_SUA.NgaySinh = NHANVIEN.NgaySinh;

            NHANVIEN_SUA.CMND = NHANVIEN.CMND;
            NHANVIEN_SUA.NgayCap = NHANVIEN.NgayCap;
            NHANVIEN_SUA.NoiCap = NHANVIEN.NoiCap;

            NHANVIEN_SUA.TinhID = NHANVIEN.TinhID;
            NHANVIEN_SUA.DiaChi = NHANVIEN.DiaChi;
            NHANVIEN_SUA.ChucVuID = NHANVIEN.ChucVuID;
            NHANVIEN_SUA.DonViID = NHANVIEN.DonViID;

            NHANVIEN_SUA.DienThoai = NHANVIEN.DienThoai;
            NHANVIEN_SUA.Email = NHANVIEN.Email;
            NHANVIEN_SUA.ChanDung = NHANVIEN.ChanDung;

            try
            {
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhanvien_xoa(NHANVIEN NHANVIEN)
        {
            NHANVIEN NHANVIEN_XOA = DB.NHANVIENs.Single(c => c.NhanVienID == NHANVIEN.NhanVienID);
            try
            {
                DB.NHANVIENs.DeleteOnSubmit(NHANVIEN_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public NHANVIEN nhanvien_thongtin(NHANVIEN NHANVIEN)
        {
            return DB.NHANVIENs.SingleOrDefault(c => c.NhanVienID == NHANVIEN.NhanVienID);
        }
        public NHANVIEN nhanvien_thongtin_ma(NHANVIEN NHANVIEN)
        {
            return DB.NHANVIENs.SingleOrDefault(c => c.MaNV.Equals(NHANVIEN.MaNV));
        }
        public bool nhanvien_kiemtrama(NHANVIEN NHANVIEN)
        {
            NHANVIEN NHANVIEN_KT = DB.NHANVIENs.SingleOrDefault(c => c.MaNV==NHANVIEN.MaNV);
            return (NHANVIEN_KT != null ? true : false);
        }
        public string nhanvien_taoma(string kitu)
        {
            NHANVIEN NV = nhanvien_danhsach().Where(c => c.MaNV.StartsWith(kitu)).OrderByDescending(c => Convert.ToInt32(c.MaNV.Substring(kitu.Length))).Take(1).SingleOrDefault();
            int mamoi = 0;
            if (NV != null)
            {
                mamoi = int.Parse(NV.MaNV.Substring(kitu.Length)) + 1;
                return kitu + string.Format ("{0:d"+(NV.MaNV.Substring (kitu.Length ).Length -mamoi.ToString ().Length).ToString() + "}", 0) + mamoi.ToString();
            }
            return kitu + "00001";
        }
    }

    //Nhà cung cấp
    public class NHACUNGCAP_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<NHACUNGCAP> nhacungcap_danhsach()
        {
            return DB.NHACUNGCAPs.OrderBy(c => c.TenNCC);
        }
        public int nhacungcap_them(NHACUNGCAP NHACUNGCAP)
        {
            try
            {
                DB.NHACUNGCAPs.InsertOnSubmit(NHACUNGCAP);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhacungcap_sua(NHACUNGCAP NHACUNGCAP)
        {
            NHACUNGCAP NCC_SUA = DB.NHACUNGCAPs.Single(c => c.NCCID == NHACUNGCAP.NCCID);
            try
            {
                NCC_SUA.TenNCC = NHACUNGCAP.TenNCC;
                NCC_SUA.HoNguoiLH = NHACUNGCAP.HoNguoiLH;
                NCC_SUA.TenNguoiLH = NHACUNGCAP.TenNguoiLH;
                NCC_SUA.ChucVu = NHACUNGCAP.ChucVu;
                NCC_SUA.TinhID = NHACUNGCAP.TinhID;
                NCC_SUA.DiaChi = NHACUNGCAP.DiaChi;
                NCC_SUA.DienThoai = NHACUNGCAP.DienThoai;
                NCC_SUA.FAX = NHACUNGCAP.FAX;
                NCC_SUA.Email = NHACUNGCAP.Email;
                NCC_SUA.Website = NHACUNGCAP.Website;
                NCC_SUA.GhiChu = NHACUNGCAP.GhiChu;

                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhacungcap_xoa(NHACUNGCAP NHACUNGCAP)
        {
            NHACUNGCAP NCC_XOA = DB.NHACUNGCAPs.Single(c => c.NCCID == NHACUNGCAP.NCCID);
            try
            {
                DB.NHACUNGCAPs.DeleteOnSubmit(NCC_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public NHACUNGCAP nhacungcap_thongtin(NHACUNGCAP NHACUNGCAP)
        {
            return DB.NHACUNGCAPs.SingleOrDefault(c => c.NCCID == NHACUNGCAP.NCCID);
        }
        public bool nhacungcap_kiemtratenncc(NHACUNGCAP NHACUNGCAP)
        {
            NHACUNGCAP NCC_KTTEN = DB.NHACUNGCAPs.SingleOrDefault(c => c.TenNCC.ToUpper().Equals(NHACUNGCAP.TenNCC.ToUpper()));
            return (NCC_KTTEN != null ? true : false);
        }
    }

    //Phụ tùng
    public class PHUTUNG_DAL
    {
        DBDataContext DB = new DBDataContext();

        public IEnumerable<PHUTUNG> phutung_danhsach()
        {
            return DB.PHUTUNGs.OrderBy(c => c.TenPhuTung);
        }
        public int phutung_them(PHUTUNG PHUTUNG)
        {
            try
            {
                DB.PHUTUNGs.InsertOnSubmit(PHUTUNG);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public string phutung_taoma(string kitu)
        {
            PHUTUNG PT = phutung_danhsach().Where(c => c.MaPhuTung.StartsWith(kitu)).OrderByDescending(c => Convert.ToInt32(c.MaPhuTung.Substring(kitu.Length))).Take(1).SingleOrDefault();
            int mamoi = 0;
            if (PT != null)
            {
                mamoi = int.Parse(PT.MaPhuTung.Substring(kitu.Length)) + 1;
                return kitu + string.Format ("{0:d"+ (PT.MaPhuTung.Substring(kitu.Length).Length - mamoi.ToString().Length).ToString()+"}",0) + mamoi.ToString();
            }
            return kitu +"00001";
        }
        public int phutung_sua(PHUTUNG PHUTUNG)
        {
            PHUTUNG PT_SUA = DB.PHUTUNGs.Single(c => c.PhuTungID == PHUTUNG.PhuTungID);
            PT_SUA.MaPhuTung = PHUTUNG.MaPhuTung;
            PT_SUA.TenPhuTung = PHUTUNG.TenPhuTung;
            PT_SUA.LoaiTBID = PHUTUNG.LoaiTBID;
            PT_SUA.DVTID = PHUTUNG.DVTID;
            PT_SUA.SoHieu = PHUTUNG.SoHieu;
            PT_SUA.ThongSoKT = PHUTUNG.ThongSoKT;
            PT_SUA.HanBaoHanh = PHUTUNG.HanBaoHanh;
            PT_SUA.NuocSX = PHUTUNG.NuocSX;
            PT_SUA.NamSX = PHUTUNG.NamSX;
            PT_SUA.HinhAnh = PHUTUNG.HinhAnh;
            PT_SUA.NgayThangSD = PHUTUNG.NgayThangSD;
            PT_SUA.MoTaThem = PHUTUNG.MoTaThem;

            try
            {
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int phutung_xoa(PHUTUNG PHUTUNG)
        {
            PHUTUNG PT_XOA = DB.PHUTUNGs.Single(c => c.PhuTungID == PHUTUNG.PhuTungID);
            try
            {
                DB.PHUTUNGs.DeleteOnSubmit(PT_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public PHUTUNG phutung_thongtin(PHUTUNG PHUTUNG)
        {
            return DB.PHUTUNGs.SingleOrDefault(c => c.PhuTungID == PHUTUNG.PhuTungID);
        }
        public bool phutung_kiemtrama(PHUTUNG PHUTUNG)
        {
            PHUTUNG PT_KT = DB.PHUTUNGs.SingleOrDefault(c => c.MaPhuTung.ToUpper().Equals(PHUTUNG.MaPhuTung.ToUpper()));
            return (PT_KT != null ? true : false);
        }
    }

    //Thiết bị
    public class THIETBI_DAL
    {
        DBDataContext DB = new DBDataContext();
        public IEnumerable<THIETBI> thietbi_danhsach()
        {
            return DB.THIETBIs.Where (c=>c.TrangThai ==1).OrderBy(c => c.TenThietBi);
        }
        //
        public IEnumerable<THIETBI> thietbi_danhsach_dahuy()
        {
            return DB.THIETBIs.Where(c => c.TrangThai == 0).OrderBy(c => c.TenThietBi);
        }
        
        //
        public int thietbi_them(THIETBI THIETBI, List<string> LST)
        {
            try
            {
                DB.Connection.Open();
                DbTransaction trs = DB.Connection.BeginTransaction();
                DB.Transaction = trs;
                THIETBI.TrangThai = 1;
                DB.THIETBIs.InsertOnSubmit(THIETBI);
                DB.SubmitChanges();
                foreach (var PT in LST)
                {
                    PHUTUNG PT_CN = DB.PHUTUNGs.Single(c => c.PhuTungID == int.Parse (PT));
                    PT_CN.ThietBiID = THIETBI.ThietBiID;
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
        public int thietbi_them(List<THIETBI> LST_THIETBI)
        {
            try
            {
                DB.Connection.Open();
                DbTransaction trs = DB.Connection.BeginTransaction();
                DB.Transaction = trs;
                DB.THIETBIs.InsertAllOnSubmit(LST_THIETBI);
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
        
        //
        public int thietbi_sua(THIETBI THIETBI,List<PHUTUNG> LST)
        {
            THIETBI TB_SUA = DB.THIETBIs.Single(c => c.ThietBiID == THIETBI.ThietBiID);
            TB_SUA.MaThietBi = THIETBI.MaThietBi;
            TB_SUA.TenThietBi = THIETBI.TenThietBi;
            TB_SUA.LoaiTBID = THIETBI.LoaiTBID;
            TB_SUA.DVTID = THIETBI.DVTID;
            TB_SUA.SoHieu = THIETBI.SoHieu;
            TB_SUA.ThongSoKT = THIETBI.ThongSoKT;
            TB_SUA.HanBaoHanh = THIETBI.HanBaoHanh;
            TB_SUA.NuocSX = THIETBI.NuocSX;
            TB_SUA.NamSX = THIETBI.NamSX;
            TB_SUA.HinhAnh = THIETBI.HinhAnh;
            
            TB_SUA.TaiLieuKT = THIETBI.TaiLieuKT;
            TB_SUA.NDTaiLieuKT = THIETBI.NDTaiLieuKT;
            TB_SUA.MoTaThem = THIETBI.MoTaThem;

            try
            {
                DB.Connection.Open();
                DbTransaction trs = DB.Connection.BeginTransaction();
                DB.Transaction = trs;

                foreach (var T in LST)
                {
                    var T_CN = DB.PHUTUNGs.Single(c => c.PhuTungID == T.PhuTungID);
                    T_CN.ThietBiID = T.ThietBiID;
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
        public int thietbi_xoa(THIETBI THIETBI)
        {
            THIETBI TB_XOA = DB.THIETBIs.Single(c => c.ThietBiID == THIETBI.ThietBiID);
            try
            {
                DB.THIETBIs.DeleteOnSubmit(TB_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public THIETBI thietbi_thongtin_timten(THIETBI THIETBI)
        {
            return DB.ExecuteQuery<THIETBI>("SELECT * FROM THIETBI WHERE UPPER(THIETBI.TenThietBi) LIKE N'%" + THIETBI.TenThietBi + "%'").Skip(0).Take(1).SingleOrDefault();
        }
        public THIETBI thietbi_thongtin(THIETBI THIETBI)
        {
            return DB.THIETBIs.SingleOrDefault(c => c.ThietBiID == THIETBI.ThietBiID);
        }
        public bool thietbi_kiemtrama(THIETBI THIETBI)
        {
            THIETBI TB_KT = DB.THIETBIs.SingleOrDefault(c => c.MaThietBi.Equals(THIETBI.MaThietBi));
            return (TB_KT != null ? true : false);
        }
        public string thietbi_taoma(string kitu)
        {
            THIETBI TB = thietbi_danhsach().Where(c => c.MaThietBi.StartsWith(kitu)).OrderByDescending(c => Convert.ToInt32(c.MaThietBi.Substring(kitu.Length))).Take(1).SingleOrDefault();
            int mamoi = 0;
            if (TB != null)
            {
                mamoi = int.Parse(TB.MaThietBi.Substring(kitu.Length)) + 1;
                return kitu + string.Format("{0:d" + (TB.MaThietBi.Substring(kitu.Length).Length - mamoi.ToString().Length).ToString() + "}", 0) + mamoi.ToString();
            }
            return kitu + "00001";
        }
    }
}
 