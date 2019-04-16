using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContent
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tsw = new StreamWriter(@"E:\SwabhavRepository\OOP\FileContent\Hello.txt", true);

            //Writing text to the file.
            //tsw.WriteLine("Hello");
            tsw.WriteLine("qwerrty");

            //Close the file.
            tsw.Close();

            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"E:\SwabhavRepository\OOP\FileContent\Hello.txt");
            Read r = new Read();
            r.ReadContent();
            // Display the file contents to the console. Variable text is a string.
           // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // 

        }
    }
}
