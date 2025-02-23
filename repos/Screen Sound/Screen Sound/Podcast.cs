// Definindo a classe Podcast
class Podcast
{
    public string Host { get; }
    
    public string NomePodcast { get; }

    private List<Episodio> listaEpisodios;

    public Podcast( string nomeHost, string nomeDoPodcast )
    {
        if( string.IsNullOrEmpty( nomeHost ) || string.IsNullOrEmpty(nomeDoPodcast) )
        {
            throw new ArgumentException( "Valores inválidos!" );
        }

        Host = nomeHost;
        NomePodcast = nomeDoPodcast;
        listaEpisodios = new List<Episodio>();
    }

    public void AdicionarEpisodio( Episodio novoEpisodio )
    {
        listaEpisodios.Add( novoEpisodio );
        Console.WriteLine( "Episódio inserido com sucesso!" );
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine( $"Nome do podcast:{NomePodcast}." );
        Console.WriteLine( $"Nome do Host:{Host}." );

        foreach( Episodio episodio in listaEpisodios )
        {
            episodio.ExibeEpisodio();
        }
    }

    
    
    
    
}
