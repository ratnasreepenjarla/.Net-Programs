<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="sitemap_and_sitemappath__Control.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="SiteMap:"></asp:Label>

<asp:SiteMapPath ID="SiteMapPath1" runat="server">
</asp:SiteMapPath>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Click here to
go to Home page</asp:HyperLink>
</asp:Content>
