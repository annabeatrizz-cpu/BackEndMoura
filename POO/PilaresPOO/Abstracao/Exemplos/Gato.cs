namespace Exemplos
{
    public class Gato : Animal
    {

        public override void FazerSom()
        {
          Console.WriteLine($"Miau Miau");
          
        }

        public override void Mover()
        {
          Console.WriteLine($"Text");
          
        }
    }
}