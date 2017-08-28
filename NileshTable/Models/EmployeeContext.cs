using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NileshTable.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext():
            base("MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}