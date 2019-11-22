using static System.Console;

namespace InsightlyProblem1
{
    public class Program
    {
        public static void Main()
        {
            //string valueIn = "!!!it is a beautiful day today!!!";
            //string valueOut = CapitalizationHelper.UpperCase(valueIn);
            //WriteLine($"valuein = {valueIn}");
            //WriteLine($"valueOut = {valueOut}");
            //WriteLine();


            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();


            //valueIn = "it is a beautiful day in california today, john. i'm not sure if it will rain, but you better be prepared! see you and anna soon.";
            //string[] names = { "john", "anna", "california", "oregon" };
            //string valueOutExpected = "It is a beautiful day in California today, John. I'm not sure if it will rain, but you better be prepared! See you and Anna soon.";
            //valueOut = capitalizationProblem.FixCaseInParagraph(valueIn, names);
            //WriteLine($"valuein = {valueIn}");
            //WriteLine($"valueOut = {valueOut}");
            //WriteLine();

            string valueIn = "one day john and anna went to oregon and california.";
            string[] names = {"john", "anna", "california", "oregon"};
            string valueOutExpected = "It is a beautiful day in California today, John. I'm not sure if it will rain, but you better be prepared! See you and Anna soon.";
            string valueOut = capitalizationProblem.FixCaseInParagraph(valueIn, names);
            WriteLine($"valuein = \"{valueIn}\"");
            WriteLine($"valueOut = \"{valueOut}\"");
            WriteLine();
        }
    }
}
