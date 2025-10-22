int qtdnumeros = 0;

Console.WriteLine($"Ola usuario, quantos numeros quer digitar?");
int qtdnumeros = int.Parse(Console.ReadLine());
String impares = "Impares: ";
String pares = "Pares: ";


for (int i = 1; i <= qtdnumeros; i++)
{
    Console.WriteLine($"Digite o {i}º numero:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ", ";
    }

    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);
