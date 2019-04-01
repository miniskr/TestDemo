using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestDemo.Solution
{
    /// <summary>
    /// 字符串转换整数
    /// </summary>
    public class Atoi
    {
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            var tStr = str.Trim().ToCharArray();
            var num = "";
            if (tStr[0] != '-' && tStr[0] != '+' && !int.TryParse(tStr[0].ToString(), out int outNumber))
                return 0;

            if (tStr.Length == 1 && (tStr[0] == '-' || tStr[0] == '+'))
                return 0;

            for (var i = 0; i < tStr.Length; i++)
            {
                if ((tStr[0] == '-' || tStr[0] == '+') && i == 0)
                    num += $"{tStr[0]}";
                else if (int.TryParse(tStr[i].ToString(), out int trueNumber))
                    num += $"{trueNumber}";
                else
                    break;
            }

            if (int.TryParse(num, out int resultNum))
                return resultNum;
            else
            {
                if (num.Length == 1) return 0;

                if (num.Contains("-"))
                    return int.MinValue;
                else
                    return int.MaxValue;
            }
        }
    }
}
