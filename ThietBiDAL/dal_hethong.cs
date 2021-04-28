using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.ComponentModel;

using System.Data.Linq.Mapping;
using System.Data.Common;
using System.Security.Cryptography;

namespace ThietBiDAL
{
    //hệ thống
    public class HETHONGDAL
    {
        DBDataContext DB = null;
        public static string TaiKhoan; //account sử dụng hệ thống
        public static string Server;
        public static string dataBase;
        public static string userName; //account kết nối Server
        public static string passWord;

        public int KetNoi(string chuoiketnoi)
        {
            try
            {
                DB = new DBDataContext();
                DB.Connection.ConnectionString = chuoiketnoi;
                DB.Connection.Open();
                return 1;
            }
            catch (Exception kn)
            {
                Console.WriteLine(kn.Message);
                return 0;
            }
     
        }
        public void NgatKetNoi()
        {
            DB.Connection.Close();
        }
        public bool KiemTraKetNoi()
        {
            if (DB.Connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        
        //
        public string TenServer()
        {
            DB = new DBDataContext();
            return DB.Connection.DataSource.ToString();
        }
        public string TenCSDL
        {
            get
            {
                DB = new DBDataContext();
               return DB.Connection.Database.ToString();
            }
        }
   
        public string TenPC()
        {
            int j = 0;
            string kq = "";
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            PhysicalAddress address = nics[j].GetPhysicalAddress();
            byte[] bytes = address.GetAddressBytes();

            for (int i = 0; i < bytes.Length; i++)
            {
                kq += string.Format("{0}", bytes[i].ToString("X2"));
                if (i != bytes.Length - 1)
                {
                    kq += "-";
                }
            }
            return System.Net.Dns.GetHostName()+": "+kq;
        }

        public List<string> DanhSachServer()
        {
            SQLDMO.NameList sqlServers = null;
            SQLDMO.Application sqlApp = new SQLDMO.ApplicationClass();

            sqlServers = sqlApp.ListAvailableSQLServers();
            List<string> LST_SERVER = new List<string>();
            if (sqlServers.Count > 0)
            {
                for (int i = 0; i < sqlServers.Count; i++)
                    LST_SERVER.Add(sqlServers.Item(i + 1));
            }
            return LST_SERVER;
        }
        public List<string> DanhSachCSDL(int kieu,string serverName, string userName, String password)
        {
            string chuoiketnoi = "";
            List<string> LST_CSDL = new List<string>();
            switch (kieu)
            {
                case 0:
                    chuoiketnoi = "Server=" + serverName + ";Database=master;Trusted_Connection=True;";
                    break;
                case 1:
                    chuoiketnoi = "Server=" + serverName + ";Database=master;User ID=" + userName + ";Password=" + password;
                    break;
            }
            DBDataContext DB = new DBDataContext(chuoiketnoi);
            var GT = DB.ExecuteQuery<DANHSACHCSDL>("SP_DATABASES").ToList<DANHSACHCSDL>();
            if (GT.Count > 0)
            {
                foreach (var T in GT)
                {
                    LST_CSDL.Add(T.tenCSDL);
                }
            }
            return LST_CSDL;
        }

        [Table(Name = "DANHSACHCSDL")]
        public class DANHSACHCSDL
        {
            [Column(Name="DATABASE_NAME")]
           public string tenCSDL { get; set; }
            [Column(Name="DATABASE_SIZE")]
           public int kichthuocCSDL { get; set; }
        }
        //
        public void SaoLuu(String serverName, String databaseName, String userName, String password, String Path)
        {
     try
			{
                //create an instance of a server class
                SQLDMO._SQLServer srv = new SQLDMO.SQLServerClass();
                //connect to the server
                srv.Connect(serverName, userName, password);
                //create a backup class instance
                SQLDMO.Backup bak = new SQLDMO.BackupClass();
                //set the backup device = files property ( easy way )
                bak.Devices = bak.Files;
                //set the files property to the File Name text box
                bak.Files = Path;
                //set the database to the chosen database
                bak.Database = databaseName;
                //perform the backup
                bak.SQLBackup(srv);
			}
			catch(Exception err)
			{			
				Console.WriteLine(err.Message,"Error");
			}
        }
        public void PhucHoi(String serverName, String databaseName, String userName, String password, String Path)
        {
            try
            {
                if (DB.Connection.State == System.Data.ConnectionState.Open) DB.Connection.Close();
                //create an instance of a server class
                SQLDMO._SQLServer srv = new SQLDMO.SQLServerClass();
                //connect to the server
                srv.Connect(serverName, userName, password);
                //create a restore class instance
                SQLDMO.Restore res = new SQLDMO.RestoreClass();
                //set the backup device = files property ( easy way )
                res.Devices = res.Files;
                //set the files property to the File Name text box
                res.Files = Path;
                //set the database to the chosen database
                res.Database = databaseName;
                // Restore the database
                res.ReplaceDatabase = true;
                res.SQLRestore(srv);
                srv.DisConnect();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message, "Error");
            }
        }
    }

    //nhóm quyền
    public enum NHOMQUYEN
    {
        QuanTri=1,
        DonViQuanLy=2,
        DonViSuDung=3,
        KeToan=4,
        NhanVien=5,
    }

    //lịch sử truy cập
    public class NHATKITRUYCAP_DAL
    {
        DBDataContext DB = new DBDataContext();
        public IEnumerable<NHATKITRUYCAP> nhatkitruycap_danhsach()
        {
            return from c in DB.NHATKITRUYCAPs orderby c.ThoiGian descending select c;
        }
        public int nhatkitruycap_them(NHATKITRUYCAP NK)
        {
            try
            {
                DB.NHATKITRUYCAPs.InsertOnSubmit(NK);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhatkitruycap_xoa(NHATKITRUYCAP NK)
        {
            NHATKITRUYCAP TRUYCAP_XOA = DB.NHATKITRUYCAPs.Single(c => c.TruyCapID == NK.TruyCapID);
            try
            {
                DB.NHATKITRUYCAPs.DeleteOnSubmit(TRUYCAP_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nhatkitruycap_xoa(List<NHATKITRUYCAP> NK)
        {
            try
            {
                DB.Connection.Open();
                DbTransaction trs = DB.Connection.BeginTransaction();
                DB.Transaction = trs;
                DB.NHATKITRUYCAPs.AttachAll(NK);
                DB.NHATKITRUYCAPs.DeleteAllOnSubmit(NK);
                DB.SubmitChanges();
                DB.Transaction.Commit();
                return 1;
            }
            catch (Exception log)
            {
                Console.WriteLine(log.Message);
                DB.Transaction.Rollback();
                return 0;
            }
        }
    }

    //Người dùng
    public class NGUOIDUNG_DAL
    {
        DBDataContext DB = new DBDataContext();

        //
        public string StringToMD5(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        //
        public int nguoidung_them(NGUOIDUNG NGUOIDUNG)
        {
            try
            {
                NGUOIDUNG.MatKhau = StringToMD5(NGUOIDUNG.MatKhau.ToUpper().Trim());
                DB.NGUOIDUNGs.InsertOnSubmit(NGUOIDUNG);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int nguoidung_sua(NGUOIDUNG NGUOIDUNG)
        {
            var ND_SUA = DB.NGUOIDUNGs.Single(c => c.NguoiDungID == NGUOIDUNG.NguoiDungID);
            ND_SUA.TaiKhoan = NGUOIDUNG.TaiKhoan;
            ND_SUA.MatKhau = StringToMD5(NGUOIDUNG.MatKhau.Trim().ToUpper ());
            ND_SUA.Quyen = NGUOIDUNG.Quyen;
            ND_SUA.NhanVienID = NGUOIDUNG.NhanVienID;
            ND_SUA.Quyen = NGUOIDUNG.Quyen;

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
        public int nguoidung_xoa(NGUOIDUNG NGUOIDUNG)
        {
            var ND_XOA = DB.NGUOIDUNGs.Single(c => c.NguoiDungID == NGUOIDUNG.NguoiDungID);
            try
            {
                DB.NGUOIDUNGs.DeleteOnSubmit(ND_XOA);
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public NGUOIDUNG nguoidung_thongtin_ID(NGUOIDUNG NGUOIDUNG)
        {
            return DB.NGUOIDUNGs.SingleOrDefault(c => c.NguoiDungID == NGUOIDUNG.NguoiDungID);
        }

        public NGUOIDUNG nguoidung_thongtin_TK(NGUOIDUNG NGUOIDUNG)
        {
            return DB.NGUOIDUNGs.SingleOrDefault(c => c.TaiKhoan == NGUOIDUNG.TaiKhoan);
        }

        public IEnumerable<NGUOIDUNG> nguoidung_danhsach()
        {
            return DB.NGUOIDUNGs.OrderBy(c => c.TaiKhoan);
        }
        public int nguoidung_kiemtrataikhoan(NGUOIDUNG NGUOIDUNG)
        {
            var ND_KT = DB.NGUOIDUNGs.SingleOrDefault(c => c.TaiKhoan.ToUpper().Equals(NGUOIDUNG.TaiKhoan.ToUpper()));
            if (ND_KT != null) return 1;//Tài khoản này đã có người dùng
            return 2;//Chưa đăng kí
        }
        public NGUOIDUNG nguoidung_kiemtranhanvien(NGUOIDUNG NGUOIDUNG)
        {
            var ND_KT_NV = DB.NGUOIDUNGs.SingleOrDefault(c => c.NhanVienID == NGUOIDUNG.NhanVienID);
            return ND_KT_NV;
        }

        //
        public int nguoidung_dangnhap(NGUOIDUNG NGUOIDUNG)
        {
            var ND_DN_TK = DB.NGUOIDUNGs.SingleOrDefault(c => c.TaiKhoan.ToUpper().Equals(NGUOIDUNG.TaiKhoan.ToUpper()));
            if (ND_DN_TK == null)
            {
                return 1;//tài khoản không tồn tại
            }
            else
            {
                if (ND_DN_TK.TrangThai == false)
                {
                    return 2;// Chưa được cấp quyền truy cập hệ thống
                }
                else if (ND_DN_TK.MatKhau != StringToMD5(NGUOIDUNG.MatKhau.ToUpper()))
                {
                    Console.WriteLine(StringToMD5(NGUOIDUNG.MatKhau.ToUpper()));
                    return 3;//Sai mật khẩu
                }
            }
            HETHONGDAL.TaiKhoan = NGUOIDUNG.TaiKhoan;
            return 4;//Thành công
        }
        public int nguoidung_doimatkhau(NGUOIDUNG NGUOIDUNG)
        {
            var ND_DMK = DB.NGUOIDUNGs.Single(c => c.NguoiDungID == NGUOIDUNG.NguoiDungID);
            ND_DMK.MatKhau = StringToMD5(NGUOIDUNG.MatKhau.ToUpper());
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
        public int nguoidung_capquyen(NGUOIDUNG NGUOIDUNG)
        {
            var ND_SUA = DB.NGUOIDUNGs.Single(c => c.NguoiDungID == NGUOIDUNG.NguoiDungID);
            ND_SUA.TaiKhoan = NGUOIDUNG.TaiKhoan;
            ND_SUA.TrangThai = NGUOIDUNG.TrangThai;
            ND_SUA.Quyen = NGUOIDUNG.Quyen;

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
        //
    }
}
