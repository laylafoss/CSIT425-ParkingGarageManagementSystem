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
            DateTime now = DateTime.Now;
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
            if (Request.Cookies["Monthly"] != null)
            {

                Button[] btns = new Button[5];
                btns[0] = btn51;
                btns[1] = btn52;
                btns[2] = btn53;
                btns[3] = btn54;
                btns[4] = btn55;

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
            btn51_Click(sender, e);

        }

        protected void updateDB(int id, Button btn)
        {
            if (id > 200 && id < 206)
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
                btn.Click += btn51_Click;
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