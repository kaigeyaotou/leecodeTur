using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace leecodeTur._78
{
    public static class _78
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            if (nums.Length == 0) return null;
            var result = new List<IList<int>>();
            recur(nums, 0, new List<int>(), ref result);
            return result;
        }

        private static void recur(int[] nums, int index, List<int> current, ref List<IList<int>> collection)
        {
            if (index == nums.Length)
            {
                int[] temp = new int[current.Count];
                Array.Copy(current.ToArray(), temp, temp.Length);
                collection.Add(temp);
                return;
            }

            current.Add(nums[index]);
            recur(nums, index + 1, current, ref collection);
            current.Remove(nums[index]);
            recur(nums, index + 1, current, ref collection);
        }
    }
}
