using Calculadora;

Console.Clear();

Calculator calc = new Calculator();
calc.N1 = 50;
calc.N2 = 10;

int Opcao = -1;
do
{


    Console.WriteLine($"=========================");
    Console.WriteLine($"      Seja bem Vindo     ");
    Console.WriteLine($"            a            ");
    Console.WriteLine($"       Calculator        ");
    Console.WriteLine($"=========================");

    Console.WriteLine($"Escolha uma opcao do menu abaixo:");
    Console.WriteLine($"                                ");

    Console.WriteLine($" 1-  Somar");
    Console.WriteLine($" 2- Subtrair");
    Console.WriteLine($" 3- Multiplicar");
    Console.WriteLine($" 4- Dividir");
    Console.WriteLine($" 5- Dividir");
    Console.Write($"Opcao:");
    Opcao = int.Parse(Console.ReadLine());


    switch (Opcao)
    {
        case 1:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;
        case 2:
            Console.WriteLine($"Resultado da subtracao: {calc.Subtrair()}");
            break;

        case 3:
            Console.WriteLine($"Resultado da multiplicacao: {calc.Multiplicar()}");
            break;
        case 4:
            Console.WriteLine($"Resultado da Divisao: {calc.Dividir()}");
            break;

        case 0:
            Console.WriteLine($"Obrigada por utilizar o programa.Saindo...");
            break;

        default:
            Console.WriteLine($"Opcao invalida, escolha uma opcao de 1 a 4 ou 0 pra sair!");
            break;
    }
    
    Console.WriteLine($"Digite <Enter> para sair...");
    Console.ReadLine();
    
    
} while (Opcao != 0);






// Console.WriteLine($"Primeiro numero: {calc.N1}");
// Console.WriteLine($"Sehundo numero: {calc.N2}");

// Console.WriteLine($"Resultados: ");
// Console.WriteLine();


// Console.WriteLine($"Soma {calc.Somar()}");
// calc.Somar();
// Console.WriteLine();

// Console.WriteLine($"Subtracao  {calc.Subtrair()}");
// calc.Subtrair();
// Console.WriteLine();

// Console.WriteLine($"Divisao  {calc.Dividir()}");
// calc.Dividir();
// Console.WriteLine();

// Console.WriteLine($"Multiplicacao  {calc.Multiplicar()}");
// calc.Multiplicar();
// Console.WriteLine();