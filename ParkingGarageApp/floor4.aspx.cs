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
            DateTime now = DateTime.Now;
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
            if (Request.Cookies["Monthly"] != null)
            {

                Button[] btns = new Button[5];
                btns[0] = btn151;
                btns[1] = btn152;
                btns[2] = btn153;
                btns[3] = btn154;
                btns[4] = btn155;

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
                conn.Close();
            }

            Response.Cookies.Add(dtCookie);
            Response.Cookies.Add(space);
            Response.Redirect("invoiceInformation.aspx");
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
            btn151_Click(sender, e);

        }

        protected void updateDB(int id, Button btn)
        {
            if (id > 400 && id < 406)
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
                btn.Click += btn151_Click;
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