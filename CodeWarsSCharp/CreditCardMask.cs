using System;

namespace Katas
{
    // https://www.codewars.com/kata/5412509bd436bd33920011bc
    public static class CreditCardMask
    {
        public static string Maskify(string cc)
        {
            if (cc.Length > 4)
                return new String('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
            else
                return cc;
        }
    }
}
