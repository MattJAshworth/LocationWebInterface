<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<a href="locations.aspx" class="button">Find current locations of all staff</a><br/>
		<a href="updatelocation.aspx" class="button">Update location of a staff member</a><br/>
		<a href="updatedetails.aspx" class="button">Edit personal details of a staff member</a><br/>
		<a href="previouslocations.aspx" class="button">Find locations of a staff member in the past 24 hours</a><br/>
		<a href="staffinlocation.aspx" class="button">Find staff members in given location</a><br/>
    </div>
    </form>
</body>
</html>