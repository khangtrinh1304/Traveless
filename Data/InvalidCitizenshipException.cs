using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    public class InvalidCitizenshipException : Exception
    {
        public InvalidCitizenshipException() : base("Invalid citizenship provided!!!") { }
        public InvalidCitizenshipException(string message) : base(message) { }
        public InvalidCitizenshipException(string message, Exception innerException) : base(message, innerException) { }
    }
}
