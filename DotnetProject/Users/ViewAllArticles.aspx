<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="ViewAllArticles.aspx.cs" Inherits="Users_ViewAllArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        <asp:GridView ID="SearchArticlesGrid" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="ArticleType" HeaderText="ArticleType" SortExpression="ArticleType" />
                <asp:BoundField DataField="ArticleDescription" HeaderText="ArticleDescription" SortExpression="ArticleDescription" />
                <asp:BoundField DataField="CDate" HeaderText="PostedDate" SortExpression="CDate" />
                <asp:BoundField DataField="UserName" HeaderText="PostedBy" SortExpression="UserName" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

