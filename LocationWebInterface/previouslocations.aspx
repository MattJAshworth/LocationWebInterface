<%@ Page Language="C#" AutoEventWireup="true" CodeFile="previouslocations.aspx.cs" Inherits="previouslocations" %>

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
		<h2>Staff member's locations in the past 24 hours:</h2>
		<p>Username:</p>
		<p><asp:ListBox ID="usernames" runat="server" OnSelectedIndexChanged="usernames_SelectedIndexChanged" AutoPostBack="true" CssClass="listBox"></asp:ListBox></p>
		<asp:GridView ID="rooms" ShowHeaderWhenEmpty="true" EmptyDataText="Staff member hasn't been in any locations in the last 24 hours" OnRowDataBound="rooms_RowDataBound" runat="server" CssClass="gridView"></asp:GridView>
    </div>
    </form>
</body>
</html>
