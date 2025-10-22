//Pedir para o usuario digitar dois numeros em seguida verificar  e exibir qual e o maior dos dois numeros

int n1;
int n2;

Console.WriteLine("Digite um numero:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
n2 = int.Parse(Console.ReadLine());



if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero e maior: {n1}");

}
else if (n2 > n1)
{
    Console.WriteLine($"O segundo numero e maior: {n2} ");
}
else
{
     Console.WriteLine($"Os numeros sao iguais: {n1} e {n2}");
}
