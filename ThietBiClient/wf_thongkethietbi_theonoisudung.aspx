<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wf_thongkethietbi_theonoisudung.aspx.cs" Inherits="ThietBiClient.wf_thongkethietbi_theonoisudung" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 154px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        

        <asp:DropDownList ID="drop_lst_donvi" runat="server" AutoPostBack="True" 
            Height="20px" onselectedindexchanged="drop_lst_donvi_SelectedIndexChanged" 
            Width="240px">
        </asp:DropDownList>
        <asp:GridView ID="grv_thietbi" runat="server">
        </asp:GridView>

    </div>
    </form>
</body>
</html>
