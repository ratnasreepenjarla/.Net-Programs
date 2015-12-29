<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="SearchArticle.aspx.cs" Inherits="Users_SearchArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        <table>
            <tr>
                <td><asp:Label ID="lblKeywordforarticle" runat="server" Text="KeyWord"></asp:Label></td>
                <td><asp:TextBox ID="txtkeywordforarticle" runat="server"></asp:TextBox></td>
               <td><asp:ImageButton ID="searcharticle" runat="server" ImageUrl="~/Images/search.jpg" Width="30" Height="30" OnClick="searcharticle_Click" /></td>
            </tr>
        </table>
    </div>
    <div align="center">
        <asp:GridView ID="SearchArticlesGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ArticleType" HeaderText="ArticleType" SortExpression="ArticleType" />
                <asp:BoundField DataField="ArticleDescription" HeaderText="ArticleDescription" SortExpression="ArticleDescription" />
                <asp:BoundField DataField="CDate" HeaderText="PostedDate" SortExpression="CDate" />
                <asp:BoundField DataField="UserName" HeaderText="PostedBy" SortExpression="UserName" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

