<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>

    <table align="center">
        <tr><td><asp:Label ID="LoginId" runat="server" Text="LoginId"></asp:Label></td></tr>
         <tr>
            <td><asp:Label ID="lblName" runat="server" Text="Nmae"></asp:Label></td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblUserName" runat ="server" Text="UserName"></asp:Label></td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblpassword" runat="server" Text="password"></asp:Label></td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblConfirmPassword" runat="server" Text="ConfirmPassword"></asp:Label></td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label></td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber"></asp:Label></td>
            <td><asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label></td>
           <td> <asp:DropDownList ID="DropDownList1" runat="server">
               <asp:ListItem>select</asp:ListItem>
               <asp:ListItem>Waht is Your Nick Nmae</asp:ListItem>
               <asp:ListItem>What is Your First School Name</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Favourite Colour</asp:ListItem>
               </asp:DropDownList></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label></td>
            <td><asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
        </tr>
            
    </table>
</div>
    </asp:Content>
