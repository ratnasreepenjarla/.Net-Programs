<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="databasecreation.aspx.cs" Inherits="Databasecreation.databasecreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbldbname" runat="server" Text="enterdbname"></asp:Label>
    
        <asp:TextBox ID="txtdbname" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="btncreatedatabase" runat="server" Text="createdatabase" OnClick="btncreatedatabase_Click" />
    </form>
</body>
</html>
