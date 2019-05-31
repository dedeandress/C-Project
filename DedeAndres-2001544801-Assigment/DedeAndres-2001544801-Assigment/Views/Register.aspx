<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txt_name" runat="server" style="margin-left: 134px" Width="180px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_password" runat="server" style="margin-left: 111px"  Width="183px" type="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label8" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="txt_conPass" runat="server" style="margin-left: 58px" Width="185px" type="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txt_email" runat="server" style="margin-left: 138px" Width="187px"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Phone"></asp:Label>
            <asp:TextBox ID="txt_phone" runat="server" style="margin-left: 134px" Width="186px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txt_address" runat="server" style="margin-left: 122px" Height="49px" Width="187px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Pick Your Birthday Date"></asp:Label>
            <asp:Calendar ID="Date_birth" runat="server" Width="278px"></asp:Calendar>
            <br />
        </div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 0px"  />
            <br />
            <br />
        </div>
        <asp:Button ID="btn_register" runat="server" Text="REGISTER!" Height="42px" Width="135px" OnClick="Button1_Click" />
        <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
