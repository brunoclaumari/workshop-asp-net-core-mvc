using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sec17_SalesWebMvc.Models;

namespace Sec17_SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly Sec17_SalesWebMvcContext _context;

        public SellerService(Sec17_SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
