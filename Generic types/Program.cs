using Generic_types.Exceptions;
using System;

namespace Generic_types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
