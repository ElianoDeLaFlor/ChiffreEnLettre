using System;
using System.Collections.Generic;
using System.Text;

namespace ChiffreEnLettre
{
    public static class Shared
    {
        public static bool IsNumeric(this string str)
        {
            return long.TryParse(str, out _);
        }

        public static long ToLong(this string str)
        {
            if (IsNumeric(str))
                return long.Parse(str);
            else
                return 0;
        }

        public static bool IsUnite(this long l)
        {
            return l >= 0 && l <= 9;
        }

        public static bool IsDizaine(this long l)
        {
            return l >= 10 && l <= 99;
        }

        public static bool IsCentaine(this long l)
        {
            return l >= 100 && l <= 999; 
        }

        public static string FirstToUpperCase(this string lettre)
        {
            string str = lettre.ToLower();
            string s = str[0].ToString().ToUpper();
            string ss = str.Remove(0, 1);
            return s + ss;
        }

        public static bool IsMillieme(this long i)
        {
            return i >= 1000 && i <= 999999;
        }
        
        public static bool IsMillionnieme(this long i)
        {
            return i >= 1000000 && i <= 999999999;
        }
        
        public static bool IsBillion(this long i)
        {
            return i >= 1000000000 && i <= 1000000000000;
        }
    }
}
