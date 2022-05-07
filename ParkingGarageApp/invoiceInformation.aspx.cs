using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingGarageApp
{
    public partial class invoiceInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cardHolderNameTxt.Text = Request.Cookies["First"].Value + " " + Request.Cookies["Last"].Value;
            if (Request.Cookies["Monthly"] != null)
            {
                cardNumberTxt.Text = "Monthly, will be invoiced by admin";
                cardNumberTxt.Enabled = false;
                expirationDateTxt.Text = "0";
                expirationDateTxt.Enabled = false;
            }
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            int total;
            int hours = Int32.Parse(hoursParkingListBox.Text);
            string payInfo = cardNumberTxt.Text;
            total = hours * 2;
            string space = Request.Cookies["Space"].Value;
            string lName = Request.Cookies["Last"].Value;
            string fName = Request.Cookies["First"].Value;
            DateTime dtExit = DateTime.Parse(Request.Cookies["Date"].Value);
            dtExit = dtExit.AddHours(hours);
            
            if (payInfo == "Monthly, will be invoiced by admin")
            {
                total = 0;
                cardNumberTxt.Enabled=false;
                expirationDateTxt.Text = "0";
                expirationDateTxt.Enabled=false;
            }

            string scon = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(scon))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into invoice set customer_lname = (@1), customer_fname = (@2), invoice_pay_method = (@3), invoice_total = (@4), parkingspace_id = (@5), invoice_datetime = (@6)";
                cmd.Parameters.AddWithValue("@1", lName);
                cmd.Parameters.AddWithValue("@2", fName);
                cmd.Parameters.AddWithValue("@3", payInfo);
                cmd.Parameters.AddWithValue("@4", total);
                cmd.Parameters.AddWithValue("@5", space);
                cmd.Parameters.AddWithValue("@6", dtExit);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "update parkingspace set parkingspace_exit = (@1) where parkingspace_id = (@2)";
                cmd2.Parameters.AddWithValue("@1", dtExit);
                cmd2.Parameters.AddWithValue("@2", Int32.Parse(space));
                cmd2.ExecuteNonQuery();
                conn.Close();
            }

            Response.Redirect("confirmationPage.aspx");
        }
    }
}