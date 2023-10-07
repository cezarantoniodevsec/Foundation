using System;

namespace CSharpFoundation.ALGORITHMS
{
    public class MergeSortAlgorithm: ISortingAlgorithm {

        public int[] sort(int[] baralhoPrincipal){
                if(baralhoPrincipal.Length == 0) 
                return baralhoPrincipal;

            divideOsMontes(baralhoPrincipal,0,baralhoPrincipal.Length-1);
            return baralhoPrincipal;
        }

        private void divideOsMontes(int[] baralhoPrincipal,int inicio,int fim){ 
            if (inicio < fim){ 
                int meio =  inicio + (fim  - inicio ) / 2;
            
                // Monte da Esquerda 
                divideOsMontes(baralhoPrincipal,inicio,meio);             
                // Monta de Direita
                divideOsMontes(baralhoPrincipal,meio + 1,fim); 

                remontaMontesOrdenando(baralhoPrincipal,inicio,meio,fim);    
            }
        }

        private void remontaMontesOrdenando(int[] baralhoPrincipal,int inicio, int meio, int fim){
            int nCartasBarEsq = meio - inicio + 1;
            int nCartasBarDir = fim - meio;
            int contBarPrincipal = inicio;  
            int i =0 , j = 0; 
            
            int[] barEsq = alocaBaralhoEsquerda(baralhoPrincipal,nCartasBarEsq, inicio);
            int[] barDir = alocaBaralhoDireita(baralhoPrincipal,nCartasBarDir, meio);
            
            while (i < nCartasBarEsq && j < nCartasBarDir){
                if (barEsq[i] <= barDir[j]){
                    baralhoPrincipal[contBarPrincipal] = barEsq[i];
                    i++;
                }else {
                    baralhoPrincipal[contBarPrincipal] = barDir[j];
                    j++;
                }
                contBarPrincipal++;
            }

            // Aloca as cartas restantes da Esquerda 
            while (i < nCartasBarEsq) {
                // Console.WriteLine($" = Coloca o valor : { barEsq[i] } no Baralho principal ");
                baralhoPrincipal[contBarPrincipal] = barEsq[i];
                i++;
                contBarPrincipal++;
            }

            // Aloca as cartas restantes da Direita 
            while (j < nCartasBarDir) {
                // Console.WriteLine($" = Coloca o valor : { barDir[j] } no Baralho principal ");
                baralhoPrincipal[contBarPrincipal] = barDir[j];
                j++;
                contBarPrincipal++;
            } 
        }
        
        private int[] alocaBaralhoEsquerda(int[] baralhoPrincipal,int nCartasBarEsq, int inicio){
            int[] barEsq = new int[nCartasBarEsq];

            for (int i = 0; i < nCartasBarEsq; ++i)
                barEsq[i] = baralhoPrincipal[inicio + i];

            return barEsq;
        }

        private int[] alocaBaralhoDireita(int[] baralhoPrincipal,int nCartasBarDir, int meio){
            int[] barEsq = new int[nCartasBarDir];

            for (int j = 0; j < nCartasBarDir; ++j)
                barEsq[j] = baralhoPrincipal[meio + 1 + j];

            return barEsq;
        }
    }
}
