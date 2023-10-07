using CSharpFoundation.ALGORITHMS;

namespace TestsCSharpFoundation.ALGORITHMS
{
    public class UTClassicAlgorithms
    {
        [Fact]
        public void testFizzBuzzFirstScenario()
        {
            // Given
            var expectedResult = "1 2 Fizz";
            var limit = 3; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void testFizzBuzzSecondScenario()
        {
            // Given
            var expectedResult = "1 2 Fizz 4 Buzz";
            var limit = 5; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }
    
        [Fact]
        public void testFizzBuzzThirdScenario()
        {
            // Given
            var expectedResult = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz";
            var limit = 20; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void testFizzBuzzForthScenario()
        {
            // Given
            var expectedResult = "Erro, o valor de entrada precisa ser maior que 1";
            var limit = -1; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void testFizzBuzzFifthScenario()
        {
            // Given
            var expectedResult = "Erro, o valor de entrada precisa ser maior que 1";
            var limit = 0; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }    

        [Fact]
        public void testFizzBuzzSixthScenario()
        {
            // Given
            var expectedResult = "Erro, o valor de entrada precisa ser maior que 1";
            var limit = -1; 
            // When
            var actualResult = ClassicAlgorithms.FizzBuzz(limit);
            // Then
            Assert.Equal(expectedResult,actualResult);
        }
    }
}
