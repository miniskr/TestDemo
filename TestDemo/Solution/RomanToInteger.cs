using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
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
