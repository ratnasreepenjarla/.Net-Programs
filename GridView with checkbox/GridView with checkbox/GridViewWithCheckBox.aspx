<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewWithCheckBox.aspx.cs" Inherits="GridView_with_checkbox.GridViewWithCheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SYS-PC;Initial Catalog=Employee;Integrated Security=True"
         SelectCommand="select * from Emp" DeleteCommand="delete Emp where empno=@eno">--%>
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:Button ID="btndelete" runat="server" Text="Delete" />
        <asp:CheckBox ID="checkall" runat="server" Text="Select All" AutoPostBack="true" />
        <br />
        <asp:Label ID="lblmsg" runat="server">



        </asp:Label>

    
    </div>
    </form>
</body>
</html>
