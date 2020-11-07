using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._455
{
    public static class _455
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int result = 0, child = 0, cookie = 0;
            while (child < g.Length && cookie < s.Length)
            {
                if (g[child] > s[cookie])
                {
                    cookie++;
                }
                else
                {
                    child++;
                    cookie++;
                }
            }

            return child;
        }
    }
}
