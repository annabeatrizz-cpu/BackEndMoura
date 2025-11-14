using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();

compraPix.ValorCompra = 15000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preco: {compraPix.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;
Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {compraCartao.ValorCompra}");
Console.WriteLine($"Pagamento com Acrescimo: {compraCartao.CalcularTotal()}");