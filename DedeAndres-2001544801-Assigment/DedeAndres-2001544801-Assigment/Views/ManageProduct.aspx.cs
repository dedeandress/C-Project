using DedeAndres_2001544801_Assigment.Factories;
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
    public partial class ManageProduct : System.Web.UI.Page
    {
        public void load() {
            GridView1.DataSource = RepositProduct.getAll();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void btn_addProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("addProduct.aspx");
        }

        protected void btn_update_Click1(object sender, EventArgs e)
        {
            int productID = Int32.Parse(((Button)sender).Attributes["ProductID"]);

            Product getProduct = RepositProduct.getProduct(productID);

            Session["Product"] = getProduct;
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {

            int productID = Int32.Parse(((Button)sender).Attributes["ProductID"]);
            RepositProduct.deleteProduct(productID);
            load();
        }
    }
}