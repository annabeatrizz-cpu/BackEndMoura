namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular;

        public float Saldo;


        public void Depositar(float valor)
        {

            Saldo += valor;
            Console.WriteLine($"Deposito efetuado com sucesso!");
            Console.WriteLine($"Novo Saldo: R${Saldo}");
            

        }



        public void Sacar(float valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso!");
            Console.WriteLine($"Novo Saldo: R${Saldo}");
            
        }
    }
}
