namespace ScreenSound.Modelos;
class Album
{
    private List<Musica> listaMusicas;
    public string NomeAlbum { get; }
   
    public Album( string nomeDoAlbum )
    {
        if( string.IsNullOrEmpty( nomeDoAlbum ) )
        {
            throw new ArgumentException( "Valor inválido para o nome do álbum!" );
        }

        NomeAlbum = nomeDoAlbum;
        listaMusicas = new List<Musica>();
    }

    public void AdicionaMusica( Musica musica )
    {
        listaMusicas.Add( musica );
        Console.WriteLine( "Música adicionada com sucesso!" );
    }
    public void TempoAlbum()
    {
        int somatorio = 0;

        foreach( Musica musica in listaMusicas )
        {
            somatorio += musica.DuracaoMusica;
        }

        Console.WriteLine( $"O tempo de duração total do álbum é: {somatorio}." );
    }
    public void ExibeAlbum()
    {
        Console.WriteLine( $"Nome do álbum: {NomeAlbum}." );
        
        if( listaMusicas.Count == 0 )
        {
            Console.WriteLine( "Nenhuma música registrada!" );
        }
        else
        {
            foreach (Musica musica in listaMusicas)
            {
                musica.ExibeMusica();
            }

            TempoAlbum();
        }
    }
}
