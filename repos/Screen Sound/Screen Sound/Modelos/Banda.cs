namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> listaAlbum;
    private List<int> notas;

    public string NomeBanda { get; }
    public double Media => notas.Average();

    public Banda( string nomeDaBanda )
    {   
        if( string.IsNullOrEmpty( nomeDaBanda) )
        {
            throw new ArgumentException( "Valor inválido para banda!" );
        }
       
        NomeBanda = nomeDaBanda;
        listaAlbum = new List<Album>();
        notas = new List<int>();
    }

    public void AdicionaAlbum( Album album )
    {
        listaAlbum.Add( album );
        Console.WriteLine( "Álbum adicionado com sucesso!" );
    }
    public void AdicionaNota( int nota )
    {
        if( nota < 0 )
        {
            throw new ArgumentException( "Valor inválido para a nota da banda!" );
        }

        notas.Add( nota );
    }
    public void ExibeBanda()
    {
        Console.WriteLine( $"Nome da banda: {NomeBanda}." );

        if( notas.Count == 0 )
        {
            Console.WriteLine( "Nenhuma nota registrada!" );
        }
        else
        {
            Console.Write( "Notas da banda: " );
            foreach( int nota in notas )
            {
                Console.Write( nota + " " );
            }

            Console.WriteLine();
        }
        
        if( listaAlbum.Count == 0 )
        {
            Console.WriteLine( "Nenhum álbum registrado!" );
        }
        else
        {
            foreach ( Album album in listaAlbum )
            {
                album.ExibeAlbum();
            }
        }
    }
}