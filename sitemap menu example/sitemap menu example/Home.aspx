<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="sitemap_menu_example.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />
        <asp:Menu ID="Menu1" runat="server"  DataSourceID="SiteMapDataSource1" Orientation="Horizontal">
            
        </asp:Menu>
    </div>
    </form>
</body>
</html>
