<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="sitemap_and_sitemappath__Control.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
 <asp:Label ID="Label2" runat="server" Text="sitemap:"></asp:Label>
<asp:SiteMapPath ID="SiteMapPath1" runat="server">
</asp:SiteMapPath>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">Click here to go to first page </asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm3.aspx">click here to go to second page</asp:HyperLink>
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/WebForm4.aspx">Click here to go to third page </asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/WebForm5.aspx">click here to go to fourth page</asp:HyperLink>


   </asp:Content>
