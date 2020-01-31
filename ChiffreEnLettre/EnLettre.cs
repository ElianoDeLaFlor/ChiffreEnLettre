using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public static class EnLettre
    {
        public static string Chiffre { get; set; }

        public static string  Resultat{ get { return Result(); } }

        private static string Result()
        {
            //juste pour faire les testes
            long k = Convert.ToInt64(Chiffre);
            string rslt;
            if(k.IsUnite())
            {
                //unite
                
                rslt=Unite.InLetter(k);
            }
            else if(k.IsDizaine())
            {
                //Dizaine
                rslt = Dizaine.DizainesInLetter(k);
            }
            else if(k.IsCentaine())
            {
                //centaine
                rslt = Centaine.CentaineInLetter(k);
            }
            else
            {
                //Millieme
                rslt = Millieme.MilleInLetter(k);
            }
            return rslt;
        }
        
    }
}
