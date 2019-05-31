<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>WELCOME TO WOKtch!</h1>
        <div>
            <asp:Button ID="btn_login" runat="server" Text="LOGIN" Height="108px" Width="273px" onClick="btn_login_Click"/>
            <br />
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btn_register" runat="server" Text="REGISTER" Height="107px" Width="277px" OnClick="btn_register_Click" />
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btn_guest" runat="server" Text="GUEST" OnClick="btn_guest_Click" />
        </div>
    </div>
    </form>
</body>
</html>
