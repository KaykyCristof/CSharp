// Definindo a classe música
class Musica
{
    public string NomeMusica { get; }

    public int DuracaoMusica { get; }

    public bool Disponivel { get; set; }

    // Definindo o construtor da classe Música.
    public Musica( string nomeDaMusica , int duracaoDaMusica )
    {
        if ( string.IsNullOrEmpty( nomeDaMusica ) )
        {
            throw new ArgumentException( "Valor inválido para o nome da música!" );
        }
        else
        {
            NomeMusica = nomeDaMusica;
        }
        
        if( duracaoDaMusica <= 0 )
        {
            throw new ArgumentException( "Valor inválido para a duração da música!" );
        }
        else
        {
            DuracaoMusica = duracaoDaMusica;
        }   
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
        Console.WriteLine();
    }
}
