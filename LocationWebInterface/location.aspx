<%@ Page Language="C#" AutoEventWireup="true" CodeFile="location.aspx.cs" Inherits="location" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<a href="Default.aspx" class="button">Home page</a>
		<asp:SqlDataSource ID="db" runat="server" ConnectionString="<%$ ConnectionStrings:rde_514209ConnectionString %>"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
