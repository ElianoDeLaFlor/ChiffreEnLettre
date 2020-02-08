using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public static class EnLettre
    {
        /// <summary>
        /// Le nombre à transcrire
        /// </summary>
        public static string Chiffre { get; set; }
        private static int ZeroCnt { get; set; }
        private static bool IsOverFlow { get; set; }
        private static bool IsDecimal { get; set; } = false;

        //Obtient les differentes parties du nombre à transcrire
        private static Tuple<bool, long, long> GetParts(string numbertoread)
        {
            long PartieEntiere, PartieDecimale;

            if (numbertoread.Contains(','))
            {
                //Un nombre décimal
                PartieEntiere = ManagePart(numbertoread.Split(',')[0]);

                IsDecimal = true;
                PartieDecimale = ManagePart(numbertoread.Split(',')[1]);

                if (PartieDecimale == 0)
                    IsDecimal = false;

                return new Tuple<bool, long, long>(IsDecimal, PartieEntiere, PartieDecimale);
            }
            else
            {
                // Un nombre entier
                PartieEntiere = ManagePart(numbertoread);
                return new Tuple<bool, long, long>(false, PartieEntiere, 0L);
            }
        }


        private static long ManagePart(string str)
        {
            long chiffre;
            if (str.Length != 0)
            {
                if (str.Length > 18)
                {
                    //Overflow
                    IsOverFlow = true;
                    chiffre = 0;
                }
                else
                {
                    IsOverFlow = false;
                    ZeroCnt=GetZeroCount(str);
                    chiffre = str.ToLong();
                }
            }
            else
            {
                chiffre = 0;
            }

            return chiffre;
        }

        /// <summary>
        /// Compte le nombre de zéro après la virgule
        /// </summary>
        /// <param name="decimalpart">La partie décimale du nombre à transcrire</param>
        /// <returns>retourne un int</returns>
        private static int GetZeroCount(string decimalpart)
        {
            if (IsDecimal)
            {
                int i = 0;
                while (decimalpart[i] == '0')
                {
                    i++;
                }
                return i;
            }
            return 0;
        }

        public static string Resultat { get { return Result(); } }

        /// <summary>
        /// Transcrit la partie entière ou la partie décimale
        /// </summary>
        /// <param name="k">Le nombre à lire</param>
        /// <returns>retourne un string</returns>
        private static string PartReader(long k)
        {
            string rslt;
            if (k.IsUnite())
            {
                //unite

                rslt = Unite.InLetter(k);
            }
            else if (k.IsDizaine())
            {
                //Dizaine
                rslt = Dizaine.DizainesInLetter(k);
            }
            else if (k.IsCentaine())
            {
                //centaine
                rslt = Centaine.CentaineInLetter(k);
            }
            else if (k.IsMillieme())
            {
                //Millieme
                rslt = Millieme.MilleInLetter(k);
            }
            else if (k.IsMillionnieme())
            {
                //Million
                rslt = Millionieme.MillionInLetter(k);
            }
            else
            {
                //Milliard
                rslt = Billion.BillionInLetter(k);
            }
            return rslt;
        }

        /// <summary>
        /// Retourne la transcription du nombre lu
        /// </summary>
        /// <returns></returns>
        private static string Result()
        {
            var NbrALire = GetParts(Chiffre);
            string rslt;

            if (NbrALire.Item1)
            {
                // un nombre decimal

                //On vérifie les différentes parties si elle sont dans la limite
                if ((IsInRange(NbrALire.Item2)) && IsInRange(NbrALire.Item3))
                    rslt = $"{PartReader(NbrALire.Item2)} virgule {WriteZeroCount(ZeroCnt)}{PartReader(NbrALire.Item3).ToLower()}";
                else
                    rslt = "Le nombre à transcrire dépasse le nombre pris en charge";
            }
            else
            {
                //un nombre entier

                //On vérifie les différentes parties si elle sont dans la limite
                if (IsInRange(NbrALire.Item2))
                    rslt = $"{PartReader(NbrALire.Item2)}";
                else
                    rslt = "Le nombre à transcrire dépasse le nombre pris en charge";
            }

            return rslt;
        }
        /// <summary>
        /// Transcrit le nombre de zéro après la virgule
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private static string WriteZeroCount(int count)
        {
            string rslt = "";
            int k = 1;
            while (count >= k)
            {
                rslt += "zéro ";
                k++;
            }
            return rslt;
        }

        /// <summary>
        /// Vérifie si le nombre à transcrire ne dépasse pas le nombre maximal que prend la fonction en charge
        /// </summary>
        /// <param name="k">Le nombre à vérifier</param>
        /// <returns>retourne true si c'est dans les limites dans le cas contraire un false</returns>
        private static bool IsInRange(long k)
        {
            //On fixe le nombre maximal
            long max = 999999999999999999;

            if (IsOverFlow)
                return false;
            else
            {
                return k <= max;
            }

        }
    }
}
