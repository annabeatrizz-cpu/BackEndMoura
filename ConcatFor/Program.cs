int qtdLetras = 0;

Console.WriteLine($"Ola usuario, quantas letras tem seu nome?");
qtdLetras = int.Parse(Console.ReadLine());
String nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual e a {i}ª letra?");
    nome += Console.ReadLine();
}

Console.WriteLine($"Seu nome e: {nome}");