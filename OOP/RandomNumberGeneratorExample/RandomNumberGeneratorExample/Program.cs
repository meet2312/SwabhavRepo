using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGeneratorExample
{
    class Program
    {
        private bool _running = true;
       
        static void Main(string[] args)
        {
            int opt;
            Program program = new Program();
            Console.Write("A menu driven number guessing game\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");
            Console.Write("\nHere are the options :\n");
            Console.Write("1-Start Game.\n2-End Game.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Random rnd = new Random();
                    int number = rnd.Next(0, 100);
                   // Console.WriteLine(number);
                    while (program._running)
                    {
                        Console.WriteLine("Guess a number from 1 to 100 :");
                        int guessedno = Convert.ToInt16(Console.ReadLine());
                       
                        if (guessedno > number)
                        {
                            Console.WriteLine("Entered number is High");
                        }
                        else if (guessedno < number)
                        {
                            Console.WriteLine("Entered number is Low");
                        }
                        else if (guessedno == number)
                        {
                            Console.WriteLine("Matched");
                            program._running = false;
                        }
                    }
                    break;

                case 2:
                   break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }
        }
    }
}
