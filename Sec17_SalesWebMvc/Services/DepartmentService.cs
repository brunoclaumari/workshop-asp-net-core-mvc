using Sec17_SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sec17_SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly Sec17_SalesWebMvcContext _context;

        public DepartmentService(Sec17_SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
