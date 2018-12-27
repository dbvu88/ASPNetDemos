<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataDemo.aspx.cs" Inherits="DataDemo.DataDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ComicBookGalleryConnectionString %>" SelectCommand="SELECT * FROM [Series]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Title" HeaderText="ComicTitle" SortExpression="Title" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
