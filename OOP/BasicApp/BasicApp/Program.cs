using System;


namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(names.Length);
            // for (int index = 0; index < names.Length; index++)
            //  {
            //      Console.WriteLine("Hello {1}", index, names[index]);

            //   }

            //    foreach (string name in names)
            //     {
            //      Console.WriteLine(name);
            //     }
            //      Number n = new Number();

            int[] no = new int[] { 22, 1, 34, 55, 89, 45 };

            //  int max;
            //GetMaximumNumbers(no);
            //Number n = new Number();
            int[] nos=Number.GetMaximumNumberss(no);
            for (int y = 0; y < nos.Length; y++)
            {
                Console.WriteLine(nos[y]);
            }
            Console.WriteLine("Highest no:{0}", nos[0]);
            Console.WriteLine("Second Highest no:{0}", nos[1]);



            // int[] a = GetMaximumNumberss(no);
            //   Console.WriteLine("Output : {0}, {1}", a.max, a.secmax);
            //  int max = 0;
            //Console.WriteLine(max);
            //Console.WriteLine("maximum no is :{0}", +max);

        }

        public static Tuple<int, int> GetMaximumNumbers(int[] no)
        {
            Console.WriteLine(no.Length);
            int max = no[0];
            int a = 0, secmax = 0;
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i] > max)
                {
                    max = no[i];

                }
                if (no[i] > a)
                {
                    secmax = a;
                    a = no[i];
                }
                else if (no[i] > secmax)
                {
                    secmax = no[i];
                }
            }
           // Console.WriteLine(max);
           // Console.WriteLine(secmax);
            return new Tuple<int, int>(max, secmax);
        }
    }
}
