namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;

        public int Idade = 0;

        public int Altura;


        public void Falar()
        {

            Console.WriteLine($"Ola, tudo bem? meu nome e {Nome}!");

        }

        public void Dormir()
        {
            Console.WriteLine($"Zzzz....");

        }
        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                Idade += _id;
            }
            else
            {
                Idade++;
            }
        }
    }
}