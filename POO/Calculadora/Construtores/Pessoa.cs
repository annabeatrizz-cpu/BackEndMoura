

namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;



        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado");
            
        }
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;

        }               
        
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
            
        }
    }
}