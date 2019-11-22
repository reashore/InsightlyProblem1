﻿using System;

namespace InsightlyProblem1
{
    public static class CapitalizationHelper
    {
        public static string UpperCase(string valueIn)
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

        public static char UpperCase(char charIn)
        {
            char charOut = charIn;

            if ('a' <= charIn && charIn <= 'z')
            {
                char charUpper = (char)(charIn - 'a' + 'A');
                charOut = charUpper;
            }

            return charOut;
        }
    }
}