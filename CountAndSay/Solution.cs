using System;
using System.Collections.Generic;
using System.Text;

namespace CountAndSay
{
    public static class Solution
    {
        private static readonly StringBuilder str = new StringBuilder();
        public static string CountAndSay(int n)
        {
            if (n == 1) return "1";

            var count = 1;
            var prevNum = n - 1;
            var prevStr = CountAndSay(prevNum);
            var charArr = prevStr.ToCharArray();

            for (var i = 0; i < charArr.Length; ++i)
            {
                if (charArr.Length == 1)
                {
                    str.Append("11");
                }
                else if (charArr.Length > i + 1 && charArr[i] == charArr[i + 1])
                {
                    count += 1;
                }
                else if (count > 0)
                {
                    str.Append($"{count}{charArr[i]}");
                    count = 1;
                }
                else
                {
                    str.Append($"1{charArr[i]}");
                    count = 1;
                }
            }

            return str.ToString();
        }
    }
}
