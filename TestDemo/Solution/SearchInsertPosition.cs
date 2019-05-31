using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    /// <summary>
    /// 搜索插入位置
    /// </summary>
    public class SearchInsertPosition
    {
        /// <summary>
        /// 遍历查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {

            if (nums.Length == 0) return 0;
            var index = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] >= target)
                {
                    index = i;
                    return i;
                }

            }

            return index + 1;
        }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsertBinary(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] < target)
                    start = mid + 1;
                else if (nums[mid] > target)
                    end = mid - 1;
                else return mid;
            }
            return 0;
        }

    }
}
