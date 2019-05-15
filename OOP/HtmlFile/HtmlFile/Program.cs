using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HtmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sWriter = new StreamWriter("E:\\SwabhavRepository\\OOP\\HtmlFile\\htmlfile.html") ;
            sWriter.WriteLine("<html>");
            sWriter.WriteLine("<body>");
            sWriter.WriteLine("<p> This is html web page </p>");
            sWriter.WriteLine("<table border ='1'>");
            sWriter.WriteLine("<tr>");
            sWriter.WriteLine("<td>First Name</td><td>Last Name</td>");
            sWriter.WriteLine("</tr>");
            sWriter.WriteLine("<tr>");
            sWriter.WriteLine("<td>Meet</td><td>Jhaveri</td>");
            sWriter.WriteLine("</tr>");
            sWriter.WriteLine("</table>");
            sWriter.WriteLine("</body>");
            sWriter.WriteLine("</html>");
            sWriter.Close();
        }
    }
}
