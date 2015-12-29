<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UsersHome.master" AutoEventWireup="true" CodeFile="ViewAllQuestions.aspx.cs" Inherits="Users_ViewAllQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="ViewAllQuariesGrid" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="replylink" runat="server" NavigateUrl='<%#Eval("QuestionId","~/users/ForumsReply.aspx?QuestionId={0}") %>' Text="select"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
            <asp:BoundField DataField="UserName" HeaderText="PostedBy" SortExpression="UserName" />
        </Columns>
     
    </asp:GridView>
</asp:Content>

    