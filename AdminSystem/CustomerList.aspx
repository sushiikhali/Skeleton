<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="348px" Width="435px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="57px" OnClick="btnAdd_Click" Text="Add" Width="84px" />
            <asp:Button ID="btnEdit" runat="server" Height="57px" OnClick="btnEdit_Click" Text="Edit" Width="81px" />
            <asp:Button ID="btnDelete" runat="server" Height="57px" OnClick="btnDelete_Click" Text="Delete" Width="84px" />
        </p>
        <p>
            Enter an Address<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
