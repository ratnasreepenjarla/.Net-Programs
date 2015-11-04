<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EmpRegistration_asp_.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div align="center" class="A">Employee Details</div>
    <br /><br /><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="EmpDetails">
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
    <asp:SqlDataSource ID="EmpDetails" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" DeleteCommand="DELETE FROM [EmpRegistration] WHERE [ID] = @ID" InsertCommand="INSERT INTO [EmpRegistration] ([Name], [UserName], [Password], [Confirmpassword], [Emailid], [PhoneNumber], [Gender], [DOB], [Designation], [Joining]) VALUES (@Name, @UserName, @Password, @Confirmpassword, @Emailid, @PhoneNumber, @Gender, @DOB, @Designation, @Joining)" SelectCommand="SELECT * FROM [EmpRegistration]" UpdateCommand="UPDATE [EmpRegistration] SET [Name] = @Name, [UserName] = @UserName, [Password] = @Password, [Confirmpassword] = @Confirmpassword, [Emailid] = @Emailid, [PhoneNumber] = @PhoneNumber, [Gender] = @Gender, [DOB] = @DOB, [Designation] = @Designation, [Joining] = @Joining WHERE [ID] = @ID">
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
   <table>
       <tr>
           <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click"  />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" /></td></tr></table>
    
</asp:Content>
