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
    public partial class Register : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name=txt_name.Text;
            string email=txt_email.Text;
            string password=txt_password.Text;
            string conPassword = txt_conPass.Text;
            string gender=RadioButtonList1.Text;
            DateTime birthdate=Date_birth.SelectedDate.Date;
            string pic=FileUpload1.FileName;
            string phone=txt_phone.Text;
            string address=txt_address.Text;
            bool isNull = (birthdate == null);
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(conPassword) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(pic) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(address)&&Date_birth.SelectedDate!=null)
            {
                if (UserReposit.findEmail(email) == true)
                {
                    lbl_message.Text = "Your email is already registered";
                } else if (password != conPassword)
                {
                    lbl_message.Text = "Your confirm password is wrong";
                } else if (!pic.EndsWith(".jpg")&&!pic.EndsWith(".png"))
                {
                    lbl_message.Text = "You must input .jpg or .png image";
                }
                else
                {
                    FileUpload1.SaveAs("D:\\UploadsUser\\" + FileUpload1.FileName);
                    string inputPath = "D:\\UploadsUser\\" + FileUpload1.FileName;
                    UserReposit.insertUser(FactoryUser.createUser(name, email, password, gender, birthdate, inputPath, phone, address));
                    Response.Redirect("Login.aspx");
                }
            }
            else {
                lbl_message.Text = "You must fill all data";
            }
        }
    }
}