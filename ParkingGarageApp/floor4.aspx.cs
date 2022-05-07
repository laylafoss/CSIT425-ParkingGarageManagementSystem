using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class floor4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int currentBtn;
            string avail;
            Button[] buttons = new Button[50];
            buttons[0] = btn151;
            buttons[1] = btn152;
            buttons[2] = btn153;
            buttons[3] = btn154;
            buttons[4] = btn155;
            buttons[5] = btn156;
            buttons[6] = btn157;
            buttons[7] = btn158;
            buttons[8] = btn159;
            buttons[9] = btn160;
            buttons[10] = btn161;
            buttons[11] = btn162;
            buttons[12] = btn163;
            buttons[13] = btn164;
            buttons[14] = btn165;
            buttons[15] = btn166;
            buttons[16] = btn167;
            buttons[17] = btn168;
            buttons[18] = btn169;
            buttons[19] = btn170;
            buttons[20] = btn171;
            buttons[21] = btn172;
            buttons[22] = btn173;
            buttons[23] = btn174;
            buttons[24] = btn175;
            buttons[25] = btn176;
            buttons[26] = btn177;
            buttons[27] = btn178;
            buttons[28] = btn179;
            buttons[29] = btn180;
            buttons[30] = btn181;
            buttons[31] = btn182;
            buttons[32] = btn183;
            buttons[33] = btn184;
            buttons[34] = btn185;
            buttons[35] = btn186;
            buttons[36] = btn187;
            buttons[37] = btn188;
            buttons[38] = btn189;
            buttons[39] = btn190;
            buttons[40] = btn191;
            buttons[41] = btn192;
            buttons[42] = btn193;
            buttons[43] = btn194;
            buttons[44] = btn195;
            buttons[45] = btn196;
            buttons[46] = btn197;
            buttons[47] = btn198;
            buttons[48] = btn199;
            buttons[49] = btn200;

            foreach (Button button in buttons)
            {
                button.Visible = true;
            }

            foreach (Button button in buttons)
            {
                if (button == null)
                {
                    continue;
                }
                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    currentBtn = int.Parse(button.Text);

                    conn.Open();
                    string sql = "select customer_lname from parkingspace where parkingspace_id = '" + currentBtn + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            button.Enabled = true;
                            button.BackColor = System.Drawing.Color.Green;
                            button.Click += btn151_Click;
                            continue;
                        }
                        avail = reader.GetString(0);
                        if (avail != "")
                        {
                            button.BackColor = System.Drawing.Color.Red;
                            button.Enabled = false;
                        }
                        else
                        {
                            button.Enabled = true;
                            button.BackColor = System.Drawing.Color.Green;
                            button.Click += btn151_Click;
                        }
                    }
                }
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("startingMap.aspx");
        }

        protected void btn151_Click(object sender, EventArgs e)
        {
            string last = Request.Cookies["Last"].Value;
            string first = Request.Cookies["First"].Value;
            string plate = Request.Cookies["Plate"].Value;
            string number = Request.Cookies["Number"].Value;
            string s = (sender as Button).Text;
            DateTime dateTime = DateTime.Now;
            HttpCookie space = new HttpCookie("Space");
            space.Value = s;


            string scon = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(scon))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update parkingspace set customer_lname = (@1), customer_fname = (@2), customer_plate = (@3), customer_phone = (@4), parkingspace_entry = (@5) where parkingspace_id = " + s;
                cmd.Parameters.AddWithValue("@1", last);
                cmd.Parameters.AddWithValue("@2", first);
                cmd.Parameters.AddWithValue("@3", plate);
                cmd.Parameters.AddWithValue("@4", number);
                cmd.Parameters.AddWithValue("@5", dateTime);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            Response.Cookies.Add(space);
            Response.Redirect("invoiceInformation.aspx");
        }
    }
}