using System.Text;

namespace CSharpFoundation.ALGORITHMS
{
    public static class ClassicAlgorithms{

        public static string processaFizzBuzz(int i){
            StringBuilder vs_FizzBuzz = new StringBuilder();
            int contador = 1; 

            if(i <= 1) 
                return "Erro, o valor de entrada precisa ser maior que 1";

            do
            {
                if ((contador % 3 == 0) && (contador % 5 == 0))
                    vs_FizzBuzz.Append("FizzBuzz");            
                else if (contador % 3 == 0)
                        vs_FizzBuzz.Append("Fizz");
                    else if (contador % 5 == 0)
                        vs_FizzBuzz.Append("Buzz");    
                    else 
                        vs_FizzBuzz.Append(contador.ToString());    
                
                if((contador +1) <= i)
                vs_FizzBuzz.Append(" ");

                contador++;
            }while (contador <= i); 

            return vs_FizzBuzz.ToString();
        }
    }
}
