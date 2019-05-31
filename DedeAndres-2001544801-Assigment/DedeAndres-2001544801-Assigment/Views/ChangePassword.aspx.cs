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
    public partial class ChangePassword : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            string curr = txt_curr.Text;
            string newPass = txt_new.Text;
            string confirm = txt_confirm.Text;
            if (user.Password != curr)
            {
                lbl_error.Text = "incorrect current password!";
            }
            else if (newPass != confirm)
            {
                lbl_error.Text = "Wrong Confirm Password!";
            }
            else {
                User getUser = UserReposit.getUser(user.Id);
                getUser.Password = newPass;
                UserReposit.updateUser(getUser.Id, getUser);
                Response.Redirect("Home.aspx");
            }
        }
    }
}