<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkboxcontrol.aspx.cs" Inherits="Checkboxcontrol.checkboxcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="checktelugu" runat="server" Text="telugu" />
        <asp:CheckBox ID="checkenglish" runat="server" Text="english" />
        <asp:CheckBox ID="checkhindi" runat="server" Text="hindi" />
    
    </div>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="submit" />
        <p>
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
