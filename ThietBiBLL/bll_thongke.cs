using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ThietBiDAL;

namespace ThietBiBLL
{

    //Giá trị thiết bị
    public class GTTHIETBI_BLL
    {
        public GTTHIETBI GTTHIETBI_DTO { get; set; }
        GTTHIETBI_DAL GTTHIETBI_DAL = new GTTHIETBI_DAL();

        public GTTHIETBI_BLL() { GTTHIETBI_DTO = new GTTHIETBI(); }
        public IEnumerable<GTTHIETBI> gtthietbi_danhsach()
        {
            return GTTHIETBI_DAL.gtthietbi_danhsach();
        }
        public int gtthietbi_macabiet(string GTThietBiID)
        {
            GTTHIETBI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return GTTHIETBI_DAL.gtthietbi_macabiet(GTTHIETBI_DTO);
        }
        public GTTHIETBI gtthietbi_thongtin(string GTThietBiID)
        {
            GTTHIETBI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return GTTHIETBI_DAL.gtthietbi_thongtin(GTTHIETBI_DTO);
        }
    }

    //Sổ theo dõi
    public class SOTHEODOI_BLL
    {
        public SOTHEODOI SOTHEODOI_DTO { get; set; }
        public DONVI DONVI_DTO { get; set; }
        public GTTHIETBI GTTHIETBI_DTO { get; set; }
        public BOPHAN BOPHAN_DTO { get; set; }

        SOTHEODOI_DAL SOTHEODOI_DAL = new SOTHEODOI_DAL();

        public SOTHEODOI_BLL()
        {
            DONVI_DTO = new DONVI();
            BOPHAN_DTO = new BOPHAN();
            GTTHIETBI_DTO = new GTTHIETBI();
            SOTHEODOI_DTO = new SOTHEODOI();
        }
        public IEnumerable<SOTHEODOI> sotheodoi_danhsach()
        {
            return SOTHEODOI_DAL.sotheodoi_danhsach();
        }

        public int sotheodoi_danhgialai(string GTThietBiID)
        {
            SOTHEODOI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return SOTHEODOI_DAL.sotheodoi_danhgialai(SOTHEODOI_DTO);
        }
        public SOTHEODOI sotheodoi_kiemtrathietbi(string DonViID, string GTThietBiID)
        {
            DONVI_DTO.DonViID = int.Parse(DonViID);
            GTTHIETBI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return SOTHEODOI_DAL.sotheodoi_kiemtrathietbi(DONVI_DTO, GTTHIETBI_DTO);
        }
        public SOTHEODOI sotheodoi_kiemtrathietbi(string DonViID,string BoPhanID, string GTThietBiID)
        {
            DONVI_DTO.DonViID = int.Parse(DonViID);
            BOPHAN_DTO.BoPhanID = int.Parse(BoPhanID);
            GTTHIETBI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return SOTHEODOI_DAL.sotheodoi_kiemtrathietbi(DONVI_DTO,BOPHAN_DTO,GTTHIETBI_DTO);
        }
        public SOTHEODOI sotheodoi_chitietthietbi(string GTThietBiID)
        {
            GTTHIETBI_DTO.GTThietBiID = Int64.Parse(GTThietBiID);
            return SOTHEODOI_DAL.sotheodoi_chitietthietbi(GTTHIETBI_DTO);
        }
    }
}
