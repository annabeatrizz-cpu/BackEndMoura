int senha;

Console.WriteLine($"Digite a senha: ");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}

Console.WriteLine();

