<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="querystringasp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblid" runat="server" Text="id"></asp:Label>
        <asp:TextBox ID="txtid" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
    </div>
        <asp:Label ID="lblpswd" runat="server" Text="pswd"></asp:Label>
        <asp:TextBox ID="txtpswd" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="login" />
        </p>
    </form>
</body>
</html>
