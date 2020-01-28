using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Class1
    {
        private static string DecodeMessage(string[] lines)
        {
            StringBuilder sb = new StringBuilder();
            List<string> rev = ExtractUpperCaseWords(lines);

            rev.Reverse();
            foreach (var i in rev)
            {
                sb.Append(i);
                sb.Append(' ');
            }

            return sb.ToString();
        }

        private static List<string> ExtractUpperCaseWords(string[] lines)
        {
            List<string> rev = new List<string>();
            foreach (var item in lines)
            {
                if (item.Length == 0)
                    continue;
                string[] line = item.Split(' ');
                foreach (var word in line)
                {
                    if (word.Length == 0)
                        continue;
                    char f = word[0];
                    if (Char.IsUpper(f))
                        rev.Add(word);
                }
            }

            return rev;
        }
    }
}
