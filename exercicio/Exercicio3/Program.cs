double lado1, lado2, lado3;

Console.WriteLine($"Informe o primeiro lado do triângulo: ");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo lado do triângulo: ");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro lado do triângulo: ");
lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"Triângulo Equilátero (3 lados iguais)");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"Triângulo Isósceles (2 lados iguais)");
}
else
{
    Console.WriteLine($"Triângulo Escaleno (3 lados diferentes)");
}

Console.WriteLine();