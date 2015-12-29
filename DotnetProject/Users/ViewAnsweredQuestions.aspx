<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="ViewAnsweredQuestions.aspx.cs" Inherits="Users_ViewAnsweredQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="ViewAnsweredQuestionGrid" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
            <asp:BoundField DataField="Reply" HeaderText="Reply" SortExpression="Reply" />
            <asp:BoundField DataField="UserName" HeaderText="PosteBy" SortExpression="UserName" />
        </Columns>
    </asp:GridView>
</asp:Content>

