// Definindo a classe Banda
class Banda
{
    private List<Album> listaAlbum;

    public string NomeBanda { get; }

    // Definindo o construtor da classe banda.
    public Banda(string nomeDaBanda)
    {   
        if( string.IsNullOrEmpty( nomeDaBanda) )
        {
            throw new ArgumentException( "Valor inválido para banda!" );
        }
        else
        {
            NomeBanda = nomeDaBanda;
        }

        listaAlbum = new List<Album>();
    }

    public void AdicionaAlbum( Album album )
    {
        listaAlbum.Add( album );
    }

    public void ExibeBanda()
    {
        Console.WriteLine( $"Nome da banda: {NomeBanda}." );
        foreach( Album album in listaAlbum )
        {
            album.ExibeAlbum();
        }
    }
}