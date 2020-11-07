using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._62
{
    public static class _62
    {
        public static int UniquePaths(int m, int n)
        {
            #region 递归
            //return recur(1, 1, m, n);
            #endregion

            #region 动态规划
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
                arr[i, 0] = 1;
            for (int i = 0; i < n; i++)
                arr[0, i] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
                }
            }

            return arr[m - 1, n - 1];
            #endregion
        }

        private static int recur(int row, int col, int m, int n)
        {
            if (row == m || col == n) return 1;
            return recur(row + 1, col, m, n) + recur(row, col + 1, m, n);
        }
    }
}
