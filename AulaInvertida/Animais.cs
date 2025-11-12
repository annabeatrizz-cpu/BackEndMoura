interface IAnimal //Define o "contrato" (métodos obrigatórios) //é obrigatorio começar com I no começo de toda interface
{
    void FazerSom();//Regra obrigatoria do "contrato"
    void Comer();//Regra obrigatoria do "contrato"
}

class Cachorro : IAnimal//Implementa os métodos de IAnimal com comportamento próprio(é obrigatorio ter as regras/comportamento)
{
    public void Comer()
    {
        throw new NotImplementedException();
    }

    public void FazerSom()
    {
        throw new NotImplementedException();
    }
}

class Gato : IAnimal//Implementa o mesmo contrato, mas com outra lógica e outro animal
{
    public void FazerSom()//Regra/comportamento
    {
        Console.WriteLine("Gato");//ação do comportamento
        Console.WriteLine("Miaaauu!");//ação do comportamento
    }
    public void Comer()//Regra/comportamento
    {
        Console.WriteLine("mastigando... comendo ração");//ação do comportamento
    }
}
