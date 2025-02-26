abstract class Acoes
{
    // Métodos Obrigatórios
    public abstract void Falar();
    public abstract void Andar();

    // Métodos Opcionais
    public void Pular()
    {
        Console.WriteLine("Estou pulando...");
    }
}