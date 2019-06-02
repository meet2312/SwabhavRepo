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
            DataAnalyzer  analyzer = new DataAnalyzer(new Loader.CsvLoader());
           // Loader.CsvLoader c = new Loader.CsvLoader();
           // c.Load();
          //  analyzer.CountEmployeeByDesignations(c.emplist);
         
            //DataAnalyzer data = new DataAnalyzer();
        //    Console.WriteLine("Disk loaded csv");
          //  DiskloadCsv(data);


         //   Console.WriteLine("Url loaded csv");
          //  UrlLoadCsv(data);

        }

        private static void UrlLoadCsv(DataAnalyzer data)
        {
            Loader.UrlLoader urlcsv = new Loader.UrlLoader();
            urlcsv.Load();
            string maxsalarys = data.MaxSalariedEmployee(urlcsv.emplist);
            Console.WriteLine();
            Console.WriteLine("Max salaried employee is :" + maxsalarys);
            Console.WriteLine();
            data.CountEmployeeByDesignation(urlcsv.emplist);
            Console.WriteLine();
            data.CountEmployeeById(urlcsv.emplist);
            Console.WriteLine();
        }

        private static void DiskloadCsv(DataAnalyzer data)
        {
            Loader.CsvLoader diskcsv = new Loader.CsvLoader();
            diskcsv.Load();

            string maxsalary = data.MaxSalariedEmployee(diskcsv.emplist);
            Console.WriteLine();
            //  Console.WriteLine("Max salaried employee is :" + maxsalary);
            Console.WriteLine();
            data.CountEmployeeByDesignation(diskcsv.emplist);
            Console.WriteLine();
            data.CountEmployeeById(diskcsv.emplist);
            Console.WriteLine();
        }
    }
}
