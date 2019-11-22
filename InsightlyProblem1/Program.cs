using System;
using static System.Console;

namespace InsightlyProblem1
{
    public class Program
    {
        public static void Main()
        {
            string valueIn = "!!!it is a beautiful day today!!!";
            string valueOut = UpperCase(valueIn);
            WriteLine($"valuein = {valueIn}");
            WriteLine($"valueOut = {valueOut}");
            WriteLine();

            valueIn = "it is a beautiful day in california today, john. i'm not sure if it will rain, but you better be prepared! see you and anna soon.";
            string[] names = {"john", "anna", "california", "oregon"};
            const string valueOutExpected = "It is a beautiful day in California today, John. I'm not sure if it will rain, but you better be prepared! See you and Anna soon.";
            valueOut = FixCaseInParagraph(valueIn);
        }
        
        private static string UpperCase(string valueIn)
        {
            if (valueIn == null)
            {
                throw new ArgumentException("valueIn must be non-null");
            }

            string valueOut = "";

            foreach (char c in valueIn)
            {
                valueOut += UpperCase(c);
            }

            return valueOut;
        }

        private static char UpperCase(char charIn)
        {
            char charOut = charIn;

            if ('a' <= charIn && charIn <= 'z')
            {
                char charUpper = (char)(charIn - 'a' + 'A');
                charOut = charUpper;
            }

            return charOut;
        }

        private static string FixCaseInParagraph(string paragraphIn)
        {
            paragraphIn = paragraphIn.Trim();
            int paraLen = paragraphIn.Length;
            string paragraphOut = "";

            for (int n = 0; n < paraLen; n++)
            {

                if (n == 0)
                {
                    paragraphOut += UpperCase(paragraphIn[n]);
                    continue;
                }

                // check for special word
                // if contains special word


            }

            return "";
        }

    }
}
