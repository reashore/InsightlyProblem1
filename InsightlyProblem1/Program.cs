using static System.Console;

namespace InsightlyProblem1
{
    public class Program
    {
        public static void Main()
        {
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            //valueIn = "it is a beautiful day in california today, john. i'm not sure if it will rain, but you better be prepared! see you and anna soon.";
            //string[] names = { "john", "anna", "california", "oregon" };
            //string valueOutExpected = "It is a beautiful day in California today, John. I'm not sure if it will rain, but you better be prepared! See you and Anna soon.";
            //valueOut = capitalizationProblem.FixCaseInParagraph(valueIn, names);
            //WriteLine($"valuein = {valueIn}");
            //WriteLine($"valueOut = {valueOut}");
            //WriteLine();


            //string stringIn = "a jim ab.";
            //string[] names = { "jim", "ab" };
            //string expectedValueOut = "A Jim Ab.";
            //string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);
            //WriteLine($"valuein = \"{stringIn}\"");
            //WriteLine($"valueOut = \"{stringOut}\"");

            string stringIn = "a ab ab.";
            string[] names = { "jim", "ab" };
            string expectedValueOut = "A Jim Ab.";
            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);
            WriteLine($"valuein = \"{stringIn}\"");
            WriteLine($"valueOut = \"{stringOut}\"");

            //stringIn = "john anna oregon california.";
            //names = new [] { "john", "anna", "california", "oregon" };
            //expectedValueOut = "John Anna Oregon California.";
            //stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);
            //WriteLine($"valuein = \"{stringIn}\"");
            //WriteLine($"valueOut = \"{stringOut}\"");
        }
    }
}
