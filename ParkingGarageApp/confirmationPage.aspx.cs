using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class confirmationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void exitBtn_Click(object sender, EventArgs e)
        {
            //brings you back to beginning
            if (Request.Cookies["Monthly"] != null)
            {
                Response.Cookies["Monthly"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("customerChoice.aspx");
        }
    }
}