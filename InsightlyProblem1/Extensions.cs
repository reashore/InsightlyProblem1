using System;
using System.Text;

namespace InsightlyProblem1
{
    public static class Extensions
    {
        public static string UpperCase(this string valueIn)
        {
            if (valueIn == null)
            {
                throw new ArgumentNullException(nameof(valueIn));
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in valueIn)
            {
                char cUpperCase = c.UpperCase();
                stringBuilder.Append(cUpperCase);
            }

            return stringBuilder.ToString();
        }

        public static char UpperCase(this char charIn)
        {
            char charOut = charIn;

            if ('a' <= charIn && charIn <= 'z')
            {
                char charUpper = (char)(charIn - 'a' + 'A');
                charOut = charUpper;
            }

            return charOut;
        }

        public static string ToString2(this char[] charArray)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in charArray)
            {
                stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }
    }
}