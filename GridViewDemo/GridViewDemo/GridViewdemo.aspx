<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewdemo.aspx.cs" Inherits="GridViewDemo.GridViewdemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Height="263px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="422px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
