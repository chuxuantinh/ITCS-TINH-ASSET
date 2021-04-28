using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThietBiDAL;
namespace ThietBiBLL
{
    public class HETHONGBLL
    {
        HETHONGDAL HETHONGDAL = new HETHONGDAL();
        //
        public void ThongSo(string Server, String Database, String userName, String passWord)
        {
            HETHONGDAL.Server = Server;
            HETHONGDAL.dataBase = Database;
            HETHONGDAL.userName = userName;
            HETHONGDAL.passWord = passWord;
        }
        //
        public int KetNoi(string chuoiketnoi)
        {
           return HETHONGDAL.KetNoi(chuoiketnoi);
        }
        public void NgatKetNoi()
        {
            HETHONGDAL.NgatKetNoi();
        }
        public bool KiemTraKetNoi()
        {
            return HETHONGDAL.KiemTraKetNoi();
        }
        public string TenServer()
        {
            return HETHONGDAL.TenServer();
        }

        public string TenTaiKhoan()
        {
            return HETHONGDAL.TaiKhoan;
        }
        public string TenCSDL()
        {
             return HETHONGDAL.TenCSDL; 
        }
        public string TenPC()
        {
            return HETHONGDAL.TenPC();
        }
        public string LayUSerID()
        {
            return HETHONGDAL.userName;
        }
        public string LayPwd()
        {
           return HETHONGDAL.passWord;
        }

        //
        public List<string> DanhSachServer()
        {
            return HETHONGDAL.DanhSachServer();
        }
        public List<string> DanhSachCSDL(int kieu, string serverName, string userName, String password)
        {
            return HETHONGDAL.DanhSachCSDL(kieu,serverName,userName,password);
        }

        //
        public void SaoLuu(String serverName, String databaseName, String userName, String password, String Path)
        {
            HETHONGDAL.SaoLuu(serverName, databaseName, userName, password, Path);
        }
        public void PhucHoi(String serverName, String databaseName, String userName, String password, String Path)
        {
            HETHONGDAL.PhucHoi(serverName, databaseName, userName, password, Path);
        }
        //


    }

    //nhật kí truy cập
    public class NHATKITRUYCAP_BLL
    {
        NHATKITRUYCAP_DAL TRUYCAP_DAL = new NHATKITRUYCAP_DAL();
        public NHATKITRUYCAP TRUYCAP_DTO { get; set; }
        //
        public NHATKITRUYCAP_BLL() { TRUYCAP_DTO = new NHATKITRUYCAP(); }

        public IEnumerable<NHATKITRUYCAP> nhatkitruycap_danhsach()
        {
            return TRUYCAP_DAL.nhatkitruycap_danhsach();
        }
        public int nhatkitruycap_them(string noidung)
        {
            HETHONGBLL HETHONG = new HETHONGBLL();
            TRUYCAP_DTO.NguoiDung = HETHONG.TenTaiKhoan();
            TRUYCAP_DTO.NoiDung = noidung;
            TRUYCAP_DTO.Server = HETHONG.TenServer();
            TRUYCAP_DTO.DiaChiMAC = HETHONG.TenPC();
            TRUYCAP_DTO.ThoiGian = DateTime.Now;
            return TRUYCAP_DAL.nhatkitruycap_them(TRUYCAP_DTO);
        }
        public int nhatkitruycap_xoa(string TruyCapID)
        {
            TRUYCAP_DTO.TruyCapID = int.Parse(TruyCapID);
            return TRUYCAP_DAL.nhatkitruycap_xoa(TRUYCAP_DTO);
        }
        public int nhatkitruycap_xoa(List<NHATKITRUYCAP> LST_NK)
        {
            return TRUYCAP_DAL.nhatkitruycap_xoa(LST_NK);
        }
    }

    //người dùng
    public class NGUOIDUNG_BLL
    {
        NGUOIDUNG_DAL NGUOIDUNG_DAL = new NGUOIDUNG_DAL();
       public NGUOIDUNG NGUOIDUNG_DTO {get;set;}

       public NGUOIDUNG_BLL() { NGUOIDUNG_DTO = new NGUOIDUNG(); }
        //
       public IEnumerable<NGUOIDUNG> nguoidung_danhsach()
       {
           return NGUOIDUNG_DAL.nguoidung_danhsach();
       }
        public int nguoidung_them()
        {
            int kq= NGUOIDUNG_DAL.nguoidung_them(NGUOIDUNG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Thêm người dùng: ID=" + NGUOIDUNG_DTO.NguoiDungID.ToString() + ";TK=" + NGUOIDUNG_DTO.TaiKhoan);
            return kq;
        }
        public int nguoidung_sua(string NguoiDungID)
        {
            NGUOIDUNG_DTO.NguoiDungID = Int64.Parse(NguoiDungID);
            string TaiKhoan = nguoidung_thongtin_ID(NguoiDungID).TaiKhoan;

            int kq = NGUOIDUNG_DAL.nguoidung_sua(NGUOIDUNG_DTO);
            if (kq > 0) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Hiệu chỉnh người dùng: ID" + NguoiDungID + ";Tài khoản:" + TaiKhoan + "-->" + NGUOIDUNG_DTO.TaiKhoan);
            return kq;
        }
        public NGUOIDUNG nguoidung_thongtin_ID(string NguoiDungID)
        {
            NGUOIDUNG_DTO.NguoiDungID = Int64.Parse(NguoiDungID);
            return NGUOIDUNG_DAL.nguoidung_thongtin_ID(NGUOIDUNG_DTO);
        }

        public NGUOIDUNG nguoidung_thongtin_TK(string TK)
        {
            NGUOIDUNG_DTO.TaiKhoan = TK;
            return NGUOIDUNG_DAL.nguoidung_thongtin_TK(NGUOIDUNG_DTO);
        }

        //
        public NGUOIDUNG nguoidung_kiemtranhanvien(string NhanVienID)
        {
            NGUOIDUNG_DTO.NhanVienID = Int64.Parse(NhanVienID);
            return NGUOIDUNG_DAL.nguoidung_kiemtranhanvien(NGUOIDUNG_DTO);
        }
        public int nguoidung_kiemtrataikhoan(string TaiKhoan)
        {
            NGUOIDUNG_DTO.TaiKhoan = TaiKhoan;
            return NGUOIDUNG_DAL.nguoidung_kiemtrataikhoan(NGUOIDUNG_DTO);
        }
        public int nguoidung_dangnhap(string TaiKhoan, string MatKhau)
        {
            NGUOIDUNG_DTO.TaiKhoan = TaiKhoan;
            NGUOIDUNG_DTO.MatKhau = MatKhau.Trim();

            int kq= NGUOIDUNG_DAL.nguoidung_dangnhap(NGUOIDUNG_DTO);
            if (kq == 4) new NHATKITRUYCAP_BLL().nhatkitruycap_them("Đăng nhập với người dùng:" + TaiKhoan);
                return kq;
        }
        public int nguoidung_doimatkhau(string NguoiDungID)
        {
            NGUOIDUNG_DTO.NguoiDungID = Int64.Parse(NguoiDungID);
            return NGUOIDUNG_DAL.nguoidung_doimatkhau(NGUOIDUNG_DTO);
        }
        public int nguoidung_capquyen(string NguoiDungID)
        {
            NGUOIDUNG_DTO.NguoiDungID = Int64.Parse(NguoiDungID);
            return NGUOIDUNG_DAL.nguoidung_capquyen(NGUOIDUNG_DTO);
        }
        
        //
    }
}
