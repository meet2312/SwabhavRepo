using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsvToList
{
    class Program
    {
        public static HashSet<Employee> emplist = new HashSet<Employee>();
        static void Main(string[] args)
        {

               LoadCsvfromDisk();
            //LoadCsvFromUrl();
            
        }

        private static void LoadCsvFromUrl()
        {

            string fileList = GetCSV("https://swabhav-tech.firebaseapp.com/emp.txt");
            string[] tempStr;

            tempStr = fileList.Split('\n');
            foreach (string employee in tempStr)
            {
                var values = employee.Split(',');

                emplist.Add(new Employee()
                {

                    Empid = int.Parse(values[0]),
                    Empname = values[1],
                    Empdesignation = values[2],
                    Managerid = values[3],
                    Dateofjoin = values[4],
                    Salary = int.Parse(values[5]),
                    Commission = values[6],
                    Deptno = int.Parse(values[7])


                });
            }
            foreach (var e in emplist)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", e.Empid.ToString(), e.Empname, e.Empdesignation, e.Managerid, e.Dateofjoin, e.Salary.ToString(), e.Commission, e.Deptno.ToString());
            }

        }

        private static void LoadCsvfromDisk()
        {
            string[] lines = File.ReadAllLines(@"E:\swabhav techlabs\empdata.txt");
            foreach (string employee in lines)
            {
                var values = employee.Split(',');

                emplist.Add(new Employee()
                {
                    Empid = int.Parse(values[0]),
                    Empname = values[1],
                    Empdesignation = values[2],
                    Managerid = values[3],
                    Dateofjoin = values[4],
                    Salary = int.Parse(values[5]),
                    Commission = values[6],
                    Deptno = int.Parse(values[7])
                });
            }
            foreach (var e in emplist)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", e.Empid.ToString(), e.Empname, e.Empdesignation, e.Managerid, e.Dateofjoin, e.Salary.ToString(), e.Commission, e.Deptno.ToString());
            }
            Console.WriteLine("{0}", emplist.Count);
        }

        public static string GetCSV(string url)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }

    }
}

