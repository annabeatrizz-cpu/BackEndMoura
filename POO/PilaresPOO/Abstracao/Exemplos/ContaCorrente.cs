namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {

        public double Saldo = 0;
        private double TaxaSaque = 5;


        public ContaCorrente(double SaldoInicial)
        {
            Saldo = SaldoInicial;
        }
       


        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"O valor do deposito deve ser positivo");
                return;
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {

            double totalComTaxa = (valor / 100 * TaxaSaque) + valor;

           if (valor <= 0 || Saldo >= totalComTaxa )
           {
             Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro na conta");
             return;

             
           }

           Saldo -= totalComTaxa;
        }
    }
}