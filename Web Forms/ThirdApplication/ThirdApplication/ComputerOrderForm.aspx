<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComputerOrderForm.aspx.cs" Inherits="ThirdApplication.ComputerOrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Computer Order</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Computer Order" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="OrderID" runat="server" Text="Order ID = "></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Order Name:"></asp:Label>
            <asp:TextBox ID="OrderName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Customer:"></asp:Label>
            <asp:TextBox ID="Customer" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Customer Email:"></asp:Label>
            <asp:TextBox ID="CustomerEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Delivery Date"></asp:Label>
            <asp:Calendar ID="DeliveryDate" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Part Number:"></asp:Label>
            <asp:TextBox ID="PartNumber" runat="server" Width="37px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Rush?"></asp:Label>
            <asp:RadioButton ID="RushYes" runat="server" GroupName="Rush" Text="Yes" />
            <asp:RadioButton ID="RushNo" runat="server" Checked="True" GroupName="Rush" Text="No" />
            <br />
            <asp:Button ID="Submit" type="submit" runat="server" Text="OK" OnClick="Submit_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
