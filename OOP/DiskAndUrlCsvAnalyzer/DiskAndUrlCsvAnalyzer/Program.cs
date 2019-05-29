using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskAndUrlCsvAnalyzer
{
    class Program
    {
       // public static HashSet<Employee> emplist = new HashSet<Employee>();
        static void Main(string[] args)
        {
            
            Loader.CsvLoader csv = new Loader.CsvLoader();
            //  csv.Load();
            Loader.UrlLoader ucsv = new Loader.UrlLoader();
            ucsv.Load();
            DataAnalyzer data = new DataAnalyzer();
            string maxsalary = data.MaxSalariedEmployee(csv.emplist);
            Console.WriteLine();
        //    Console.WriteLine("Max salaried employee is :" + maxsalary);
            Console.WriteLine();
            data.CountEmployeeByDesignation(csv.emplist);
            Console.WriteLine();
            data.CountEmployeeById(csv.emplist);
            Console.WriteLine();

            //  DataAnalyzer.Loading(new Loader.CsvLoader());


            string maxsalarys = data.MaxSalariedEmployee(ucsv.emplist);
            Console.WriteLine();
            Console.WriteLine("Max salaried employee is :" + maxsalarys);
            Console.WriteLine();
            data.CountEmployeeByDesignation(ucsv.emplist);
            Console.WriteLine();
            data.CountEmployeeById(ucsv.emplist);
            Console.WriteLine();

        }
    }
}
