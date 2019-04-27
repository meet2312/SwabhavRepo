using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    public struct Car
    {
        // Declaring different data types 
        public string Brand;
        public string Model;
        public string Color;
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Car c1;

            // c1's data 
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron";
            c1.Color = "Gray";

            // Displaying the values 
            Console.WriteLine("Name of brand: " + c1.Brand +
                              "\nModel name: " + c1.Model +
                              "\nColor of car: " + c1.Color);
        }
    }
}
