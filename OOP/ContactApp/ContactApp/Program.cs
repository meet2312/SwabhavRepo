using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    class Program
    {
        Program p = new Program();
        static void Main(string[] args)
        {
           // ArrayList contacts = new ArrayList();
            ContactAdd ca = new ContactAdd();
            ca.Menu();
        }
    }
    class ContactAdd
    {
        public void Menu()
        {
            int opt;
            ArrayList list = new ArrayList();
            Console.Write("1-Add Contact.\n 2-Display contact.\n 3-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1: AddContact();
                    break;
                case 2: DisplayContact(list);
                    break;
                case 3: break;
                default:
                    Console.Write("Input correct option\n");
                    break;

            }
            if(opt != 3)
            {
                Menu();
            }

        }


        public  void DisplayContact(ArrayList list)
        {
            ReadContacts r = new ReadContacts();
            r.ReadContent();
        //    foreach (var cont in list)
        //    {
        //        Console.WriteLine(cont);
        //    }
           
        }

        public  void AddContact()
        {
            TextWriter tsw = new StreamWriter(@"E:\SwabhavRepository\OOP\ContactApp\Contact.txt", true);
            var contactbook = new ArrayList();
            Console.WriteLine("Enter first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter mobile no:");
            double phoneno = Convert.ToDouble(Console.ReadLine());
            var contact = new Contact(firstname, lastname, email, phoneno);
            contactbook.Add(contact);
            Console.WriteLine("contact added");
            tsw.WriteLine("firstname:"+firstname+ " lastname:"+lastname+ " email:"+email+ " phoneno:"+phoneno);
            tsw.Close();
            foreach(var contactss in contactbook)
             {
                Console.WriteLine(contactss);
             }
         //   DisplayContact(contactbook);

            ArrayList contacts = new ArrayList();
            contacts = contactbook;
            foreach (var x in contacts)
            {
                Console.WriteLine(x);
            }
        }
        
        
    }
}

