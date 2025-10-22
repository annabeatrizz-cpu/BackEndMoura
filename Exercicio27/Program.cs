int qtdUsuario = 0;
int contador = 1;

Console.WriteLine($"quantos numeros voce quer digitar");
qtdUsuario = int.Parse(Console.ReadLine());

while(contador <= qtdUsuario)
{
    Console.WriteLine($"digite um numero: ");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero digitado eh par: {batata}");
    }

    contador++;
}