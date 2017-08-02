using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aftremath_Nissan.Models
{
    public class Staff
    {
        public int StaffID{ get; set; }
        public string DealInfo{ get; set; }
        public string VehicleInfo{ get; set; }
        public double AmountPaid{ get; set; }
        public string StaffInfo { get; set; }

        public int CustomerID{ get; set; }
        public string Comments{ get; set; }

        public virtual  Customer Customers{ get; set; }
        public List<Manager> Managers { get; set; }


    }
}