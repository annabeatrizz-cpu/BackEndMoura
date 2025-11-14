string[] nome = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;


do
{
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 0:
         Console.WriteLine($"Encerrando o programa... ");
         
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
        ListarCliente();
            break;

        default:
        Console.WriteLine($"Opcao invalida");
        break;
    }

    Console.WriteLine($"Precione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);



void  CadastrarCliente()
{
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;
    }

    Console.Write($"Nome do Cliente: ");
    nome[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso");
    
}

void Depositar()
{
   
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
     Console.Write($"Valor para deposito: ");
    float Valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += Valor;
    Console.WriteLine($"Deposito de R$ {Valor:F2} realizado");
    
}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    
    Console.WriteLine($"Valor para saque: ");
    float Valor = float.Parse(Console.ReadLine());
    saldos[idCliente] = Valor;

if (saldos[idCliente] >= Valor && Valor > 0
)
    {

        saldos[idCliente] -= Valor;
        Console.WriteLine($"Saque realizado com sucesso!");
       
}
else
{
    Console.WriteLine($"Saldo insuficiente!");
    
}

  
}
void Transferir()
{
    
    Console.WriteLine($"== Transferencia ==");
    Console.Write($"Conta de origem");

    int idOrigem = BuscarCliente();
    if (idOrigem == -1) return;
  
        Console.WriteLine($"Conta de destino: ");
        int idDestino = BuscarCliente();

        if (idDestino == -1) return;

        Console.WriteLine($"Valor para transferir: ");
       float Valor = float.Parse(Console.ReadLine());


    if (saldos[idOrigem] >= Valor && Valor > 0)
    {
        saldos[idOrigem] -= Valor;
        saldos[idDestino] += Valor;
        Console.WriteLine($"Transferenia concluida!");

    }
   else
   {
    Console.WriteLine($"Saldo Insuficiente! ");
    
   }
}

void ListarCliente()
{
    Console.WriteLine($"===Listar Clientes===");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} | Saldos: R$ {saldos[i]} -");

    }
}

int BuscarCliente()
{
    ListarCliente();

    Console.WriteLine($"Digite o numero do cliente: ");

    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente nao encontrado!");
        return -1;
    }
    return idCliente;
}