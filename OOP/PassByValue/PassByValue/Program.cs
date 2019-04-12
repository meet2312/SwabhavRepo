using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int marks = 100;
            int[] markss = { 10, 20, 30, 40 };
            //Program p = new Program();
            ChangeMarksToZero(ref marks);
            ChangeAllMarksToZero(markss);
            Console.WriteLine("Marks is {0}", marks);
            foreach (int mark in markss)
            {
                Console.WriteLine(mark);
            }

            Product p = new Product();
            p.name = "aaaa";         
            p.price = 55;

            Console.WriteLine("Name of prod: " + p.name +
                              "\n prod price: " + p.price);

            ChangeDataToZero(p);

            Console.WriteLine("Name of prod: " + p.name +
                              "\n prod price: " + p.price);

            Car c1;

            // c1's data 
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron";


            // Displaying the values 
            Console.WriteLine("Name of brand: " + c1.Brand +
                              "\nModel name: " + c1.Model);
            ChangeDataToZero(c1);

            // ChangeDataToZero( c1.Brand, c1.Model);
            Console.WriteLine("Name of brand: " + c1.Brand +
                             "\nModel name: " + c1.Model);
        }

        static void ChangeDataToZero(Product p1)
        {


            // Console.WriteLine(c1.Brand);
            p1.name = "null";
            // Console.WriteLine(c1.Brand);
            p1.price = 0;
        }

        static void ChangeDataToZero(Car c)
        {


            // Console.WriteLine(c1.Brand);
            c.Brand = "null";
            // Console.WriteLine(c1.Brand);
            c.Model = "null";
        }

        // static void ChangeDataToZero(string brand,string model )
        // {

        //brand =default(string);
        // Console.WriteLine(brand);
        //  brand = "null";
        //  model = "null";
        //  }

        static void ChangeMarksToZero(ref int m)
        {
            m = 0;
        }

        static void ChangeAllMarksToZero(int[] newmarkss)
        {
            for (int i = 0; i < newmarkss.Length; i++)
            {
                newmarkss[i] = 0;
            }
        }


    }

   

   
}
