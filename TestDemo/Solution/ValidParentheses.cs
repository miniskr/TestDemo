using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    /// <summary>
    /// 有效的括号
    /// </summary>
    public class ValidParentheses
    {
        private readonly Dictionary<char, char> dic;
        public ValidParentheses()
        {
            this.dic = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
        }

        public bool IsValid(string s)
        {
            var charStr = s.ToCharArray();
            var stack = new Stack<char>();

            for (var i = 0; i < charStr.Length; i++)
            {
                var c = charStr[i];

                if (this.dic.ContainsKey(c))
                {
                    var topElement = stack.Count == 0 ? '#' : stack.Pop();

                    if (topElement != this.dic.GetValueOrDefault(c))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }


    }
}
