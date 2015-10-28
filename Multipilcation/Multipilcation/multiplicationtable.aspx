<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiplicationtable.aspx.cs" Inherits="Multipilcation.multiplicationtable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
        <asp:Label ID="lblentertnumber" runat="server" Text="entertnumber"></asp:Label>
         <asp:TextBox ID="txtentertnumber" runat="server"></asp:TextBox>
   </div>
   <div>
        <asp:Label ID="lblenterrange" runat="server" Text="enterrange"></asp:Label>
        <asp:TextBox ID="txtenterrange" runat="server"></asp:TextBox>
  </div>
  <div>
        <asp:Button ID="btnDisplayTable" runat="server" Text="DisplayTable" OnClick="btnsave_Click" />
   </div>
    
    
        
        
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    
        
        
    </form>
</body>
</html>
