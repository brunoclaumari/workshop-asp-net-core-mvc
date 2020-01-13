using System;


namespace Sec17_SalesWebMvc.Services.Exceptions
{
    public class IntegrityException:ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
