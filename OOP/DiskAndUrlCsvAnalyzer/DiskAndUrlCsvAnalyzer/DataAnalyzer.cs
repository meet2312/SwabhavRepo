using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskAndUrlCsvAnalyzer
{
    class DataAnalyzer
    {
       
     //   public HashSet<Employee> emplist = new HashSet<Employee>();
        public DataAnalyzer(Loader.ILoader i)
        {
            i.Load();
        }

        public string MaxSalariedEmployee(HashSet<Employee> emplist)
        {
           // Loader.CsvLoader c = new Loader.CsvLoader();
            
            int max = 0;
            string name = null;

            foreach (var emp in emplist)
            {
                max = Math.Max(max, emp.Salary);
                if (emp.Salary.Equals(max))
                {
                    name = emp.Empname;
                }

            }
            //Console.WriteLine((name + "salary :" + max));
            return (name + "salary :" + max);
        }

        public void CountEmployeeById(HashSet<Employee> emplist)
        {
            List<string> deptno = new List<string>();
            foreach (var employee in emplist)
            {
                int total = 0;
                string id = employee.Deptno.ToString();
                if (!deptno.Contains(id))
                {
                    foreach (var employees in emplist)
                    {
                        if (id == employees.Deptno.ToString())
                        {
                            total = total + 1;
                        }
                    }
                    Console.WriteLine("Department no:" + id + " total no of employees:" + total);
                }
                deptno.Add(id);

            }
        }

        public void CountEmployeeByDesignation(HashSet<Employee> emplist)
        {
            
            List<string> empdesignation = new List<string>();
            foreach (var employee in emplist)
            {
                int total = 0;
                string designation = employee.Empdesignation;
                if(!empdesignation.Contains(designation))
                {
                    foreach(var employees in emplist)
                    {
                        if (designation == employees.Empdesignation)
                        {
                            total = total + 1;
                        }
                    }
                    Console.WriteLine("Designation:" + designation + "total no of employees :" + total);
                }
                empdesignation.Add(designation);
                
            }
            
        }

        public void CountEmployeeByDesignations(HashSet<Employee> emplist)
        {
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            foreach(var e in emplist)
            {
                dictionary.Add(e.Empid.ToString(), e.Empdesignation);
                
            }
            Dictionary<string, int> valCount = new Dictionary<string, int>();
            
            foreach (string i in dictionary.Values)
                if (valCount.ContainsKey(i))
                    valCount[i]++;
                else
                    valCount[i] = 1;
           
            foreach (KeyValuePair<string, int> kvp in valCount)
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
        }
    }
}
