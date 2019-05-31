using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DedeAndres_2001544801_Assigment.Views
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btn_guest_Click(object sender, EventArgs e)
        {
            Session["Guest"] = (int)1;
            Response.Redirect("Home.aspx");
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}