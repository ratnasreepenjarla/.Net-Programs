<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="ForgetPassword.aspx.cs" Inherits="ForgetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table>
       <caption>Forget Password</caption>
       <br /><br />
        <tr>
            <td><asp:Label ID="lblUserName" runat ="server" Text="UserName"></asp:Label></td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td></tr>
       <tr>
            <td><asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label></td>
           <td> <asp:DropDownList ID="ddlSelectQuestion" runat="server">
               <asp:ListItem>select</asp:ListItem>
               <asp:ListItem>Waht is Your Nick Nmae</asp:ListItem>
               <asp:ListItem>What is Your First School Name</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Favourite Colour</asp:ListItem>
               </asp:DropDownList>
               <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label></td>
            <td><asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox></td>   
     
        </tr>
       <tr>
            <td></td>
            <td><asp:Button ID="btnGetPassword" runat="server" Text="GetPassword" OnClick="btnGetPassword_Click"/></td>
        </tr>
    </table>
    <div align="center">
        <asp:Label ID="lblforgetpswd" runat="server"></asp:Label>
    </div>

</asp:Content>

