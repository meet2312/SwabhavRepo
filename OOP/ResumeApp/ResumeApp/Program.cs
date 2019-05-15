using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ResumeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sWriter = new StreamWriter("E:\\SwabhavRepository\\OOP\\ResumeApp\\resume.html");
            sWriter.WriteLine("<html>");
            sWriter.WriteLine("<HEAD>");
            sWriter.WriteLine("<TITLE>Hunter S. Jobseeker</TITLE>");
            sWriter.WriteLine("</HEAD>");
            sWriter.WriteLine("<BODY BGCOLOR=#FFFFFF>");
            sWriter.WriteLine("<H1>Hunter S. Jobseeker</H1>");
            sWriter.WriteLine("<TABLE WIDTH=”100%”>");
            sWriter.WriteLine("<table border ='1'>");
            sWriter.WriteLine("<TR><TD ALIGN=”left”>12013 Future Drive</TD>");
            sWriter.WriteLine("<TD ALIGN=”right”>Residence (305) 555-1212</TD></TR>");
            sWriter.WriteLine("<TR><TD ALIGN=”left”>New York, NY 10019</TD>");
            sWriter.WriteLine("<TD ALIGN=”right”>Message (305) 555-1213</TD></TR>");
            sWriter.WriteLine("</TD></TR>");
            sWriter.WriteLine("<TD ALIGN=”right”>Email: jobseeker@internet.com</TD></TR>");
            sWriter.WriteLine("<H2>Objective</H2>");
            sWriter.WriteLine("<TABLE><TR><TD>&nbsp;</TD>");
            sWriter.WriteLine("<TD>Marketing, public relations or sales position with a medical equipment company.</TD></TR></TABLE>");
            sWriter.WriteLine("<H2>Sales Experience</H2>");
            sWriter.WriteLine("<H3>March 2013 to Present</H3>");
            sWriter.WriteLine("<TABLE><TR><TD>&nbsp;</TD>");
            sWriter.WriteLine("<TD>Commissioned Salesperson — Fine Jewelry<BR>");
            sWriter.WriteLine("Macy’s Department Store, New York, New York<UL>");
            sWriter.WriteLine("<LI>Sell men’s and women’s jewelry, develop positive customer relations, provide sales promotion support for upper management, and maintain a product inventory worth up to $3 million.</LI>");
            sWriter.WriteLine("<LI>Achieved 100 percent or more of sales quota since employed.</LI></UL></TD></TR></TABLE>");
            sWriter.WriteLine("<H3>May 1990 to November 2012</H3>");
            sWriter.WriteLine("<TABLE><TR><TD>&nbsp;</TD>");
            sWriter.WriteLine("<TD>Commissioned Salesperson — Men’s Suits<BR>");
            sWriter.WriteLine("Barney’s, New York, New York<UL><LI>");
            sWriter.WriteLine("Sold men’s suits, established customer relations, handled staff scheduling duties, and ordered merchandise. kept track of market trends and effectively reformatted the store’s accounting system as it pertained to this department.</LI>");
            sWriter.WriteLine("<LI>Ranked first, second, or third in every sales program during period of employment.</LI></UL></TD></TR></TABLE>");
            sWriter.WriteLine("<H2>Additional Experience</H2>");
            sWriter.WriteLine("<H3>June 1987 to November 1989</H3>");
            sWriter.WriteLine("<UL><LI>Part-time and summer employment experience: Zoo Worker, Bronx Zoo, New York, summer 1987.</LI>");
            sWriter.WriteLine("<LI>Word Processor and Medical Records Assistant, Mercy Hospital, New York, September 1987 – November 1989.</LI></UL>");
            sWriter.WriteLine("<H2>Education</H2>");
            sWriter.WriteLine("<TABLE><TR><TD>&nbsp;</TD>");
            sWriter.WriteLine("<TD>Bachelor of Arts in Biology — December 1989");
            sWriter.WriteLine("<BR>Columbia University<BR>");
            sWriter.WriteLine("GPA: 3.5/4.0</TD></TR></TABLE>");
            sWriter.WriteLine("<H2>Activities</H2>");
            sWriter.WriteLine("<TABLE><TR><TD>&nbsp;</TD>");
            sWriter.WriteLine("<TD>Vice President 1989, Social Chair 1987, Pi Beta Phi Sorority</TD></TR></TABLE></BODY>");
            sWriter.WriteLine("</HTML>");
            sWriter.Close();
        }
    }
}
