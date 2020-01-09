using System;

namespace Sec17_SalesWebMvc.Services.Exceptions
{
    public class NotFoundException: ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
