

namespace ClasseEObjetos
{
    public class ProdutoComDesconto
    {
        public string Nome;

        public double Preco;

        public void  AplicarDesconto (double percentual)
        {
        
            Preco -= Preco / 100 * percentual ;
            Console.WriteLine($"Desconto de {percentual}% aplicado! Novo preço: R$ {Preco}");
        
        }
    }
}