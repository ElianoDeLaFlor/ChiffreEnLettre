using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Millieme:Centaine
    {
        public static string MilleInLetter(long l)
        {
            string mille, rslt;

            //modulo
            long k = l % 1000;

            //long a = i - k;
            //long cnt = a / 1000;

            long mile = (l - k) / 1000;



            if (mile.IsUnite())
            {
                //Unite
                mille = UniteCentaineInLetter(mile);
            }
            else if (mile.IsDizaine())
            {
                //Dizaine
                mille = $"{DizainesInLetter(mile)} ";
            }
            else
            {
                //Centaine
                mille = $"{CentaineInLetter(mile)} ";
            }
             
            
            if (k.IsUnite())
            {
                //Unite
                rslt = $"{mille} mile {UniteDizaineCentaineInLetter(k)}";
            }
            else if (k.IsDizaine())
            {
                //Dizaine
                rslt = $"{mille} mile {DizainesInLetter(k)}";
            }
            else
            {
                //Dizaine
                rslt = $"{mille} mile {CentaineInLetter(k)}";
            }

            return rslt.Trim().FirstToUpperCase();
        }
    }
}
