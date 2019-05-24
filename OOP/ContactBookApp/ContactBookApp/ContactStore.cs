using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApp
{
    class ContactStore
    {

        public List<string> DisplayContact()
        { 
            List<string> contactlist = ReadContent().ToList();
            return contactlist;
        }

        public void AddContact()
        {
            TextWriter tsw = new StreamWriter(@"E:\SwabhavRepository\OOP\ContactBookApp\Contact.txt", true);
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
            tsw.WriteLine("firstname:"+firstname+"lastname:"+lastname+"email:"+email+"phoneno:"+phoneno+",");
            tsw.Close();
            foreach (var contactss in contactbook)
            {
                Console.WriteLine(contactss);
            }
            //   DisplayContact(contactbook);

            ArrayList contacts = new ArrayList();
            contacts.Add()
            contacts = contactbook;

        }

        private string[] ReadContent()
        {
            string text = File.ReadAllText((@"E:\SwabhavRepository\OOP\ContactBookApp\Contact.txt"));
            string[] contactz = text.Split(',').ToArray();
            return contactz;
        }
        
    }
}



















/*
public List<string> DisplayContact()
{
    // ReadContacts r = new ReadContacts();
    //   string contactlist = ReadContent();
    List<string> contactlist = ReadContent().ToList();
    //  string[] contactlist;
    //  contactlist = ReadContent();
    //   Console.WriteLine(contactlist);
    //      foreach (var cont in contactlist)
    //      {
    //          Console.WriteLine(cont);
    //       }
    return contactlist;
}

    */
/*
  private string[] ReadContent()
        {
            string text = File.ReadAllText((@"E:\SwabhavRepository\OOP\ContactBookApp\Contact.txt"));
            string[] contactz = text.Split(',').ToArray();
         //   foreach(var c in contactz)
         //   {
         //       Console.WriteLine(c);
        //    }
           // contactz = 
           // Console.WriteLine("split:{0}", contactz);
            // Display the file contents to the console. Variable text is a string.
            //   System.Console.WriteLine("Contacts: {0}", text);
            return contactz;
        }
*/