﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._169
{
    public static class _169
    {
        #region 1
        //private static int countInRange(int[] nums, int num, int lo, int hi)
        //{
        //    int count = 0;
        //    for (int i = lo; i <= hi; i++)
        //    {
        //        if (nums[i] == num)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}


        //public static int majorityElement(int[] nums)
        //{
        //    return majorityElementRec(nums, 0, nums.Length - 1);
        //}


        //private static int majorityElementRec(int[] nums, int lo, int hi)
        //{
        //    // base case; the only element in an array of size 1 is the majority
        //    // element.
        //    if (lo == hi)
        //    {
        //        return nums[lo];
        //    }

        //    // recurse on left and right halves of this slice.
        //    int mid = (hi - lo) / 2 + lo;
        //    int left = majorityElementRec(nums, lo, mid);
        //    int right = majorityElementRec(nums, mid + 1, hi);

        //    // if the two halves agree on the majority element, return it.
        //    if (left == right)
        //    {
        //        return left;
        //    }

        //    // otherwise, count each element and return the "winner".
        //    int leftCount = countInRange(nums, left, lo, hi);
        //    int rightCount = countInRange(nums, right, lo, hi);

        //    return leftCount >= rightCount ? left : right;
        //}

        #endregion

        #region 2

        #endregion
    }
}
