using CSharpFoundation.ALGORITHMS;

namespace TestsCSharpFoundation.ALGORITHMS
{
    public class UTMergeSort {
        private ISortingAlgorithm sortingAlgorithm;

        public UTMergeSort(){
           sortingAlgorithm = new MergeSortAlgorithm();
        }

        [Fact]
        public void QuantidadeParDeElementos()
        {        
            int[] arr_desordenado = new int[] {4,7,2,6,4,1,8,3};
            int[] expected = new int[]{ 1,2,3,4,4,6,7,8};
            var atual = sortingAlgorithm.sort(arr_desordenado);
            Assert.Equal(atual,expected);
        }   
        
        [Fact]
        public void QuantidadeImparElementos()
        {        
            int[] arr_desordenado = new int[] {12 ,11 ,13, 5 ,6 ,7};
            int[] expected = new int[]{ 5 ,6 ,7, 11 ,12 ,13 };
            var atual = sortingAlgorithm.sort(arr_desordenado);
            Assert.Equal(atual,expected);
        }
    }
}
