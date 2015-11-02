<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator1.aspx.cs" Inherits="EmpRegistration_asp_.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
       
        
    <table>
        <tr><td><asp:TextBox ID="txtstatus" runat="server" Width="160px" BorderColor="#CC0066"></asp:TextBox><br />
        <asp:TextBox ID="txtresult" runat="server" Width="160px" BorderColor="#CC0066"></asp:TextBox></td></tr>
        
  <tr><td>
        <asp:Button ID="btn1" runat="server" Text="1" BorderColor="#CC0066" ForeColor="#333333" Width="33px" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="2" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
        <asp:Button ID="btnadd" runat="server" Text="+" Width="57px" BackColor="#80FFFF" BorderColor="#CC0066" OnClick="btnadd_Click" />
    </td></tr> 
        <tr><td>
            <asp:Button ID="btn4" runat="server" Text="4" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
            <asp:Button ID="btn5" runat="server" Text="5" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
            <asp:Button ID="btn6" runat="server" Text="6" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
            <asp:Button ID="btnsub" runat="server" Text="-" BackColor="#FF66CC" style="margin-bottom: 0px; height: 26px;" Width="57px" BorderColor="#CC0066" OnClick="btnsub_Click" />
      </td></tr>
      <tr><td>
        <asp:Button ID="btn7" runat="server" Text="7" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
        <asp:Button ID="btn8" runat="server" Text="8" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
        <asp:Button ID="btn9" runat="server" Text="9" Width="33px" BorderColor="#CC0066" OnClick="btn1_Click" />
        <asp:Button ID="btnmul" runat="server" Text="*" BackColor="#FFFF80" Width="57px" BorderColor="#CC0066" OnClick="btnmul_Click" />
   </td></tr>
     <tr><td>
            <asp:Button ID="btn0" runat="server" Text="0" Width="38px" BorderColor="#CC0066" OnClick="btn1_Click" />
            <asp:Button ID="btncalculate" runat="server" Text="=" Width="66px" BackColor="#FFCC00" BorderColor="#CC0066" OnClick="btncalculate_Click" />
           <asp:Button ID="btndiv" runat="server" Text="/" Width="57px" BackColor="#66FF66" Height="26px" BorderColor="#CC0066" OnClick="btndiv_Click" />
    </td></tr>
         <tr><td>
             <asp:Button ID="btnReset" runat="server" Text="Reset" BorderColor="#CC0066" style="margin-left: 0px" Width="170px" BackColor="Fuchsia" ForeColor="White" OnClick="btnReset_Click" />
          </td></tr>    

       </table>
    </div>
    </form>
</body>
</html>
