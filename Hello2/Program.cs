//Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario e quanto investiu esse ano

string nomeDoFulano;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("Ola, qual e seu nome?");
nomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual e o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual e a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual e o seu saldo bancario?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual e o seu investimento?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Nome: {nomeDoFulano} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nomeDoFulano} e {idade} ");
Console.WriteLine($"Saldo Bancario: {saldoBancario} ");
Console.WriteLine($"Investimento este ano: {investimentos} ");