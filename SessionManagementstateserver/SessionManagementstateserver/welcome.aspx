<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="SessionManagementstateserver.wlcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="linkid" runat="server" align="right" >LinkButton</asp:LinkButton>
    
    </div>
        <asp:Label ID="lblmessage" runat="server"></asp:Label>
        <asp:Button ID="btnlogout" runat="server" OnClick="btnlogout_Click" Text="logout" />
    </form>
</body>
</html>
