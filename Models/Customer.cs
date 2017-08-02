using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aftremath_Nissan.Models
{
    public class Customer
    {
        public int CustomerID{ get; set; }
        public string DealInfo { get; set; }
        public string VehicleInfo{ get; set; }
        public string AmountPaidView{ get; set; }
        public string Comments{ get; set; }
        public List<Staff>Staffs { get; set; }
    }
}