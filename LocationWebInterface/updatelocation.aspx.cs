using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class updatelocation : Page
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

	protected void Update_Click(object sender, EventArgs e)
	{
		usernameError.Visible = false;
		updateDone.Visible = false;
		locationError.Visible = false;

		if (usernames.SelectedIndex == -1)
		{
			usernameError.Text = "Error: Please select a username";
			usernameError.Visible = true;
			return;
		}

		string username = usernames.SelectedItem.ToString();
		string room = location.Text;

		// stored as varchar(255) in DB
		// test me - 256 or 255?
		if (room.Length > 255)
		{
			locationError.Text = "Location too long: must be shorter than " +
								 "255 characters";
			locationError.Visible = true;
			return;
		}
		else if (room == "")
		{
			locationError.Text = "Location cannot be empty!";
			locationError.Visible = true;
			return;
		}

		using (SqlConnection conn = new SqlConnection(db.ConnectionString))
		{
			conn.Open();
			Queries.UpdateLocation(username, room, conn);
			Queries.StoreLocationAndTime(username, room, DateTime.Now, conn);
		}

		updateDone.Text = "Update successful!";
		updateDone.Visible = true;
	}

	protected void usernames_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (usernames.SelectedIndex != -1)
		{ 
			using (SqlConnection conn = new SqlConnection(db.ConnectionString))
			{
				conn.Open();
				string username = usernames.SelectedItem.ToString();

				SqlDataReader reader = Queries.GetLocation(username, conn);

				while (reader.Read())
				{
					location.Text = reader[0].ToString();
				}
			}
		}
	}
}