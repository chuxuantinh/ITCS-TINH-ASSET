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
    public partial class frm_dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (IsPostBack)
            {
                int kq = new NGUOIDUNG_BLL().nguoidung_dangnhap(Login1.UserName, Login1.Password);
                switch (kq)
                {
                    case 4:
                        Response.Write("<script>alert('Thành công');</script>");
                        Response.Redirect("~/Default.aspx");
                        break;
                    case 1:
                        Response.Write("<script>alert('Tài khoản không tồn tại');</script>");
                        break;

                    case 2:
                        Response.Write("<script>alert('Chưa được cấp quyền truy cập hệ thống');</script>");
                        break;
                    case 3:
                        Response.Write("<script>alert('Sai mật khẩu');</script>");
                        break;
                }
            }
        }
    }
}
