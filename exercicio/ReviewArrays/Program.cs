string[] nomes = new string[4];

nomes[0] = "edu";
nomes[1] = "Marcio";
nomes[2] = "Manoel";

Console.WriteLine($"1o Nome: {nomes[0]}");
Console.WriteLine($"2o Nome: {nomes[1]}");
Console.WriteLine($"3o Nome: {nomes[2]}");
Console.WriteLine($"4o Nome: {nomes[3]}");

Console.WriteLine($"Tamanho do Array: {nomes.Length}");
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"        {i + 1}o Nome: {nomes[i]}");
    
}

