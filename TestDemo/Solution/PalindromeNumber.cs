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
    }
}
