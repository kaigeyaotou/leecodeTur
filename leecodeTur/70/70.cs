using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._70
{
    public static class _70
    {
        public static int ClimbStairs(int n)
        {
            #region 1
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            #endregion 
        }
    }
}
