using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TableParser
{
    [TestFixture]
    public class QuotedFieldTaskTests
    {
        [TestCase("''", 0, "", 2)]
        [TestCase("'a'", 0, "a", 3)]
        public void TestAuthor(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(actualToken, new Token(expectedValue, startIndex, expectedLength));
        }

        // Добавьте свои тесты
        [TestCase("", 0, "", 0)]
        public void TestEmpty(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(actualToken, new Token(expectedValue, startIndex, expectedLength));
        }
         // Добавьте свои тесты
        [TestCase("1 2	3", 0, "", 0)]
        [TestCase("a \"bcd ef\" 'x y'", 0, "", 0)]
        [TestCase("\"a 'b' 'c' d\" '\"1\" \"2\" \"3\"'", 0, "", 0)]
        [TestCase("a\"b c d e\"f", 0, "", 0)]
        [TestCase("abc \"def g h", 0, "", 0)]
        [TestCase("\"a \\\"c\\\"\"", 0, "", 0)]
        [TestCase("\"\\\\\" b", 0, "", 0)]

        public void TestSet01(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(actualToken, new Token(expectedValue, startIndex, expectedLength));
        }
    }

    class QuotedFieldTask
    {
        //Метод ReadQuotedField принимает строку и позицию в строке.
        //По этой позиции находится открывающая кавычка поля в кавычках.
        //Метод должен вернуть токен поля в кавычках, начинающийся с указанной позиции. 
        public static Token ReadQuotedField(string s, int startIndex)
        {
            int l = 0;
            int bs = 0;
            string t = string.Empty;
            for ( int i = startIndex; i < s.Length; ++i)
            {
                char c = s[i];
                if (i == startIndex && c.Equals('"'))
                {
                    continue;
                }
                else if (i != startIndex && c.Equals('"') && bs%2==0)
                {
                    break;
                }

                if (c.Equals('\\'))
                {
                    ++l;
                    ++bs;
                }
                else
                {
                    if (bs != 0 )
                    {
                        if (bs % 2 != 0){
                            t += '\\'+c;
                        }else
                        {
                            if (!c.Equals('\''))
                            {
                                t += c;
                            }
                            
                        }
                        
                        bs = 0;
                    }
                    else
                    {
                        if (!c.Equals('\''))
                        {
                            t += c;
                        }
                    }
                }
                
                ++l;
            }
            return new Token(t, startIndex, l);
        }
    }
}
