﻿using System;
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
    }
}