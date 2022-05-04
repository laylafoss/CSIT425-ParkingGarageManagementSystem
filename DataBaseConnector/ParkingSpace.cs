using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnector
{
    class ParkingSpace
    {
        private string parkingSpaceId;
        public string parkingSpaceLName;
        private string parkingSpaceFname;
        private string parkingSpacePlate;
        private string parkingSpaceNum;
        private string parkingSpaceMonthlyId;
        public ParkingSpace() { }
        public ParkingSpace(string id, string lnanme, string fname, string plate, string num, string mnthlyid)
        {
            this.parkingSpaceId = id;
            this.parkingSpaceLName = lnanme;
            this.parkingSpaceFname = fname;
            this.parkingSpacePlate = plate;
            this.parkingSpaceNum = num;
            this.parkingSpaceMonthlyId = mnthlyid;
        }
        public string ParkingspaceID { get { return parkingSpaceId; }  set { parkingSpaceId = value; }  }
        public string ParkingspaceLName { get { return parkingSpaceLName;  } set { parkingSpaceLName = value;  } }
        public string ParkingspaceFName { get { return parkingSpaceFname;  } set { parkingSpaceFname = value; } }
        public string ParkingspacePlate { get { return parkingSpacePlate; } set { parkingSpacePlate = value; } }
        public string ParkingspaceNum { get { return parkingSpaceNum; } set { parkingSpaceNum = value; } }
        public string ParkingspaceMonthlyId { get { return parkingSpaceMonthlyId; } set { parkingSpaceMonthlyId = value; } }
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
