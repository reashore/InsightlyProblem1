using System;
using Xunit;

namespace InsightlyProblem1.Tests
{
    public class CapitalizationProblemTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            const string stringIn = "john anna oregon california another.";
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act
            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);

            // Assert
            const string expectedStringOut = "John Anna Oregon California another.";
            Assert.Equal(expectedStringOut, stringOut);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            const string stringIn = "one day john and anna went to oregon and california.";
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act
            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);

            // Assert
            const string expectedStringOut = "One day John and Anna went to Oregon and California.";
            Assert.Equal(expectedStringOut, stringOut);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            const string stringIn = "it is a beautiful day in california today, john. i'm not sure if it will rain, but you better be prepared! see you and anna soon.";
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act
            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);

            // Assert
            const string expectedStringOut = "It is a beautiful day in California today, John. I'm not sure if it will rain, but you better be prepared! See you and Anna soon.";
            Assert.Equal(expectedStringOut, stringOut);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            const string stringIn = "";
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act
            string stringOut = capitalizationProblem.FixCaseInParagraph(stringIn, names);

            // Assert
            const string expectedStringOut = "";
            Assert.Equal(expectedStringOut, stringOut);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            const string stringIn = null;
            string[] names = { "john", "anna", "california", "oregon" };
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => capitalizationProblem.FixCaseInParagraph(stringIn, names)) ;
        }

        [Fact]
        public void Test6()
        {
            // Arrange
            const string stringIn = "john anna oregon california another.";
            string[] names = null;
            CapitalizationProblem capitalizationProblem = new CapitalizationProblem();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => capitalizationProblem.FixCaseInParagraph(stringIn, names)) ;
        }
    }
}
