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
                    
                    txtSuccess.Text = ("Employee inserted succssfully");
                    txtError.Text = "";
                    fetch();
                    Clear();
                }
                else
                {
                    txtSuccess.Text = "";
                    txtError.Text = ("Check Your Data");
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           using(SqlConnection con = new SqlConnection (constr))
            {
                con.Open ();
                string query = "update tbl_employee set employee_name = @employee_name, gender = @gender, DOB = @DOB,mobile_number = @mobile_number, Address = @Address where id = @employee_id";
                SqlCommand cmd = new SqlCommand(query,con);               
                cmd.Parameters.AddWithValue("@employee_name", txt_emp_name.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", ddl_Gender.SelectedValue);
                cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile_number", txt_mobile.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                cmd.Parameters.AddWithValue("@employee_id", HiddenField1.Value.Trim());
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    txtSuccess.Text = ("Employee Updated succssfully");
                    txtError.Text = "";
                    fetch();
                    Clear();
                }
                else
                {
                    txtSuccess.Text = "";
                    txtError.Text = ("Check Your Data");
                }
                con.Close();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open ();
                string query = "Delete from tbl_employee where id = @employee_id";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@employee_id", HiddenField1.Value.Trim());
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    txtSuccess.Text = ("Employee Deleted succssfully");
                    txtError.Text = "";
                    fetch();
                    Clear();
                }
                else
                {
                    txtSuccess.Text = "";
                    txtError.Text = ("Check Your Data");
                }
                con.Close();
            }
        }

        public void Clear()
        {
            txt_address.Text = txt_DOB.Text = txt_emp_name.Text = txt_mobile.Text = HiddenField1.Value = "";
            ddl_Gender.SelectedIndex = 0;
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_emp_name.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            ddl_Gender.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_DOB.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_mobile.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            txt_address.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
            HiddenField1.Value = GridView1.SelectedRow.Cells[1].Text.ToString();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            fetch();
        }
    }
}