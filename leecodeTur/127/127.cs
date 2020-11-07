using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leecodeTur._127
{
    public static class _127
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            #region 1
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Dictionary<string, List<string>> dics = new Dictionary<string, List<string>>();
            foreach (var word in wordList)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    string newWord = word.Substring(0, i) + "*" + word.Substring(i + 1);
                    List<string> temp = new List<string>();
                    if (dics.ContainsKey(newWord))
                    {
                        temp = dics[newWord];
                        temp.Add(word);
                        dics[newWord] = temp;
                    }
                    else
                    {
                        temp.Add(word);
                        dics.Add(newWord, temp);
                    }
                }
            }

            Queue<(string, int)> q = new Queue<(string, int)>();
            q.Enqueue((beginWord, 1));
            visited.Add(beginWord, true);

            while (q.Any())
            {
                var node = q.Dequeue();
                var word = node.Item1;
                var level = node.Item2;
                for (int i = 0; i < word.Length; i++)
                {
                    string newWord = word.Substring(0, i) + "*" + word.Substring(i + 1);
                    if (!dics.ContainsKey(newWord)) continue;

                    var list = dics[newWord];
                    foreach (var item in list)
                    {
                        if (item == endWord) return level + 1;

                        if (!visited.ContainsKey(item))
                        {
                            q.Enqueue((item, level + 1));
                            visited.Add(item, true);
                        }
                    }
                }
            }
            return 0;
            #endregion
        }
    }
}
