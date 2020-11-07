using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur
{
    
    public static class _226
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode node = new TreeNode(root.val);
            node.left = InvertTree(root.right);
            node.right = InvertTree(root.left);

            return node;
        }
    }
}
