using System;
using System.Data.Entity;

namespace EntityFrameworkCRUDExample.Models
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}

