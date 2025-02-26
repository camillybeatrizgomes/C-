// Exemplo 01
Pessoa obj1 = new Pessoa();
obj1.Nome = "Camilly";
// obj1.Apresentacao();

// Exemplo 02
Pessoa obj2 = new();
obj2.Nome = "Beatriz";
// obj2.Apresentacao();

// Exemplo 03
Pessoa obj3 = new()
{
    Nome = "Camilly",
    Idade = 21
};
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);
