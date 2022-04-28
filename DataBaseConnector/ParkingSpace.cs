using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnector
{
    public class ParkingSpace
    {
        //public ParkingSpace() { }
        public string ParkingspaceID { get; set; }
        public string ParkingspaceLName { get; set; }
        public string ParkingspaceFName { get; set; }
        public string ParkingspacePlate { get; set; }
        public string ParkingspaceNumber { get; set; }
        public string ParkingspaceMonthlyId { get; set; }
    }
    public class MonthlyCustomer
    {
        public string MonthlyID { get; set; }
        public string MonthlyLName { get; set; }
        public string MonthlyFName { get; set; }
        public string MonthlyPlate { get; set; }
        public string MonthlyPhone { get; set; }
        public string MonthlyParkingSpaceID { get; set; }
    }
    public class Invoice
    {
        public string InvoiceID { get; set; }
        public string InvoiceLName { get; set; }
        public string InvoiceFName { get; set; }
        public string InvoiceMethod { get; set; }
        public double InvoiceTotal { get; set; }
    }
    
    
}
