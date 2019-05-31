<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMember.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.ViewMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Height="200px" Width="560px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID"/>
                <asp:BoundField DataField="Name" HeaderText="Name"/>
                <asp:BoundField DataField="Email" HeaderText="Email"/>
                <asp:BoundField DataField="Password" HeaderText="Password"/>
                <asp:BoundField DataField="Gender" HeaderText="Gender"/>
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate"/>
                <asp:BoundField DataField="ProfilePic" HeaderText="Profile Picture"/>
                <asp:BoundField DataField="Phone" HeaderText="Phone Number"/>
                <asp:BoundField DataField="Address" HeaderText="Address"/>
                <asp:BoundField DataField="Role" HeaderText="Role"/>
                <asp:ImageField DataImageUrlField=ProfilePic HeaderText="Profile Pic"><//asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txt_find" runat="server"></asp:TextBox>
        <asp:LinkButton ID="link_role" runat="server" OnClick="link_role_Click" >Change Role</asp:LinkButton>
        <asp:LinkButton ID="link_delete" runat="server" OnClick="link_delete_Click" >Delete</asp:LinkButton>
    </div>
    </form>
</body>
</html>
