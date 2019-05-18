using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{

    public static class GuitarBuilder
    {
        public enum Builder
        {
            FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
        }
        public static string ToString(Enum e)
        {
            switch (e.ToString())
            {
                case "FENDER": return "fender";
                case "MARTIN": return "martin";
                case "GIBSON": return "gibson";
                case "COLLINGS": return "collings";
                case "OLSON": return "olson";
                case "RYAN": return "ryan";
                case "PRS": return "prs";
                case "ANY": return "any";
            }
            return null;
        }

       




        /* public static string GetString(this Builder b)
         {
             switch (b)
             {
                 case Builder.FENDER: return "fender";
                 case Builder.MARTIN: return "martin";
                 case Builder.GIBSON: return "gibson";
                 case Builder.COLLINGS: return "collings";
                 case Builder.OLSON: return "olson";
                 case Builder.RYAN: return "ryan";
                 case Builder.PRS:return "prs";
                 case Builder.ANY: return "any";
             }
             return null;
         }
     }*/
    }
}
