<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridviewdelete.aspx.cs" Inherits="Gridviewdelete.Gridviewdelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel1" GroupingText="Delete" runat="server">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="btndelete" runat="server" Text="delete" OnClick="btndelete_Click" />
        </asp:Panel>
    </form>
</body>
</html>
