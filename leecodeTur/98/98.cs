using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._98
{

    public static class _98
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        //public static bool IsValidBST(TreeNode root)
        //{
        //    if (root == null) return true;
        //    return recur(root, root.right?.val ?? int.MinValue);
        //}

        //private static bool recur(TreeNode node, int low, int upper)
        //{
        //    if (node.left == null && node.right == null) return true;
        //    else if (node.left != null && node.val <= node.left.val) return false;
        //    else if (node.right != null && node.val >= node.right.val && node.right.val >= val) return false;
        //    else
        //    {
        //        bool left = true, right = true;
        //        if (node.left != null)
        //        {
        //            left = recur(node.left, node.right?.val ?? int.MinValue);
        //        }
        //        if (node.right != null)
        //        {
        //            right = recur(node.right, node.right?.val ?? int.MinValue);
        //        }
        //        return left && right;
        //    }


        //}
    }
}
