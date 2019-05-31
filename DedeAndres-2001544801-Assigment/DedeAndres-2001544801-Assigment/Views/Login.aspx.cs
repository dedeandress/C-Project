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
    public partial class Login : System.Web.UI.Page
    {
        UserReposit userRepo = new UserReposit();
        public static string email, password, role;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["rememberMe"] != null)
            {
                HttpCookie cookie = Request.Cookies.Get("rememberMe");
                string email = cookie.Values["Email"].ToString();
                txt_email.Attributes["value"] = email;
            }
            else {

            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != null && txt_password.Text != null)
            {
                if (userRepo.compareUser(txt_email.Text, txt_password.Text) == null)
                {
                    lbl_message.Text = "Invalid email or password";
                }
                else
                {
                    
                        HttpCookie rememberMe = new HttpCookie("Email", txt_email.Text);
                        rememberMe.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(rememberMe);
                    
                    User getUser = userRepo.compareUser(txt_email.Text, txt_password.Text);
                    Session["user"] = getUser;
                    Response.Redirect("Home.aspx");
                }
            }
            else {
                lbl_message.Text = "You must fill all the box";
            }
            
        }
    }
}