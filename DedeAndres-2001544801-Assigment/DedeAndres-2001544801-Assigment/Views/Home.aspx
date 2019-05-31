<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="lbl_username" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />
        </div>
        <div>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Height="200px" Width="560px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID"/>
                <asp:BoundField DataField="WatchName" HeaderText="Watch Name"/>
                <asp:BoundField DataField="WatchPrice" HeaderText="WatchPrice"/>
                <asp:BoundField DataField="Stock" HeaderText="Stock(s)"/>
            </Columns>
        </asp:GridView>
        </div>
        <div>
            <asp:Button ID="btn_profile" runat="server" Text="Profile" OnClick="btn_profile_Click" />
            <asp:Button ID="btn_changePass" runat="server" Text="Change Password" OnClick="btn_changePass_Click" />
            <asp:Button ID="btn_product" runat="server" Text="Manage Product" OnClick="btn_product_Click" />
            <asp:Button ID="btn_user" runat="server" Text="View Member" OnClick="btn_user_Click" />
        </div>
        </div>
    </form>
</body>
</html>
