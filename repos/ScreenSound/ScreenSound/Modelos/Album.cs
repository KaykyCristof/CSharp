namespace ScreenSound.Modelos;

internal class Album : Abstract
{
    private List<Musica> musicas;

    public string Nome { get; }

    public int TempoTotal => musicas.Sum( n => n.Duracao );

    public Album( string nomeAlbum )
    {
        if( string.IsNullOrWhiteSpace( nomeAlbum ) ) throw new ArgumentException( "Valor inválido!" );
        Nome = nomeAlbum;
        musicas = new List<Musica>();
    }

    public void InsereMusica( Musica novaMusica )
    {
        musicas.Add( novaMusica );
        Console.WriteLine( $"Música: {novaMusica.Nome} inserida com sucesso!" );
    }

    public static Album Parse( string nomeAlbum )
    {
        return new Album( nomeAlbum );
    }

    public override void ExibeInformacoes()
    {
        Console.WriteLine( $"Nome do álbum: {Nome}." );

        if( ListaVazia( musicas ) ) Console.WriteLine( "Nenhuma música inserida!" );
        else
        {
            foreach( Musica musica in musicas )
                musica.ExibeInformacoes();
            Console.WriteLine( $"Tempo de duração do álbum: {TempoTotal}." );
        }
    }
}
