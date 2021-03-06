﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    class FindGuitarTester
    {
        static void Main(string[] args)
        {
            GuitarBuilder.ToString(default(GuitarBuilder.Builder));

            GuitarType.ToString(default(GuitarType.Type));

            WoodType.ToString(default(WoodType.Wood));
            Inventory inventory = new Inventory();
            initializeInvetory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(GuitarBuilder.Builder.FENDER, "Stratocastor",GuitarType.Type.ELECTRIC, WoodType.Wood.MAPLE, WoodType.Wood.CEDAR);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars != null)
            {

                Console.WriteLine("Erin, you might like these guitars :");

                foreach (Guitar guitar in matchingGuitars)  // we can use foreach instead of IEnumerator to loop thorugh the collection
                {

                    GuitarSpec spec = guitar.getSpec();
                    Console.WriteLine(" We have a " +
                    spec.getBuilder() + " " + spec.getModel() + " " +
                    spec.getType() + " guitar : \n    " +
                    spec.getBackWood() + " back and sides, \n    " +
                    spec.getTopWood() + " top. \nYou can have it only for $" +
                    guitar.getPrice() + " ! ");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInvetory(Inventory inventory)
        {
            inventory.addGuitar("1", 3000, GuitarBuilder.Builder.FENDER, "Stratocastor",GuitarType.Type.ELECTRIC, WoodType.Wood.MAPLE, WoodType.Wood.CEDAR);
            inventory.addGuitar("2", 3500,GuitarBuilder.Builder.FENDER, "Stratocastor", GuitarType.Type.ELECTRIC, WoodType.Wood.MAPLE, WoodType.Wood.CEDAR);
            inventory.addGuitar("3", 4000, GuitarBuilder.Builder.OLSON, "Stratocastor", GuitarType.Type.ACOUSTIC, WoodType.Wood.ALDER, WoodType.Wood.ALDER);

        }
    }
}
