using System;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            string result = string.Empty;
            // На вход подают phraseBeginning. Сначала пытаемся найти триграммы по ключу из последних двух слов в phraseBeginning.
            //    В случае нахождения прибавляем value найденной триграммы к phraseBeginning и повторяем.Если подходящих триграмм нет, 
            //    ищем биграммы по последнему слову в phraseBeginning.
            for (int i = 0; i < wordsCount; ++i)
            {
                string[] s = phraseBeginning.Split(' ');
                if (s.Length == 0)
                    break;
                if (s.Length >= 2)
                {
                    if (nextWords.ContainsKey(String.Format("{0} {1}", s[s.Length - 2], s[s.Length - 1])))
                    {
                        phraseBeginning += " " + nextWords[String.Format("{0} {1}", s[s.Length - 2], s[s.Length - 1])];
                        continue;
                    }
                }
                if (nextWords.ContainsKey(s[s.Length - 1]))
                {
                    phraseBeginning += " " + nextWords[s[s.Length - 1]];
                    continue;
                }
                break;   
            }
            return phraseBeginning;
        }
    }
    
}