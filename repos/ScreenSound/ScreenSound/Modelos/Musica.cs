namespace ScreenSound.Modelos;

internal class Musica : Abstract
{
    public string Nome { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Musica( string nomeMusica, int duracaoMusica ) 
    {
        if( string.IsNullOrWhiteSpace( nomeMusica) || duracaoMusica <= 0 ) throw new ArgumentException( "Valor inválido!" );
        Nome = nomeMusica;
        Duracao = duracaoMusica;
    }

    public static Musica Parse( string nomeMusica, int duracaoMusica )
    {
        return new Musica( nomeMusica, duracaoMusica );
    }

    public string VerificaDisponivel => Disponivel ? "Música disponível!" : "Música não disponível!";

    public override void ExibeInformacoes()
    {
        Console.WriteLine( $"Nome da música: {Nome}." );
        Console.WriteLine( $"Duração da música: {Duracao}." );
        Console.WriteLine( "Disponível: " + VerificaDisponivel );
    }
}
