using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExample
{
    class Movie
    {
        public string title;
        public string genre;
        public int rating;
        public void playIt()
        {
            Console.WriteLine("Playing the movie");
        }
    }
}
