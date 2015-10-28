<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="input.aspx.cs" Inherits="Multipilcation.Redirect" %>

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
       </form>
</body>
</html>
