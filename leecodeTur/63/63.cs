using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace leecodeTur._63
{
    public static class _63
    {
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int row = obstacleGrid.Length;
            int col = obstacleGrid[0].Length;
            int[,] dp = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                if (obstacleGrid[i][0] == 0)
                    dp[i, 0] = 1;
                else dp[i, 0] = 0;
            }
            for (int i = 0; i < col; i++)
            {
                if (obstacleGrid[0][i] == 0) dp[0, i] = 1;
                else dp[0, i] = 0;
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    dp[i, j] = obstacleGrid[i][j] == 0 ? ((obstacleGrid[i - 1][j] == 0 ? dp[i - 1, j] : 0) + (obstacleGrid[i][j - 1] == 0 ? dp[i, j - 1] : 0)) : 0;
                }
            }

            return dp[row - 1, col - 1];
        }
    }
}
