

namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public float Preco;

        public int Estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;

        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco:F2}, Qtd Estoque: {Estoque}");
            
        }
                 
    }
}