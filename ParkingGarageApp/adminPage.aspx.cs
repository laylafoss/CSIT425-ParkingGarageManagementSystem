using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class adminPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestCon_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using(MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                if (cn.Ping())
                {
                    Response.Write("success");
                    cn.Close();
                }
            }
        }

        protected void btnTestRet_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select * from dailyparking.parkingspace where ;";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader.GetInt32("parkingspace_id").ToString());
                }
                cn.Close();
                
            }
        }

        protected void btnTestWrit_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "update dailyparking.parkingspace set customer_lname = '" + txtBxTestWrit.Text + "' where parkingspace_id = 201;";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

            }
        }
    }
}