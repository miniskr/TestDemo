using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    /// <summary>
    /// 移除链表中指定的数字
    /// </summary>
    public class RemoveLinkedList
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return head;

            if (head.val == val)
                return RemoveElements(head.next, val);

            head.next = RemoveElements(head.next, val);

            return head;
        }

        public ListNode RemoveElementsWithWhileMethod(ListNode head, int val)
        {
            while (head != null && head.val == val)
                head = head.next;

            if (head == null)
                return null;

            var p = head;
            while (p.next != null)
            {
                if (p.next.val == val)
                    p.next = p.next.next;
                else
                    p = p.next;
            }
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
