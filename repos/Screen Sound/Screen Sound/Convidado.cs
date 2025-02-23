// Definindo a classe Convidado

class Convidado
{
    public string NomeConvidado { get; }

    public Convidado( string nomeDoConvidado )
    {
        if( string.IsNullOrEmpty( nomeDoConvidado) )
        {
            throw new ArgumentException( "Valor inválido para o nome do convidado!" );
        }

        NomeConvidado = nomeDoConvidado;
    }

    public void ExibeConvidado()
    {
        Console.WriteLine( $"{NomeConvidado}." );
    }
}
