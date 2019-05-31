<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="DedeAndres_2001544801_Assigment.Views.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div>
          <div>
              <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label>
              <br />
              <asp:Label ID="lbl_price" runat="server" Text=""></asp:Label>
              <br />
              <asp:Label ID="lbl_stock" runat="server" Text=""></asp:Label>
              <br />
          </div>
             <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Watch Name"></asp:Label>
            <asp:TextBox ID="txt_watchName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Watch Price"></asp:Label>
            <asp:TextBox ID="txt_watchPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txt_stock" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <asp:Button ID="btn_Update" runat="server" Text="Update !" OnClick="btn_Update_Click" />
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
        <br />
      </div>  
    </div>
    </form>
</body>
</html>
