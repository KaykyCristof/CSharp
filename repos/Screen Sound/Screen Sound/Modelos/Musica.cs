namespace ScreenSound.Modelos;
class Musica
{
    public string NomeMusica { get; }
    public int DuracaoMusica { get; }
    public bool Disponivel { get; set; }

    public Musica( string nomeDaMusica , int duracaoDaMusica )
    {
        if ( string.IsNullOrEmpty( nomeDaMusica ) || duracaoDaMusica <= 0 )
        {
            throw new ArgumentException( "Valores inválidos" );
        }
        
        NomeMusica = nomeDaMusica;
        DuracaoMusica = duracaoDaMusica;
    }

    public void VerificaDisponivel()
    {
        if( Disponivel )
        {
            Console.WriteLine( "Disponível no plano." );
        }
        else
        {
            Console.WriteLine( "Adquira o plano Plus+" );
        }
    }
    public void ExibeMusica()
    {
        Console.WriteLine( $"Nome da música: {NomeMusica}." );
        Console.WriteLine( $"Duração da música: {DuracaoMusica}." );
        VerificaDisponivel();
    }
}
