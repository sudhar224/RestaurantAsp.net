using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaranStreetRestaurant
{
	public partial class LoginPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnsubmit_click(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection("Data Source = DESKTOP-7TUTM2S\\SQLEXPRESS; Initial Catalog = shoemart; Integrated Security = true;");
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_login", con);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlParameter p1 = new SqlParameter("@username", SqlDbType.VarChar);
			cmd.Parameters.Add(p1).Value = txt_username.Text.Trim();

			SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
			cmd.Parameters.Add(p2).Value = txt_pwd.Text.Trim();

			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			sda.Fill(ds);

			int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

			if (a > 0)
			{
				Response.Write("loginsuccessfully");
				Response.Redirect("index.aspx");
			}
			else
			{
				Response.Write("Login fail");
			}
		}
	}
}