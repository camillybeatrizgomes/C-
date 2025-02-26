// Matriz
string[,] dados = {
    {"Camilly", "Recife"},
    {"Juliana", "Campinas"},
    {"Cleber", "Joinville"},
    {"Marcela", "Londrina"}
};

// Exibir dados 
// Console.WriteLine(dados[0, 1]);

foreach (string dado in dados)
{
    Console.WriteLine(dado);
}