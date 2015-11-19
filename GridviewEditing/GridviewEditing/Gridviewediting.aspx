<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridviewediting.aspx.cs" Inherits="GridviewEditing.Gridviewediting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="id">
                <ItemTemplate>
                    <asp:Label ID="lblid" runat="server" Text='<%#Eval("aid")%>' />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="name">
                <ItemTemplate>
                  <%#Eval("aname") %>

                </ItemTemplate>
                 <EditItemTemplate>
                     <asp:TextBox ID="txtname" runat="server" Text='<%#Eval("aname")%>' />
                 </EditItemTemplate>

            </asp:TemplateField>
        </Columns>
        </asp:GridView>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
