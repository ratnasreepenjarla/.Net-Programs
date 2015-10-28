<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessionweb.aspx.cs" Inherits="SessionManagement.Sessionweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <asp:Button ID="btnsend" runat="server" OnClick="btnsend_Click" Text="send" />
        <p>
            <asp:Label ID="lblcount" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
