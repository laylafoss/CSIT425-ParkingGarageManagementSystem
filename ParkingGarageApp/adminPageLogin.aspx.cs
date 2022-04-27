using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class adminPage : System.Web.UI.Page
    {
        private 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void enterBtn_Click(object sender, EventArgs e)
        {
            //hardcoded in password for now, will change later
            if (adminPasswordTxt.Text == null)
            {
                errorMessageLabel.Text = "Error: Must enter valid password.";
                errorMessageLabel.Visible = true;
            }
            else if (adminPasswordTxt.Text == "Adminkey123")
            {
                Response.Redirect("adminPage.aspx");
            }
            else if (adminPasswordTxt.Text != "Adminkey123")
            {
                errorMessageLabel.Text = "Password incorrect, please try again.";
                errorMessageLabel.Visible = true;
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerChoice.aspx");
        }
    }
}