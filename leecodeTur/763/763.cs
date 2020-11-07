using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace leecodeTur._763
{
    public static class _763
    {
        public static IList<int> PartitionLabels(string S)
        {
            #region  1
            //var result = new List<int>();
            //if (string.IsNullOrEmpty(S)) return result;
            //int[] last = new int[26];
            //for (int i = 0; i < S.Length; i++)
            //{
            //    last[S[i] - 'a'] = i;
            //}

            //int max = 0, start = 0;
            //for (int i = 0; i < S.Length; i++)
            //{
            //    max = Math.Max(max, last[S[i] - 'a']);
            //    if (i == max)
            //    {
            //        result.Add(max - start + 1);
            //        start = max + 1;
            //    }
            //}

            //return result;
            #endregion

            #region 2
            var result = new List<int>();
            if (string.IsNullOrEmpty(S)) return result;

            int[] arr = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                arr[S[i] - 'a'] = i;
            }

            int max = 0, start = 0;
            for (int i = 0; i < S.Length; i++)
            {
                max = Math.Max(max, arr[S[i] - 'a']);
                if (i == max)
                {
                    result.Add(max - start + 1);
                    start = max + 1;
                }
            }

            return result;
            #endregion
        }
    }
}
