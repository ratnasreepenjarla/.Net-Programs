<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="PostAQuery.aspx.cs" Inherits="Users_PostAQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center">
        <tr>
            <td><asp:Label ID="lblQuestionid" Text="QuestionId" runat="server"></asp:Label></td>
            <td><asp:TextBox ID="txtQuestionId" runat="server" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblQuestion" runat="server" Text="Question"></asp:Label></td>
            <td><asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
          <td></td>
        <td><asp:Button ID="btnPostQuery" runat="server" Text="PostQuery" OnClick="btnPostQuery_Click"/></td>
      </tr>
        
    </table>
    <div align="center">
        <asp:Label ID="lblposted" runat="server"></asp:Label>
    </div>
</asp:Content>

