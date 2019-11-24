using static System.Console;

namespace InsightlyProblem1
{
    public class Program
    {
        public static void Main()
        {
            const string stringIn = "it is a beautiful day in california today, john. i'm not sure if it will rain, but you better be prepared! see you and anna soon.";
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);

            WriteLine($"stringIn  = {stringIn}");
            WriteLine($"stringOut = {stringOut}");

            //char[] foo = stringIn.ToCharArray();
            //string bar1 = foo.ToString1();
            //string bar2 = foo.ToString2();
            //string bar3 = foo.ToString();

        }
    }
}
