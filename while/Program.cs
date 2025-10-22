int contador = 1;

Console.WriteLine($"quantas vezes voce quer rodar o while?");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)

{
    Console.WriteLine($"Contador e: {contador}");
    contador++;
}
