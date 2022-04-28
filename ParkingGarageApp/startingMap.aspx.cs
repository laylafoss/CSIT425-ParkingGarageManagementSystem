using System;
using DataBaseConnector;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class startingMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firstFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor1.aspx");
        }

        protected void secondFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor2.aspx");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {

        }

        protected void thirdFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor3.aspx");
        }

        protected void fourthFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor4.aspx");
        }

        protected void fifthFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor5.aspx");
        }
    }
}