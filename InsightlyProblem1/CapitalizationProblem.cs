namespace InsightlyProblem1
{
    public class CapitalizationProblem
    {
        private char[] _paragraphInArray;

        public string FixCaseInParagraph(string paragraphIn, string[] names)
        {
            paragraphIn = paragraphIn.Trim();
            int paraLen = paragraphIn.Length;
             _paragraphInArray = new char[paraLen];

            // Since strings are immutable, convert string to char[]
            for (int n = 0; n < paraLen; n++)
            {
                _paragraphInArray[n] = paragraphIn[n];
            }

            // Capitalize first word of first sentence
            _paragraphInArray[0] = CapitalizationHelper.UpperCase(_paragraphInArray[0]);

            // Start from 1, not 0, since first character is now capitalized
            for (int n = 1; n < paraLen; n++)
            {
                (bool isName, int nameLength) = IsName(n, paraLen, names);

                if (isName)
                {
                    _paragraphInArray[n] = CapitalizationHelper.UpperCase(_paragraphInArray[n]);
                    n += nameLength;
                }

                bool isSentenceSeparator = IsSentenceSeparator(n, paraLen);

                if (isSentenceSeparator)
                {
                    n += 2;
                    _paragraphInArray[n] = CapitalizationHelper.UpperCase(_paragraphInArray[n]);
                }
            }

            return ConvertToString(_paragraphInArray);
        }

        private (bool, int) IsName(int n, int paraLen, string[] words)
        {
            int remainingLen = paraLen - n;
            bool found = true;

            foreach (string word in words)
            {
                int wordLen = word.Length;

                if (wordLen >= remainingLen)
                {
                    return (false, 0);
                }

                foreach (char c in word)
                {
                    if (c != _paragraphInArray[n])
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

        private bool IsSentenceSeparator(int n, int paraLen)
        {
            int remainingLen = paraLen - n;

            // test this
            if (remainingLen <= 2)
            {
                return false;
            }

            if (_paragraphInArray[n] == '.' && _paragraphInArray[n] == ' ')
            {
                return true;
            }

            return false;
        }

        private string ConvertToString(char[] charArray)
        {
            string result = "";

            foreach (char c in charArray)
            {
                result += c;
            }

            return result;
        }
    }
}