using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    class Person
    {
        private double height;
        private double weight;
        private char gender;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'F' && value != 'M' && value != 'm' && value != 'f')
                {
                    Console.WriteLine("Invalid Gender.");
                }
                else
                {
                    gender = value;
                }
            }
        }

        public void eat()
        {
            weight = weight + (weight * 0.10);
        }


        /*  public void SetName(string namee)
          {
              name = namee;
          }*/
        /*  public string SetGender(char gen)
          {
              //gender = gen;
              if (gender == 'M')
              {
                  return "Male";
              }
              else if (gender == 'F')
              {
                  return "Female";
              }
              else return null;

          }
        /*  public void SetHeight(double hei)
          {
              height = hei;
          }
        /*  public void SetWeight(double wei)
          {
              weight = wei;
          }*/
        /*  public string GetName(string namee)
          {
              return name;
          }
          public double GetHeight(double hei)
          {
              return height;
          }
       /*   public double GetWeight(double wei)
          {
              return weight;
          }*/
        /*public char GetGender(string gen)
        {
            return gender;
        }
        */
        /*   public double eat()
           {
               weight = weight + (weight * 0.10);
               return weight;    
           }
           */

    }
}
