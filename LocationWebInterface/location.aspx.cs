using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class location : Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		
		if (Request.QueryString["username"] != null)
		{
			Get(Request.QueryString["username"]);
		}
		else if (Request.Form["username"] != null
				 && Request.Form["location"] != null)
		{
			Post(Request.Form["username"], Request.Form["location"]);
		}
		else
		{
			Response.Write("Request is neither a GET or a POST request!");
			Response.StatusCode = 404;
			Response.End();
		}
	}

	private void Get(string username)
	{
        if (username == "")
        {
            Response.Write("Empty inputs are forbidden!");
            Response.StatusCode = 400;
            Response.End();
            return;
        }

        if (username.Length > 128)
        {
            Response.Write("Inputs must be no longer than 128 characters!");
            Response.StatusCode = 400;
            Response.End();
            return;
        }

        using (SqlConnection conn = new SqlConnection(db.ConnectionString))
		{
			conn.Open();

			using (SqlDataReader rdr = Queries.GetLocation(username, conn))
			{
				if (rdr.HasRows)
				{
					while (rdr.Read())
					{
						Response.Write(rdr[0]);
					}
				}
				else
				{
					Response.StatusCode = 404;
				}
			}
		}

		Response.End();
	}

	private void Post(string username, string location)
	{
        if (username == "" || location == "")
        {
            Response.Write("Empty inputs are forbidden!");
            Response.StatusCode = 400;
            Response.End();
            return;
        }

        if (username.Length > 128 || location.Length > 128)
        {
            Response.Write("Inputs must be no longer than 128 characters!");
            Response.StatusCode = 400;
            Response.End();
            return;
        }

        using (SqlConnection conn = new SqlConnection(db.ConnectionString))
		{
			conn.Open();

			if (Queries.IsUpdate(username, conn))
			{
				Queries.UpdateLocation(username, location, conn);
			}
			else
			{
				Queries.InsertUser(username, location, conn);
				Queries.CreateUserTable(username, conn);
			}

			Queries.StoreLocationAndTime(username, location, DateTime.Now,
										 conn);
		}

		Response.End();
	}
}