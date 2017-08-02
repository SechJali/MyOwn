using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aftremath_Nissan.Models
{
    public class ServiceDepartment
    {
        public int ServiceID{ get; set; }
        public int CustomerID{ get; set; }
        public string VehicleVIN{ get; set; }
        public string RegNo { get; set; }
        public string Status{ get; set; }
        public string StaffInfo{ get; set; }
        public string Progress{ get; set; }
        public string Comments{ get; set; }

        public virtual Customer Customers { get; set; }
    }
}