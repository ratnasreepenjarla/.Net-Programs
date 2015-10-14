<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Studentreg.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
   
   .name
   {
       color:;
   }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="name" runat="server" Text="name" CssClass="name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
       
        

    </div>
        <asp:Label ID="Label1" runat="server" Text="phnum" CssClass="name"></asp:Label>
         <asp:TextBox ID="txtPhno" runat="server"></asp:TextBox>
        </div>
       <div>
         <asp:Label ID="Label2" runat="server" Text="emailid" CssClass="name"></asp:Label>
           <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
           </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender" CssClass="name"></asp:Label>
            <asp:RadioButton ID="rbmale" runat="server" Text="male" />
            <asp:RadioButton ID="rbfemale" runat="server" Text="female" />
        </div>
        <asp:Label ID="Label4" runat="server" Text="dob" CssClass="name"></asp:Label>
        <asp:DropDownList ID="ddlDate" runat="server" Height="16px">
            <asp:ListItem>Date</asp:ListItem>
             <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlmonth" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>month</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlyear" runat="server">
            <asp:ListItem>year</asp:ListItem>
            <asp:ListItem>1994</asp:ListItem>
            <asp:ListItem>1995</asp:ListItem>
            <asp:ListItem>1996</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="btnregister" runat="server" OnClick="Button1_Click" Text="Register" />
            <asp:Button ID="btnreset" runat="server" Text="reset" OnClick="btnreset_Click" />
        </p>
    </form>
</body>
</html>
