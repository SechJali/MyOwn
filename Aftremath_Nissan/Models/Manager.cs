using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aftremath_Nissan.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public string UserName { get; set; }
        public string Credentials { get; set; }
        public string Password { get; set; }
        public int StaffID { get; set; }
        public string DealInfo { get; set; }
        public string VehichleInfo { get; set; }
        public Double AmountPaid{ get; set; }
        public int CustomerID { get; set; }
        public string Comments { get; set; }

        public virtual Staff Saffs{ get; set; }
        public virtual Customer Customers { get; set; }


    }
}