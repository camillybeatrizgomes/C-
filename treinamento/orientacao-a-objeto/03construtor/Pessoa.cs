class Pessoa
{
    // 1º Construtor
    public Pessoa()
    {
        Console.WriteLine("Hello World!");
    }

    // 2º Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}!");
    }

    // 3º Construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, você tem {idade} anos");
    }
}