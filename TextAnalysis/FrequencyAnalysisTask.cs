using System;
using System.CodeDom;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string>();
            var ngramm = new Dictionary<string, Dictionary<string, int>>();
            for (int s=0; s<text.Count; ++s)
            {
                int sentenceLength = text[s].Count;
                for (int w=0; w < sentenceLength; ++w)
                {
                    Set1Gramm(text, sentenceLength, w, ngramm, s);
                    Set2Gramm(text, sentenceLength, w, ngramm, s);
                    Set3Gramm(text, sentenceLength, w, ngramm, s);
                }
            }

            CleanStatistics(ngramm, result);
            return result;
        }

        private static void CleanStatistics(Dictionary<string, Dictionary<string, int>> ngramm, 
            Dictionary<string, string> result)
        {
            foreach (var gkey in ngramm.Keys)
            {
                Dictionary<string, int> stat = ngramm[gkey];
                string gram = "";
                int max = 0;
                foreach (var key in stat.Keys)
                {
                    if (max < stat[key])
                    {
                        gram = key;
                        max = stat[key];
                    }
                    else if (max == stat[key])
                    {
                        if (string.CompareOrdinal(gram.ToLower(), key.ToLower()) >= 0)
                        {
                            gram = key;
                        }
                    }
                }

                result.Add(gkey, gram);
            }
        }

        private static void Set1Gramm(List<List<string>> text, 
            int sentenceLength, 
            int w, 
            Dictionary<string, Dictionary<string, int>> ngramm, 
            int s)
        {
            if (sentenceLength - w > 1)
            {
                string gramKey = text[s][w];
                string gramm = text[s][w + 1];
                SetStatistics(ngramm, gramKey, gramm);
            }
        }
        private static void Set2Gramm(List<List<string>> text, 
            int sentenceLength, 
            int w, 
            Dictionary<string, Dictionary<string, int>> ngramm, 
            int s)
        {
            if (sentenceLength - w > 2)
            {
                string gramKey = string.Format("{0} {1}", text[s][w]  , text[s][w + 1]);
                string gramm = text[s][w + 2];
                SetStatistics(ngramm, gramKey, gramm);
            }
        }
        private static void Set3Gramm(List<List<string>> text, 
            int sentenceLength, 
            int w, 
            Dictionary<string, Dictionary<string, int>> ngramm, 
            int s)
        {
            if (sentenceLength - w > 3)
            {
                string gramKey = string.Format("{0} {1} {2}", text[s][w] , text[s][w + 1] , text[s][w + 2]);
                string gramm = text[s][w + 3];
                SetStatistics(ngramm, gramKey, gramm);
            }
        }

        private static void SetStatistics(Dictionary<string, Dictionary<string, int>> ngramm, string gramKey, string gramm)
        {
            if (!ngramm.ContainsKey(gramKey))
            {
                Dictionary<string, int> frq = new Dictionary<string, int> {[gramm] = 1};
                ngramm.Add(gramKey, frq);
            }
            else
            {
                Dictionary<string, int> dct = ngramm[gramKey];
                if (dct.ContainsKey(gramm))
                {
                    ++dct[gramm];
                }
                else
                {
                    dct.Add(gramm, 1);
                }
            }
        }
    }
}