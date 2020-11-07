using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leecodeTur._126
{
    public static class _126
    {
        public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Dictionary<string, List<string>> dics = new Dictionary<string, List<string>>();
            foreach (var word in wordList)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    List<string> temp = new List<string>();
                    string newWord = word.Substring(0, i) + "*" + word.Substring(i + 1);
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
            var result = new List<IList<string>>();
            Queue<(string, IList<string>)> q = new Queue<(string, IList<string>)>();
            q.Enqueue((beginWord, new List<string>()));
            visited.Add(beginWord, true);
            while (q.Any())
            {
                var node = q.Dequeue();
                var word = node.Item1;
                var list = node.Item2;

                for (int i = 0; i < word.Length; i++)
                {
                    var newWord = word.Substring(0, i) + "*" + word.Substring(i + 1);
                    if (!dics.ContainsKey(newWord)) continue;

                    var temp = dics[newWord];
                    foreach (var tempnode in temp)
                    {
                        if (tempnode == endWord)
                        {
                            list.Add(tempnode);
                            result.Add(list);
                        }
                        else
                        {
                            if (!visited.ContainsKey(tempnode))
                            {
                                list.Add(tempnode);
                                visited.Add(tempnode, true);
                                q.Enqueue((tempnode, list));
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
