<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridviewselectedindex.aspx.cs" Inherits="GridViewSelectedindex.Gridviewselectedindex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:TemplateField HeaderText="id">
                    <ItemTemplate>
                        <asp:Label ID="lblid" runat="server" Text='<%#Eval("aid")%> '/>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="name">
                    <ItemTemplate>
                        <asp:Label ID="lblname" runat="server" Text='<%#Eval("aname")%> '/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
        <asp:Label ID="lblidname" runat="server" ></asp:Label>
         <asp:Label ID="lblname1" runat="server"></asp:Label>    
    </div>
    </form>
</body>
</html>
