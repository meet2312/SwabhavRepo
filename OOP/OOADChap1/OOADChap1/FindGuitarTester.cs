using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public class FindGuitarTester
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);
            Guitar WhatErinLikes = new Guitar("",0,"Fender","stratocastor","electric","Alder","Alder");
            Guitar guitar = inventory.Search(WhatErinLikes);
       //     List<> matchingGuitars =  inventory.Search(WhatErinLikes);
            if (guitar != null)
            {
                Console.WriteLine("Erin,u might like this" + guitar.GetBuilder() + "" + guitar.GetModel() + "" + guitar.GetType() + "guitar:\n" + guitar.GetBackWood() + "back and sides \n " + guitar.GetTopWood() + "top \n . You can have only for " + guitar.GetPrice() + "!");
            }
            else
            {
                Console.WriteLine("Sorry erin we have nothing for u");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, "Fender", "Stratocastor", "electric", "Alder", "Alder");
            inventory.AddGuitar("V9512",1549.95,"Fender")
        }
    }
}
