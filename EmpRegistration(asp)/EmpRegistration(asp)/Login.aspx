<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmpRegistration_asp_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>

        <link href="StyleSheet1.css" rel="stylesheet">
       
  
</head>
<body>
    <form id="form1"  runat="server">
        <br />
        <br />
    <div>
      <table align="center">
          <caption class="A">
              Login Form
          </caption>
            <tr>
                <td> <asp:Label ID="lblUserName" CssClass="A" runat="server" Text="UserName"></asp:Label></td>
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" CssClass="A" runat="server"  Text="Password"></asp:Label></td>
                <td> <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSignin" runat="server" Text="Signin" OnClick="btnSignin_Click" /></td>
                   <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnSignUp" runat="server" Text="SignUp" OnClick="btnSignUp_Click" />
                </td>
            </tr>
            <tr align="center">
                <br />
                <td colspan="2"><asp:Label ID="lblMessage"  runat="server"></asp:Label>
    </td>
            </tr>
        </table>
    </div >
        </form>
    <p>
        &nbsp;</p>
</body>
</html>
