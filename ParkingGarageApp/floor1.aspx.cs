using System;
using MySql.Data.MySqlClient;
using DataBaseConnector;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class app : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int[] arr = new int[50];
            Button[] buttons = new Button[50];
            buttons[0] = btn1;
            buttons[1] = btn2;
            buttons[2] = btn3;
            buttons[3] = btn4;
            buttons[4] = btn5;
            foreach (Button button in buttons)
            {
                if (button == null)
                {
                    continue;
                }
                if (button.Text == "103")
                {
                    button.BackColor = System.Drawing.Color.Red;
                } else
                {
                    button.BackColor = System.Drawing.Color.Green;
                }
            }
            int count = 1;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
           using (MySqlConnection conn = new MySqlConnection(connStr))

            {     
                conn.Open();
                string sql = "select * from dailyparking.parkingspace where customer_lname is null or customer_lname = '';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (count <= 50)
                {
                    reader.Read();
                    if (reader.GetInt32("parkingspace_id") == count + 100)
                    {
                        arr[count-1] = count + 100;   
                    } else
                    {
                        arr[count - 1] = 0;
                    }
                    count++;
                }
                conn.Close();
            }
            foreach(int i in arr)
            {
                ListBox1.Items.Add(i.ToString());
            }
            
            
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