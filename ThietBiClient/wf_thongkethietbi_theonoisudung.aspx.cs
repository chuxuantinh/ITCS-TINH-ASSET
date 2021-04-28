using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using ThietBiDAL;
using ThietBiBLL;

namespace ThietBiClient
{
    public partial class wf_thongkethietbi_theonoisudung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                danhmuc_donvi();
            }
        }

        public void danhmuc_donvi()
        {
            var DV = new DONVI_BLL().donvi_danhsach().Select(c => new
            {
                DonViID=c.DonViID,
                TenDonVi=c.TenDonVi,
            }).ToList();

           
            this.drop_lst_donvi.DataSource = DV;
            this.drop_lst_donvi.DataValueField = "DonViID";
            this.drop_lst_donvi.DataTextField = "TenDonVi";
            this.drop_lst_donvi.DataBind();
        }
        public void danhmuc_thietbi(string DonViID)
        {
         //   this.grv_thietbi.DataSource = null;
            var TB = new SOTHEODOI_BLL().sotheodoi_danhsach().Where (c=>c.DonViSD==int.Parse(DonViID)).Select(c => new
            {
                MaCaBiet=c.GTTHIETBI.MaCaBiet,
                TenThietBi=c.GTTHIETBI.THIETBI.TenThietBi,
                TinhTrang=(c.TinhTrang!=0?c.TINHTRANG1.TenTinhTrang:"Chưa xác định"),
            }).ToList();
            this.grv_thietbi.DataSource = TB;
            this.grv_thietbi.DataBind();
        }

        protected void drop_lst_donvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.drop_lst_donvi.SelectedIndex >= 0)
            {
                //Response.Write ("<script>alert('"+this.drop_lst_donvi.SelectedValue.ToString()+"')</script>");
                danhmuc_thietbi(this.drop_lst_donvi.SelectedValue.ToString());
            }
        }
    }
}
