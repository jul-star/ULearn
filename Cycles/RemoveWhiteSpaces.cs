using System;
using System.Collections.Generic;
using System.Text;

namespace Cycles
{
    public class RemoveWhiteSpaces
    {
        public static string RemoveStartSpaces(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            int i = 0;
            while (char.IsWhiteSpace(text[i]) && i < text.Length - 1)
            {
                i++;
            }

            if (i == text.Length - 1 && char.IsWhiteSpace(text[i]))
                return string.Empty;
            return text.Substring(i);

        }
    }
}
