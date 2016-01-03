<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="UploadProject.aspx.cs" Inherits="Users_UploadProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <caption>UploadProject</caption>
        <tr>
            <td><asp:Label ID="lblprojectid" runat="server" Text="Project Id"></asp:Label></td>
            <td><asp:TextBox ID="txtprojectid" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblprojecttype" runat="server" Text="Project Type"></asp:Label></td>
            <td><asp:TextBox ID="txtprojecttype" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lbluploadaproject" runat="server" Text="Upload a Project"></asp:Label></td>
            <td> <asp:FileUpload ID="FileUpload1" runat="server" />  </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnuploadproject" runat="server" Text="Upload Project" OnClick="btnuploadproject_Click" /></td>
        </tr>
    </table>
</asp:Content>

