using System;
using System.Collections.Generic;
using System.Text;
using TestDemo.Solution;
using Xunit;

namespace TestDemo.Test
{
    public class SearchInsertPositionTest
    {
        private readonly SearchInsertPosition _searchInsertPosition;
        public SearchInsertPositionTest()
        {
            this._searchInsertPosition = new SearchInsertPosition();
        }

        [Fact]
        public void BinarySearchInputTest()
        {
            var testArr = new int[] { 1, 3, 5, 6 };
            var target = 2;

            var index = this._searchInsertPosition.SearchInsertBinary(testArr, target);

            Assert.Equal(1, index);
        }
    }
}
