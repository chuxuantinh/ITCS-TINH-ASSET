using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace ThietBiDAL
{
    //Giá trị thiết bị
    public class GTTHIETBI_DAL
    {
        DBDataContext DB = new DBDataContext();
        public IEnumerable<GTTHIETBI> gtthietbi_danhsach()
        {
            return DB.GTTHIETBIs.OrderByDescending(c => c.CTPHIEUNHAP.PHIEUNHAP.NgayNhap);
        }
        public int gtthietbi_macabiet(GTTHIETBI GTTHIETBI)
        {
            try
            {
                var GT = DB.GTTHIETBIs.Single(c => c.GTThietBiID == GTTHIETBI.GTThietBiID);
                GT.MaCaBiet = GTTHIETBI.MaCaBiet;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public GTTHIETBI gtthietbi_thongtin(GTTHIETBI GT)
        {
            return DB.GTTHIETBIs.SingleOrDefault(c => c.GTThietBiID == GT.GTThietBiID);
        }
    }

    //Sổ theo dõi
    public class SOTHEODOI_DAL
    {
        DBDataContext DB = new DBDataContext();
        public IEnumerable<SOTHEODOI> sotheodoi_danhsach()
        {
            return DB.SOTHEODOIs;
        }
        public SOTHEODOI sotheodoi_kiemtrathietbi(DONVI DONVI,GTTHIETBI GTTB)
        {
            return DB.SOTHEODOIs.SingleOrDefault (c=>c.DonViSD==DONVI.DonViID && c.GTThietBiID==GTTB.GTThietBiID);
        }
        public SOTHEODOI sotheodoi_kiemtrathietbi(DONVI DONVI,BOPHAN BOPHAN, GTTHIETBI GTTB)
        {
            return DB.SOTHEODOIs.SingleOrDefault(c => c.DonViSD == DONVI.DonViID && c.BoPhanSD==BOPHAN.BoPhanID && c.GTThietBiID == GTTB.GTThietBiID);
        }

        //
        public int sotheodoi_danhgialai(SOTHEODOI STD)
        {
            try
            {
                var STD_SUA = DB.SOTHEODOIs.Single(c => c.GTThietBiID == STD.GTThietBiID);
                STD_SUA.DonViSD = STD.DonViSD;
                STD_SUA.BoPhanSD = STD.BoPhanSD;
                STD_SUA.TinhTrang = STD.TinhTrang;
                STD_SUA.HienTrang = STD.HienTrang;
                DB.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public SOTHEODOI sotheodoi_chitietthietbi(GTTHIETBI GTTHIETBI)
        {
            return DB.SOTHEODOIs.SingleOrDefault(c => c.GTThietBiID == GTTHIETBI.GTThietBiID);
        }
    }

}
