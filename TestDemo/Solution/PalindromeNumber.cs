using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    class PalindromeNumber
    {
        /// <summary>
        /// 字符串解决
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var charX = $"{x}".ToCharArray();
            Array.Reverse(charX);
            var parsed = int.TryParse(charX, out int reverseInt);

            if (!parsed)
                return false;

            return x == reverseInt;
        }

        public static bool IsPalindromeNoStr(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            var revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
