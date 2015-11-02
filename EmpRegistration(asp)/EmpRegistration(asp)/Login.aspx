<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmpRegistration_asp_.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <table>
            <tr>
                <td> <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label></td>
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
                <td> <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSignin" runat="server" Text="Signin" OnClick="btnSignin_Click" /></td>
                   <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnSignUp" runat="server" Text="SignUp" OnClick="btnSignUp_Click" />
                </td>
            </tr>
        </table>
    
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </asp:Content>