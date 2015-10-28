<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Applicationweb.aspx.cs" Inherits="SessionManagement.Applicationweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="save" />
    <div>
    
    </div>
        <asp:Label ID="lblcount" runat="server"></asp:Label>
    </form>
</body>
</html>
