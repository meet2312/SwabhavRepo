using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContent
{
    class Read
    {
        public void ReadContent()
        {
            string text = File.ReadAllText(@"E:\SwabhavRepository\OOP\FileContent\Hello.txt");

            // Display the file contents to the console. Variable text is a string.
             System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
       
        }
    }
}
