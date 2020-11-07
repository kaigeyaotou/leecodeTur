using System;
using System.Collections.Generic;
using System.Text;

namespace leecodeTur._925
{
    public static class _925
    {
        public static bool IsLongPressedName(string name, string typed)
        {
            #region 1
            //int i = 0, j = 0;
            //var namearr = name.ToCharArray();
            //var typedarr = typed.ToCharArray();
            //while (j < typedarr.Length)
            //{

            //    if (i < namearr.Length && namearr[i] == typedarr[j])
            //    {
            //        i++;
            //        j++;
            //    }
            //    else if (j > 0 && typedarr[j] == typedarr[j - 1]) j++;
            //    else
            //    {
            //        return false;
            //    }
            //}

            //return i == namearr.Length;
            #endregion

            #region 2
            int i = 0, j = 0;
            while (j < typed.Length)
            {
                if (i < name.Length && name[i] == typed[j])
                {
                    i++;
                    j++;
                }
                else if (j > 0 && typed[j] == typed[j - 1])
                {
                    j++;
                }
                else
                {
                    return false;
                }
            }

            return i == name.Length;

            #endregion
        }
    }
}
