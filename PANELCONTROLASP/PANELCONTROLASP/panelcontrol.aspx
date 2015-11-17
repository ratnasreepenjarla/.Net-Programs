<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panelcontrol.aspx.cs" Inherits="PANELCONTROLASP.panelcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/ws_The_royal_entrance_2560x1920.jpg" GroupingText="sample panel" HorizontalAlign="Center" ScrollBars="Both" Direction="LeftToRight" Wrap="true" DefaultButton="btnsave" Height="400px" Width="500px">
       <table>
           <tr>
               <td colspan="2">
                   this is sample panel program 
               </td>
           </tr>
           <tr>
                   <td><asp:Label ID="ldlid" Text="id" runat="server"></asp:Label> </td>
                   <td><asp:TextBox ID="txtid" runat="server" ></asp:TextBox></td>
               
           </tr>
           <tr>
              
                    <td><asp:Label ID="lblpassword" Text="Password" runat="server"></asp:Label> </td>
                    <td> <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox> </td>
              
           </tr>
           <tr>
               
                  <td> <asp:Button ID="btnsave" Text="save" runat="server" ></asp:Button> </td>
                  <td><asp:Button ID="btncancel" Text="cancel" runat="server" /></td>
           </tr>
       </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
