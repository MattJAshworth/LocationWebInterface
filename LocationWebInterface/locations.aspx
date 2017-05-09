<%@ Page Language="C#" AutoEventWireup="true" CodeFile="locations.aspx.cs" Inherits="locations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:SqlDataSource ID="db" runat="server" ConnectionString="<%$ ConnectionStrings:rde_514209ConnectionString %>"></asp:SqlDataSource>
		<a href="Default.aspx" class="button">Home page</a>
		<h2>Locations of all staff:</h2>
		<asp:GridView ID="users" ShowHeaderWhenEmpty="true" EmptyDataText="No staff in database" runat="server" OnRowDataBound="users_RowDataBound" CssClass="gridView"></asp:GridView>
    </div>
    </form>
</body>
</html>
