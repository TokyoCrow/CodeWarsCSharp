﻿namespace Katas
{
    //https://www.codewars.com/kata/526dbd6c8c0eb53254000110
    public static class NotVerySecure
    {
        public static bool Alphanumeric(string str)
        {
            if (str.Equals("") || str.Contains(" ") || str.Contains("_"))
                return false;
            else
            {
                foreach(char ch in str)
                {
                    if (!char.IsDigit(ch) && !char.IsLetter(ch))
                        return false;
                }
                return true;
            }
        }
    }
}
