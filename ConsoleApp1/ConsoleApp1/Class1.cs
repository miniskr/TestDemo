using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DledgateSample
    {
        public delegate bool ComparisonHandler(int first, int second);

        public static void BubleSort(int[] items, ComparisonHandler comparisonHandler)
        {
            int i;
            int j;
            int temp;

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (comparisonHandler(items[j - 1], items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }

        public static bool AlphabetcalGreaterThan(int first, int second)
        {
            int comparison;
            comparison = (first.ToString().CompareTo(second.ToString()));

            return comparison > 0;
        }


    }
}
