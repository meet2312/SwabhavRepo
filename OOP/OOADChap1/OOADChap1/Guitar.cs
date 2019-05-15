using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public class Guitar
    {
        private string serialNo, builder, model, type, backWood, topWood;
        private double price;
        private string v1;
        private int v2;
        private Builder fENDER;
        private string v3;
        private Type eLECTRIC;
        private Wood aLDER1;
        private Wood aLDER2;

        public Guitar (string serialNo,double price, string builder, string model, string type,string backWood,string topWood)
        {
            this.serialNo = serialNo;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

   /*     public Guitar(string v1, int v2, Builder fENDER, string v3, Type eLECTRIC, Wood aLDER1, Wood aLDER2)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.fENDER = fENDER;
            this.v3 = v3;
            this.eLECTRIC = eLECTRIC;
            this.aLDER1 = aLDER1;
            this.aLDER2 = aLDER2;
        }
*/
        public string GetSerialNo()
        {
            return serialNo;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(float newprice)
        {
            this.price = newprice;
        }
        public string GetBuilder()
        {
            return builder;
        }
        public string GetModel()
        {
            return model;
        }
        public  new string  GetType()
        {
            return type;
        }
        public string GetBackWood()
        {
            return backWood;
        }
        public string GetTopWood()
        {
            return topWood;
        }

    }
}
