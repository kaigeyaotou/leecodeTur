using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._50
{
    public static class _50
    {
        public static double MyPow(double x, int n)
        {
            #region 1
            //var symbol = n > 0;
            //var ret = symbol ? recur(x, n) : 1 / recur(x, -n);
            //return ret;
            #endregion

            #region 2
            var symbol = n > 0;
            var val = recur(x, n > 0 ? n : -n);
            return symbol ? val : 1 / val;
            #endregion
        }

        private static double recur(double x, int n)
        {
            if (n == 0) return 1;

            var val = recur(x, n / 2);
            return n % 2 == 1 ? val * val * x : val * val;
        }

        //private static double recur(double x, int n)
        //{
        //    if (n == 0) return 1.00f;

        //    var ret = recur(x, n / 2);
        //    return n % 2 == 0 ? ret * ret : ret * ret * x;
        //}
    }
}
