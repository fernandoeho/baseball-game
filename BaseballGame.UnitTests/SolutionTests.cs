using Xunit;

namespace BaseballGame.UnitTests;

public class SolutionTests
{
    [Theory]
    [InlineData(new string[] { "5", "2", "C", "D", "+" }, 30)]
    [InlineData(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
    [InlineData(new string[] { "1" }, 1)]
    public void When_InputIsProvided_Then_CalculatePoints(string[] ops, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.CalPoints(ops);

        // Assert
        Assert.Equal(expected, actual);
    }
}