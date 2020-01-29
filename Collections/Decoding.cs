using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public static class Decoding
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

        public static string ApplyCommands(string[] commands)
        {
            StringBuilder sb  = new StringBuilder();
            
            foreach (var cmd in commands)
            {
                if (cmd.Contains("push"))
                {
                    string item = cmd.Remove(0, "push ".Length);
                    sb.Append(item);
                }
                else if (cmd.Contains("pop"))
                {
                    string item = cmd.Remove(0, "pop ".Length);
                    try
                    {
                        int count = int.Parse(item);
                        count = (count < sb.Length ? count : sb.Length);
                        sb.Remove(sb.Length-count, count);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
