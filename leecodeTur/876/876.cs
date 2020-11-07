using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._876
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class _876
    {
        public static ListNode MiddleNode(ListNode head)
        {
            if (head == null) return null;
            ListNode p1 = head, p2 = head;
            while (p2.next != null && p2.next.next != null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
            }
            if (p2.next != null) p1 = p1.next;
            return p1;
        }
    }
}
