<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridviewinsert.aspx.cs" Inherits="GridViewinsert.Gridviewinsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbleno" runat="server" Text="eno"></asp:Label>
        <asp:TextBox ID="txteno" runat="server" ></asp:TextBox>
    
       </div> 
        
         <div>
          <asp:Label ID="lblename" runat="server" Text="ename"></asp:Label>
         <asp:TextBox ID="txtename" runat="server" Height="16px"></asp:TextBox>
        </div>
       
           <div>   
            <asp:Label ID="lblsalary" runat="server" Text="salary"></asp:Label>
            <asp:TextBox ID="txtsalary" runat="server" Height="16px"></asp:TextBox>
        </div>

         <div>
             <asp:Button ID="btninsert" Text="insert"  runat="server" OnClick="btninsert_Click" /> 
     
       </div> 

    </form>
</body>
</html>
