namespace CSharpFoundation.ALGORITHMS {

    public class QuickSort: ISortingAlgorithm {
        public int[] sort(int[] vet){
            if (vet.Length == 0)
                return vet;
        
            return breakAndOrder(vet,0,vet.Length-1);
        }
        private static int[] breakAndOrder(int[] v,int inicio_vetor,int fim_vetor){
            int pivot = v[inicio_vetor];
            int pontEsquerda = inicio_vetor;
            int pontDireita = fim_vetor;

            while(pontEsquerda <= pontDireita){
                // Enquanto não encontrar ninguém maior que o Pivot o Ponteiro da esquerda avança. 
                while(v[pontEsquerda] < pivot) pontEsquerda++;
                // Enquanto não encontrar ninguém menor que o Pivot o ponteiro da direta recua
                while(v[pontDireita] > pivot) pontDireita--;

                if(pontEsquerda <= pontDireita){
                    // Swap estilosão
                    (v[pontEsquerda],v[pontDireita]) = (v[pontDireita],v[pontEsquerda]);
                    pontEsquerda++;
                    pontDireita--; 
                }
            }
            // Divide o vetor e ordena os sub vetores recursivamente 
            if (inicio_vetor < pontDireita) breakAndOrder(v,inicio_vetor,pontDireita);
            if (pontEsquerda < fim_vetor) breakAndOrder(v,pontEsquerda,fim_vetor);
            
            return v;
        }
    }
}
