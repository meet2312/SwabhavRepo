using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChap1
{
    public enum Builder
    {
        FENDER,MARTIN,GIBSON,COLLINGS,OLSON,RYAN,PRS,ANY
    }
    public static class GuitarBuilder
    {
        public static string GetString(this Builder b)
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
    }
}
