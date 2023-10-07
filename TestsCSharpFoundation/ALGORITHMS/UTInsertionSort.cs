using CSharpFoundation.ALGORITHMS;

namespace TestsCSharpFoundation.ALGORITHMS
{
    public class UTInsertionSort
    {
        private ISortingAlgorithm sortingAlgorithm;
        
        public UTInsertionSort(){
            sortingAlgorithm = new InsertionSort();
        }

        [Fact]
        public void testDisordered()
        {
            // Given
            var input = TestSortUtils.DISORDERED_ARRAY;
            var expectedResult = TestSortUtils.ORDERED_ARRAY;            
            // When
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testBubleSortNegative()
        {
            // Given
            var input  = TestSortUtils.NEGATIVE_DISORDERED_ARRAY;
            var expectedResult = TestSortUtils.NEGATIVE_ORDERED_ARRAY;
            // When        
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testEmptyBubleSort()
        {
            // Given
            var input  = new int[]{};
            var expectedResult = new int[]{};
            // When        
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testBubleSortWorstCase()
        {
            // Given
            var input  = TestSortUtils.WORST_CASE;
            var expectedResult = TestSortUtils.WORST_CASE_ORDERED;
            // When        
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testBubleSortBestCase()
        {
            // Given
            var input  = TestSortUtils.BEST_CASE;
            var expectedResult = TestSortUtils.BEST_CASE_ORDERED;
            // When        
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
