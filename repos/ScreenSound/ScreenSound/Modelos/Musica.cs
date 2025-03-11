namespace ScreenSound.Modelos;

internal class Musica : IAvaliavel
{
    private List<Avaliacao> notas;
    public string Nome { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public double Media => notas.Count == 0 ? 0 : notas.Average( n => n.Nota );

    public Musica( string nomeMusica, int duracaoMusica ) 
    {
        if( string.IsNullOrWhiteSpace( nomeMusica) || duracaoMusica <= 0 ) throw new ArgumentException( "Valor inválido!" );
        Nome = nomeMusica;
        Duracao = duracaoMusica;
        notas = new List<Avaliacao>();
    }

    public static Musica Parse( string nomeMusica, int duracaoMusica )
    {
        return new Musica( nomeMusica, duracaoMusica );
    }

    public string VerificaDisponivel => Disponivel ? "Música disponível!" : "Música não disponível!";

    public void InsereNota( Avaliacao novaNota )
    {
        notas.Add( novaNota );
    }

    public bool ListaVazia<T>( List<T> lista )
    {
        if (lista.Count == 0) return true;
        return false;
    }

    public void ExibeInformacoes()
    {
        Console.WriteLine( $"Nome da música: {Nome}." );
        Console.WriteLine( $"Duração da música: {Duracao}." );
        Console.WriteLine( "Disponível: " + VerificaDisponivel );

        if( ListaVazia( notas ) ) Console.WriteLine( "Nenhuma nota inserida!" );
        else
        {
            Console.Write( "Notas: " );
            foreach( Avaliacao nota in notas )
            {
                Console.Write( nota.Nota + " " );
            }
            Console.WriteLine();
        }
    }
}
