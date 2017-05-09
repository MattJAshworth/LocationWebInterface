using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class previouslocations : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			Utilities.PopulateUsernames(usernames, db.ConnectionString);
		}
		else
		{
			usernames.DataBind();
		}
	}

	protected void usernames_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (usernames.SelectedIndex != -1)
		{ 
			using (SqlConnection conn = new SqlConnection(db.ConnectionString))
			{
				conn.Open();

				string username = usernames.SelectedItem.ToString();

				rooms.DataSource = Queries.LocationsPastDay(username, conn);
				rooms.DataBind();
			}
		}
	}

	protected void rooms_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		if (e.Row.RowType == DataControlRowType.Header)
		{
			e.Row.Cells[0].Text = "Username";
			e.Row.Cells[1].Text = "Time";
		}
	}
}