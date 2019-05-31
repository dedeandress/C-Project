<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Current Password"></asp:Label>
            <asp:TextBox ID="txt_curr" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox ID="txt_new" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="txt_confirm" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btn_confirm" runat="server" Text="CONFIRM !" OnClick="btn_confirm_Click" />
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
