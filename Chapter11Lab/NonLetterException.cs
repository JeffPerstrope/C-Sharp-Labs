using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Lab
{
    class NonLetterException : Exception
    {
        private static string msg = "That is not a letter\n";
        public NonLetterException() : base(msg)
        {

        }
    }
}
