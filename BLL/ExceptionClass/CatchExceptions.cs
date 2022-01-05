using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ExceptionClass
{
    public class CatchExceptions : Exception
    {
        public CatchExceptions(string message) : base(message) { }
    }
}
