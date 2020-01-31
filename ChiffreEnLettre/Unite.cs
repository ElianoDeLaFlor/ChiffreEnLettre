using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public class Unite
    {
        private static readonly string[] TableauUnite = new[] { "Zéro", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf" };
        private static readonly string[] TableauUniteCentaine = new[] { "", "", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf" };
        private static readonly string[] TableauUniteDizaineCentaine = new[] { "", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf" };
        public long Unit { get; set; }

        public static string InLetter(long u)
        {
            return TableauUnite[u];
        }

        public static string UniteCentaineInLetter(long u)
        {
            return TableauUniteCentaine[u];
        }
        public static string UniteDizaineCentaineInLetter(long u)
        {
            return TableauUniteDizaineCentaine[u];
        }
    }
}
