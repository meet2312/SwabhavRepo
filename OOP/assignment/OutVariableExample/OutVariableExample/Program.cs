using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string authorName, bookTitle;
            long publishedYear;
            AuthorByOutParam(out authorName, out bookTitle, out publishedYear);
            Console.WriteLine("Author: {0}, Book: {1}, Year: {2}",
            authorName, bookTitle, publishedYear);
            Console.ReadKey();
        }

        static void AuthorByOutParam(out string name, out string title, out long year)
        {
            name = "Chetan Bhagat";
            title = "3 Mistakes of my Life";
            year = 2001;
        }
    }
}

