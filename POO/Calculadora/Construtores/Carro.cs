namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;



        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}, Ano {Ano}");

        }
        
        
         public Carro(string n, string xpto, int i)
        {
            Marca = n;
            Modelo = xpto;
            Ano = i;

            ExibirDados();
        }
       
    }


}