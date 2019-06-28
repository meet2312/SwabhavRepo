using FactoryMethodLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryClient
{
   public class Program
    {
        static void Main(string[] args)
        {
            // IAutoMobileFactory fact = BMWFactory.GetInstance();
            //   IAutoMobileFactory fact = LoadFactoryFromFile();

            //   string fact = LoadFactoryFromFile();
            //      IAutoMobile auto = fact.Make();
            //      auto.Start();
            //     auto.Stop();
           // Type mytype = (typeof(AudiFactory));
           // Dummy d = new Dummy();
             LoadFromFile();
//
        //    string fact = ConfigurationManager.AppSettings["Loadfactory"];
         //   Type type = Type.GetType(fact);
           
         //   IAutoMobileFactory  factory = (IAutoMobileFactory)type.GetMethod("GetInstance");
       //     IAutoMobile auto = factory.Make();
     //       auto.Start();
     //       auto.Stop();
        }
         public static void LoadFromFile()
        {
            
            try
            {
               // Console.WriteLine(typeof(AudiFactory).AssemblyQualifiedName);
                string class1 = ConfigurationManager.AppSettings["load"];
               // Console.WriteLine(class1);
                //MethodBase type = Type.GetType(class1).GetMethod("GetInstance", null);
                MethodInfo type =Type.GetType(class1).GetMethod("GetInstance");
               //MethodInfo[] type = Type.GetType(class1).GetMethods();
                IAutoMobileFactory factory=null;
                //   var m = type.Invoke("GetInstance", new Type[0]);
                // Console.WriteLine(type);
              //  factory = (IAutoMobileFactory)type[0];
               factory = (IAutoMobileFactory)type.Invoke(null, null);
                 IAutoMobile auto = factory.Make();
                 auto.Start();
                 auto.Stop();
                
              


                /*  if (appSettings.Count == 0)
                  {
                      Console.WriteLine("AppSettings is empty.");
                  }
                  else
                  {
                      foreach (var key in appSettings.AllKeys)
                      {
                          Console.WriteLine("Key: {0} Value: {1}", key, appSettings["Loadfactory"]);
                      }
                  }*/
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

      /*  private static IAutoMobileFactory LoadFactoryFromFile()
        {
            // var fullMethodName = System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.FullName;
            // Console.WriteLine(fullMethodName);
            //  return fullMethodName;
            return new BMWFactory();
        }*/
    }
}
