using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._206
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class _206
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;

            var array = new ArrayList();
            var node = head;
            while (node != null)
            {
                array.Add(node);
                node = node.next;
            }

            int i = 0, j = array.Count - 1;
            var ret = (ListNode)array[j];
            while (i < j)
            {
                var p = ((ListNode)array[i]).next;
                ((ListNode)array[i]).next = ((ListNode)array[j]).next;
                ((ListNode)array[j]).next = p;
                i++;
                if (i == j) break;
                j--;
            }
            return ret;
        }
    }
}
