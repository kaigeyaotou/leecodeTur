using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._143
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

    public static class _143
    {
        public static void ReorderList(ListNode head)
        {
            #region 1
            //if (head == null) return;
            //var node = head;
            //ArrayList array = new ArrayList();
            //while (node != null)
            //{
            //    array.Add(node);
            //    node = node.next;
            //}

            //int i = 0, j = array.Count - 1;
            //while (i < j)
            //{
            //    ((ListNode)array[i]).next = (ListNode)array[j];
            //    i++;
            //    if (i == j) break;
            //    ((ListNode)array[j]).next = (ListNode)array[i];
            //    j--;
            //}
            //((ListNode)array[i]).next = null;
            #endregion


            #region 2
            if (head == null) return;
            var node = head;
            var nodes = new ArrayList();
            while (node != null)
            {
                nodes.Add(node);
                node = node.next;
            }

            int i = 0, j = nodes.Count - 1;
            while (i < j)
            {
                ((ListNode)nodes[i]).next = (ListNode)nodes[j];
                i++;
                if (i == j) break;
                ((ListNode)nodes[j]).next = (ListNode)nodes[i];
                j--;
            }
            ((ListNode)nodes[i]).next = null;
            #endregion
        }
    }
}
