using System;
using MySql.Data.MySqlClient;
using System.Data;

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
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                string sql = "Select * from parkingspace;";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();

            }
        }

        protected void btnTestRet_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select count(*) from parkingspace where customer_fname is null;";
                int count;
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                    Label1.Text = "There are " + count + " spots open.";
                    Label1.Visible = true;

                }
            }
        }

        protected void btnTestWrit_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                int count;
                string sql = "select count(*) from parkingspace where mnthly_id is null and parkingspace_entry is not null;";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32(0);
                    Label2.Text = "There are " + count + " daily customers currently parked";
                    Label2.Visible = true;

                }

            }
        }

        protected void btnMnthCount_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                int count;
                string sql = "select count(*) from parkingspace where mnthly_id = 'y';";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32(0);
                    Label3.Text = "There are " + count + " monthly customers currently parked";
                    Label3.Visible = true;
                }
            }
        }

        protected void btnEarned_Click(object sender, EventArgs e)
        {
            int dollars;

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "SELECT sum(invoice_total) FROM invoice WHERE DATE(invoice_datetime) = CURDATE();";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dollars = dr.GetInt32(0);
                    Label4.Text = "The total amount earned today is $" + dollars + ".00";
                    Label4.Visible = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int dollars;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select sum(invoice_total) from invoice;";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dollars = dr.GetInt32(0);
                    Label5.Text = "The total amount earned lifetime is $" + dollars + ".00";
                    Label5.Visible = true;
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                string sql = "select customer_lname, customer_fname, parkingspace_id, invoice_id from invoice where invoice_pay_method = 'Monthly, will be invoiced by admin';";
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                GridView2.DataSource = dataTable;
                GridView2.DataBind();


                
                cmd.CommandText = "update invoice set invoice_pay_method = 'paid' where invoice_pay_method =  'Monthly, will be invoiced by admin'";
                cmd.ExecuteNonQuery();
                if (GridView2.Rows.Count > 0)
                {
                    Label7.Visible = true;
                    foreach (GridViewRow dr in GridView2.Rows)
                    {
                        string first, last, space, id;

                        last = dr.Cells[0].Text;
                        first = dr.Cells[1].Text;
                        space = dr.Cells[2].Text;
                        cmd.CommandText = "insert into invoice set customer_lname = (@1), customer_fname = (@2), invoice_pay_method = 'paid', invoice_total = '100', parkingspace_id = (@3), invoice_datetime = (@4)";
                        cmd.Parameters.AddWithValue("@1", last);
                        cmd.Parameters.AddWithValue("@2", first);
                        cmd.Parameters.AddWithValue("@3", space);
                        cmd.Parameters.AddWithValue("@4", now);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                //cmd.CommandText = "insert into invoice set customer_lname = 'test', invoice_total = '100'";
                //cmd.ExecuteNonQuery();

            }
        }
    }
}