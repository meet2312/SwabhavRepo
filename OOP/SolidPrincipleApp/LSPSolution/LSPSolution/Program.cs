using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeWidthIfHeightChanges(new Rectangle(50, 5));
        }

        public static void ShouldNotChangeWidthIfHeightChanges(Rectangle r)
        {
            int before = r.Width;
            r.SetHeight(100);
            int after = r.Width;

            Console.WriteLine("before:{0}", before);
            Console.WriteLine("after :{0}", after);
        }
    }
}
