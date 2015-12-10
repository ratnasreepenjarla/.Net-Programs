<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="sitemap_and_sitemappath__Control.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Label ID="Label2" runat="server" Text="SiteMap:"></asp:Label>

<asp:SiteMapPath ID="SiteMapPath1" runat="server">
</asp:SiteMapPath>
<br />
<br />
   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm3.aspx">click here
to go to mywebpage2</asp:HyperLink>
</asp:Content>
