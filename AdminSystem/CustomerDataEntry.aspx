<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerID" runat="server" Height="15px" Text="Customer Number " Width="121px"></asp:Label>
</body>
</html>
    <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
    <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    <p>
        <asp:Label ID="lblCustomerName" runat="server" Height="15px" Text="Customer Name " Width="120px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="lblCustomerEmail" runat="server" Height="15px" Text="Customer Email" Width="120px"></asp:Label>
    <asp:TextBox ID="txtCustomerEmail" runat="server" OnTextChanged="txtCustomerEmail_TextChanged" style="margin-bottom: 0px"></asp:TextBox>
    <p>
        <asp:Label ID="lblCustomerDOB" runat="server" Height="15px" Text="Customer DOB" Width="120px"></asp:Label>
        <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblCustomerAdress" runat="server" Height="15px" Text="Customer Address" Width="120px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
    </p>
    <asp:CheckBox ID="chkIsOver18" runat="server" Height="15px" Text="Over 18?" TextAlign="Left" Width="120px" />
    <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="50px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
    </p>
</form>
