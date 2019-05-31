<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> PROFILE </h1>
    <div>
        <div>
             <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Name" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Email" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_password" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Gender" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Birthdate" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Phone" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_Address" runat="server" Text=""></asp:Label>
             <br />
             <asp:Label ID="lbl_role" runat="server" Text=""></asp:Label>
             <br />
       </div>
        <asp:Button ID="btn_back" runat="server" Text="Back" OnClick="btn_back_Click" />
    </div>
    </form>
</body>
</html>
