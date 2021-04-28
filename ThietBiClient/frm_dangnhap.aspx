<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_dangnhap.aspx.cs" Inherits="ThietBiClient.frm_dangnhap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Đăng nhập</title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
    <asp:Login ID="Login1" runat="server" BackColor="AliceBlue" 
        BorderStyle="Double" PasswordLabelText="Mật khẩu:" TitleText="Đăng nhập" 
        UserNameLabelText="Người dùng:" onauthenticate="Login1_Authenticate">
    </asp:Login>

    </form>
</body>
</html>
