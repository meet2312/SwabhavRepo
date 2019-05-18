using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public class GuitarSpec
    {
        private string builder, model, type, backWood, topWood;
        public GuitarSpec(GuitarBuilder.Builder builder, string model, GuitarType.Type type, WoodType.Wood backWood, WoodType.Wood topWood)
        {
            this.builder = builder.ToString();
            this.model = model;
            this.type = type.ToString();
            this.backWood = backWood.ToString();
            this.topWood = topWood.ToString();
        }
        public string getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public string getType()
        {
            return type;
        }

        public string getBackWood()
        {
            return backWood;
        }

        public string getTopWood()
        {
            return topWood;
        }
    }
    /*
    private String model;
    private Type type;
    private GuitarBuilder.Builder builder;
    private WoodType.Wood backWood;
    private WoodType.Wood topWood;

    public GuitarSpec(string model,Type type ,GuitarBuilder.Builder builder, WoodType.Wood backWood, WoodType.Wood topWood)
    {
        this.model = model;
        this.type = type;
        this.builder = builder;
        this.backWood = backWood;
        this.topWood = topWood;
    }
    public String getModel()
    {
        return model;
    }
    public Type getType()
    {
        return type;
    }
    public GuitarBuilder.Builder getBuilder()
    {
        return builder;
    }
    public WoodType.Wood getBackWood()
    {
        return backWood;
    }
    public WoodType.Wood getTopWood()
    {
        return topWood;
    }

}
*/
}
