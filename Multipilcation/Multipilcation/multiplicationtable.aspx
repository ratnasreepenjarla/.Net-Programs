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
        <asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click" />
   </div>
    
    
        
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    
        
        
    </form>
</body>
</html>
