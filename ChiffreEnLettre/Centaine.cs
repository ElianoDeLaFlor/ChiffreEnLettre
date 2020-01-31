using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Centaine:Dizaine
    {
        public static string CentaineInLetter(long i)
        {
            string cent, rslt;

            //modulo
            long k = i % 100;

            //long a = i - k;
            //long cnt = a / 100;

            long cnt = (i - k) / 100;

            cent = UniteCentaineInLetter(cnt);

            if (k.IsUnite())
            {
                //Unite
                rslt = cent + " cent " + UniteDizaineCentaineInLetter(k);
            }
            else
            {
                //Dizaine
                rslt = cent + " cent " + (DizainesInLetter(k)).ToLower();
            }

            return rslt.FirstToUpperCase().Trim();
        }
    }
}
