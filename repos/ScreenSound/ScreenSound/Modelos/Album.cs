namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas;
    private List<Avaliacao> notas;

    public string Nome { get; }

    public int TempoTotal => musicas.Sum( n => n.Duracao );

    public double Media => notas.Count == 0 ? 0 : notas.Average( n => n.Nota );

    public Album( string nomeAlbum )
    {
        if( string.IsNullOrWhiteSpace( nomeAlbum ) ) throw new ArgumentException( "Valor inválido!" );
        Nome = nomeAlbum;
        musicas = new List<Musica>();
        notas = new List<Avaliacao>();
    }

    public void InsereMusica( Musica novaMusica )
    {
        musicas.Add( novaMusica );
        Console.WriteLine( $"Música: {novaMusica.Nome} inserida com sucesso!" );
    }

    public void InsereNota( Avaliacao novaNota )
    {
        notas.Add( novaNota );
        Console.WriteLine( $"Nota do álbum {Nome} inserida com sucesso!" );
    }

    public bool ListaVazia<T>( List<T> lista )
    {
        if (lista.Count == 0) return true;
        return false;
    }

    public static Album Parse( string nomeAlbum )
    {
        return new Album( nomeAlbum );
    }

    public List<Musica> GetMusica()
    {
        return musicas;
    }

    public void ExibeInformacoes()
    {
        Console.WriteLine( $"Nome do álbum: {Nome}." );

        if( ListaVazia( musicas ) ) Console.WriteLine( "Nenhuma música inserida!" );
        else
        {
            foreach( Musica musica in musicas )
                musica.ExibeInformacoes();
            Console.WriteLine( $"Tempo de duração do álbum: {TempoTotal}." );
        }

        if( ListaVazia( notas ) ) Console.WriteLine( "Nenhuma nota inserida!" );
        else
        {
            foreach( Avaliacao nota in notas )
                Console.Write( nota.Nota + " " );
            Console.WriteLine();
        }
    }
}
