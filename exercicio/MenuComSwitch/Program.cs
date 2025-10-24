int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"-----------------------------------------------");
    Console.WriteLine($"                    bem vindo                  ");
    Console.WriteLine($"                       ao                      ");
    Console.WriteLine($"                  Jacareca food                ");
    Console.WriteLine($"-----------------------------------------------");
    Console.WriteLine($"                                 ");
    Console.WriteLine($"                                 ");

    Console.WriteLine($"Escolha uma opcao do menu abaixo:");
    Console.WriteLine($"                                ");

    Console.WriteLine($" 1- Hot holl .....................  29,00");
    Console.WriteLine($" 2- Temaki   .....................  30,00");
    Console.WriteLine($" 3- Sashimi  .....................  29,90");
    Console.WriteLine($" 4- Sair     .....................       ");
    Console.Write($"Opcao:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;

        case 1:
            Hotholl();
            Console.WriteLine($"Boa escolha, vamos perparar se hot holl com carinho");
            break;
        case 2:
            Temaki();
            Console.WriteLine($"Boa escolha, vamos perparar se Temaki  com carinho");
            break;
        case 3:
            Sashimi();
            Console.WriteLine($"Boa escolha, vamos perparar se Sashimi com carinho");
            break;

        default:
            Console.WriteLine($"Opcao invalida");

            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();
} while (opcao != 0);

void Hotholl()
{
    Console.WriteLine($"Boa escolha, vamos perparar se hot holl com carinho");
    
}

void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos perparar se Temaki com carinho");
    
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos perparar se Sashimi com carinho");
    
}

