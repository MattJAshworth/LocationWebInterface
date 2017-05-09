<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatelocation.aspx.cs" Inherits="updatelocation" %>

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
		<h2>Update a staff member's location:</h2>
		<p>Username:</p>
		<div><asp:Label ID="usernameError" runat="server" Visible="false"></asp:Label></div>
		<asp:ListBox ID="usernames" runat="server" OnSelectedIndexChanged="usernames_SelectedIndexChanged" AutoPostBack="true" CssClass="listBox"></asp:ListBox>
		<p>Location:</p>
		<div><asp:Label ID="locationError" runat="server" Visible="false"></asp:Label></div>
		<asp:TextBox ID="location" runat="server" CssClass="textBox"></asp:TextBox>
		<p><asp:Button ID="Update" Text="Update location" runat="server" onclick="Update_Click" CssClass="aspButton"/></p>
		<div><asp:Label ID="updateDone" runat="server" Visible="false"></asp:Label></div><br />
	</div>
    </form>
</body>
</html>