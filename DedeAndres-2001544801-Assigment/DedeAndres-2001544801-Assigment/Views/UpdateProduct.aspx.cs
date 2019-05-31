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
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Product"] != null)
            {
                Product product = (Product)Session["Product"];
                lbl_name.Text = product.WatchName;
                lbl_price.Text = product.WatchPrice.ToString();
                lbl_stock.Text = product.Stock.ToString();
            }
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Product product = (Product)Session["Product"];
            int id = product.Id;
            string name = txt_watchName.Text;
            int price = int.Parse(txt_watchPrice.Text);
            int stock = int.Parse(txt_stock.Text);
            string pic = FileUpload1.FileName;
            if (txt_stock.Text != null && txt_watchName.Text != null && txt_watchPrice.Text != null && !FileUpload1.HasFile)
            {
                if (!pic.EndsWith(".jpg") && !pic.EndsWith(".png"))
                {
                    lbl_error.Text = "File must .png or .jpg";
                }
                else if (stock <= 0)
                {
                    lbl_error.Text = "You must input stock greater than 0";
                }
                else
                {
                    FileUpload1.SaveAs("D:\\DedeAndres-2001544801-Assigment\\UploadProduct\\" + FileUpload1.FileName);
                    string input = "D:\\DedeAndres-2001544801-Assigment\\UploadProduct\\" + FileUpload1.FileName;
                    Product newProduct = FactoryProduct.createProduct(name, price, stock, input);
                    RepositProduct.updateProduct(id, newProduct);
                    Response.Redirect("ManageProduct.aspx");
                }
            }
            else
            {
                lbl_error.Text = "You must fill all data";
            }
        }
    }
}