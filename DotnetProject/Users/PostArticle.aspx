<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="PostArticle.aspx.cs" Inherits="Users_PostArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center">
        <tr>
            <td><asp:Label ID="lblArticleId" Text="ArticleId" runat="server"></asp:Label></td>
            <td><asp:TextBox ID="txtArticleIdd" runat="server" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblArticleType" runat="server" Text="ArticleType"></asp:Label></td>
            <td><asp:TextBox ID="txtArticleType" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblArticleDescrption" runat="server" Text="Descrption"></asp:Label></td>
            <td><asp:TextBox ID="txtArticleDescrption" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>

        <tr>
          <td></td>
        <td><asp:Button ID="btnPostArticle" runat="server" Text="PostArticle" OnClick="btnPostArticle_Click"/></td>
      </tr>
        
    </table>
    <div align="center">
        <asp:Label ID="lblpostedArticle" runat="server"></asp:Label>
    </div>
</asp:Content>

