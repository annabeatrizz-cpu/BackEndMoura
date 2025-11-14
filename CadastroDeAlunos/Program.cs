string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;
int opcao = -1;


do
{
    Console.Clear();
    Console.WriteLine($"=====Aplicativo Sala De Aula=====");
    Console.WriteLine($"1) Listar Alunos");
    Console.WriteLine($"2) Cadastrar Alunos");
    Console.WriteLine($"3) Sair");
    Console.Write($"Escolha uma opcao: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            break;

        case 1:
            ListarAluno();
            break;

        case 2:
            CadastrarAluno();
            break;

        default:
            Console.WriteLine($"Opcao invalida");
            break;
    }
    Console.WriteLine($"Precione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine($"=== Listagem de Aluno ===");
    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}, {idades[i]} anos");
        Console.WriteLine();

    }



}

void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastrando Aluno ===");
    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite as vagas atingindo");
        return;
    }

    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
}