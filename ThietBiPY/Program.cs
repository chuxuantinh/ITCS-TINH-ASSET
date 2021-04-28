using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ThietBiPY.HeThong;
using ThietBiDAL;
using ThietBiBLL;

using ThietBiPY.NghiepVu;
using ThietBiPY.DanhMuc.thongtinthietbi;
using ThietBiPY.BaoCao_ThongKe.thongkethietbi;
using ThietBiPY.BaoCao_ThongKe;
using ThietBiPY.DanhMuc;
using ThietBiPY.BaoCao_ThongKe.report;

namespace ThietBiPY
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LopHoTro.CAUHINHREGISTRY Reg = new ThietBiPY.LopHoTro.CAUHINHREGISTRY();
            LopHoTro.CHUYENKIEU MaHoa = new ThietBiPY.LopHoTro.CHUYENKIEU();

            //
            string chuoiketnoi = "";
            string Server="",Database="",UserID="",Pwd="";
            Server = MaHoa.Mahoa2Mahoa(Reg.laykhoa("Server"));
           
            //
            if (Server != "")
            {
                Database = MaHoa.Mahoa2Mahoa(Reg.laykhoa("Database"));
                UserID = MaHoa.Mahoa2Mahoa(Reg.laykhoa("User ID"));
                Pwd = MaHoa.Mahoa2Mahoa(Reg.laykhoa("Password"));

                //
                chuoiketnoi = "Server=" + Server + ";Database=" + Database + (UserID != ""?(";User ID=" + UserID + ";Password=" + Pwd):";Trusted_Connection=True;");
                HETHONGBLL HETHONG = new HETHONGBLL();
                if (HETHONG.KetNoi(chuoiketnoi) == 1)
                {
                    HETHONG.ThongSo(Server, Database, UserID, Pwd);
                    SingleInstance.SingleApplication.Run(new frm_nguoidung("dangnhap"));
                    return;
                }
            }
            SingleInstance.SingleApplication.Run(new frm_ketnoiserver());
        }
    }
}
