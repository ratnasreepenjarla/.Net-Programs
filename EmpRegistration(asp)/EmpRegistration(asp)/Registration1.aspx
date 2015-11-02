<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration1.aspx.cs" Inherits="EmpRegistration_asp_.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 642px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
           <tr>
                <td><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
                <td class="auto-style1"> <asp:TextBox ID="txtName"   placeholder="Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Please enter Name"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z]+$" runat="server" ErrorMessage="Name contains alphabets only"></asp:RegularExpressionValidator>
                </td>
          </tr>

           <tr>
                <td><asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label></td>
                <td class="auto-style1"> <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtUserName" runat="server" ErrorMessage="enter Username"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>-
              <td><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
              <td class="auto-style1"> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="ReqireFieldValidator3" ControlToValidate="txtPassword" runat="server" ErrorMessage="enter password"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtPassword" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$" runat="server" ErrorMessage="Pawwsord has 1 uppercase,1 lowrcase,1 Specialsymbol,1 digi&& length between 8-15"></asp:RegularExpressionValidator>
              </td>
         </tr>
         <tr>
             <td><asp:Label ID="lblConfirmPassword" runat="server" Text="ConfirmPassword"></asp:Label> </td>
             <td class="auto-style1"><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtConfirmPassword"  runat="server" ErrorMessage="enter confirmpassword"></asp:RequiredFieldValidator>
                 <asp:CompareValidator ID="CompareValidator1" ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword"  runat="server" ErrorMessage="Password and ConfirmPassword should be same" ></asp:CompareValidator></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEmailid" runat="server" Text="Emailid"></asp:Label></td>
            <td class="auto-style1"><asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtEmailid"   runat="server" ErrorMessage="enter Emailid"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtEmailid" ValidationExpression="^[a-zA-Z0-9]+@+[a-z]+.+[com]$" runat="server" ErrorMessage="Emaail should be in correct format"></asp:RegularExpressionValidator>
                
            </td>
       </tr>
       <tr>

            <td><asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber"></asp:Label></td>
            <td> <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtPhoneNumber" runat="server" ErrorMessage="enter Phonenumber"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtPhoneNumber" ValidationExpression="^[0-9]{10}" runat="server" ErrorMessage="phonenumber should be digits only and length 10"></asp:RegularExpressionValidator>
              </td>
        </tr>
       <tr>
           <td><asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
           </td>
           <td> <asp:RadioButton GroupName="Gender" ID="rbMale" runat="server" Text="Male" /> &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:RadioButton GroupName="Gender" ID="rbFemale" runat="server" Text="Female" /></td>
       </tr>
   <tr>
       <td class="auto-style2"> <asp:Label ID="lblDOB" runat="server" Text="DOB"></asp:Label></td>
       <td class="auto-style2"><asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox></td>
   </tr>
    <tr>
        <td><asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label></td>
        <td> 
        <asp:DropDownList ID="DdlDesignation" runat="server">
            <asp:ListItem>Sr.Developer</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Jr.Developer</asp:ListItem>
            <asp:ListItem>Manager</asp:ListItem>
        </asp:DropDownList></td>
    </tr>
     <tr>
         <td><asp:Label ID="lblJoining" runat="server" Text="Joining"></asp:Label></td>
         <td><asp:TextBox ID="txtJoining" runat="server" TextMode="Date"></asp:TextBox></td>
     </tr>
     <tr>
         <td>&nbsp;</td>
         <td>&nbsp;</td>
     </tr>
     <tr>
         <td></td>
         <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />&nbsp;&nbsp;&nbsp; <asp:Button ID="btnClear" runat="server" Text="Clear" Width="66px" OnClick="btnClear_Click" /></td>
     </tr>


    </table> </div>
        
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        
    </form>
        
</body>
</html>
