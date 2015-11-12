<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkboxlist.aspx.cs" Inherits="Checkboxcontrol.checkboxlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBoxList ID="checklist1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>telugu</asp:ListItem>
            <asp:ListItem>english</asp:ListItem>
            <asp:ListItem>hindi</asp:ListItem>
        </asp:CheckBoxList>
    
    </div>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </form>
</body>
</html>
