<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>

    <table align="center">
        <caption>Registration Form</caption>
        <tr><td><asp:Label ID="LoginId" runat="server" Text="LoginId"></asp:Label></td>
            <td><asp:TextBox ID="txtLoginid" runat="server" ReadOnly="True" ></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblUserName" runat ="server" Text="UserName"></asp:Label></td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="UserName is manditory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="lblpassword" runat="server" Text="password"></asp:Label></td>
            <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblConfirmPassword" runat="server" Text="ConfirmPassword"></asp:Label></td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtConfirmPassword" ErrorMessage="password and Confirm Password must be Equal" ForeColor="Red"></asp:CompareValidator>
             </td>
        </tr>
         <tr>
            <td><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label></td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="incorrect format" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
             </td>
        </tr>
         <tr>
            <td><asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber"></asp:Label></td>
            <td><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label></td>
           <td> <asp:DropDownList ID="ddlSelectQuestion" runat="server">
               <asp:ListItem>select</asp:ListItem>
               <asp:ListItem>Waht is Your Nick Nmae</asp:ListItem>
               <asp:ListItem>What is Your First School Name</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Home Town</asp:ListItem>
               <asp:ListItem>What is Your Favourite Colour</asp:ListItem>
               </asp:DropDownList>
               <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="ddlSelectQuestion" ErrorMessage="select anyone from the list" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label></td>
            <td><asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAnswer" ErrorMessage="please enter answer for the question" ForeColor="#FF3300"></asp:RequiredFieldValidator>
             </td>
        </tr>
        <tr>
            <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td>
        </tr>
            
    </table>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
</div>
</asp:Content>

