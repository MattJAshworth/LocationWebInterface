using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class locations : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			using (SqlConnection conn = new SqlConnection(db.ConnectionString))
			{
				conn.Open();
				users.DataSource = Queries.GetAllUsersLocations(conn);
				users.DataBind();
			}
		}
		else
		{
			users.DataBind();
		}
	}

	protected void users_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		if (e.Row.RowType == DataControlRowType.Header)
		{
			e.Row.Cells[0].Text = "Username";
			e.Row.Cells[1].Text = "Location";
		}
	}
}