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

        public DbSet<Sec17_SalesWebMvc.Models.Department> Department { get; set; }
    }
}
