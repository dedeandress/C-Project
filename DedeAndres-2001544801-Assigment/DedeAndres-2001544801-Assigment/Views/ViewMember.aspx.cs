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
    public partial class ViewMember : System.Web.UI.Page
    {
        public void load() {
            GridView1.DataSource = UserReposit.getAll();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void link_delete_Click(object sender, EventArgs e)
        {
            int find = int.Parse(txt_find.Text);
            UserReposit.deleteUser(find);
            load();
        }

        protected void link_role_Click(object sender, EventArgs e)
        {
            int find = int.Parse(txt_find.Text);
            User roleUser = UserReposit.getUser(find);
            roleUser.Role = "Admin";
            load();
        }
    }
}