namespace Exercicio02
{
        public class Professor : Pessoa
    {
        public string Disciplina;

        public void exibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }

}