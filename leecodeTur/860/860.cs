using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._860
{
    public static class _860
    {
        public static bool LemonadeChange(int[] bills)
        {
            int five = 0, ten = 0;
            foreach (var bill in bills)
            {
                if (bill == 5)
                    five++;
                else if (bill == 10)
                {
                    if (five == 0) return false;
                    five--;
                    ten++;
                }
                else
                {
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
