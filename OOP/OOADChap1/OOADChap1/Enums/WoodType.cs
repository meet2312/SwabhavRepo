using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    
    public static class WoodType
    {
        public enum Wood
        {
            INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
        }
        public static string ToString(Enum e)
        {
            switch (e.ToString())
            {
                case "INDIAN_ROSEWOOD": return "indian_rosewood";
                case "BRAZILIAN_ROSEWOOD": return "brazilian_rosewood";
                case "MAHOGANY": return "mahogany";
                case "MAPLE": return "maple";
                case "COCOBOLO": return "cocobolo";
                case "CEDAR": return "cedar";
                case "ADIRONDACK": return "adirondack";
                case "ALDER": return "alder";
                case "SITKA": return "sitka";
            }
            return null;
        }
       


        /* public static string GetString(this Wood w)
         {
             switch (w)
             {
                 case Wood.INDIAN_ROSEWOOD: return "indian_rosewood";
                 case Wood.BRAZILIAN_ROSEWOOD: return "brazilian_rosewood";
                 case Wood.MAHOGANY: return "mahogany";
                 case Wood.MAPLE: return "maple";
                 case Wood.COCOBOLO: return "cocobolo";
                 case Wood.CEDAR: return "cedar";
                 case Wood.ADIRONDACK: return "adirondack";
                 case Wood.ALDER: return "alder";
                 case Wood.SITKA: return "sitka";
             }
             return null;
         }*/
    }
}
