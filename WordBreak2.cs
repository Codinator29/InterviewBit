using System;
using System.Collections.Generic;
using System.Linq;

namespace WordBreak2
{
    class Program
    {
        #region Driver Code

        static void Main(string[] args)
        {
            string s = "pineapplepenapple";
            IList<string> wordDict = new List<string>
            {
                "apple", "pen", "applepen", "pine", "pineapple"
            };

            var result = WordBreak(s, wordDict);

            foreach(var val in result)
            {
                Console.WriteLine(val);
            }
        }

        #endregion

        #region Main Logic

        public static IList<string> WordBreak(string s, IList<string> wordDict)
        {
            if(s.Length == 0 || wordDict == null || !wordDict.Any())
            {
                return new List<string>();
            }

            IList<string> FinalResult = new List<string>();
            recurse(s, wordDict, string.Empty, FinalResult, 0);
            return FinalResult;
        }

        public static void recurse(string s, IList<string> wordDict, string result, IList<string> finalResult, int index)
        {
            if(index >= s.Length)
            {
                finalResult.Add(result.Trim());
                return;
            }

            string substr = string.Empty;

            for(int i = index; i < s.Length; i++)
            {
                substr += s[i];

                if (wordDict.Contains(substr))
                {
                    //result += substr + " ";
                    recurse(s, wordDict, result + substr + " ", finalResult, i + 1);
                }
            }
        }

        #endregion
    }
}
