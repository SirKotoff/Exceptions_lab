using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_lab
{
    class MatrixEx : Exception
    {
        public MatrixEx(string message) : base(message)
        {
        }
    }
}
