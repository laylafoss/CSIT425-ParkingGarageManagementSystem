using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class floor3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int currentBtn;
            string avail;
            DateTime now = DateTime.Now;
            Button[] buttons = new Button[50];
            buttons[0] = btn101;
            buttons[1] = btn102;
            buttons[2] = btn103;
            buttons[3] = btn104;
            buttons[4] = btn105;
            buttons[5] = btn106;
            buttons[6] = btn107;
            buttons[7] = btn108;
            buttons[8] = btn109;
            buttons[9] = btn110;
            buttons[10] = btn111;
            buttons[11] = btn112;
            buttons[12] = btn113;
            buttons[13] = btn114;
            buttons[14] = btn115;
            buttons[15] = btn116;
            buttons[16] = btn117;
            buttons[17] = btn118;
            buttons[18] = btn119;
            buttons[19] = btn120;
            buttons[20] = btn121;
            buttons[21] = btn122;
            buttons[22] = btn123;
            buttons[23] = btn124;
            buttons[24] = btn125;
            buttons[25] = btn126;
            buttons[26] = btn127;
            buttons[27] = btn128;
            buttons[28] = btn129;
            buttons[29] = btn130;
            buttons[30] = btn131;
            buttons[31] = btn132;
            buttons[32] = btn133;
            buttons[33] = btn134;
            buttons[34] = btn135;
            buttons[35] = btn136;
            buttons[36] = btn137;
            buttons[37] = btn138;
            buttons[38] = btn139;
            buttons[39] = btn140;
            buttons[40] = btn141;
            buttons[41] = btn142;
            buttons[42] = btn143;
            buttons[43] = btn144;
            buttons[44] = btn145;
            buttons[45] = btn146;
            buttons[46] = btn147;
            buttons[47] = btn148;
            buttons[48] = btn149;
            buttons[49] = btn150;

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
                            button.Click += btn101_Click;
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
                            button.Click += btn101_Click;
                        }
                    }
                }
            }
            if (Request.Cookies["Monthly"] != null)
            {

                Button[] btns = new Button[5];
                btns[0] = btn101;
                btns[1] = btn102;
                btns[2] = btn103;
                btns[3] = btn104;
                btns[4] = btn105;

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

        protected void btn101_Click(object sender, EventArgs e)
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
            btn101_Click(sender, e);

        }

        protected void updateDB(int id, Button btn)
        {
            if (id > 300 && id < 306)
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
                btn.Click += btn101_Click;
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