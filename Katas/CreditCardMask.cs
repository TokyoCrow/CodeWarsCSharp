using System;

namespace Katas
{
    // https://www.codewars.com/kata/5412509bd436bd33920011bc
    public static class CreditCardMask
    {
        public static string Maskify(string cardNumber)
        {
            if (cardNumber.Length > 4)
                return new String('#', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);
            else
                return cardNumber;
        }
    }
}
