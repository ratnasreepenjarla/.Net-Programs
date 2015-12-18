<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewWithCheckBox.aspx.cs" Inherits="GridView_with_checkbox.GridViewWithCheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SYS-PC;Initial Catalog=Employee;Integrated Security=True"
         SelectCommand="select * from Emp" DeleteCommand="delete Emp where empno=@eno">--%>
        
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="true">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="check" runat="server" />
                    </ItemTemplate>
           

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btndelete" runat="server" Text="Delete" />
        <asp:CheckBox ID="checkall" runat="server" Text="Select All" AutoPostBack="true" />
        <br />
        <asp:Label ID="lblmsg" runat="server">



        </asp:Label>

    
    </div>
    </form>
</body>
</html>
