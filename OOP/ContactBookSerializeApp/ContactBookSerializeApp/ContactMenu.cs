using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookSerializeApp
{
    class ContactMenu
    {
        public void Menu()
        {
            int opt;
          
            Console.Write("1-Add Contact.\n 2-Display contact.\n 3-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                  
                    break;
                case 3: break;
                default:
                    Console.Write("Input correct option\n");
                    break;

            }
            if (opt != 3)
            {
                Menu();
            }

        }

        private void AddContact()
        {
           // List<Contact> listofcontact = new List<Contact>();
            
            var contactbook = new List<Contact>();
            Console.WriteLine("Enter first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter mobile no:");
            double phoneno = Convert.ToDouble(Console.ReadLine());
         //   listofcontact=new List<Contact>() { firstname,lastname,email,phoneno};
            var contact = new Contact(firstname, lastname, email, phoneno);
                contactbook.Add(contact);
            DisplayContactadded(contactbook);
           // contactbook.AddRange(listofcontact);
            foreach (var c in contactbook)
            {
                Console.WriteLine(c);
            }
           
        }

        private void DisplayContactadded(List<Contact> listofcontact)
        {
            foreach (var c in listofcontact)
            {
                Console.WriteLine(c);
            }

        }

    }
}
