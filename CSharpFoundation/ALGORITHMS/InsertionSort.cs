using System;

namespace CSharpFoundation.ALGORITHMS
{
    public class InsertionSort: ISortingAlgorithm {

        public int[] sort(int[] vet){
            int n  = vet.Length;
            int chave = 0;
            int j = 0;
            // Imagine 3,2,5    
            for (int i = 1; i < n; i++){
                chave = vet[i]; 
                // Primeira passada a chave vai ser 2  
                j = i -1;
                // O j vai ser 0 
                // Na primeira passada, estamos comparando 3 com 2 
                while (j >= 0 && vet[j] > chave){
                    // j é igual a zero na primeira passada 
                    // e vet[0] (3 no vetor) é maior que chave (valor 2) 
                    // então a primeira passada entra no loop
                    vet[j+1] = vet[j];
                    j = j-1;
                    // vet[0+1] (2 no vetor) recebeu o valor vet[0] (3 no vetor)
                    // e depois j ficou com -1 e vai sair do loop          
                }
                // agora que j tem -1, j[0] pode receber o valor 2 (chave)
                vet[j+1] = chave;            
                // Na próxima passada o vetor já vai estar ordenado e não entrará no loop.
            }
            return vet;
        }
    }
}
