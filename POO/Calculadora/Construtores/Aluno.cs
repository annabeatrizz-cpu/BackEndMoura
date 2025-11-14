namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public int Nota;

        public Aluno()
        {
            Console.WriteLine($"Lista de alunos");

        }

        public Aluno(string n, int m)
        {
            Nome = n;
            Nota = m;
        }
        
        public void ExibirDados()
       {
         Console.WriteLine($"Aluno: {Nome} | Nota: {Nota} "  );
       } 
    }
}