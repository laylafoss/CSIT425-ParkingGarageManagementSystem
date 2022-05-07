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
            DateTime now = DateTime.Now;
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
                    string sql = "select customer_lname, parkingspace_exit from parkingspace where parkingspace_id = '" + currentBtn + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["parkingspace_exit"] != DBNull.Value)
                        {
                            DateTime d2 = reader.GetDateTime(1);
                            if (DateTime.Compare(now, d2) > 0)
                            {
                                updateDB(currentBtn, button);
                                continue;
                            }
                        }
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

            if (Request.Cookies["Monthly"] != null)
            {
                
                Button[] btns = new Button[5];
                btns[0] = btn1;
                btns[1] = btn2;
                btns[2] = btn3;
                btns[3] = btn4;
                btns[4] = btn5;
                
                foreach (Button b in btns)
                {
                    currentBtn = int.Parse(b.Text);
                    string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "select customer_fname from parkingspace where parkingspace_id = '" + currentBtn + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["customer_fname"] != DBNull.Value)
                            {
                                b.BackColor = System.Drawing.Color.Red;
                                b.Enabled = false;
                                
                            }
                           
                            else
                            {
                                b.Enabled = true;
                                b.BackColor = System.Drawing.Color.SpringGreen;
                                b.Click += monthly_Click;
                            }
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
            HttpCookie space = new HttpCookie("Space");
            space.Value = s;
            HttpCookie dtCookie = new HttpCookie("Date");
            dtCookie.Value = dateTime.ToString();


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
            }

            Response.Cookies.Add(dtCookie);
            Response.Cookies.Add(space);
            Response.Redirect("invoiceInformation.aspx");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("startingMap.aspx");
        }

        protected void monthly_Click(object sender, EventArgs e)
        {
            string last = Request.Cookies["Last"].Value;
            string first = Request.Cookies["First"].Value;
            string plate = Request.Cookies["Plate"].Value;
            string email = Request.Cookies["Email"].Value;
            string number = Request.Cookies["Number"].Value;
            string space = (sender as Button).Text;
            string scon = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(scon))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "insert into monthlycustomer set mnthly_lname = (@1), mnthly_fname = (@2), license_plate = (@3), mnthly_email = (@4), mnthly_phonenum = (@5), parkingspace_id = (@6)";
                //cmd.Parameters.AddWithValue("@1", last);
                //cmd.Parameters.AddWithValue("@2", first);
                //cmd.Parameters.AddWithValue("@3", plate);
                //cmd.Parameters.AddWithValue("@4", email);
                //cmd.Parameters.AddWithValue("@5", number);
                //cmd.Parameters.AddWithValue("@6", space);
                //cmd.ExecuteNonQuery();
                cmd.CommandText = "update parkingspace set mnthly_id = 'y' where parkingspace_id = (@7)";
                cmd.Parameters.AddWithValue("@7", space);
                cmd.ExecuteNonQuery();

            }
            btn1_Click(sender, e);

        }
        protected void updateDB(int id, Button btn)
        {
            if (id > 100 && id < 106)
            {
                btn.Enabled = false;
                btn.BackColor = System.Drawing.Color.Red;
                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string sql = "update parkingspace set customer_lname = 'monthly', customer_fname = null, customer_plate = null, customer_phone = null, mnthly_id = null, parkingspace_entry = null, parkingspace_exit = null where parkingspace_id = '" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                btn.Enabled = true;
                btn.BackColor = System.Drawing.Color.Green;
                btn.Click += btn1_Click;
                string connStr2 = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connStr2))
                {
                    conn.Open();

                    string sql = "update parkingspace set customer_lname = null, customer_fname = null, customer_plate = null, customer_phone = null, mnthly_id = null, parkingspace_entry = null, parkingspace_exit = null where parkingspace_id = '" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }

        }

    }
}