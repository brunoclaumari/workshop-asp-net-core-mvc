using System;

namespace Sec17_SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException:ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }
}
