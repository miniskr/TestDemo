using System;
using System.Collections.Generic;
using System.Text;
using TestDemo.Solution;
using Xunit;

namespace TestDemo.Test
{
    public class RemoveLinkedListTest
    {
        private readonly RemoveLinkedList _removeLinkedList;


        public RemoveLinkedListTest()
        {
            this._removeLinkedList = new RemoveLinkedList();
        }

        readonly ListNode arrs = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            }
        };
        readonly ListNode target = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                }
            }
        };

        [Fact]
        public void TestRemoveLinkedList()
        {
            var removeInt = 6;

            var removed = this._removeLinkedList.RemoveElements(arrs, removeInt);
            var removedWhile = this._removeLinkedList.RemoveElementsWithWhileMethod(arrs, removeInt);

            Assert.True(this.AssertObjEquals(removed, target));
            Assert.True(this.AssertObjEquals(removedWhile, target));
        }

        public bool AssertObjEquals(ListNode test, ListNode target)
        {
            if (test.next == null && target.next == test.next && test.val == target.val)
                return true;

            if (test == null)
                return false;

            if (test.val == target.val)
                return AssertObjEquals(test.next, target.next);

            return false;
        }
    }
}
