<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hiddenfield.aspx.cs" Inherits="Hiddenfieldasp.Hiddenfield" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HiddenField ID="HiddenField1" runat="server" />
    
    </div>
        <asp:Label ID="lblname" runat="server"></asp:Label>
        <p>
            <asp:Label ID="lblpswd" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="submit" />
        </p>
        <asp:Label ID="lblhiddenvalue" runat="server"></asp:Label>
    </form>
</body>
</html>
