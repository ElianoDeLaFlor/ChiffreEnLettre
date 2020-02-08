using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Millionieme:Millieme
    {
        public static bool IsBillion { get; set; } = false;
        public static string MillionInLetter(long l)
        {
            string million, rslt;

            //modulo
            long k = l % 1000000;

            long millionn = (l - k) / 1000000;

            if (millionn.IsUnite())
            {
                //Unite
                million = InLetter(millionn);
            }
            else if (millionn.IsDizaine())
            {
                //Dizaine
                million = $"{DizainesInLetter(millionn)}";
            }
            else
            {
                //Centaine
                million = $"{CentaineInLetter(millionn)}";
            }


            if (k.IsUnite())
            {
                //Unite
                rslt = $"{million} million {UniteDizaineCentaineInLetter(k)}";
            }
            else if (k.IsDizaine())
            {
                //Dizaine
                rslt = $"{million} million {DizainesInLetter(k)}";
            }
            else if(k.IsCentaine())
            {
                //Centaine
                rslt = $"{million} million {CentaineInLetter(k)}";
            }
            else if (k.IsMillieme())
            {
                rslt =$"{million} million {MilleInLetter(k)}";
            }
            else
            {
                //million
                if (IsBillion)
                {
                    if (million == "Zéro ")
                        rslt = MilleInLetter(k);
                    else
                        rslt = $"{ million} million {MillionInLetter(k)}";
                }
                else
                {
                    rslt = $"{million} million {MillionInLetter(k)}";
                }
            }

            return rslt.Trim().FirstToUpperCase();
        }
    }
}
