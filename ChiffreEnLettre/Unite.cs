using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    class Unite
    {
        public static long Unit { get; set; }

        /// <summary>
        /// Contient le nom en lettre des chiffres des unités
        /// </summary>
        private static readonly string[] TableauUnite = new[] { "Zéro", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf" };

        public static string InLetter(long unit)
        {
            return TableauUnite[unit];
        }
    }
}
