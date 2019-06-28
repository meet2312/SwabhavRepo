using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        delegate void DelegateOperation(int x, int y);
        static void Main(string[] args)
        {
            // Delegate instantiation  
            DelegateOperation[] obj =
           {
               new DelegateOperation(Operation.Add),
               new DelegateOperation(Operation.Multiple)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
            Console.ReadLine();
        }
    }
}
