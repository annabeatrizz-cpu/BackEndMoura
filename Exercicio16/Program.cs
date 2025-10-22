string cargo;
float salario, salarioNovo;




Console.WriteLine($"Digite seu cargo, producao, administrativo ou diretoria?");
cargo = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o salario do funcionario");


if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065f);
}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075f);
}

else if (cargo == "diretoriaa")
{
    salarioNovo = salario + (salario * 0.12f);
}
else
{
    Console.WriteLine($"Cargo invalido");

}

Console.WriteLine($"o novo salario reajustado e {salarioNovo}");