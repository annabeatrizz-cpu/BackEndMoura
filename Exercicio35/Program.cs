int repeticoes = 0;


Console.WriteLine("Insira um numero de repeticoes");
repeticoes = int.Parse(Console.ReadLine());

int contador = 1;
int x = int.Parse(Console.ReadLine());

while (contador <= x)
{
    Console.WriteLine("Insira um numero");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo numero");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine($"o numero {num1} e maior que o {num2}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"o numero {num2} e maior que o {num1}");
    }
    else
    {
        Console.WriteLine($"os numeros {num1} sao iguais {num2}");
    }

    contador++;
}