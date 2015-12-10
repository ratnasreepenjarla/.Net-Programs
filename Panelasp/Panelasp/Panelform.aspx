<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panelform.aspx.cs" Inherits="Panelasp.Panelform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="update">
            <asp:Label ID="lblselectempname" runat="server" Text="select empname"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
       
        <asp:Label ID="lblenternewsalary" runat="server" Text="enternewname"></asp:Label>

        <asp:TextBox ID="txtentername" runat="server"></asp:TextBox><br />

       
            <asp:Button ID="btnupdate" runat="server" Text="update" OnClick="btnupdate_Click" />
       
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
             </asp:Panel>
    
    </div>
    </form>
</body>
</html>
