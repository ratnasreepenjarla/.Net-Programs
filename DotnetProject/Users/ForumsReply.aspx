<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="ForumsReply.aspx.cs" Inherits="Users_ForumsReply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div align="center">
        <table>
            <tr>
                <td>Question:<asp:Label ID="lblgetquestion" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblanswer" runat="server" Text="Answer"></asp:Label></td>
                <td><asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                 <td></td>
                <td><asp:Button ID="btnPostReply" runat="server" Text="PostReply"  OnClick="btnPostReply_Click"/></td>
            </tr>
        </table>
        <asp:Label ID="lblreply" runat="server"></asp:Label>
       </div>
</asp:Content>

