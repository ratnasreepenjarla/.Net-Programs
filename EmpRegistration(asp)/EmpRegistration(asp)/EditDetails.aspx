﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditDetails.aspx.cs" Inherits="EmpRegistration_asp_.EditDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table align="center" >
           <tr>
                <td><asp:Label ID="lblName" runat="server" Text="Name" CssClass="A"></asp:Label></td>
                <td class="auto-style1"> <asp:TextBox ID="txtName"   placeholder="Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Please enter Name" CssClass="Error"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z]+$" runat="server" ErrorMessage="Name contains alphabets only" CssClass="Error"></asp:RegularExpressionValidator>
                </td>
          </tr>

           <tr>
                <td><asp:Label ID="lblUserName" runat="server" Text="UserName" CssClass="A"></asp:Label></td>
                <td class="auto-style1"> <asp:TextBox ID="txtUserName" runat="server" ReadOnly="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtUserName" runat="server" ErrorMessage="enter Username" CssClass="Error"></asp:RequiredFieldValidator></td>
          </tr>
        <tr>
            <td><asp:Label ID="lblEmailid" runat="server" Text="Emailid" CssClass="A"></asp:Label></td>
            <td class="auto-style1"><asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtEmailid"   runat="server" ErrorMessage="enter Emailid" CssClass="Error"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtEmailid" ValidationExpression="^[a-zA-Z0-9]+@+[a-z]+.+[com]$" runat="server" ErrorMessage="Emaail should be in correct format" CssClass="Error"></asp:RegularExpressionValidator>
                
            </td>
       </tr>
       <tr>

            <td><asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber" CssClass="A"></asp:Label></td>
            <td> <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtPhoneNumber" runat="server" ErrorMessage="enter Phonenumber" CssClass="Error"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtPhoneNumber" ValidationExpression="^[0-9]{10}" runat="server" ErrorMessage="phonenumber should be digits only and length 10" CssClass="Error"></asp:RegularExpressionValidator>
              </td>
        </tr>
       <tr>
           <td><asp:Label ID="lblGender" runat="server" Text="Gender" CssClass="A"></asp:Label>
           </td>
           <td> <asp:RadioButton GroupName="Gender" ID="rbMale" runat="server" Text="Male" CssClass="A" /> &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:RadioButton GroupName="Gender" ID="rbFemale" runat="server" Text="Female" CssClass="A" /></td>
       </tr>
   <tr>
       <td class="auto-style2"> <asp:Label ID="lblDOB" runat="server" Text="DOB" CssClass="A"></asp:Label></td>
       <td class="auto-style2"><asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox></td>
   </tr>
    <tr>
        <td class="auto-style1"><asp:Label ID="lblDesignation" runat="server" Text="Designation" CssClass="A"></asp:Label></td>
        <td class="auto-style1"> 
        <asp:DropDownList ID="DdlDesignation" runat="server">
            <asp:ListItem>Sr.Developer</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Jr.Developer</asp:ListItem>
            <asp:ListItem>Manager</asp:ListItem>
        </asp:DropDownList></td>
    </tr>
     <tr>
         <td><asp:Label ID="lblJoining" runat="server" Text="Joining" CssClass="A"></asp:Label></td>
         <td><asp:TextBox ID="txtJoining" runat="server" TextMode="Date"></asp:TextBox></td>
     </tr>
     <tr>
         <td>&nbsp;</td>
         <td>&nbsp;</td>
     </tr>
     <tr>
         <td></td>
         <td><asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
         </td>
     </tr>

    </table> 
    <asp:Label ID="lblMessage" runat="server" CssClass="Error"></asp:Label>
        
        
</asp:Content>
