using System;
using System.Collections.Generic;
using System.Text;

namespace RomeToInt
{
    public static class Solution
    {
        public static int RomeToInt(string s)
        {
            var romeDic = new Dictionary<char, int>
            {
                { 'I', 1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };

            var charArr = s.ToCharArray();
            var len = charArr.Length;
            if (len == 1) return romeDic[charArr[0]];

            var result = 0;

            for (var i = 0; i < len; i++)
            {
                var num = romeDic[charArr[i]];

                if (i == len - 1) result += num;
                else
                {
                    var next = romeDic[charArr[i + 1]];
                    if (num < next) result -= num;
                    if (num >= next) result += num;
                }
            }

            return result;
        }
    }
}
