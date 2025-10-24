int quantidade;
double total;

Console.WriteLine($"Informe o número de maçãs compradas: ");
quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    total = quantidade * 0.30;
}
else
{
    total = quantidade * 0.25;
}

Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
Console.WriteLine();