using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public static class Contacts
    {
        public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var item in contacts)
            {
                AddRecord(item, dictionary);
            }
            return dictionary;
        }

        private static void AddRecord(string item, Dictionary<string, List<string>> dictionary)
        {
            var abr = getAbreviation(item);
            InsertRecord(item, dictionary, abr);
        }

        private static void InsertRecord(string item, Dictionary<string, List<string>> dictionary, string abr)
        {
            if (abr.Length != 0)
            {
                if (dictionary.ContainsKey(abr))
                {
                    dictionary[abr].Add(item);
                }
                else
                {
                    dictionary.Add(abr, new List<string> {item});
                }
            }
        }

        private static string getAbreviation(string item)
        {
            string abr = "";
            string[] ne = item.Split(':');
            if (ne.Length == 0)
                return abr;

            string name = ne[0];
            if (name.Length >= 2)
            {
                abr = String.Format("{0}{1}", name[0], name[1]);
            }
            else if (name.Length == 1)
            {
                abr = String.Format("{0}", name);
            }

            return abr;
        }
    }
}
