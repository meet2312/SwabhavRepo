using System;


namespace BasicApp
{
    class Program
    {
        static void Main(string[] names)
        {
            Console.WriteLine(names.Length);
            for (int index = 0; index < names.Length; index++)
            {
               Console.WriteLine("Hello {1}", index, names[index]);
               

            }

            foreach (string name in names)
            {
               
                Console.WriteLine(name);
            }


        }


    }
}
