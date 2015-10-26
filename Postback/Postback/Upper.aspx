<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upper.aspx.cs" Inherits="Postback.Upper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
         <div>
        <asp:Label ID="lblentertext" runat="server" Text="enter your text"></asp:Label>
        <asp:TextBox ID="txtentertext" runat="server" OnTextChanged="txtentertext_TextChanged" AutoPostBack="true"></asp:TextBox>
        </div>

         <div>
             <asp:Label ID="lbloutput1" runat="server" Text="output1"></asp:Label>
             <asp:TextBox ID="txtoutput1" runat="server"></asp:TextBox>
    </div>
        <div>

            <asp:Label ID="lbloutput2" runat="server" Text="output2"></asp:Label>
            <asp:TextBox ID="txtoutput2" runat="server"></asp:TextBox>

    </div>
   
    </form>
   

    

    </body>
</html>
