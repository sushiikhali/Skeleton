<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml%22%3E
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" Height="15px" Text="Order Number" Width="121px"></asp:Label>
</body>
</html>
    <asp:TextBox ID="txtOrderNumber" runat="server" Width="130px"></asp:TextBox>
    <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    <p>
        <asp:Label ID="lblOrderName" runat="server" Height="15px" Text="Order Name " Width="120px"></asp:Label>
        <asp:TextBox ID="txtOrderName" runat="server" Width="130px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="130px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblOrderPrice" runat="server" Height="15px" Text="Order Price" Width="120px"></asp:Label>
        <asp:TextBox ID="txtOrderPrice" runat="server" Width="130px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblOrderAmount" runat="server" Height="15px" Text="Order Amount" Width="120px"></asp:Label>
        <asp:TextBox ID="txtOrderAmount" runat="server" Width="130px"></asp:TextBox>
    </p>
    <asp:CheckBox ID="chkDispatched" runat="server" Height="15px" Text="Dispatched?" TextAlign="Left" Width="120px" />
    <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="50px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </p>
</form>
