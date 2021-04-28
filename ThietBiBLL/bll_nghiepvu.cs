using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ThietBiDAL;

namespace ThietBiBLL
{
    //Phiếu giao nhận
    public class PHIEUNHAP_BLL
    {
        PHIEUNHAP_DAL PHIEUNHAP_DAL = new PHIEUNHAP_DAL();
        public PHIEUNHAP PHIEUNHAP_DTO { get; set; }
        public List<CTPHIEUNHAP> LST_CTPHIEUNHAP { get; set; }
        public PHIEUNHAP_BLL()
        {
            PHIEUNHAP_DTO = new PHIEUNHAP();
            LST_CTPHIEUNHAP = new List<CTPHIEUNHAP>();
        }

        //
        public IEnumerable<PHIEUNHAP> phieunhap_danhsach()
        {
            return PHIEUNHAP_DAL.phieunhap_danhsach();
        }
        public int phieunhap_them()
        {
            int kq= PHIEUNHAP_DAL.phieunhap_them(PHIEUNHAP_DTO, LST_CTPHIEUNHAP);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm giao nhận thiết bị: ID" + PHIEUNHAP_DTO.PhieuNhapID.ToString() + ";ngày giao nhận: " + PHIEUNHAP_DTO.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
            return kq;
        }
        public int phieunhap_sua(string PhieuNhapID)
        {
            PHIEUNHAP_DTO.PhieuNhapID = int.Parse(PhieuNhapID);
            int kq= PHIEUNHAP_DAL.phieunhap_sua(PHIEUNHAP_DTO, LST_CTPHIEUNHAP);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh phiếu giao nhận: ID" + PHIEUNHAP_DTO.PhieuNhapID.ToString());
            return kq;
        }
        public int phieunhap_xoa(string PhieuNhapID)
        {
            string ngaynhap = new PHIEUNHAP_BLL ().phieunhap_thongtin(PhieuNhapID).NgayNhap.Value.Date.ToString("dd/MM/yyyy");
            PHIEUNHAP_DTO.PhieuNhapID = int.Parse(PhieuNhapID);
            int kq = PHIEUNHAP_DAL.phieunhap_xoa(PHIEUNHAP_DTO);

            if (kq > 0)
            {
                new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa phiếu giao nhận: ID=" + PhieuNhapID + ";Ngày nhận: " + ngaynhap);
            }
            return kq;
        }
        public PHIEUNHAP phieunhap_thongtin(String PhieuNhapID)
        {
            PHIEUNHAP_DTO.PhieuNhapID = int.Parse(PhieuNhapID);
            return PHIEUNHAP_DAL.phieunhap_thongtin(PHIEUNHAP_DTO);
        }
    }
    public class CTPHIEUNHAP_BLL
    {
        CTPHIEUNHAP_DAL CTPHIEUNHAP_DAL = new CTPHIEUNHAP_DAL();

        public IEnumerable<CTPHIEUNHAP> ctphieunhap_danhsach()
        {
            return CTPHIEUNHAP_DAL.ctphieunhap_danhsach();
        }
    }

    //Phiếu bàn giao
    public class PHIEUBANGIAO_BLL
    {
        PHIEUBANGIAO_DAL PHIEUBANGIAO_DAL = new PHIEUBANGIAO_DAL();
        public BANGIAO BANGIAO_DTO { get; set; }
        public List<CTBANGIAO> LST_CTBANGIAO { get; set; }
        //
        public PHIEUBANGIAO_BLL()
        {
            BANGIAO_DTO = new BANGIAO();
            LST_CTBANGIAO = new List<CTBANGIAO>();
        }

        public IEnumerable<BANGIAO> phieubangiao_danhsach()
        {
            return PHIEUBANGIAO_DAL.phieubangiao_danhsach();
        }
        public int phieubangiao_them()
        {
            int kq = PHIEUBANGIAO_DAL.phieubangiao_them(BANGIAO_DTO, LST_CTBANGIAO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Phiếu bàn giao: ID" + BANGIAO_DTO.BanGiaoID.ToString() + ";ngày bàn giao: " + BANGIAO_DTO.NgayBanGiao.Value.Date.ToString("dd/MM/yyyy"));
            return kq;
        }
        public int phieubangiao_sua(string BanGiaoID)
        {
            BANGIAO_DTO.BanGiaoID = int.Parse(BanGiaoID);
            int kq = PHIEUBANGIAO_DAL.phieubangiao_sua(BANGIAO_DTO, LST_CTBANGIAO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh phiếu bàn giao: ID" + BanGiaoID);
            return kq;
        }
        public int phieubangiao_xoa(string BanGiaoID)
        {
            var CT = new PHIEUBANGIAO_BLL().phieubangiao_thongtin(BanGiaoID);

            BANGIAO_DTO.BanGiaoID = int.Parse(BanGiaoID);
            int kq = PHIEUBANGIAO_DAL.phieubangiao_xoa(BANGIAO_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa phiếu bàn giao: ID=" + BanGiaoID + ";Mã ĐV nhận=" + CT.DonViNhan.ToString() + ";Mã BP nhận=" + CT.BoPhanNhan.ToString());
            return kq;
        }
        public BANGIAO phieubangiao_thongtin(string BanGiaoID)
        {
            BANGIAO_DTO.BanGiaoID = int.Parse(BanGiaoID);
            return PHIEUBANGIAO_DAL.phieubangiao_thongtin(BANGIAO_DTO);
        }
    }
    public class CTBANGIAO_BLL
    {
        CTBANGIAO_DAL CTBANGIAO_DAL = new CTBANGIAO_DAL();
        BANGIAO BANGIAO_DTO = new BANGIAO();
        public IEnumerable<CTBANGIAO> ctbangiao_danhsach(string BanGiaoID)
        {
            BANGIAO_DTO.BanGiaoID = int.Parse(BanGiaoID);
            return CTBANGIAO_DAL.ctbangiao_danhsach(BANGIAO_DTO);
        }
        public IEnumerable<CTBANGIAO> ctbangiao_danhsach()
        {
            return CTBANGIAO_DAL.ctbangiao_danhsach();
        }
    }

    //Phiếu thanh lý
    public class PHIEUTHANHLY_BLL
    {
        PHIEUTHANHLY_DAL PHIEUTHANHLY_DAL = new PHIEUTHANHLY_DAL();
        public List<CTTHANHLY> LST_CTTHANHLY { get; set; }
        public THANHLY THANHLY_DTO { get; set; }
        //
        public PHIEUTHANHLY_BLL()
        {
            LST_CTTHANHLY = new List<CTTHANHLY>();
            THANHLY_DTO = new THANHLY();
        }
        public IEnumerable<THANHLY> phieuthanhly_danhsach()
        {
            return PHIEUTHANHLY_DAL.phieuthanhly_danhsach();
        }
        public int phieuthanhly_them()
        {
           int kq= PHIEUTHANHLY_DAL.phieuthanhly_them(THANHLY_DTO, LST_CTTHANHLY);
           if (kq > 0)
           {
               new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm phiếu thanh lý: ID=" + THANHLY_DTO.ThanhLyID.ToString() + ";Ngày thanh lý=" + THANHLY_DTO.NgayThanhLy.Value.Date.ToString("dd/MM/yyyy"));
           }
           return kq;
        }
        public int phieuthanhly_sua(string ThanhLyID)
        {
            THANHLY_DTO.ThanhLyID = int.Parse(ThanhLyID);
            int kq= PHIEUTHANHLY_DAL.phieuthanhly_sua(THANHLY_DTO, LST_CTTHANHLY);
            if (kq > 0)
            {
                new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh phiếu thanh lý: ID=" + THANHLY_DTO.ThanhLyID.ToString() + ";Ngày thanh lý: " + THANHLY_DTO.NgayThanhLy.Value.Date.ToString("dd/MM/yyyy"));
            }
            return kq;
        }
        public int phieuthanhly_xoa(string ThanhLyID)
        {
            THANHLY_DTO.ThanhLyID = int.Parse(ThanhLyID);
            string NgayThanhLy =phieuthanhly_thongtin (ThanhLyID).NgayThanhLy.Value.Date.ToString("dd/MM/yyyy");

            int kq= PHIEUTHANHLY_DAL.phieuthanhly_xoa(THANHLY_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Xóa phiếu thanh lý: ID=" + ThanhLyID + ";Ngày thanh lý=" + NgayThanhLy);
            return kq;
        }
        public THANHLY phieuthanhly_thongtin(string ThanhLyID)
        {
            THANHLY_DTO.ThanhLyID = int.Parse(ThanhLyID);
            return PHIEUTHANHLY_DAL.phieuthanhly_thongtin(THANHLY_DTO);
        }

    }
    public class CTTHANHLY_BLL
    {
        CTTHANHLY_DAL CTTHANHLY_DAL = new CTTHANHLY_DAL();
        public IEnumerable<CTTHANHLY> ctthanhly_danhsach(string ThanhLyID)
        {
            THANHLY THANHLY = new THANHLY();
            THANHLY.ThanhLyID = int.Parse(ThanhLyID);
            return CTTHANHLY_DAL.ctthanhly_danhsach(THANHLY);
        }
    }

    //Phiếu thu hồi
    public class PHIEUTHUHOI_BLL
    {
        PHIEUTHUHOI_DAL PHIEUTHUHOI_DAL = new PHIEUTHUHOI_DAL();
        public THUHOI THUHOI_DTO { get; set; }
        public List<CTTHUHOI> LST_CTTHUHOI { get; set; }
        //
        public PHIEUTHUHOI_BLL()
        {
            THUHOI_DTO = new THUHOI();
            LST_CTTHUHOI = new List<CTTHUHOI>();
        }
        public IEnumerable<THUHOI> phieuthuhoi_danhsach()
        {
            return PHIEUTHUHOI_DAL.phieuthuhoi_danhsach();
        }
        public int phieuthuhoi_them()
        {
            return PHIEUTHUHOI_DAL.phieuthuhoi_them(THUHOI_DTO,LST_CTTHUHOI);
        }
        public int phieuthuhoi_sua(string ThuHoiID)
        {
            THUHOI_DTO.ThuHoiID = int.Parse(ThuHoiID);
            return PHIEUTHUHOI_DAL.phieuthuhoi_sua(THUHOI_DTO, LST_CTTHUHOI);
        }
        public int phieuthuhoi_xoa(string ThuHoiID)
        {
            THUHOI_DTO.ThuHoiID = int.Parse(ThuHoiID);
            return PHIEUTHUHOI_DAL.phieuthuhoi_xoa(THUHOI_DTO);
        }
        public THUHOI phieuthuhoi_thongtin(string ThuHoiID)
        {
            THUHOI_DTO.ThuHoiID = int.Parse(ThuHoiID);
            return PHIEUTHUHOI_DAL.phieuthuhoi_thongtin(THUHOI_DTO);
        }
    }
    public class CTTHUHOI_BLL
    {
        CTTHUHOI_DAL CTTHUHOI_DAL = new CTTHUHOI_DAL();
        public IEnumerable<CTTHUHOI> ctthuhoi_danhsach(string ThuHoiID)
        {
            THUHOI THUHOI = new THUHOI();
            THUHOI.ThuHoiID = int.Parse(ThuHoiID );
            return CTTHUHOI_DAL.ctthuhoi_danhsach(THUHOI);
        }
    }

    //Phiếu kiểm kê
    public class PHIEUKIEMKE_BLL
    {
        PHIEUKIEMKE_DAL PHIEUKIEMKE_DAL = new PHIEUKIEMKE_DAL();
        public KIEMKE KIEMKE_DTO { get; set; }
        public List<CTKIEMKE> LST_CTKIEMKE { get; set; }
        public List<DAIDIENKIEMKE> LST_DD_KK { get; set; }

        public PHIEUKIEMKE_BLL()
        {
            KIEMKE_DTO = new KIEMKE();
            LST_CTKIEMKE = new List<CTKIEMKE>();
            LST_DD_KK = new List<DAIDIENKIEMKE>();
        }

        //
        public IEnumerable<KIEMKE> phieukiemke_danhsach()
        {
            return PHIEUKIEMKE_DAL.phieukiemke_danhsach();
        }
        public int phieukiemke_them()
        {
            int kq= PHIEUKIEMKE_DAL.phieukiemke_them(KIEMKE_DTO, LST_DD_KK, LST_CTKIEMKE);
            if (kq > 0)
            {
                new NHATKITRUYCAP_BLL().nhatkitruycap_them("Kiểm kê: ID=" + KIEMKE_DTO.KiemKeID.ToString() + ";Ngày=" + KIEMKE_DTO.NgayKiemKe.Value.Date.ToString("dd/MM/yyyy"));
            }
            return kq;
        }
        public int phieukiemke_sua(string KiemKeID)
        {
            KIEMKE_DTO.KiemKeID = int.Parse(KiemKeID);
            string ngaykiemke = new PHIEUKIEMKE_BLL().phieukiemke_thongtin(KiemKeID).NgayKiemKe.Value.Date.ToString("dd/MM/yyyy");
            int kq = PHIEUKIEMKE_DAL.phieukiemke_sua(KIEMKE_DTO, LST_DD_KK, LST_CTKIEMKE);
            if (kq > 0)
            {
                new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh phiếu kiểm kê:ID=" + KIEMKE_DTO.KiemKeID.ToString() + ";Ngày kiểm kê:"+ngaykiemke);
            }
            return kq;
        }
        public int phieukiemke_xoa(string KiemKeID)
        {
            KIEMKE_DTO.KiemKeID = int.Parse(KiemKeID);
            return PHIEUKIEMKE_DAL.phieukiemke_xoa(KIEMKE_DTO);
        }
        public KIEMKE phieukiemke_thongtin(string KiemKeID)
        {
            KIEMKE_DTO.KiemKeID = int.Parse(KiemKeID);
            return PHIEUKIEMKE_DAL.phieukiemke_thongtin(KIEMKE_DTO);
        }
    }
    public class CTKIEMKE_BLL
    {
        CTKIEMKE_DAL CTKIEMKE_DAL = new CTKIEMKE_DAL();
        KIEMKE KIEMKE = new KIEMKE();
        public IEnumerable<CTKIEMKE> ctkiemke_danhsach(string KiemKeID)
        {
            KIEMKE.KiemKeID = int.Parse(KiemKeID);
            return CTKIEMKE_DAL.ctkiemke_danhsach(KIEMKE);
        }
    }
    public class DAIDIENKIEMKE_BLL
    {
        DAIDIENKIEMKE_DAL DD_KK = new DAIDIENKIEMKE_DAL();
        KIEMKE KIEMKE = new KIEMKE();
        public IEnumerable<DAIDIENKIEMKE> ddkiemke_danhsach(string KiemKeID)
        {
            KIEMKE.KiemKeID = int.Parse(KiemKeID);
            return DD_KK.ddkiemke_danhsach(KIEMKE);
        }
    }
}
