using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_lab
{
    class MulMEx : Exception
    {
        public MulMEx(string message) : base(message)
        {
        }
    }
}
