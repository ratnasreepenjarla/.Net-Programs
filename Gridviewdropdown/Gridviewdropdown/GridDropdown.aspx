<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridDropdown.aspx.cs" Inherits="Gridviewdropdown.GridDropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblselectemp" runat="server" Text="select emp"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </form>
</body>
</html>
