using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Exceptions
{
    internal class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message)
        {

        }
    }
}
