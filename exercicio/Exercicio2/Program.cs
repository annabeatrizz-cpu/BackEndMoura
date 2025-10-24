int golsTime1, golsTime2;

Console.WriteLine($"Informe os gols do primeiro time: ");
golsTime1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gols do segundo time: ");
golsTime2 = int.Parse(Console.ReadLine());

if (golsTime1 == golsTime2)
{
    Console.WriteLine($"O resultado foi um Empate!");
}
else if (golsTime1 > golsTime2)
{
    Console.WriteLine($"Vitória do Primeiro time!");
}
else
{
    Console.WriteLine($"Vitória do Segundo time!");
}

Console.WriteLine();
