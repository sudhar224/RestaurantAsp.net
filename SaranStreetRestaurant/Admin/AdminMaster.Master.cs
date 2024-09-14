using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaranStreetRestaurant.Admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Table.aspx");
        }

        protected void btn_food_item_Click(object sender, EventArgs e)
        {
            Response.Redirect("FoodItems.aspx");
        }

        protected void btn_billing_Click(object sender, EventArgs e)
        {
            Response.Redirect("Billing.aspx");
        }
    }
}