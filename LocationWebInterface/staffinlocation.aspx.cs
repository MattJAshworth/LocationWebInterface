using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class staffinlocation : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			using (SqlConnection conn = new SqlConnection(db.ConnectionString))
			{
				conn.Open();

				SqlDataReader reader = Queries.GetLocations(conn);
				
				while (reader.Read())
				{
					ListItem user = new ListItem((string)reader["LOCATION"]);
					locations.Items.Add(user);
				}
			}
		}
		else
		{
			locations.DataBind();
		}
	}

	protected void locations_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (locations.SelectedIndex != -1)
		{
			using (SqlConnection conn = new SqlConnection(db.ConnectionString))
			{
				conn.Open();

				string location = locations.SelectedItem.ToString();

				users.DataSource = Queries.UsersInLocation(location, conn);
				users.DataBind();
			}
		}
	}

	protected void users_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		if (e.Row.RowType == DataControlRowType.Header)
		{
			e.Row.Cells[0].Text = "Username";
		}
	}
}