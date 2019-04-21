using System;
using Xunit;
using TestDemo.Solution;

namespace TestDemo.Test
{
    public class RemoveElementTest
    {
        private readonly RemoveElement _removeElement;

        public RemoveElementTest()
        {
            this._removeElement = new RemoveElement();
        }

        [Fact]
        public void TestRemoveElement()
        {
            var arrs =new int[6] {1,2,3,3,4,5 };
            var removeInt = 3;
            var arr = _removeElement.RemoveElements(arrs, removeInt);

            Assert.False(arr != 4, "this test false");
        }
    }
}
