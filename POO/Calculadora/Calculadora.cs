
namespace Calculadora
{
    public class Calculator
    {
        public double N1;

        public double N2;

        public double Resultado;

        public double Somar()
        {
            Resultado = N1 + N2;
            Console.WriteLine($"Resultado da soma: {Resultado}");
            return Resultado;
        }
        
        public double Subtrair()
        {
            Resultado = N1 - N2;
            Console.WriteLine($"Resultado da subtracao: {Resultado}");
            return Resultado;
        }

        public double Dividir()
        {
       if (N2 == 0)
       {
                Console.WriteLine($"Nao existe divisao por zero");
                return -1;
       } 
            Resultado = N1 / N2;
            return Resultado;
        }
        
        public double Multiplicar()
        {
            Resultado = N1 * N2;
            Console.WriteLine($"Resultado da multiplicacao: {Resultado}");
            return Resultado;
        }
    }
}