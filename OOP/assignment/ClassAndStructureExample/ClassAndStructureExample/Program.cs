using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Program
    {
        // Data members of class 
        public string name;
        public string language;
        public int article_no;


        // Method of class 
        public void Details(string name, string language,
                            int article_no)
        {
            this.name = name;
            this.language = language;
            this.article_no = article_no;


            Console.WriteLine("The name of the author is :  " + name
                              + "\nThe name of language is : " + language
                              + "\nTotal number of article published  "
                              + article_no);
        }

        static void Main(string[] args)
        {
            // Creating object 
            Program obj = new Program();

            // Calling method of class 
            // using class object 
            obj.Details("Sandeep", "C#", 80);
        }

    }
}
