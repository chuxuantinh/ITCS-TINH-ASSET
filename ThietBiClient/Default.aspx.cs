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

namespace ThietBiClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

              Label1 .Text =  (Request.Form["txt_nguoidung"]);

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/wf_thongkethietbi_theonoisudung.aspx");
        }
    }
}
