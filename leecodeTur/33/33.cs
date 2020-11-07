using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._33
{
    public static class _33
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                if (nums[0] <= nums[mid])
                {
                    if (target > nums[mid] || target < nums[0])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target < nums[0])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
