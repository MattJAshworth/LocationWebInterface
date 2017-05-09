<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatedetails.aspx.cs" Inherits="updatedetails" %>

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
		<h2>Update a staff member's personal details:</h2>
		<p>Username:</p>
		<div><asp:Label ID="usernameError" runat="server" Visible="false"></asp:Label></div>
		<asp:ListBox ID="usernames" runat="server" OnSelectedIndexChanged="usernames_SelectedIndexChanged" AutoPostBack="true" CssClass="listBox"></asp:ListBox>
		<p>First Name:</p>
		<div><asp:Label ID="firstNameError" runat="server" Visible="false"></asp:Label></div>
		<asp:TextBox ID="firstname" runat="server" CssClass="textBox"></asp:TextBox>
		<p>Last Name:</p>
		<div><asp:Label ID="lastNameError" runat="server" Visible="false"></asp:Label></div>
		<p><asp:TextBox ID="lastname" runat="server" CssClass="textBox"></asp:TextBox></p>
		<p><asp:Button ID="Update" Text="Update details" runat="server" OnClick="Update_Click" CssClass="aspButton"/></p>
		<div><asp:Label ID="updateDone" runat="server" Visible="false"></asp:Label></div><br />
	</div>
    </form>
</body>
</html>