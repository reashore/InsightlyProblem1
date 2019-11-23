namespace InsightlyProblem1
{
    public static class Converter
    {
        public static string ConvertToString(char[] charArray)
        {
            string result = "";

            foreach (char c in charArray)
            {
                result += c;
            }

            return result;
        }

        public static char[] ConvertToCharArray(string stringIn)
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