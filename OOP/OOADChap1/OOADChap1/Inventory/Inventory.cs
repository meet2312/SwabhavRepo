using System;
using System.Collections;
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
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price, GuitarBuilder.Builder builder, string model, GuitarType.Type type,
        WoodType.Wood backWood, WoodType.Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }

            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                GuitarSpec guitarSpec = guitar.getSpec();
                // Ignore serial number since that's uniquer
                // Ignore price since that's unique                    
                string builder = searchSpec.getBuilder();
                if (searchSpec.getBuilder() != searchSpec.getBuilder())
                    continue;
                String model = searchSpec.getModel().ToLower();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitarSpec.getModel().ToLower())))
                    continue;
                if (searchSpec.getType() != guitarSpec.getType())
                    continue;
                if (searchSpec.getBackWood() != guitarSpec.getBackWood())
                    continue;
                if (searchSpec.getTopWood() != guitarSpec.getTopWood())
                    continue;

                matchingGuitars.Add(guitar);

            }
            return matchingGuitars;
        }
    }
}

/*
        List<Guitar> guitarList;

        public Inventory()
        {
            guitarList = new ArrayList<GuitarSpec>();
        }


        public void addGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitarList.Add(guitar);
             
        }

        public Guitar getGuitar(Guitar guitar)
        {
            for (Guitar guitarData : guitarList)
            {
                if (guitarData.getSerialNumber().equals(guitar.getSerialNumber()))
                {
                    return guitarData;
                }
            }
            return null;
        }


        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> list = new ArrayList<GuitarSpec>();
            for (Guitar guitar : guitarList)
            {
                GuitarSpec guitarSpec = guitar.getGuitarSpec();
                if (searchSpec.getBuilder() != null || !searchSpec.getBuilder().Equals(guitarSpec.getBuilder()))
                {
                    continue;
                }

                if (searchSpec.getTopWood() == null || !searchSpec.getTopWood().Equals(guitarSpec.getTopWood()))
                {
                    continue;
                }

                if (searchSpec.getBackWood() == null || !searchSpec.getBackWood().Equals(guitarSpec.getBackWood()))
                {
                    continue;
                }

                if (searchSpec.getType() == null || !searchSpec.getType().Equals(guitarSpec.getType()))
                {
                    continue;
                }

                if (searchSpec.getModel() == null || !searchSpec.getModel().Equals(guitarSpec.getModel()))
                {
                    continue;
                }
                list.Add(guitar);
            }
            return list;
        }








        /*
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
        */
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
       /* 

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
 */