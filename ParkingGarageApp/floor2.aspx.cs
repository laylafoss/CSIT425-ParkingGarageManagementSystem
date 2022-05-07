using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class floor2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int currentBtn;
            string avail;
            Button[] buttons = new Button[50];
            buttons[0] = btn51;
            buttons[1] = btn52;
            buttons[2] = btn53;
            buttons[3] = btn54;
            buttons[4] = btn55;
            buttons[5] = btn56;
            buttons[6] = btn57;
            buttons[7] = btn58;
            buttons[8] = btn59;
            buttons[9] = btn60;
            buttons[10] = btn61;
            buttons[11] = btn62;
            buttons[12] = btn63;
            buttons[13] = btn64;
            buttons[14] = btn65;
            buttons[15] = btn66;
            buttons[16] = btn67;
            buttons[17] = btn68;
            buttons[18] = btn69;
            buttons[19] = btn70;
            buttons[20] = btn71;
            buttons[21] = btn72;
            buttons[22] = btn73;
            buttons[23] = btn74;
            buttons[24] = btn75;
            buttons[25] = btn76;
            buttons[26] = btn77;
            buttons[27] = btn78;
            buttons[28] = btn79;
            buttons[29] = btn80;
            buttons[30] = btn81;
            buttons[31] = btn82;
            buttons[32] = btn83;
            buttons[33] = btn84;
            buttons[34] = btn85;
            buttons[35] = btn86;
            buttons[36] = btn87;
            buttons[37] = btn88;
            buttons[38] = btn89;
            buttons[39] = btn90;
            buttons[40] = btn91;
            buttons[41] = btn92;
            buttons[42] = btn93;
            buttons[43] = btn94;
            buttons[44] = btn95;
            buttons[45] = btn96;
            buttons[46] = btn97;
            buttons[47] = btn98;
            buttons[48] = btn99;
            buttons[49] = btn100;

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
                            button.Click += btn51_Click;
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
                            button.Click += btn51_Click;
                        }
                    }
                }
            }
        }

        protected void firstFloorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("floor1.aspx");
        }

        protected void secondFloorBtn0_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("startingMap.aspx");
        }

        protected void btn51_Click(object sender, EventArgs e)
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