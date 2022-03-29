using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
        }
    }
}
