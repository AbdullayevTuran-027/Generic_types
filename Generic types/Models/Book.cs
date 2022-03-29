using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, int count, string authorName, int pageCount):base(name, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id {Id} - Name {Name} - Price {Price} - Count {Count} - TotalInCome  {TotalInCome} - AuthorName {AuthorName}");
        }

        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalInCome += Price;
                return;
            }
            throw new NotImplementedException("mal yoxdu");
        }

       
    }
}
