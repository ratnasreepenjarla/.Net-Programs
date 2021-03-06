﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imagecontrol1.aspx.cs" Inherits="Imagecontrolasp.imagecontrol1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Width="126px" ToolTip="yellow flowers" AlternateText="give correct path"/>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Confirmpassword" HeaderText="Confirmpassword" SortExpression="Confirmpassword" />
                <asp:BoundField DataField="Emailid" HeaderText="Emailid" SortExpression="Emailid" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                <asp:BoundField DataField="Joining" HeaderText="Joining" SortExpression="Joining" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" DeleteCommand="DELETE FROM [EmpRegistration] WHERE [ID] = @ID" InsertCommand="INSERT INTO [EmpRegistration] ([Name], [UserName], [Password], [Confirmpassword], [Emailid], [PhoneNumber], [Gender], [DOB], [Designation], [Joining]) VALUES (@Name, @UserName, @Password, @Confirmpassword, @Emailid, @PhoneNumber, @Gender, @DOB, @Designation, @Joining)" SelectCommand="SELECT * FROM [EmpRegistration]" UpdateCommand="UPDATE [EmpRegistration] SET [Name] = @Name, [UserName] = @UserName, [Password] = @Password, [Confirmpassword] = @Confirmpassword, [Emailid] = @Emailid, [PhoneNumber] = @PhoneNumber, [Gender] = @Gender, [DOB] = @DOB, [Designation] = @Designation, [Joining] = @Joining WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Confirmpassword" Type="String" />
                <asp:Parameter Name="Emailid" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="DOB" Type="String" />
                <asp:Parameter Name="Designation" Type="String" />
                <asp:Parameter Name="Joining" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Confirmpassword" Type="String" />
                <asp:Parameter Name="Emailid" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="DOB" Type="String" />
                <asp:Parameter Name="Designation" Type="String" />
                <asp:Parameter Name="Joining" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
