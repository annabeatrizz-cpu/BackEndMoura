//Pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros 
int numero1;
int numero2;

Console.WriteLine("Digite um numero:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;

Console.WriteLine($"A soma de {numero1} + {numero2} e {soma}");