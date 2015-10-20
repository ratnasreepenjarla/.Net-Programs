<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validations.aspx.cs" Inherits="Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>sample</title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
    <div > 
        
        
        
        <table>
        <tr>
            <td class="labels"  >id </td>
           <td class="labels" ><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator  ID ="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3"></asp:RequiredFieldValidator></td>
      </tr>
        <tr>
          <td class="labels"> password</td>
          <td class="labels" > <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox></td>
           <td><asp:RequiredFieldValidator  ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4"></asp:RequiredFieldValidator></td>
          </tr>  <asp:ValidationSummary Visible="true" ID="ValidationSummary1" runat="server" />
       <tr>
           <td colspan="2">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="txtsave" /></td></tr>
           </table>
</div>
        
    </form>
</body>
</html>
