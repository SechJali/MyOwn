using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aftremath_Nissan.Context
{
    public class AftermathContext: DbContext
    {
        public AftermathContext():base("Nissan")
            {
            }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceDepartment> ServiceDepartments { get; set; }
    }
}