<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatalistControl.aspx.cs" Inherits="Datalistcontrol.DatalistControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="5" RepeatDirection="Horizontal" CellPadding="3" CellSpacing="1">
            <HeaderTemplate>
                Emp Information
            </HeaderTemplate>
            <ItemTemplate>
               emp name:
                <asp:Label ID="lblempno" runat="server" Text='<%#Eval("name")%>'></asp:Label><br />
               
                 emp email
                <asp:Label ID="lblemail" runat="server" Text='<%#Eval("email")%>'></asp:Label><br />
                  
                emp phnum
                <asp:Label ID="lblphnum" runat="server" Text='<%#Eval("phnum")%>'></asp:Label><br />

                 emp gender
                <asp:Label ID="lblgender" runat="server" Text='<%#Eval("Gender")%>'></asp:Label><br />
                 
                empusername
                <asp:Label ID="lblusername" runat="server" Text='<%#Eval("username")%>'></asp:Label><br />

                emp password
                 <asp:Label ID="lblpassword" runat="server" Text='<%#Eval("password")%>'></asp:Label><br />

                emp cpassword
                 <asp:Label ID="lblcpassword" runat="server" Text='<%#Eval("cpassword")%>'></asp:Label><br />

                

                


            </ItemTemplate>
        </asp:DataList>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True" SelectCommand="select *from Employees"></asp:SqlDataSource>
    </form>
</body>
</html>
