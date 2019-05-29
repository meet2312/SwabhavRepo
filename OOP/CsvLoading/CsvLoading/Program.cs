using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsvLoading
{
    class Program
    {
       // public static List<Employee> emplist = new List<Employee>();
        static void Main(string[] args)
        {
            // List<Employee> employeelist = new List<Employee>();
            //     List<string> emp = ReadFile();
            //    foreach(string e in emp)
            //     {
            //         Console.WriteLine(e);
            //      }
            //ReadFile();
            //    GetCSV("http://swabhav-tech.firebaseapp.com/emp.txt");
              SplitCSV();
           // string[] f = GetCSV("http://swabhav-tech.firebaseapp.com/emp.txt");
           

        }

       
        private static void ReadFile()
        {

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
            var result = results.Split('\n');
           
           foreach(string r in result)
            {
               // Console.WriteLine(r);

               // Console.WriteLine("-------");
            }
            string final=ConvertStringArrayToString(result);
           // Console.WriteLine(final);
            return final;
           
        }
        static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                
                builder.Append(value);
                builder.AppendLine("\n");
               
            }
            Console.WriteLine(builder);
            return builder.ToString();
        }
        private static void SplitCSV()
        {

            List<Employee> emplist = new List<Employee>();
            //  List<string> splitted = new List<string>();
            string lines = GetCSV("http://swabhav-tech.firebaseapp.com/emp.txt");
           // var line = lines.Split(Environment.NewLine.ToCharArray());
       //     Console.WriteLine(lines);
           

               string[] tempS = lines.Split(',');
                for (int i = 0; i < tempS.Length;i++)
               {
                Console.WriteLine("{0}", tempS[i]);
                emplist.Add((new Employee()
                    {
                    Empid = int.Parse(tempS[0]),
                    Empname = tempS[1],
                    Empdesignation = tempS[2],
                    Managerid = tempS[3],
                    Dateofjoin = tempS[4],
                    Salary = (tempS[5]),
                    Commission = tempS[6],
                    Deptno = int.Parse(tempS[7])
                }));
            }
              
           //    Console.WriteLine("{0}", tempS[1]);
          //     Console.WriteLine("{0}", tempS[2]);
           //    Console.WriteLine("{0}", tempS[3]);
           //    Console.WriteLine("{0}", tempS[4]);
          //     Console.WriteLine("{0}", tempS[5]);
          //     Console.WriteLine("{0}", tempS[6]);
         //      Console.WriteLine("{0}", tempS[7]);
        //       Console.WriteLine("{0}", tempS[8]);
         //   Console.WriteLine("{0}", tempS[9]);
            //    Console.WriteLine("{0}", tempS[2]);

            /*    foreach (var i in lines)
                {
                     if (!String.IsNullOrWhiteSpace(lines))
                        {
                         string[] tempS = lines.Split(',');
                        // if(tempS.Length >= 7)
                        //   {
                        emplist.Add(new Employee()
                        {
                            //     Empid = int.Parse(tempS[0]),
                                Empname = tempS[1],
                                Empdesignation = tempS[2],
                                Managerid = tempS[3],
                                Dateofjoin = tempS[4],
                                Salary = (tempS[5]),
                                Commission = tempS[6],
                           //     Deptno = int.Parse(tempS[7])


                            });
                        //}
                        // var values = employee.Split(',');
                        //  var tempStr = lines.Split(',');
               //         Console.WriteLine("{0} {1} {2} {3} {4} {5} ", tempS[1], tempS[2], tempS[3], tempS[4], tempS[5], tempS[6]);
                    }
                 //   Console.WriteLine(i);
                  // Console.WriteLine("{0} {1} {2} {3} {4} {5} ",tempS[1],tempS[2],tempS[3],tempS[4],tempS[5],tempS[6]);
                }

        */
            //  foreach (Employee x in emplist)
            //  {

            //    Console.WriteLine("{0} {1} {2} {3} {4} {5} ", x.Empname, x.Empdesignation, x.Managerid, x.Dateofjoin, x.Salary, x.Commission);
            //  }
            //  foreach (string item in tempStr)
            //{
            //  if (!string.IsNullOrWhiteSpace(item))
            //{
            //  splitted.Add(item);
            //}
            //}
        }
       
    }

    }

