using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Shared.CustomExceptions
{
    public class ApiException:Exception
    {
        public ApiException(string message,Exception innerException):base(message, innerException) 
        {

        }
        public ApiException(string message):base(message)
        {

        }
    }
}
