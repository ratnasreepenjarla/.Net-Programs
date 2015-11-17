<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adorator.aspx.cs" Inherits="adoratorcontrol.adorator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/myadd.xml" Target="_self" />
    
    </div>
    </form>
</body>
</html>
