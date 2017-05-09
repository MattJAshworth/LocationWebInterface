using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class updatedetails : System.Web.UI.Page
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

				SqlDataReader reader = Queries.GetNames(username, conn);

				// null values will just appear as ""
				while (reader.Read())
				{
					firstname.Text = reader[0].ToString();
					lastname.Text = reader[1].ToString();
				}
			}
		}
	}

	protected void Update_Click(object sender, EventArgs e)
	{
		usernameError.Visible = false;
		updateDone.Visible = false;
		firstNameError.Visible = false;
		lastNameError.Visible = false;

		if (usernames.SelectedIndex == -1)
		{
			usernameError.Text = "Error: Please select a username";
			usernameError.Visible = true;
			return;
		}

		string username = usernames.SelectedItem.ToString();
		string firstName = firstname.Text;
		string lastName = lastname.Text;

		if (firstName.Length > 255)
		{
			firstNameError.Text = "Firstname too long: must be shorter than " +
								  "255 characters";
			firstNameError.Visible = true;
			return;
		}

		if (lastName.Length > 255)
		{
			lastNameError.Text = "Lastname too long: must be shorter than " +
								 "255 characters";
			lastNameError.Visible = true;
			return;
		}

		using (SqlConnection conn = new SqlConnection(db.ConnectionString))
		{
			conn.Open();
			Queries.UpdateNames(username, firstName, lastName, conn);
		}

		updateDone.Text = "Update successful!";
		updateDone.Visible = true;
	}
}