using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApp
{
    class ContactMenu
    {
        public void Menu()
        {
            int opt;
            ContactStore contactstore = new ContactStore();
            ArrayList list = new ArrayList();
            Console.Write("1-Add Contact.\n 2-Display contact.\n 3-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    contactstore.AddContact();
                    break;
                case 2:
                    List<string> finalcontactlist = contactstore.DisplayContact();
                  
                    foreach(var c in finalcontactlist)
                    {
                        Console.WriteLine(c);
                    }
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
    }
}





















//   string contact=contactstore.DisplayContact();
//  string[] contact = contactstore.DisplayContact();
