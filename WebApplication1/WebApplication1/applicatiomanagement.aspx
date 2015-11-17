<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="applicatiomanagement.aspx.cs" Inherits="WebApplication1.applicatiomanagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="lbltotalwsers">
    
        totalusers&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txttotusers" runat="server"></asp:TextBox>
    
    </div>
        Activeusers&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtactiveusers" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnDestroysession" runat="server" OnClick="btnDestroysession_Click" Text="Destroysession" />
        </p>
    </form>
</body>
</html>
