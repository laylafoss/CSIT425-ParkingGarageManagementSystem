using System;
using MySql.Data.MySqlClient;
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
            int currentBtn;
            string avail;
            Button[] buttons = new Button[50];
            buttons[0] = btn1;
            buttons[1] = btn2;
            buttons[2] = btn3;
            buttons[3] = btn4;
            buttons[4] = btn5;
            buttons[5] = btn6;
            buttons[6] = btn7;
            buttons[7] = btn8;
            buttons[8] = btn9;
            buttons[9] = btn10;
            buttons[10] = btn11;
            buttons[11] = btn12;
            buttons[12] = btn13;
            buttons[13] = btn14;
            buttons[14] = btn15;
            buttons[15] = btn16;
            buttons[16] = btn17;
            buttons[17] = btn18;
            buttons[18] = btn19;
            buttons[19] = btn20;
            buttons[20] = btn21;
            buttons[21] = btn22;
            buttons[22] = btn23;
            buttons[23] = btn24;
            buttons[24] = btn25;
            buttons[25] = btn26;
            buttons[26] = btn27;
            buttons[27] = btn28;
            buttons[28] = btn29;
            buttons[29] = btn30;
            buttons[30] = btn31;
            buttons[31] = btn32;
            buttons[32] = btn33;
            buttons[33] = btn34;
            buttons[34] = btn35;
            buttons[35] = btn36;
            buttons[36] = btn37;
            buttons[37] = btn38;
            buttons[38] = btn39;
            buttons[39] = btn40;
            buttons[40] = btn41;
            buttons[41] = btn42;
            buttons[42] = btn43;
            buttons[43] = btn44;
            buttons[44] = btn45;
            buttons[45] = btn46;
            buttons[46] = btn47;
            buttons[47] = btn48;
            buttons[48] = btn49;
            buttons[49] = btn50;

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
                            button.Click += btn1_Click;
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
                            button.Click += btn1_Click;
                        }
                    }
                }
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string last = Request.Cookies["Last"].Value;
            string first = Request.Cookies["First"].Value;
            string plate = Request.Cookies["Plate"].Value;
            string number = Request.Cookies["Number"].Value;
            string s = (sender as Button).Text;
            DateTime dateTime = DateTime.Now;


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
            
            Response.Redirect("customerChoice.aspx");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("startingMap.aspx");
        }

    }
}