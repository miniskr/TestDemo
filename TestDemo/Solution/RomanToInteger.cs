using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    /// <summary>
    /// 罗马整数
    /// </summary>
    class RomanToInteger
    {
        public int Solution(string s)
        {
            var charS = s.ToCharArray();
            Array.Reverse(charS);
            for(var i = 0; i < charS.Length; i++)
            {

            }
            return 0;
        }
    }
}
