<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="querystringasp.logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblid" runat="server"></asp:Label>
    
    </div>
        <asp:Label ID="lblpswd" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnlogout" runat="server" OnClick="btnlogout_Click" Text="logout" />
        </p>
    </form>
</body>
</html>
