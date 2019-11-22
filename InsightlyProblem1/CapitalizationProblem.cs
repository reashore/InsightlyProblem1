namespace InsightlyProblem1
{
    public class CapitalizationProblem
    {
        private char[] _charArray;
        private int _charArrayLength;

        public string FixCaseInParagraph(string value, string[] names)
        {
            value = value.Trim();
            _charArray = ConvertToCharArray(value);
            _charArrayLength = _charArray.Length;

            // Capitalize first word of first sentence
            _charArray[0] = CapitalizationHelper.UpperCase(_charArray[0]);

            // Start from 1, not 0, since first character is now capitalized
            for (int n = 1; n < _charArrayLength; n++)
            {
                (bool isName, int nameLength) = IsName(n, names);

                if (isName)
                {
                    _charArray[n] = CapitalizationHelper.UpperCase(_charArray[n]);
                    n += nameLength;
                }

                bool isSentenceSeparator = IsSentenceSeparator(n);

                if (isSentenceSeparator)
                {
                    n += 2;
                    _charArray[n] = CapitalizationHelper.UpperCase(_charArray[n]);
                }
            }

            return ConvertToString(_charArray);
        }

        private (bool, int) IsName(int nStart, string[] words)
        {
            int remainingLen = _charArrayLength - nStart;
            bool found = true;

            foreach (string word in words)
            {
                int wordLen = word.Length;

                if (wordLen >= remainingLen)
                {
                    continue;
                }

                int n = nStart;

                foreach (char c in word)
                {
                    if (c != _charArray[n])
                    {
                        found = false;
                        break;
                    }

                    n++;
                }

                if (found)
                {
                    return (true, word.Length);
                }
            }

            return (false, 0);
        }

        private bool IsSentenceSeparator(int n)
        {
            int remainingLen = _charArrayLength - n;

            // test this
            if (remainingLen <= 2)
            {
                return false;
            }

            if (_charArray[n] == '.' && _charArray[n] == ' ')
            {
                return true;
            }

            return false;
        }

        private static string ConvertToString(char[] charArray)
        {
            string result = "";

            foreach (char c in charArray)
            {
                result += c;
            }

            return result;
        }

        private static char[] ConvertToCharArray(string stringIn)
        {
            int length = stringIn.Length;
            char[] charArray = new char[length];

            for (int n = 0; n < length; n++)
            {
                charArray[n] = stringIn[n];
            }

            return charArray;
        }
    }
}