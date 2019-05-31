<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.addProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Add Product
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Watch Name"></asp:Label>
            <asp:TextBox ID="txt_watchName" runat="server" style="margin-left: 3px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Watch Price"></asp:Label>
            <asp:TextBox ID="txt_watchPrice" runat="server" style="margin-left: 7px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txt_stock" runat="server" style="margin-left: 45px"></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <asp:Button ID="btn_addProduct" runat="server" Text="Add Product !" OnClick="btn_addProduct_Click" />
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btn_back" runat="server" Text="Back" OnClick="btn_back_Click" />
    </div>
    </form>
</body>
</html>
