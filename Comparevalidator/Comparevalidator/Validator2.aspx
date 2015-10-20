<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator2.aspx.cs" Inherits="Comparevalidator.Validator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
  </title>
   <style>
       .labels
       {
           color:cyan;
       }

     table
       {
           background-image:url("img/Webpage_Background_by_kierun.jpg")
       }
   </style>
</head>
<body>
    <form id="form1"  runat="server" style=" ">
    <div>
        <table>
            <tr>
                <td class="labels"> password</td>
               <td class="labels"><asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                   
                </td></tr>
            <tr>
                <td class="labels"> confirmpassword</td>
                <td class="labels"><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>  
            <tr><td colspan="2">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="equal" /></td></tr>
            </table>
        <asp:CompareValidator ID="CompareValidator1" ControlToValidate="TextBox2"  ControlToCompare="TextBox1" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>

    </div>
     
    </form>
</body>
</html>
