using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    public class RemoveElement
    {
        public int RemoveElements(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            var i = 0;
            for(var j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
