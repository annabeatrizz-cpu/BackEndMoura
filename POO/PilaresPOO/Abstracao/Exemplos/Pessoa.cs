namespace Exemplos
{
    public class Pessoa : Animal
    {


        public string Nome;

        public int Idade;

        public void Dormir()
        {
            Console.WriteLine($"Zzzzz...");
            
        }
        public override void FazerSom()
        {
         Console.WriteLine($"Oii");
         
        }

        public override void Mover()
        {
         Console.WriteLine($"Tec Tec Tec");
         
        }
    }
}