using DedeAndres_2001544801_Assigment.Models;
using DedeAndres_2001544801_Assigment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DedeAndres_2001544801_Assigment.Views
{
    public partial class Home : System.Web.UI.Page
    {
        public void load()
        {
            GridView1.DataSource = RepositProduct.getAll();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                
                User user = (User)Session["user"];
                lbl_username.Text = user.Name.ToString();
                if (user.Role == "Admin")
                {
                    load();
                    btn_product.Visible = true;
                    btn_user.Visible = true;
                }
                else {
                    load();
                    btn_product.Visible = false;
                    btn_user.Visible = false;
                }
            } else if(Session["Guest"] !=null)
            {
                load();
                btn_changePass.Visible = false;
                btn_profile.Visible = false;
                btn_product.Visible = false;
                btn_user.Visible = false;
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btn_product_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageProduct.aspx");
        }

        protected void btn_user_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMember.aspx");
        }

        protected void btn_profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btn_changePass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}