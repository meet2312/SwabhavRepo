using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            LinkedList<Guitar> guitars = new LinkedList<Guitar>();

        }

        public void AddGuitar(string serialNo, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNo, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNo)
        {
            foreach (var val in guitars)
            {
                if (val.GetSerialNo().Equals(serialNo))
                {
                    return val;
                }
            }
            return null;
        }

        /*     public Guitar Search(Guitar seachGuitar)
             {
                 foreach (var val in guitars)
                 {
                     string builder = seachGuitar.GetBuilder();
                     if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(val.GetBuilder())))
                     {
                         continue;
                     }
                     string model = seachGuitar.GetModel();
                     if ((model != null) && (!model.Equals("")) && (!model.Equals(val.GetBuilder())))
                     {
                         continue;
                     }
                     string type = seachGuitar.GetType();
                     if ((type != null) && (!seachGuitar.Equals("")) && (!type.Equals(val.GetBuilder())))
                     {
                         continue;
                     }
                     string backWood = seachGuitar.GetBackWood();
                     if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(val.GetBuilder())))
                     {
                         continue;
                     }
                     string topWood = seachGuitar.GetTopWood();
                     if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(val.GetBuilder())))
                     {
                         continue;
                     }

                 }
                 return null;
             }
          */


        public Guitar Search(Guitar seachGuitar)
        {
            foreach (var val in guitars)
            {
                if (seachGuitar.GetBuilder() != val.GetBuilder())
                {
                    continue;
                }
                string model = seachGuitar.GetModel().ToLower();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(val.GetModel().ToLower())))
                {
                    continue;
                }
                if (seachGuitar.GetType() != val.GetType())
                {
                    continue;
                }
                if (seachGuitar.GetBackWood() != val.GetBackWood())
                {
                    continue;
                }
                if (seachGuitar.GetTopWood() != val.GetTopWood())
                {
                    continue;
                }
                return null;
            }
        }













        public List<Guitar> Search(Guitar seachGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            
            return null;
        }

    }
}
