using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Exceptions
{
    public class WrongBirthDateException : Exception
    {
        public WrongBirthDateException()
        {
        }

        public WrongBirthDateException(string message)
            : base(message)
        {
        }

        public WrongBirthDateException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
