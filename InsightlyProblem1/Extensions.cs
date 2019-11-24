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
                //char cUpperCase = UpperCase(c);
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


        //public static string UpperCase(string valueIn)
        //{
        //    if (valueIn == null)
        //    {
        //        throw new ArgumentNullException(nameof(valueIn));
        //    }

        //    StringBuilder stringBuilder = new StringBuilder();

        //    foreach (char c in valueIn)
        //    {
        //        char cUpperCase = UpperCase(c);
        //        stringBuilder.Append(cUpperCase);
        //    }

        //    return stringBuilder.ToString();
        //}

        //public static string ConvertToString(char[] charArray)
        //{
        //    string result = "";

        //    foreach (char c in charArray)
        //    {
        //        result += c;
        //    }

        //    return result;
        //}

        //public static string ToString1(this char[] charArray)
        //{
        //    string result = "";

        //    foreach (char c in charArray)
        //    {
        //        result += c;
        //    }

        //    return result;
        //}

        //public static string ToString(this char[] charArray)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();

        //    foreach (char c in charArray)
        //    {
        //        stringBuilder.Append(c);
        //    }

        //    return stringBuilder.ToString();
        //}

        public static string ToString2(this char[] charArray)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in charArray)
            {
                stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        //public static char[] ConvertToCharArray(string stringIn)
        //{
        //    int length = stringIn.Length;
        //    char[] charArray = new char[length];

        //    for (int n = 0; n < length; n++)
        //    {
        //        charArray[n] = stringIn[n];
        //    }

        //    return charArray;
        //}
    }
}