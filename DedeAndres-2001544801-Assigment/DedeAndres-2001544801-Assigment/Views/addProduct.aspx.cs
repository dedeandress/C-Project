using DedeAndres_2001544801_Assigment.Factories;
using DedeAndres_2001544801_Assigment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DedeAndres_2001544801_Assigment.Views
{
    public partial class addProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_addProduct_Click(object sender, EventArgs e)
        {
            string watchName = txt_watchName.Text;
            int watchPrice = int.Parse(txt_watchPrice.Text);
            int stock = int.Parse(txt_stock.Text);
            string img= FileUpload1.FileName;
            if (watchName != null && txt_watchPrice.Text != null && txt_stock.Text != null && img != null)
            {
                if (!img.EndsWith(".jpg") && !img.EndsWith(".png"))
                {
                    lbl_error.Text = "File must .png or .jpg";
                }
                else if (stock<=0)
                {
                    lbl_error.Text = "You must input stock greater than 0";
                }
                else {
                    FileUpload1.SaveAs("D:\\DedeAndres-2001544801-Assigment\\UploadProduct\\" + FileUpload1.FileName);
                    string input = "D:\\DedeAndres-2001544801-Assigment\\UploadProduct\\" + FileUpload1.FileName;
                    RepositProduct.insertProduct(FactoryProduct.createProduct(watchName, watchPrice, stock, input));
                    Response.Redirect("addProduct.aspx");
                }
            }
            else {
                lbl_error.Text = "You must fill all data";
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageProduct.aspx");
        }
    }
}