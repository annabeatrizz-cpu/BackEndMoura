namespace Exemplos
{
    public abstract class ContaPoupanca : ContaBancaria
    {   
        public double Saldo =0;

        private double TaxaSaque = 3;

        public ContaPoupanca(double SaldoInicial)
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
            throw new NotImplementedException();
        }
    }
}