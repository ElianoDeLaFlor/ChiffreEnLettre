using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Billion:Millionieme
    {
        public static string BillionInLetter(long l)
        {
            string billion, rslt;
            
            //modulo
            long k = l % 1000000000;

            long billionn = (l - k) / 1000000000;

            if (billionn.IsUnite())
            {
                //Unite
                billion = InLetter(billionn);
            }
            else if (billionn.IsDizaine())
            {
                //Dizaine
                billion = $"{DizainesInLetter(billionn)}";
            }
            else if (billionn.IsCentaine())
            {
                //Centaine
                billion = $"{CentaineInLetter(billionn)}";
            }
            else if (billionn.IsMillieme())
            {
                //millième
                billion = $"{MilleInLetter(billionn)}";
            }
            else
            {
                //Million
                billion = MillionInLetter(billionn);
            }

            if (k.IsUnite())
            {
                //Unite
                rslt = $"{billion} Milliard {UniteDizaineCentaineInLetter(k)}";
            }
            else if (k.IsDizaine())
            {
                //Dizaine
                rslt = $"{billion} Milliard {DizainesInLetter(k)}";
            }
            else if (k.IsCentaine())
            {
                //Centaine
                rslt = $"{billion} Milliard {CentaineInLetter(k)}";
            }
            else if(k.IsMillieme())
            {
                //Mille
                rslt = $"{billion} Milliard {MilleInLetter(k)}";
            }
            else //if (k.IsMillionnieme())
            {
                //Million
                Millionieme.IsBillion = true;
                rslt = $"{billion} Milliard {MillionInLetter(k)}";
            }
            return rslt.Trim().FirstToUpperCase();
        }
    }
}
