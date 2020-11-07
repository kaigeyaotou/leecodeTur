using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._122
{
    public static class _122
    {
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int tmp = prices[i] - prices[i - 1];
                if (tmp > 0) profit += tmp;
            }
            return profit;
        }

    }
}
