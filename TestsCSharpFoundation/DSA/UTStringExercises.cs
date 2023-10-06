namespace TestsCSharpFoundation.DSA;
using CSharpFoundation.DSA;

public class UTStringExercises
{
    [Fact]
    public void testStringsAreIsomorphic()
    {   
        /// Given
        var firstWord   = "aab";
        var secoundWord = "xxy";
        var expectedResult = true;     
        // When
        var actualResult = StringExercises.StringsAreIsomorphic(firstWord, secoundWord);
        // Then
        Assert.Equal(expectedResult,actualResult);
    }
}