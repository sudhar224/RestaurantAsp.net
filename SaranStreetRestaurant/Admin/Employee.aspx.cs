using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
namespace SaranStreetRestaurant.Admin
{
    public partial class Employee : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fetch();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "Insert into tbl_employee values (@employee_name,@gender,@DOB,@mobile_number,@Address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@employee_name", txt_emp_name.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", ddl_Gender.SelectedValue);
                cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile_number", txt_mobile.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Response.Write("Data inserted suessfully");
                    fetch();
                }
                else
                {
                    Response.Write("Check Your Data");
                }
                con.Close();
            }
        }

        public void fetch()
        {
            using( SqlConnection con = new SqlConnection(constr))
            {
                con.Open ();
                string query = "Select * from tbl_employee";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sdr.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}