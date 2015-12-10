<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customvalidator.aspx.cs" Inherits="CustomValidator.Customvalidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblenterpswd" runat="server" Text="enter pswd"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="passwordshould have 6 characters" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <p>
            <asp:Button ID="btnsubmit" runat="server" Text="submit" />
        </p>
    </form>
</body>
</html>
