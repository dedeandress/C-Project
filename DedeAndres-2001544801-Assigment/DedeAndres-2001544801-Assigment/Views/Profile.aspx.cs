using DedeAndres_2001544801_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DedeAndres_2001544801_Assigment.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            lbl_id.Text = user.Id.ToString();
            lbl_Name.Text = user.Name;
            lbl_password.Text = user.Password;
            lbl_Phone.Text = user.Phone;
            lbl_role.Text = user.Role;
            lbl_Email.Text = user.Email;
            lbl_Birthdate.Text = user.BirthDate.ToString();
            lbl_Address.Text = user.Address;
            lbl_Gender.Text = user.Gender;
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}