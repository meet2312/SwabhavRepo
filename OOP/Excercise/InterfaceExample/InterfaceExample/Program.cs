using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Bruno"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Max"));
            dogs.Sort();
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
            Console.ReadKey();
            */

            Transaction t1 = new Transaction("001", "27/02/2012", 78900.00);
            Transaction t2 = new Transaction("002", "23/12/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();

        }
    }

    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
            Console.WriteLine("");
        }
    }






     /* interface Animal
     {
         string Describe();

         string Name
         {
             get;
             set;
         }
     }

     class Dog : Animal, IComparable
     {
         private string name;

         public Dog(string name)
         {
             this.Name = name;
         }
         public string Describe()
         {
             return "Hello, I'm a dog : " + this.Name;
         }
          public int CompareTo(object obj)
         {
             if (obj is Animal)
                 return this.Name.CompareTo((obj as Animal).Name);
             return 0;
         }
         public string Name
         {
             get { return name; }
             set { name = value; }
         }
     }*/
}
