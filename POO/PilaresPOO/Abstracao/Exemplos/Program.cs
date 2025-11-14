using Exemplos;

Gato birobinha = new Gato();
Cachorro toto = new Cachorro();
Pessoa Anna = new Pessoa();


Anna.Nome = "Anna Beatriz";
Anna.Idade = 16;

Anna.FazerSom();
Anna.Mover();
Anna.Dormir();


Console.WriteLine($"Nome: {Anna.Nome}");
Console.WriteLine($"Idade da {Anna.Nome}: {Anna.Idade} anos");

Console.WriteLine($"Som do {Anna.Nome}: ");
Anna.FazerSom();

Console.Clear();

Console.WriteLine($"CONTA CORRENTE");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: {cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: {cc.Saldo}");

Console.WriteLine();

Console.WriteLine($"CONTA POUPANCA: ");
ContaCorrente cp = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da poupanca: {cp.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: {cp.Saldo}");
cc.Sacar(10);
Console.WriteLine($"Saldo apos saque: {cp.Saldo}");