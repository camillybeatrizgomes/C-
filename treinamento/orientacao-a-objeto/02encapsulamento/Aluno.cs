class Aluno
{
    // Atributos
    // private string? Nome;
    // private double Media;

    // 1º maneira
    private string? _nome;
    public string? Nome
    {
        get{return _nome;}
        set{ _nome = value;}
    }
    // 2º maneira
    public double Media { get; set; }
}

