<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txt_email" runat="server" style="margin-left: 70px" Width="156px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_password" runat="server"  style="margin-left: 43px" Width="156px" type="Password"></asp:TextBox>
        </div>
        <asp:CheckBox ID="chck_Remember" runat="server" />
        <asp:Button ID="btn_login" runat="server" Text="LOGIN" OnClick="btn_login_Click" />
        <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
    </div>
        
    </form>
</body>
</html>
