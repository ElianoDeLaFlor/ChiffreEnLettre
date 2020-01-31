using ChiffreEnLettre;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nous allons tester notre code avant de poursuivre
            string k = "";
            do
            {
                Console.WriteLine("Votre nombre");
                string nbr = Console.ReadLine();
                EnLettre.Chiffre = nbr;
                Console.WriteLine(EnLettre.Resultat);
                Console.WriteLine("Appuyer sur O pour rééssayer");
                k = Console.ReadLine();
            } while (k == "O");
        }
    }
}
