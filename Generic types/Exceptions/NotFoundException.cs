using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
