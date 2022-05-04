using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class dailyInformation : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void continueBtn_Click(object sender, EventArgs e)
        {
            //ParkingSpace parkingSpace = new ParkingSpace();
            if (String.IsNullOrEmpty(lastTxt.Text + firstTxt.Text + licenseTxt.Text + phoneNumberTxt.Text))
            {
                invalidInputLabel.Text = "Invalid input, all required fields must be filled.";
                invalidInputLabel.Visible = true;
            }
            else if (licenseTxt.Text.Length < 8)
            {
                invalidInputLabel.Text = "Invalid input, license plate number too short.";
                invalidInputLabel.Visible = true;
            }
            else if (licenseTxt.Text.Length > 8)
            {
                invalidInputLabel.Text = "Invalid input, license plate number too long.";
                invalidInputLabel.Visible = true;
            }
            else if (phoneNumberTxt.Text.Length < 10)
            {
                invalidInputLabel.Text = "Invalid input, invalid phone number.";
                invalidInputLabel.Visible = true;
            }
            else if (phoneNumberTxt.Text.Length > 10)
            {
                invalidInputLabel.Text = "Invalid input, invalid phone number.";
                invalidInputLabel.Visible = true;
            }
            else
            {
                HttpCookie cookie = new HttpCookie("Last");
                cookie.Value = lastTxt.Text;
                Response.Cookies.Add(cookie);
                Response.Redirect("startingMap.aspx");
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerChoice.aspx");
        }
    }
}