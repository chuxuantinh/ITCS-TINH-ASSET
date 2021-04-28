using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThietBiDAL;
namespace ThietBiBLL
{

    //Nước
    public class NUOC_BLL
    {
        NUOC_DAL NUOC_DAL = new NUOC_DAL();
        public NUOC NUOC_DTO { get; set; }
        public NUOC_BLL() { NUOC_DTO = new NUOC(); }
        //
        public IEnumerable<NUOC> nuoc_danhsach()
        {
            return NUOC_DAL.nuoc_danhsach();
        }
        public int nuoc_them()
        {
            int kq = 0;
            kq=NUOC_DAL.nuoc_them(NUOC_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm nước có ID=" + NUOC_DTO.NuocID.ToString());
            return kq;
        }
        public int nuoc_sua(string NuocID)
        {
            string tengoicu = nuoc_thongtin(NuocID).TenNuoc;
            NUOC_DTO.NuocID = int.Parse(NuocID);
            int kq = 0;
            kq=NUOC_DAL.nuoc_sua(NUOC_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Sửa nước có ID=" + NUOC_DTO.NuocID.ToString() + ";Tên gọi: " + tengoicu + "-->" + NUOC_DTO.TenNuoc);
            return kq;
        }
        public int nuoc_xoa(string NuocID)
        {
            string tengoi = nuoc_thongtin(NuocID).TenNuoc;
            NUOC_DTO.NuocID = int.Parse(NuocID);
            int kq = 0;
            kq= NUOC_DAL.nuoc_xoa(NUOC_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa nước có ID=" + NuocID + ";Tên gọi: " + tengoi);
            return kq;
        }
        public NUOC nuoc_thongtin(string NuocID)
        {
            NUOC_DTO.NuocID = int.Parse(NuocID);
            return NUOC_DAL.nuoc_thongtin(NUOC_DTO);
        }
    }

    //Tỉnh
    public class TINH_BLL
    {
        TINH_DAL TINH_DAL = new TINH_DAL();
        public TINH TINH_DTO { get; set; }
        public TINH_BLL() { TINH_DTO = new TINH(); }

        public IEnumerable<TINH> tinh_danhsach()
        {
            return TINH_DAL.tinh_danhsach();
        }
        public int tinh_them()
        {
            int kq = 0;
            kq = TINH_DAL.tinh_them(TINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm tỉnh/tp : ID=" + TINH_DTO.TinhID.ToString () + ";Tên gọi: " + TINH_DTO.TenTinh);
            return kq;
        }
        public int tinh_sua(string TinhID)
        {
            string tengoicu = tinh_thongtin(TinhID).TenTinh;
            TINH_DTO.TinhID = int.Parse(TinhID);

            int kq = 0;
            kq= TINH_DAL.tinh_sua(TINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh tỉnh có ID=" + TINH_DTO.TinhID.ToString() + ";Tên gọi: " + tengoicu + "-->" + TINH_DTO.TenTinh);
            return kq;
        }
        public int tinh_xoa(string TinhID)
        {
            string tengoi = tinh_thongtin(TinhID).TenTinh;
            TINH_DTO.TinhID = int.Parse(TinhID);
            int kq = 0;
            kq=TINH_DAL.tinh_sua(TINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa tỉnh/tp có ID=" + TinhID + ";Tên gọi: " + tengoi);
            return kq;
        }
        public TINH tinh_thongtin(string TinhID)
        {
            TINH_DTO.TinhID = int.Parse(TinhID);
            return TINH_DAL.tinh_thongtin(TINH_DTO);
        }
    }

    //Đơn vị tính
    public class DONVITINH_BLL
    {
        DONVITINH_DAL DONVITINH_DAL = new DONVITINH_DAL();
        public DONVITINH DONVITINH_DTO { get; set; }

        public DONVITINH_BLL() { DONVITINH_DTO = new DONVITINH(); }

        public IEnumerable<DONVITINH> donvitinh_danhsach()
        {
            return DONVITINH_DAL.donvitinh_danhsach();
        }
        public int donvitinh_them()
        {
            int kq = 0;
            kq = DONVITINH_DAL.donvitinh_them(DONVITINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm đơn vị tính : ID=" + DONVITINH_DTO.DVTID.ToString() + ";Tên gọi: " + DONVITINH_DTO.TenDVT);
            return kq;
        }
        public int donvitinh_sua(string dvtid)
        {
            string tengoicu =donvitinh_thongtin (dvtid).TenDVT ;
            DONVITINH_DTO.DVTID = int.Parse(dvtid);
            int kq = 0;
            kq = DONVITINH_DAL.donvitinh_sua(DONVITINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Sửa đơn vị tính: ID=" + DONVITINH_DTO.DVTID.ToString() + ";Tên gọi: " + tengoicu + "-->" + DONVITINH_DTO.TenDVT);
            return kq;
        }
        public int donvitinh_xoa(string dvtid)
        {
            string tengoi = donvitinh_thongtin(dvtid).TenDVT;
            DONVITINH_DTO.DVTID = int.Parse(dvtid);
            int kq = DONVITINH_DAL.donvitinh_xoa(DONVITINH_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa đơn vị tính,ID=" + dvtid + ";Tên gọi: " + tengoi);
            return kq;
        }
        public bool donvitinh_kiemtra(string tendvt)
        {
            DONVITINH_DTO.TenDVT = tendvt;
            return DONVITINH_DAL.donvitinh_kiemtra(DONVITINH_DTO);
        }
        public DONVITINH donvitinh_thongtin(string dvtid)
        {
            DONVITINH_DTO.DVTID = int.Parse(dvtid);
            return DONVITINH_DAL.donvitinh_thongtin(DONVITINH_DTO);
        }
    }

    //Nhóm thiết bị
    public class NHOMTHIETBI_BLL
    {
        NHOMTHIETBI_DAL NHOMTHIETBI_DAL = new NHOMTHIETBI_DAL();
        public NHOMTHIETBI NHOMTHIETBI_DTO { get; set; }

        public NHOMTHIETBI_BLL() { NHOMTHIETBI_DTO = new NHOMTHIETBI(); }

        public IEnumerable<NHOMTHIETBI> nhomthietbi_danhsach()
        {
            return NHOMTHIETBI_DAL.nhomthietbi_danhsach();
        }
        public int nhomthietbi_them()
        {
            int kq = 0;
            kq = NHOMTHIETBI_DAL.nhomthietbi_them(NHOMTHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm nhóm thiết bị, ID=" + NHOMTHIETBI_DTO.NhomTBID.ToString() + ";Tên gọi: " + NHOMTHIETBI_DTO.TenNhomTB);
            return kq;
        }
        public int nhomthietbi_sua(string nhomtbid)
        {
            string tengoicu = nhomthietbi_thongtin(nhomtbid).TenNhomTB;
            NHOMTHIETBI_DTO.NhomTBID = int.Parse(nhomtbid);

            int kq= NHOMTHIETBI_DAL.nhomthietbi_sua(NHOMTHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh nhóm thiết bị có ID=" + NHOMTHIETBI_DTO.NhomTBID.ToString() + ";Tên gọi: " + tengoicu + "-->" + NHOMTHIETBI_DTO.TenNhomTB);
            return kq;
        }
        public int nhomthietbi_xoa(string nhomtbid)
        {
            string tengoi = nhomthietbi_thongtin(nhomtbid).TenNhomTB;
            NHOMTHIETBI_DTO.NhomTBID = int.Parse(nhomtbid);
            int kq = 0;
            kq= NHOMTHIETBI_DAL.nhomthietbi_xoa(NHOMTHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa nhóm thiết bị có ID=" + nhomtbid + ";Tên gọi: " + tengoi);
            return kq;
        }
        public bool nhomthietbi_kiemtra(string tennhomtb)
        {
            NHOMTHIETBI_DTO.TenNhomTB = tennhomtb;
            return NHOMTHIETBI_DAL.nhomthietbi_kiemtra(NHOMTHIETBI_DTO);
        }
        public NHOMTHIETBI nhomthietbi_thongtin(string nhomtbid)
        {
            NHOMTHIETBI_DTO.NhomTBID = int.Parse(nhomtbid);
            return NHOMTHIETBI_DAL.nhomthietbi_thongtin(NHOMTHIETBI_DTO);
        }
    }

    //Loại thiết bị
    public class LOAITHIETBI_BLL
    {
        LOAITHIETBI_DAL LOAITHIETBI_DAL = new LOAITHIETBI_DAL();
        public LOAITHIETBI LOAITHIETBI_DTO { get; set; }

        public LOAITHIETBI_BLL() { LOAITHIETBI_DTO = new LOAITHIETBI(); }
        public IEnumerable<LOAITHIETBI> loaithietbi_danhsach()
        {
            return LOAITHIETBI_DAL.loaithietbi_danhsach();
        }
        public int loaithietbi_them()
        {
            int kq = 0;
            kq = LOAITHIETBI_DAL.loaithietbi_them(LOAITHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm loại thiết bị có ID=" + LOAITHIETBI_DTO.LoaiTBID.ToString());
            return kq;
        }
        public int loaithietbi_sua(string LoaiTBID)
        {
            string tengoicu = loaithietbi_thongtin(LoaiTBID).TenLoaiTB;
            int kq = 0;
            LOAITHIETBI_DTO.LoaiTBID = int.Parse ( LoaiTBID);
            kq = LOAITHIETBI_DAL.loaithietbi_sua(LOAITHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh loại thiết bị, ID=" + LOAITHIETBI_DTO.LoaiTBID.ToString() + ";Tên gọi:" + tengoicu + "-->" + LOAITHIETBI_DTO.TenLoaiTB);
            return kq;
        }
        public int loaithietbi_xoa(string LoaiTBID)
        {
            string loaithietbi = loaithietbi_thongtin(LoaiTBID).TenLoaiTB;
            LOAITHIETBI_DTO.LoaiTBID = int.Parse(LoaiTBID);
            int kq = 0;
            kq = LOAITHIETBI_DAL.loaithietbi_xoa(LOAITHIETBI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa loại thiết bị,ID=" + LoaiTBID+";Tên gọi:" + loaithietbi);
            return kq;
        }
        public bool loaithietbi_kiemtraten(string LoaiTB)
        {
            LOAITHIETBI_DTO.TenLoaiTB = LoaiTB;
            return LOAITHIETBI_DAL.loaithietbi_kiemtraten(LOAITHIETBI_DTO);
        }
        public LOAITHIETBI loaithietbi_thongtin(string LoaiTBID)
        {
            LOAITHIETBI_DTO.LoaiTBID = int.Parse(LoaiTBID);
            return LOAITHIETBI_DAL.loaithietbi_thongtin(LOAITHIETBI_DTO);
        }
    }

    //Tỷ lệ hao mòn
    public class TYLEHAOMON_BLL
    {
        TYLEHAOMON_DAL TYLEHAOMON_DAL = new TYLEHAOMON_DAL();
        public TYLEHAOMON TYLEHAOMON_DTO { get; set; }
        public TYLEHAOMON_BLL() { TYLEHAOMON_DTO = new TYLEHAOMON(); }
        //
        public IEnumerable<TYLEHAOMON> tylehaomon_danhsach()
        {
            return TYLEHAOMON_DAL.tylehaomon_danhsach();
        }
        public int tylehaomon_them()
        {
            return TYLEHAOMON_DAL.tylehaomon_them(TYLEHAOMON_DTO);
        }
        public int tylehaomon_sua(string ID)
        {
            TYLEHAOMON_DTO.TyLeHaoMonID = int.Parse(ID);
            return TYLEHAOMON_DAL.tylehaomon_sua(TYLEHAOMON_DTO);
        }
        public int tylehaomon_xoa(string ID)
        {
            TYLEHAOMON_DTO.TyLeHaoMonID = int.Parse(ID);
            return TYLEHAOMON_DAL.tylehaomon_xoa(TYLEHAOMON_DTO);
        }
        public bool tylehaomon_ktloaithietbi(string LoaiTBID)
        {
            TYLEHAOMON_DTO.LoaiTBID = int.Parse(LoaiTBID);
            return TYLEHAOMON_DAL.tylehaomon_ktloaithietbi(TYLEHAOMON_DTO);
        }
        public TYLEHAOMON tylehaomon_thongtin(string ID)
        {
            TYLEHAOMON_DTO.TyLeHaoMonID = int.Parse(ID);
            return TYLEHAOMON_DAL.tylehaomon_thongtin(TYLEHAOMON_DTO);
        }
    }

    //Tình trạng thiết bị
    public class TINHTRANG_BLL
    {
        TINHTRANG_DAL TINHTRANG_DAL = new TINHTRANG_DAL();
        public TINHTRANG TINHTRANG_DTO { get; set; }

        public TINHTRANG_BLL() { TINHTRANG_DTO = new TINHTRANG(); }
        public IEnumerable<TINHTRANG> tinhtrang_danhsach()
        {
            return TINHTRANG_DAL.tinhtrang_danhsach();
        }
        public int tinhtrang_them()
        {
            int kq = 0;
            kq = TINHTRANG_DAL.tinhtrang_them(TINHTRANG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm tình trạng.ID=" + TINHTRANG_DTO.TinhTrangID.ToString() + ";Tên gọi: " + TINHTRANG_DTO.TenTinhTrang);
            return kq;
        }
        public int tinhtrang_sua(string TinhTrangID)
        {
            string tengoicu = tinhtrang_thongtin(TinhTrangID).TenTinhTrang;
            TINHTRANG_DTO.TinhTrangID = int.Parse(TinhTrangID);
            int kq = 0;
            kq = TINHTRANG_DAL.tinhtrang_sua(TINHTRANG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh tình trạng có ID=" + TINHTRANG_DTO.TinhTrangID.ToString() + ";Tên gọi: " + tengoicu + "-->" + TINHTRANG_DTO.TenTinhTrang);
            return kq;
        }
        public int tinhtrang_xoa(string TinhTrangID)
        {
            string tentinhtrang = tinhtrang_thongtin(TinhTrangID).TenTinhTrang;
            TINHTRANG_DTO.TinhTrangID = int.Parse(TinhTrangID);
            int kq = 0;
            kq = TINHTRANG_DAL.tinhtrang_xoa(TINHTRANG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa tình trạng có ID=" + TinhTrangID + ";Tên gọi:" + tentinhtrang);
            return kq;
        }
        public bool tinhtrang_kiemtra(string TenTinhTrang)
        {
            TINHTRANG_DTO.TenTinhTrang = TenTinhTrang;
            return TINHTRANG_DAL.tinhtrang_kiemtra(TINHTRANG_DTO);
        }
        public TINHTRANG tinhtrang_thongtin(string TinhTrangID)
        {
            TINHTRANG_DTO.TinhTrangID = int.Parse(TinhTrangID);
            return TINHTRANG_DAL.tinhtrang_thongtin(TINHTRANG_DTO);
        }
    }

    //Chức vụ
    public class CHUCVU_BLL
    {
        CHUCVU_DAL CHUCVU_DAL = new CHUCVU_DAL();
        public CHUCVU CHUCVU_DTO { get; set; }
        public CHUCVU_BLL() { CHUCVU_DTO = new CHUCVU(); }

        public IEnumerable<CHUCVU> chucvu_danhsach()
        {
            return CHUCVU_DAL.chucvu_danhsach();
        }
        public int chucvu_them()
        {
            int kq = CHUCVU_DAL.chucvu_them(CHUCVU_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm chức vụ: ID=" + CHUCVU_DTO.ChucVuID.ToString() + ";Tên gọi: " + CHUCVU_DTO.TenChucVu);
            return kq;
        }
        public int chucvu_sua(string ChucVuID)
        {
            CHUCVU_DTO.ChucVuID = int.Parse(ChucVuID);
            string tengoicu = chucvu_thongtin(ChucVuID).TenChucVu;

            int kq = CHUCVU_DAL.chucvu_sua(CHUCVU_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh chức vụ: ID=" + ChucVuID + ";Tên gọi: " + tengoicu + "-->" + CHUCVU_DTO.TenChucVu);
            return kq;
        }
        public int chucvu_xoa(string ChucVuID)
        {
            CHUCVU_DTO.ChucVuID = int.Parse(ChucVuID);
            int kq = CHUCVU_DAL.chucvu_xoa(CHUCVU_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa chức vụ: ID=" + ChucVuID + ";Tên gọi: " + CHUCVU_DTO.TenChucVu);
            return kq;
        }
        public bool chucvu_kiemtra(string TenCV)
        {
            CHUCVU_DTO.TenChucVu = TenCV;
            return CHUCVU_DAL.chucvu_kiemtra(CHUCVU_DTO);
        }
        public CHUCVU chucvu_thongtin(string ChucVuID)
        {
            CHUCVU_DTO.ChucVuID = int.Parse (ChucVuID);
            return CHUCVU_DAL.chucvu_thongtin(CHUCVU_DTO);
        }
    }

    //Đơn vị
    public class DONVI_BLL
    {
        DONVI_DAL DONVI_DAL = new DONVI_DAL();
        public DONVI DONVI_DTO { get; set; }

        public DONVI_BLL() { DONVI_DTO = new DONVI(); }
        public IEnumerable<DONVI> donvi_danhsach()
        {
            return DONVI_DAL.donvi_danhsach();
        }
        public int donvi_them()
        {
            string tengoi = DONVI_DTO.TenDonVi;
            int kq = DONVI_DAL.donvi_them(DONVI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm đơn vị mới: ID=" + DONVI_DTO.DonViID.ToString() + ";Tên gọi=" + tengoi);
            return kq;
        }
        public int donvi_sua(string DonViID)
        {
            DONVI_DTO.DonViID = int.Parse(DonViID);
            string tengoicu = donvi_thongtin(DonViID).TenDonVi;
            int kq = DONVI_DAL.donvi_sua(DONVI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh đơn vị: ID=" + DonViID + ";Tên gọi=" + tengoicu + "-->" + DONVI_DTO.TenDonVi);
            return kq;
        }
        public int donvi_xoa(string DonViID)
        {
            DONVI_DTO.DonViID = int.Parse(DonViID);
            string tengoi = DONVI_DTO.TenDonVi;
            int kq = DONVI_DAL.donvi_xoa(DONVI_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa đơn vị: ID=" + DonViID + ";Tên gọi=" + tengoi);
            return kq;
        }
        public bool donvi_kiemtra(string TenDV)
        {
            DONVI_DTO.TenDonVi = TenDV;
            return DONVI_DAL.donvi_kiemtra(DONVI_DTO);
        }
        public DONVI donvi_thongtin(string DonViID)
        {
            DONVI_DTO.DonViID = int.Parse(DonViID);
            return DONVI_DAL.donvi_thongtin(DONVI_DTO);
        }
    }

    //Khu vực
    public class BOPHAN_BLL
    {
        BOPHAN_DAL BOPHAN_DAL = new BOPHAN_DAL();
        public BOPHAN BOPHAN_DTO { get; set; }

        public BOPHAN_BLL() { BOPHAN_DTO = new BOPHAN(); }
        public IEnumerable<BOPHAN> bophan_danhsach()
       {
           return BOPHAN_DAL.bophan_danhsach();
       }
        public int bophan_them()
       {
           int kq = BOPHAN_DAL.bophan_them(BOPHAN_DTO);
           if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm bộ phận: ID=" + BOPHAN_DTO.BoPhanID.ToString() + ";Tên gọi:" + BOPHAN_DTO.TenBoPhan);
           return kq;
       }
        public int bophan_sua(string BoPhanID)
       {
           BOPHAN_DTO.BoPhanID = int.Parse(BoPhanID);
           string tencu = bophan_thongtin(BoPhanID).TenBoPhan ;
           int kq = BOPHAN_DAL.bophan_sua(BOPHAN_DTO);
           if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh bộ phận: ID=" + BoPhanID + ";Tên gọi:" + tencu + "-->" + BOPHAN_DTO.TenBoPhan);
           return kq;
       }

        public int bophan_xoa(string BoPhanID)
       {
           BOPHAN_DTO.BoPhanID = int.Parse(BoPhanID);
           string tencu = BOPHAN_DTO.TenBoPhan;
           int kq = BOPHAN_DAL.bophan_xoa(BOPHAN_DTO);
           if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa bộ phận: ID=" + BoPhanID + ";Tên gọi=" + tencu);
           return kq;
       }
        public bool bophan_kiemtra(string TenBoPhan)
       {
           BOPHAN_DTO.TenBoPhan = TenBoPhan;
           return BOPHAN_DAL.bophan_kiemtra(BOPHAN_DTO);
       }
        public BOPHAN bophan_thongtin(string BoPhanID)
        {
            BOPHAN_DTO.BoPhanID = int.Parse(BoPhanID);
            return BOPHAN_DAL.bophan_thongtin(BOPHAN_DTO);
        }
    }

    //Nhân viên
    public class NHANVIEN_BLL
    {
        NHANVIEN_DAL NHANVIEN_DAL = new NHANVIEN_DAL();
        public NHANVIEN NHANVIEN_DTO { get; set; }
        public NHANVIEN_BLL() { NHANVIEN_DTO = new NHANVIEN(); }
        //
        public IEnumerable<NHANVIEN> nhanvien_danhsach()
        {
            return NHANVIEN_DAL.nhanvien_danhsach();
        }
        public int nhanvien_them()
        {
            int kq = NHANVIEN_DAL.nhanvien_them(NHANVIEN_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm nhân viên: ID=" + NHANVIEN_DTO.NhanVienID + ";MaNV=" + NHANVIEN_DTO.MaNV);
            return kq;
        }
        public int nhanvien_sua(string NhanVienID)
        {
            NHANVIEN_DTO.NhanVienID = Int64 .Parse(NhanVienID);
            string tencu =nhanvien_thongtin (NhanVienID ).MaNV;

            int kq = NHANVIEN_DAL.nhanvien_sua(NHANVIEN_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh nhân viên: ID=" + NHANVIEN_DTO.NhanVienID + ";MaNV=" +tencu+"-->"+ NHANVIEN_DTO.MaNV);
            return kq; 
        }
        public int nhanvien_xoa(string NhanVienID)
        {
            NHANVIEN_DTO.NhanVienID = Int64.Parse(NhanVienID);
            int kq = NHANVIEN_DAL.nhanvien_xoa(NHANVIEN_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa nhân viên: MaNV=" + NHANVIEN_DTO.MaNV);
            return kq;
        }

        public NHANVIEN nhanvien_thongtin(string NhanVienID)
        {
            NHANVIEN_DTO.NhanVienID = Int64.Parse(NhanVienID);
            return NHANVIEN_DAL.nhanvien_thongtin(NHANVIEN_DTO);
        }
        public NHANVIEN nhanvien_thongtin_ma(string MaNV)
        {
            NHANVIEN_DTO.MaNV = MaNV;
            return NHANVIEN_DAL.nhanvien_thongtin_ma(NHANVIEN_DTO);
        }
        public bool nhanvien_kiemtrama(string MaNV)
        {
            NHANVIEN_DTO.MaNV = MaNV;
            return NHANVIEN_DAL.nhanvien_kiemtrama(NHANVIEN_DTO);
        }
        public string nhanvien_taoma()
        {
            return NHANVIEN_DAL.nhanvien_taoma("NV");
        }
    }

    //Nhà cung cấp
    public class NHACUNGCAP_BLL
    {
        NHACUNGCAP_DAL NHACUNGCAP_DAL = new NHACUNGCAP_DAL();
        public NHACUNGCAP NHACUNGCAP_DTO { get; set; }

        public NHACUNGCAP_BLL() { NHACUNGCAP_DTO = new NHACUNGCAP(); }
        //
        public IEnumerable<NHACUNGCAP> nhacungcap_danhsach()
        {
            return NHACUNGCAP_DAL.nhacungcap_danhsach();
        }
        public int nhacungcap_them()
        {
            int kq=NHACUNGCAP_DAL.nhacungcap_them(NHACUNGCAP_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm nhà cung cấp : ID=" + NHACUNGCAP_DTO.NCCID.ToString() + ";Tên NCC=" + NHACUNGCAP_DTO.TenNCC);
            return kq;
        }
        public int nhacungcap_sua(string NCCID)
        {
            string tencu = nhacungcap_thongtin(NCCID).TenNCC;
            NHACUNGCAP_DTO.NCCID = int.Parse(NCCID);
            int kq = NHACUNGCAP_DAL.nhacungcap_sua(NHACUNGCAP_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh NCC: ID=" + NHACUNGCAP_DTO.NCCID.ToString() + ";Tên NCC=" + tencu + "-->" + NHACUNGCAP_DTO.TenNCC);
            return kq;
        }
        public int nhacungcap_xoa(string NCCID)
        {
            NHACUNGCAP_DTO.NCCID = int.Parse(NCCID);
            string tenncc = NHACUNGCAP_DTO.TenNCC;

            int kq = NHACUNGCAP_DAL.nhacungcap_xoa(NHACUNGCAP_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa NCC: ID=" + NCCID + ";Tên NCC="+tenncc);
            return kq;
        }
        public NHACUNGCAP nhacungcap_thongtin(string NCCID)
        {
            NHACUNGCAP_DTO.NCCID = int.Parse(NCCID);
            return NHACUNGCAP_DAL.nhacungcap_thongtin(NHACUNGCAP_DTO);
        }
        public bool nhacungcap_kiemtratenncc(string TenNCC)
        {
            NHACUNGCAP_DTO.TenNCC = TenNCC;
            return NHACUNGCAP_DAL.nhacungcap_kiemtratenncc(NHACUNGCAP_DTO);
        }
    }

    // Phụ tùng
    public class PHUTUNG_BLL
    {
        PHUTUNG_DAL PHUTUNG_DAL = new PHUTUNG_DAL();
        public PHUTUNG PHUTUNG_DTO { get; set; }
        public PHUTUNG_BLL() { PHUTUNG_DTO = new PHUTUNG(); }
        //
        public IEnumerable<PHUTUNG> phutung_danhsach()
        {
            return PHUTUNG_DAL.phutung_danhsach();
        }
        public int phutung_them()
        {
            int kq = PHUTUNG_DAL.phutung_them(PHUTUNG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm phụ tùng: ID=" + PHUTUNG_DTO.PhuTungID.ToString() + ";Tên:" + PHUTUNG_DTO.TenPhuTung);
            return kq;
        }
        public string phutung_taoma()
        {
            return PHUTUNG_DAL.phutung_taoma("PT");
        }
        public int phutung_sua(string PhuTungID)
        {
            string tencu = phutung_thongtin(PhuTungID).TenPhuTung;
            PHUTUNG_DTO.PhuTungID = int.Parse(PhuTungID);
            int kq = PHUTUNG_DAL.phutung_sua(PHUTUNG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh phụ tùng: ID=" + PHUTUNG_DTO.PhuTungID.ToString() + ";Tên:" + tencu + "-->" + PHUTUNG_DTO.TenPhuTung);
            return kq;
        }
        public int phutung_xoa(string PhuTungID)
        {
            PHUTUNG_DTO.PhuTungID = int.Parse(PhuTungID);
            return PHUTUNG_DAL.phutung_xoa(PHUTUNG_DTO);
        }
        public bool phutung_kiemtrama(string MaPhuTung)
        {
            PHUTUNG_DTO.MaPhuTung = MaPhuTung;
            return PHUTUNG_DAL.phutung_kiemtrama(PHUTUNG_DTO);
        }
        public PHUTUNG phutung_thongtin(string PhuTungID)
        {
            PHUTUNG_DTO.PhuTungID = int.Parse(PhuTungID);
            return PHUTUNG_DAL.phutung_thongtin(PHUTUNG_DTO);
        }
    }

    //Thiết bị
    public class THIETBI_BLL
    {
        THIETBI_DAL THIETBI_DAL = new THIETBI_DAL();
        public THIETBI THIETBI_DTO { get; set; }
        public THIETBI_BLL() { THIETBI_DTO = new THIETBI(); }
        //
        public IEnumerable<THIETBI> thietbi_danhsach()
        {
            return THIETBI_DAL.thietbi_danhsach();
        }
        public IEnumerable<THIETBI> thietbi_danhsach_dahuy()
        {
            return THIETBI_DAL.thietbi_danhsach_dahuy();
        }

        public int thietbi_them(List<string> PT)
        {
            if (THIETBI_DTO.MaThietBi == null || THIETBI_DTO.MaThietBi == "")
            {
                THIETBI_DTO.MaThietBi = new THIETBI_BLL().thietbi_taoma();
            }
            int kq = THIETBI_DAL.thietbi_them(THIETBI_DTO, PT);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm thiết bị: ID=" + THIETBI_DTO.ThietBiID.ToString() + ";Tên:" + THIETBI_DTO.TenThietBi);
            return kq;
        }
        public int thietbi_them(List<THIETBI> LST_THIETBI)
        {
            int kq = THIETBI_DAL.thietbi_them(LST_THIETBI);
            if (kq > 0)
            {
                NHATKITRUYCAP_BLL NK = new NHATKITRUYCAP_BLL();
                foreach (var TB in LST_THIETBI)
                {
                    NK.nhatkitruycap_them("Thêm thiết bị : ID=" + TB.ThietBiID.ToString() + ";Tên:" + TB.TenThietBi);
                }
            }
            return kq;
        }
        public int thietbi_sua(string ThietBiID,List<PHUTUNG> LST)
        {
            string tencu = thietbi_thongtin(ThietBiID).TenThietBi;
            THIETBI_DTO.ThietBiID = int.Parse(ThietBiID);
            int kq = THIETBI_DAL.thietbi_sua(THIETBI_DTO,LST);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh thiết bị: ID=" + THIETBI_DTO.ThietBiID.ToString() + ";Tên:" + tencu + "-->" + THIETBI_DTO.TenThietBi);
            return kq;
        }
        public int thietbi_xoa(string ThietBiID)
        {
            THIETBI_DTO.ThietBiID = int.Parse(ThietBiID);
            return THIETBI_DAL.thietbi_xoa(THIETBI_DTO);
        }
        public bool thietbi_kiemtrama(string MaThietBi)
        {
            THIETBI_DTO.MaThietBi = MaThietBi;
            return THIETBI_DAL.thietbi_kiemtrama(THIETBI_DTO);
        }
        public string thietbi_taoma()
        {
            return THIETBI_DAL.thietbi_taoma("TB");
        }

        public THIETBI thietbi_thongtin_timten(string TenThietBi)
        {
            THIETBI_DTO.TenThietBi = TenThietBi;
            return THIETBI_DAL.thietbi_thongtin_timten(THIETBI_DTO);
        }
        public THIETBI thietbi_thongtin(string ThietBiID)
        {
            THIETBI_DTO.ThietBiID = int.Parse(ThietBiID);
            return THIETBI_DAL.thietbi_thongtin(THIETBI_DTO);
        }
    }


}
