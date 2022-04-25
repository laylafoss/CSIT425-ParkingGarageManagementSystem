using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class app : System.Web.UI.Page
    {
        //private bool firstFloorButtonClicked = false;
        //private bool secondFloorButtonClicked = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btn10.Visible = true;
            btn11.Visible = true;
            btn12.Visible = true;
            btn13.Visible = true;
            btn14.Visible = true;
            btn15.Visible = true;
            btn16.Visible = true;
            btn17.Visible = true;
            btn18.Visible = true;
            btn19.Visible = true;
            btn20.Visible = true;
            btn21.Visible = true;
            btn22.Visible = true;
            btn23.Visible = true;
            btn24.Visible = true;
            btn25.Visible = true;
            btn26.Visible = true;
            btn27.Visible = true;
            btn28.Visible = true;
            btn29.Visible = true;
            btn30.Visible = true;
            btn31.Visible = true;
            btn32.Visible = true;
            btn33.Visible = true;
            btn34.Visible = true;
            btn35.Visible = true;
            btn36.Visible = true;
            btn37.Visible = true;
            btn38.Visible = true;
            btn39.Visible = true;
            btn40.Visible = true;
            btn41.Visible = true;
            btn42.Visible = true;
            btn43.Visible = true;
            btn44.Visible = true;
            btn45.Visible = true;
            btn46.Visible = true;
            btn47.Visible = true;
            btn48.Visible = true;
            btn49.Visible = true;
            btn50.Visible = true;
        }

        protected void firstFloorBtn_Click(object sender, EventArgs e)
        {
                
            }
        protected void secondFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor2.aspx");
        }

        protected void thirdFloorBtn_Click(object sender, EventArgs e)
        {

        }

        protected void fourthFloorBtn_Click(object sender, EventArgs e)
        {

        }

        protected void fifthFloorBtn_Click(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("startingMap.aspx");
        }
    }
}