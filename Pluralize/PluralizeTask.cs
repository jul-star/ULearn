using System.Diagnostics.Eventing.Reader;

namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            count = count % 100;

            if (count == 1)
            {
                return "рубль";
            }
            else if (count > 1 && count < 5)
            {
                return "рубля";
            }
            else if (count > 4 && count < 20)
            {
                return "рублей";
            }

            count = count % 10;
            if (count == 1)
            {
                return "рубль";
            }
            else if (count > 1 && count < 5)
            {
                return "рубля";
            }
            return "рублей";

        }
    }
}