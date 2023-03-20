using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    public class NoMoreSeatException : Exception
    {
        public NoMoreSeatException() : base("No more seat in this flight!!!") { }
        public NoMoreSeatException(string message) : base(message) { }
        public NoMoreSeatException(string message, Exception innerException) : base(message, innerException) { }
    }
}
