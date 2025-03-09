namespace ScreenSound.Modelos;

internal class Banda : Abstract
{
    private List<Album> albuns;
    private List<Avaliacao> notas;
    
    public string Nome { get; }

    public double Media => ListaVazia( notas ) ? 0 : notas.Average( n => n.Nota );

    public Banda( string nomeBanda )
    {
        if( string.IsNullOrWhiteSpace( nomeBanda) ) throw new ArgumentException( "Valor inválido!" );
        Nome = nomeBanda;
        albuns = new List<Album>();
        notas = new List<Avaliacao>();
    }

    public void InsereAlbum( Album novoAlbum )
    {
        albuns.Add( novoAlbum );
        Console.WriteLine( $"Álbum: {novoAlbum.Nome} adicionado com sucesso!" );
    }

    public void InsereNota( Avaliacao novaNota )
    {
        notas.Add( novaNota );
        Console.WriteLine( $"Nota: {novaNota.Nota} adicionada com sucesso!" );
    }

    public List<Album> GetAlbum()
    {
        return albuns;
    }

    public static Banda Parse( string nomeBanda )
    {
        return new Banda( nomeBanda );
    }

    public override void ExibeInformacoes()
    {
        Console.WriteLine( $"Nome da banda: {Nome}." );
        Console.WriteLine( $"Média da banda: {Media}." );
        if( ListaVazia( albuns ) ) Console.WriteLine( "Nenhum álbum inserido!" );
        else
        {
            foreach( Album album in albuns )
                album.ExibeInformacoes();
        }
        ExibeNotas();
    }

    public void ExibeNotas()
    {
        if( ListaVazia( notas ) ) Console.WriteLine( "Nenhuma nota inserida!" );
        else
        {
            foreach( Avaliacao nota in notas )
                Console.Write( nota + " " );
            Console.WriteLine();
        }
    }
}
