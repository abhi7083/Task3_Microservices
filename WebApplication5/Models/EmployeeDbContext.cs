using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {

        }
    }
}
