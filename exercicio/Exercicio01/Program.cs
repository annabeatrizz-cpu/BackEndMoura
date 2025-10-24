//Faça um programa que o usuário informe o salário recebido 
// e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” 
// caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” 
// se o valor gasto ultrapassar o valor do salário.

double salario;
double gastos;

Console.WriteLine("Quanto voce recebe?");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Quanto voce gasta no total?");
gastos = double.Parse(Console.ReadLine());

if (gastos <= salario)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else 
{
    Console.WriteLine($"Orçamento estourado");
}