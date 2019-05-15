using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public enum Type
    {
        ACOUSTIC,ELECTRIC
    }

   public static class GuitarType
    {
        public static string GetString(this Type t)
        {
            switch(t)
            {
                case Type.ACOUSTIC: return "acoustic";
                case Type.ELECTRIC: return "electric";
            }
            return null;
        }
    }



}
