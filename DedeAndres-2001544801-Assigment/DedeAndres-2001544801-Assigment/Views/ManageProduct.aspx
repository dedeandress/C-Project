<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" EnableEventValidation="false" Inherits="DedeAndres_2001544801_Assigment.Views.ManageProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Button ID="btn_addProduct" runat="server" Text="AddProduct" OnClick="btn_addProduct_Click"/>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Height="200px" Width="560px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID"/>
                <asp:BoundField DataField="WatchName" HeaderText="Watch Name"/>
                <asp:BoundField DataField="WatchPrice" HeaderText="WatchPrice"/>
                <asp:BoundField DataField="Stock" HeaderText="Stock(s)"/>
                <asp:TemplateField>
                    <ItemTemplate>
                                <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click1" Text="Update" ProductID='<%# Eval("Id") %>' />
                                <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" ProductID='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
    </div>
    </form>
</body>
</html>
