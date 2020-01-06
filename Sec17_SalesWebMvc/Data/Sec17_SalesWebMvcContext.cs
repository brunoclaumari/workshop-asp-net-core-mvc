using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sec17_SalesWebMvc.Models
{
    public class Sec17_SalesWebMvcContext : DbContext
    {
        public Sec17_SalesWebMvcContext (DbContextOptions<Sec17_SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
