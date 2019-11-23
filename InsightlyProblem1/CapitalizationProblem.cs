namespace InsightlyProblem1
{
    public class CapitalizationProblem
    {
        private readonly char[] _charArray;
        private readonly int _charArrayLength;
        private readonly string[] _names;

        public CapitalizationProblem(string value, string[] names)
        {
            value = value.Trim();
            _charArray = Converter.ConvertToCharArray(value);
            _charArrayLength = _charArray.Length;
            _names = names;
        }

        public string FixCaseInParagraph()
        {
            // Capitalize first word of first sentence
            _charArray[0] = CapitalizationHelper.UpperCase(_charArray[0]);

            // Start from 1, since first character is capitalized
            for (int n = 1; n < _charArrayLength; n++)
            {
                (bool isName, int nameLength) = IsName(n);

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

            return Converter.ConvertToString(_charArray);
        }

        private (bool, int) IsName(int nStart)
        {
            int remainingLen = _charArrayLength - nStart;

            foreach (string name in _names)
            {
                int wordLen = name.Length;

                if (wordLen >= remainingLen)
                {
                    continue;
                }

                int n = nStart;
                bool found = true;

                foreach (char c in name)
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
                    return (true, name.Length);
                }
            }

            return (false, 0);
        }

        private bool IsSentenceSeparator(int n)
        {
            int remainingLen = _charArrayLength - n;
            const string sentenceSeparator = ". ";
            int sentenceSeparatorLength = sentenceSeparator.Length;

            if (remainingLen <= sentenceSeparatorLength)
            {
                return false;
            }

            bool endOfSentence = _charArray[n] == '.' || _charArray[n] == '!' || _charArray[n] == '?';

            return endOfSentence && _charArray[n + 1] == ' ';
        }
    }
}