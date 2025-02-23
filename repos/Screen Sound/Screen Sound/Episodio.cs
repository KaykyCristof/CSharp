// Definindo a classe episodio

class Episodio
{
    private int ordem;
    public int Duracao { get; set; }
    public int Ordem => ordem;
    public string Resumo { get; }
    public string Titulo { get; }

    private List<Convidado> listaConvidado;

    public Episodio( string resumoEp, string tituloEp )
    {
        if( string.IsNullOrEmpty( resumoEp ) || string.IsNullOrEmpty( tituloEp ) )
        {
            throw new ArgumentException( "Valores inválidos!" );
        }

        Resumo = resumoEp;
        Titulo = tituloEp;
        listaConvidado = new List<Convidado>();
    }

    public void ConfiguraOrdem()
    {
        ordem = ordem + 1;
    }

    public void AdicionarConvidados( Convidado novoConvidado )
    {
        ConfiguraOrdem();
        listaConvidado.Add( novoConvidado );
        Console.WriteLine( "Convidado adicionado com sucesso!" );
    }

    public void ExibeEpisodio()
    {
        Console.WriteLine( $"Título:{Titulo}." );
        Console.WriteLine( $"Resumo:{Resumo}." );
        Console.WriteLine( $"Ordem:{Ordem}." );
        Console.WriteLine( $"Duracao:{Duracao}." );

        Console.WriteLine( "Nome dos convidados:" );
        foreach( Convidado convidado in listaConvidado )
        {
            convidado.ExibeConvidado();
        }
    }
}