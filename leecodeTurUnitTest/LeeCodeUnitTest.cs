using leecodeTur;
using leecodeTur._1143;
using leecodeTur._122;
using leecodeTur._126;
using leecodeTur._127;
using leecodeTur._143;
using leecodeTur._169;
using leecodeTur._206;
using leecodeTur._234;
using leecodeTur._33;
using leecodeTur._455;
using leecodeTur._50;
using leecodeTur._62;
using leecodeTur._63;
using leecodeTur._70;
using leecodeTur._763;
using leecodeTur._78;
using leecodeTur._860;
using leecodeTur._876;
using leecodeTur._925;
using leecodeTur._98;
using Xunit;

namespace leecodeTurUnitTest
{
    public class LeeCodeUnitTest
    {
        [Fact]
        public void _78UnitTest()
        {
            var result = _78.Subsets(new int[] { 1, 2, 3, 4 });
        }

        [Fact]
        public void _50UnitTest()
        {
            var result = _50.MyPow(2.00f, 2);
            result = _50.MyPow(2.00f, 3);
            result = _50.MyPow(2.00f, 0);
            result = _50.MyPow(2.00f, -2);
        }

        [Fact]
        public void _143UnitTest()
        {
            var l1 = new leecodeTur._143.ListNode(1);
            var l2 = new leecodeTur._143.ListNode(2);
            var l3 = new leecodeTur._143.ListNode(3);
            var l4 = new leecodeTur._143.ListNode(4);
            var l5 = new leecodeTur._143.ListNode(5);
            var l6 = new leecodeTur._143.ListNode(6);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            //l5.next = l6;

            _143.ReorderList(l1);
        }

        [Fact]
        public void _876UnitTest()
        {
            var l1 = new leecodeTur._876.ListNode(1);
            var l2 = new leecodeTur._876.ListNode(2);
            var l3 = new leecodeTur._876.ListNode(3);
            var l4 = new leecodeTur._876.ListNode(4);
            var l5 = new leecodeTur._876.ListNode(5);
            var l6 = new leecodeTur._876.ListNode(6);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            var result = _876.MiddleNode(l1);
        }

        [Fact]
        public void _206UnitTest()
        {
            var l1 = new leecodeTur._206.ListNode(1);
            var l2 = new leecodeTur._206.ListNode(2);
            var l3 = new leecodeTur._206.ListNode(3);
            var l4 = new leecodeTur._206.ListNode(4);
            var l5 = new leecodeTur._206.ListNode(5);
            var l6 = new leecodeTur._206.ListNode(6);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            var result = _206.ReverseList(l1);
        }

        [Fact]
        public void _925UnitTest()
        {
            var result = _925.IsLongPressedName("alex", "alexxr");
            result = _925.IsLongPressedName("ab", "aab");
            result = _925.IsLongPressedName("abb", "aab");
        }

        [Fact]
        public void _169UnitTest()
        {
            //var result = _169.majorityElement(new int[] { 3, 2, 3 });
        }

        [Fact]
        public void _763UnitTest()
        {
            var result = _763.PartitionLabels("ababcbacadefegdehijhklij");
        }

        [Fact]
        public void _234UnitTest()
        {
            var l1 = new leecodeTur._234.ListNode(1);
            var l2 = new leecodeTur._234.ListNode(2);
            var l3 = new leecodeTur._234.ListNode(3);
            var l21 = new leecodeTur._234.ListNode(2);
            var l11 = new leecodeTur._234.ListNode(1);
            l1.next = l2;
            l2.next = l3;
            l3.next = l21;
            //l21.next = l11;

            var result = _234.IsPalindrome(l1);
        }

        [Fact]
        public void _70UnitTest()
        {
            var result = _70.ClimbStairs(1);
            result = _70.ClimbStairs(2);
            result = _70.ClimbStairs(3);
            result = _70.ClimbStairs(4);

        }

        [Fact]
        public void _226UnitTest()
        {
            var n4 = new _226.TreeNode(4);
            var n2 = new _226.TreeNode(2);
            var n7 = new _226.TreeNode(7);
            var n1 = new _226.TreeNode(1);
            var n3 = new _226.TreeNode(3);
            var n6 = new _226.TreeNode(6);
            var n9 = new _226.TreeNode(9);
            n4.left = n2;
            n4.right = n7;
            n2.left = n1;
            n2.right = n3;
            n7.left = n6;
            n7.right = n9;

            var result = _226.InvertTree(n4);
        }

        [Fact]
        public void _98UnitTest()
        {
            //var n5 = new _98.TreeNode(5);
            //var n1 = new _98.TreeNode(1);
            //var n4 = new _98.TreeNode(4);
            //var n3 = new _98.TreeNode(3);
            //var n6 = new _98.TreeNode(6);
            //n5.left = n1;
            //n5.right = n4;
            //n4.left = n3;
            //n4.right = n6;

            //var n11 = new _98.TreeNode(11);
            //var n12 = new _98.TreeNode(12);
            //var n13 = new _98.TreeNode(13);
            //n12.left = n11;
            //n12.right = n13;

            //var result = _98.IsValidBST(n5);
            //result = _98.IsValidBST(new _98.TreeNode(0));

            //var n0 = new _98.TreeNode(0);
            //var n_1 = new _98.TreeNode(-1);
            //n0.left = n_1;
            //result = _98.IsValidBST(n0);

            //var v10 = new _98.TreeNode(10);
            //var v5 = new _98.TreeNode(5);
            //var v15 = new _98.TreeNode(15);
            //var v6 = new _98.TreeNode(6);
            //var v12 = new _98.TreeNode(12);

        }

        [Fact]
        public void _127UnitTest()
        {
            var result = _127.LadderLength("hil", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" });
        }

        [Fact]
        public void _126UnitTest()
        {
            var result = _126.FindLadders("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" });
        }


        [Fact]
        public void _122UnitTest()
        {
            var result = _122.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        }

        [Fact]
        public void _455UnitTest()
        {
            var result = _455.FindContentChildren(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
        }

        [Fact]
        public void _860UnitTest()
        {
            var result = _860.LemonadeChange(new int[] { 5, 5, 5, 10, 5, 5, 10, 20, 20, 20 });
            result = _860.LemonadeChange(new int[] { 5, 5, 10 });
            result = _860.LemonadeChange(new int[] { 10, 10 });
            result = _860.LemonadeChange(new int[] { 5, 5, 10, 10, 20 });
        }

        [Fact]
        public void _33UnitTest()
        {
            var result = _33.Search(new int[] { 0, 1, 2, 4, 5, 6, 7 }, 4);
            result = _33.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 4);
            result = _33.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 2);
            result = _33.Search(new int[] { 1, 3 }, 3);
        }

        [Fact]
        public void _62UnitTest()
        {
            var result = _62.UniquePaths(3, 2);

        }


        [Fact]
        public void _63UnitTest()
        {
            //var result = _63.UniquePathsWithObstacles(new int[3][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } });
            var result = _63.UniquePathsWithObstacles(new int[1][] { new int[] { 1, 0 } });

        }

        [Fact]
        public void _1143UnitTest()
        {
            var result = _1143.LongestCommonSubsequence("abcdef", "adf");
        }

    }
}
