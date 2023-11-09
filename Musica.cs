class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel {get ;set;}
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTenica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        
        if (!Disponivel)
        {
            Console.WriteLine("Não está disponível no plano.");
        }
        else
        {
            Console.WriteLine("Disponível no plano.");
        }
        Console.WriteLine("\n");

    }
}
