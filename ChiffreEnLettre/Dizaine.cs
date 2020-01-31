using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Dizaine : Unite
    {
        private static readonly string[] TableauDizaine = new[] { "Dix","Onze", "Douze", "Treize", "Quatorze", "Quinze", "Seize", "Dix-" };
        private static readonly string[] TableauVingtaine = new[] { "Vingt", "Vingt-et-un", "Vingt-" };
        private static readonly string[] TableauTrentaine = new[] { "Trente", "Trente-et-un", "Trente-" };
        private static readonly string[] TableauQuarantaine = new[] { "Quarante", "Quarante-et-un", "Quarante-" };
        private static readonly string[] TableauCinquantaine = new[] { "Cinquante", "Cinquante-et-un", "Cinquante-" };
        private static readonly string[] TableauSoixantaine = new[] { "Soixante", "Soixante-et-un", "Soixante-" };
        private static readonly string[] TableauSoixanteDizaine = new[] { "Soixante-dix", "Soixante-" };
        private static readonly string[] TableauQuatreVingtaine = new[] { "Quatre-vingt", "Quatre-vingt-et-un","Quatre-vingt-" };
        private static readonly string[] TableauQuatreVingtDizaine = new[] { "Quatre-vingt-dix", "Quatre-vingt-" };


        public static string DizainesInLetter(long k)
        {
            if(k>=10 && k <= 19)
            {
                //Dizaine
                return DizaineInLetter(k);
            }
            if(k>=20 && k <= 29)
            {
                //Vingtaine
                return VingtaineInLetter(k);
            }
            else if (k >= 30 && k <= 39)
            {
                //trentaine
                return TrentaineInLetter(k);
            }
            else if (k >= 40 && k <= 49)
            {
                //quarantaine
                return QuarantaineInLetter(k);
            }
            else if (k >= 50 && k <= 59)
            {
                // cinquantaine
                return CinquantaineInLetter(k);
            }
            else if (k >= 60 && k <= 69)
            {
                //soixantaine
                return SoixantaineInLetter(k);
            }
            else if (k >= 70 && k <= 79)
            {
                //soixante-dizaine
                return SoixanteDizaineInLetter(k);
            }
            else if (k >= 80 && k <= 89)
            {
                //quatre-vingtaine
                return QuatreVingtaineInLetter(k);
            }
            else //if(k>=90 && k <= 99)
            {
                // quatre-vingt-dizaine
                return QuatreVingtDizaineInLetter(k);
            }
        }

        public static string DizaineInLetter(long k)
        {
            long i = k % 10;

            string result;
            switch (i)
            {
                case 7:
                    {
                        result = TableauDizaine[7] + (InLetter(i)).ToLower();// ==> "Dix-"+"sept"<==>"Dix-sept"
                        break;
                    }
                case 8:
                    {
                        result = TableauDizaine[7] + (InLetter(i)).ToLower();
                        break;
                    }
                case 9:
                    {
                        result = TableauDizaine[7] + (InLetter(i)).ToLower();
                        break;
                    }
                default:
                    {
                        result = TableauDizaine[i];
                        break;
                    }
            }

            return result;
        }

        public static string VingtaineInLetter(long k)
        {
            long i = k % 20;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauVingtaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauVingtaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauVingtaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string TrentaineInLetter(long k)
        {
            long i = k % 30;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauTrentaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauTrentaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauTrentaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string QuarantaineInLetter(long k)
        {
            long i = k % 40;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauQuarantaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauQuarantaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauQuarantaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string CinquantaineInLetter(long k)
        {
            long i = k % 50;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauCinquantaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauCinquantaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauCinquantaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string SoixantaineInLetter(long k)
        {
            long i = k % 60;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauSoixantaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauSoixantaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauSoixantaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string SoixanteDizaineInLetter(long k)
        {
            long i = k % 70;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauSoixanteDizaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauSoixanteDizaine[1] + (DizaineInLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string QuatreVingtaineInLetter(long k)
        {
            long i = k % 80;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauQuatreVingtaine[i];
                        break;
                    }
                case 1:
                    {
                        result = TableauQuatreVingtaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauQuatreVingtaine[2] + (InLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }

        public static string QuatreVingtDizaineInLetter(long k)
        {
            long i = k % 90;
            string result;
            switch (i)
            {
                case 0:
                    {
                        result = TableauQuatreVingtDizaine[i];
                        break;
                    }
                default:
                    {
                        result = TableauQuatreVingtDizaine[1] + (DizaineInLetter(i)).ToLower();
                        break;
                    }
            }

            return result;
        }
    }
}
