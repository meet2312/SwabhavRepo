using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;
        public Guitar(String serialNumber, double price, GuitarBuilder.Builder builder, string model, GuitarType.Type type, WoodType.Wood backWood, WoodType.Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            spec = new GuitarSpec(builder, model, type, backWood, topWood);

        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec getSpec()
        {
            return spec;
        }

    }
    /*
    private String serialNumber;
    private double price;
    private GuitarSpec guitarSpec;

    public Guitar(string serialNumber,double price, GuitarSpec guitarSpec)
    {
        this.serialNumber = serialNumber;
        this.price = price;
        this.guitarSpec = guitarSpec;
    }

    public String getSerialNumber()
    {
        return serialNumber;
    }
    public double getPrice()
    {
        return price;
    }
    public GuitarSpec getGuitarSpec()
    {
        return guitarSpec;
    }


}
*/
}

























        /*  private string serialNo, builder, model, type, backWood, topWood;
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
          */
   
