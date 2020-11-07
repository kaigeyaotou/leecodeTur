using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._234
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static class _234
    {
        public static bool IsPalindrome(ListNode head)
        {
            #region 1
            if (head == null) return true;
            ArrayList arr = new ArrayList();
            while (head != null)
            {
                arr.Add(head);
                head = head.next;
            }

            int i = 0, j = arr.Count - 1;
            while (i < j)
            {
                if (((ListNode)arr[i]).val != ((ListNode)arr[j]).val)
                {
                    return false;
                }
                i++; j--;
            }

            return true;
            #endregion


        }
    }
}
