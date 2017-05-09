<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staffinlocation.aspx.cs" Inherits="staffinlocation" %>

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
		<h2>Staff members in selected location:</h2>
		<p>Location:</p>
		<p><asp:ListBox ID="locations" runat="server" OnSelectedIndexChanged="locations_SelectedIndexChanged" AutoPostBack="true" CssClass="listBox"></asp:ListBox></p>
		<asp:GridView ID="users" runat="server" OnRowDataBound="users_RowDataBound" CssClass="gridView"></asp:GridView>
    </div>
    </form>
</body>
</html>
