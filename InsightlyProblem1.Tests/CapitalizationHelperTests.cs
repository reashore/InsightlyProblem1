using Xunit;

namespace InsightlyProblem1.Tests
{
    public class CapitalizationHelperTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            const string stringIn = "it is a beautiful day today";

            // Act
            string stringOut = stringIn.UpperCase();

            // Assert
            const string expectedStringOut = "IT IS A BEAUTIFUL DAY TODAY";
            Assert.Equal(expectedStringOut, stringOut);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            const string stringIn = "!@#$%^&*()+=_-<>";

            // Act
            string stringOut = stringIn.UpperCase();

            // Assert
            Assert.Equal(stringIn, stringOut);
        }

        [Theory]
        [InlineData('a', 'A')]
        [InlineData('b', 'B')]
        [InlineData('c', 'C')]
        [InlineData('d', 'D')]
        [InlineData('e', 'E')]
        [InlineData('f', 'F')]
        [InlineData('g', 'G')]
        [InlineData('h', 'H')]
        [InlineData('i', 'I')]
        [InlineData('j', 'J')]
        [InlineData('k', 'K')]
        [InlineData('l', 'L')]
        [InlineData('m', 'M')]
        [InlineData('n', 'N')]
        [InlineData('o', 'O')]
        [InlineData('p', 'P')]
        [InlineData('q', 'Q')]
        [InlineData('r', 'R')]
        [InlineData('s', 'S')]
        [InlineData('t', 'T')]
        [InlineData('u', 'U')]
        [InlineData('v', 'V')]
        [InlineData('w', 'W')]
        [InlineData('x', 'X')]
        [InlineData('y', 'Y')]
        [InlineData('z', 'Z')]
        public void Test3(char charIn, char expectedCharOut)
        {
            // Arrange

            // Act
            char charOut = charIn.UpperCase();

            // Assert
            Assert.Equal(expectedCharOut, charOut);
        }
    }
}
