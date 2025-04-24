namespace Classics;

public class FractionTest
{
    [Theory]
    [Trait("Category", "Addition")]
    [InlineData(4, 7, 2, 7, 6, 7)]
    [InlineData(4, 7, -2, 7, 2, 7)]

    public void Add_When_same_denominator_Then_Sum_numerator(int aNumerator, int aDenominator, int bNumerator, int bDenominator, int expectedNumerator, int expectedDenominator)
    {
        // Arrange
        var a = new Fraction(aNumerator, aDenominator);
        var b = new Fraction(bNumerator, bDenominator);
        var expected = new Fraction(expectedNumerator, expectedDenominator);

        // Act
        var result = FractionService.Add(a, b);

        // Assert
        Assert.Equivalent(expected, result);
    }

}
public class DiamondTest
{
    [Theory]
    [Trait("Category", "Diamond")]
    [InlineData('A', "A\n")]
    [InlineData('B', " A \nB B\n A \n")]
    [InlineData('C', "  A  \n B B \nC   C\n B B \n  A  \n")]
    [InlineData('D', "   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   \n")]
    [InlineData('E', "    A    \n   B B   \n  C   C  \n D     D \nE       E\n D     D \n  C   C  \n   B B   \n    A    \n")]
        public void PrintDiamond_When_ValidCharacter_Then_PrintDiamond(char c, string expected)
    {
        // Arrange
        var expectedResult = expected.Replace("\r\n", "\n");

        // Act
        var result = DiamondService.BuildDiamond(c).Replace("\r\n", "\n");

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
