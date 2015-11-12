<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkbox2.aspx.cs" Inherits="Checkboxcontrol.checkbox2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:CheckBox ID="checktelugu" runat="server" Text="telugu" OnCheckedChanged="language" AutoPostBack="true" />
        <asp:CheckBox ID="checkenglish" runat="server" Text="english" OnCheckedChanged="language" AutoPostBack="true" />
        <asp:CheckBox ID="checkhindi" runat="server" Text="hindi" OnCheckedChanged="language" />
    
    </div>
       
        <p>
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </p>
  
    </form>
</body>
</html>
