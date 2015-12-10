<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Onetier.aspx.cs" Inherits="Onetier.Onetier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="lblsalary" runat="server" Text="salary"></asp:Label>
        <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lbldeptname" runat="server" Text="deptname"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Button ID="btninsert" runat="server" OnClick="btninsert_Click" Text="insert" />
    </form>
</body>
</html>
