using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Account acc = new Account();
            Account account = new Account(7020, "xyz", 1200);
            Account account1 = new Account(9090, "abc",1500);
          //  PrintDetails(account);
            ReflectionData(acc);
        }

        public static void ReflectionData(Object obj)
        {
            Type field = typeof(Account);
            FieldInfo[] fieldInfo = field.GetFields();
            Console.WriteLine("Fields of project:");
            foreach (FieldInfo fields in fieldInfo)
            {
                
                Console.WriteLine(fields.FieldType);
            }
            Type type = typeof(Account);
            PropertyInfo[] propertyInfo = type.GetProperties();
            Console.WriteLine("property of project:");
            foreach (PropertyInfo properties in propertyInfo)
            {
               
                Console.WriteLine(properties.Name);
            }
           Type constructor = typeof(Account);
           ConstructorInfo[] constructorInfo = constructor.GetConstructors();
            Console.WriteLine("constructor of project:");
            foreach (ConstructorInfo construct in constructorInfo)
           {
               
                Console.WriteLine(construct);
           }
            Type method = typeof(Account);
            MethodInfo[] methodInfo = method.GetMethods();
            Console.WriteLine("method of project:");
            foreach (MethodInfo methods in methodInfo)
            {
              
                Console.WriteLine(methods);
            }
  
        }
        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Acc no:{0}", acc.Accno);
            Console.WriteLine("Name:{0}", acc.Name);
            Console.WriteLine("Balance:{0}", acc.Balance);
        }
    }
}
