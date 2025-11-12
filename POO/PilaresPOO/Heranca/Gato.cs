
namespace Heranca
{
    public class Gato : Animais
    {
        
        public string nome;

        public string raca;

        public int idade;
        
        public void FazerSom()
        {
            Console.WriteLine($"miau miau miau");
            
        }
        
    }
}