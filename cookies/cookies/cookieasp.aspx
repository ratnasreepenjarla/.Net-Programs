<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookieasp.aspx.cs" Inherits="cookies.cookieasp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblid" runat="server" Text="id"></asp:Label>
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="login" />
        </p>
    </form>
</body>
</html>
