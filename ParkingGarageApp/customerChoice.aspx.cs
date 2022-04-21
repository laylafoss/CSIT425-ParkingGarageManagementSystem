using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dailyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("dailyInformation.aspx");
        }

        protected void monthlyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("monthlyInformation.aspx");
        }
    }
}